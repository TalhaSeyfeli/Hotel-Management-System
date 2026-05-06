using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace OtelOdaTakipSistemi
{
    public partial class FormUserInterface : Form
    {
        public bool admin { get; set; }

        SqlConnection baglanti;
        private FormOdaDuzenle FormOdaDuzenle;

        public FormUserInterface()
        {
            InitializeComponent();
            FormOdaDuzenle = new FormOdaDuzenle(this);
            baglanti = new SqlConnection(VeritabaniAyarlari.BaglantiCumlesiGetir());
        }

        private void FormUserInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void maskedTextBoxOdaNoAraİnt_Click(object sender, EventArgs e)
        {
            maskedTextBoxOdaNoAraİnt.SelectionStart = 0;
            maskedTextBoxOdaNoAraİnt.Text = string.Empty;
        }

        private void OdalariYukle()
        {
            try
            {
                flowLayoutPanelOdalar.Controls.Clear();
                lblToplamOdaSayisiİnt.Text = string.Empty;
                lblDoluOdaSayisiİnt.Text = string.Empty;

                string sorgu = "SELECT OdaNo, OdaDurumu, FotografGorsel, OdaIhtiyaclari FROM OdaBilgileri ORDER BY OdaNo ASC";
                string toplamOdaSorgu = "SELECT Count(*) FROM OdaBilgileri";
                string doluOdaSorgu = "SELECT Count(*) FROM OdaBilgileri WHERE OdaDurumu = 1";

                SqlCommand cmd = new SqlCommand(sorgu, baglanti);

                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string ihtiyaclar = reader["OdaIhtiyaclari"].ToString();
                    int no = Convert.ToInt32(reader["OdaNo"]);
                    bool durum = Convert.ToInt32(reader["OdaDurumu"]) == 1;
                    byte[] gorselVerisi = (byte[])reader["FotografGorsel"];
                    Image gorsel;
                    using (MemoryStream ms = new MemoryStream(gorselVerisi))
                    {
                        gorsel = Image.FromStream(ms);
                    }

                    Panel odaPaneli = new Panel();
                    odaPaneli.Size = new Size(350, 275);
                    odaPaneli.BackColor = durum ? Color.FromArgb(202, 72, 72) : Color.FromArgb(65, 223, 112);
                    odaPaneli.Tag = no;

                    Button btnDetay = new Button();
                    btnDetay.Size = new Size(150, 50);
                    btnDetay.BackColor = Color.LightGray;
                    btnDetay.Location = new Point(15, 215);
                    btnDetay.Text = "Detay";
                    odaPaneli.Controls.Add(btnDetay);
                    btnDetay.Tag = no;

                    PictureBox odaFotoğrafi = new PictureBox();
                    odaFotoğrafi.Size = new Size(150, 189);
                    odaFotoğrafi.Location = new Point(5, 5);
                    odaFotoğrafi.Image = gorsel;
                    odaPaneli.Controls.Add(odaFotoğrafi);

                    Label odaNo = new Label();
                    odaNo.Text = $"Oda No: {no}";
                    odaNo.Font = new Font("Microsoft Sans Serif", 10);
                    odaNo.Location = new Point(165, 5);
                    odaPaneli.Controls.Add(odaNo);

                    Label odaIhtiyaclari = new Label();
                    odaIhtiyaclari.Text = $"İhtiyaçlar: {ihtiyaclar}";
                    odaIhtiyaclari.Size = new Size(180, 210);
                    odaIhtiyaclari.Font = new Font("Microsoft Sans Serif", 12);
                    odaIhtiyaclari.Location = new Point(165, 60);
                    odaPaneli.Controls.Add(odaIhtiyaclari);

                    Label odaDurumu = new Label();
                    odaDurumu.Text = durum ? "Durum: Dolu" : "Durum: Bos ";
                    odaDurumu.Font = new Font("Microsoft Sans Serif", 12);
                    odaDurumu.Location = new Point(165, 30);
                    odaPaneli.Controls.Add(odaDurumu);

                    flowLayoutPanelOdalar.Controls.Add(odaPaneli);
                    btnDetay.Click += new EventHandler(OdaBilgileri_Click);
                }
                reader.Close();

                using (SqlCommand komut = new SqlCommand(toplamOdaSorgu, baglanti))
                {
                    lblToplamOdaSayisiİnt.Text = Convert.ToInt32(komut.ExecuteScalar()).ToString();
                }
                using (SqlCommand sor = new SqlCommand(doluOdaSorgu, baglanti))
                {
                    lblDoluOdaSayisiİnt.Text = Convert.ToInt32(sor.ExecuteScalar()).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Odalar yüklenirken hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        private void OdaGuncelle(Panel odaPaneli)
        {
            int arananOdaNo = 0;
            if (!int.TryParse(FormOdaDuzenle.maskedTextBoxOdaNo.Text, out arananOdaNo)) return;

            Panel bulunanPanel = null;

            foreach (Control ctrl in flowLayoutPanelOdalar.Controls)
            {
                if (ctrl is Panel panel && panel.Tag != null && (int)panel.Tag == arananOdaNo)
                {
                    bulunanPanel = panel;
                    break;
                }
            }

            if (bulunanPanel != null)
            {
                foreach (Control c in bulunanPanel.Controls)
                {
                    if (c is Label lbl)
                    {
                        if (lbl.Text.StartsWith("Durum:"))
                        {
                            lbl.Text = FormOdaDuzenle.radioButtonDolu.Checked ? "Durum: Dolu" : "Durum: Bos ";
                        }
                        else if (lbl.Text.StartsWith("İhtiyaçlar:"))
                        {
                            lbl.Text = $"İhtiyaçlar: {FormOdaDuzenle.richTextBoxOdaİhtiyaçlari.Text}";
                        }
                    }
                    else if (c is PictureBox pb)
                    {
                        pb.Image = FormOdaDuzenle.pictureBoxOdaResmi.Image;
                    }
                }
            }
            else
            {
                flowLayoutPanelOdalar.Controls.Add(odaPaneli);
            }
        }

        private void OdaEkle()
        {
            try
            {
                PictureBox odaFotoğrafi = new PictureBox();
                Label odaNo = new Label();
                Label odaDurumu = new Label();
                Label odaIhtiyaclari = new Label();
                Button btnDetay = new Button();
                Panel odaPaneli = new Panel();
                int no;
                bool durum;
                Image gorsel;

                int numara;
                if (!int.TryParse(FormOdaDuzenle.maskedTextBoxOdaNo.Text, out numara)) return;

                string sor = "select FotografGorsel, OdaDurumu, OdaIhtiyaclari from OdaBilgileri WHERE OdaNo = @OdaNo ORDER BY OdaNo ASC";
                SqlCommand cmd = new SqlCommand(sor, baglanti);
                cmd.Parameters.AddWithValue("@OdaNo", numara);

                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                no = numara;
                if (reader.Read())
                {
                    if (Convert.ToInt32(reader["OdaDurumu"]) == 1)
                        durum = true;
                    else
                        durum = false;

                    byte[] resimVerisi = (byte[])reader["FotografGorsel"];
                    using (MemoryStream ms = new MemoryStream(resimVerisi))
                    {
                        gorsel = Image.FromStream(ms);
                    }

                    int odaNumarasiİnt = no;
                    string odaNumarasiString = ($"Oda No:{odaNumarasiİnt.ToString()}");
                    odaIhtiyaclari.Text = $"İhtiyaçlar: {reader["OdaIhtiyaclari"].ToString()}";
                    btnDetay.Size = new Size(150, 50);
                    btnDetay.BackColor = Color.LightGray;
                    btnDetay.Location = new Point(15, 215);
                    btnDetay.Text = "Detay";
                    btnDetay.Tag = numara;
                    odaNo.Text = odaNumarasiString;
                    odaNo.Font = new Font("Microsoft Sans Serif", 10);
                    odaNo.Location = new Point(165, 5);
                    odaIhtiyaclari.Font = new Font("Microsoft Sans Serif", 12);
                    odaIhtiyaclari.Location = new Point(165, 60);
                    odaIhtiyaclari.Size = new Size(180, 210);
                    odaDurumu.Text = durum ? "Durum: Dolu" : "Durum: Bos ";
                    odaDurumu.Font = new Font("Microsoft Sans Serif", 12);
                    odaDurumu.Location = new Point(165, 30);
                    odaFotoğrafi.Size = new Size(150, 189);
                    odaFotoğrafi.Location = new Point(5, 5);
                    odaFotoğrafi.Image = gorsel;
                    odaPaneli.Tag = numara;
                }
                reader.Close();
                baglanti.Close();

                odaPaneli.Controls.Add(btnDetay);
                odaPaneli.Controls.Add(odaFotoğrafi);
                odaPaneli.Controls.Add(odaNo);
                odaPaneli.Controls.Add(odaDurumu);
                odaPaneli.Controls.Add(odaIhtiyaclari);
                odaPaneli.Size = new Size(350, 275);
                odaPaneli.BackColor = Color.LightGray;
                OdaGuncelle(odaPaneli);
                btnDetay.Click += new EventHandler(OdaBilgileri_Click);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda eklenirken hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        private void OdaBilgileri_Click(object sender, EventArgs e)
        {
            FormOdaDuzenle.listBoxRezervasyonTakvimi.Items.Clear();
            FormOdaDuzenle.listBoxOdaÖzellikleri.Items.Clear();
            FormOdaDuzenle.pictureBoxOdaResmi.Image = null;
            FormOdaDuzenle.richTextBoxOdaİhtiyaçlari.Text = "";

            int tiklananOda;
            if (sender is Control clickedControl && clickedControl.Tag != null)
            {
                tiklananOda = Convert.ToInt32(clickedControl.Tag);
            }
            else
            {
                if (!int.TryParse(maskedTextBoxOdaNoAraİnt.Text, out tiklananOda))
                {
                    MessageBox.Show("Geçerli bir oda numarası giriniz.");
                    return;
                }
            }

            FormOdaDuzenle.maskedTextBoxOdaNo.Text = tiklananOda.ToString();
            string sor = "select FotografGorsel, OdaDurumu, OdaIhtiyaclari, OdaRezervasyonTakvimi, OdaOzellikleri from OdaBilgileri WHERE OdaNo = @OdaNo ";

            try
            {
                SqlCommand cmd = new SqlCommand(sor, baglanti);
                cmd.Parameters.Add(new SqlParameter("@OdaNo", tiklananOda));
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    byte[] resimVerisi = (byte[])reader["FotografGorsel"];
                    using (MemoryStream ms = new MemoryStream(resimVerisi))
                    {
                        FormOdaDuzenle.pictureBoxOdaResmi.Image = Image.FromStream(ms);
                    }
                    if (Convert.ToInt32(reader["OdaDurumu"]) == 1)
                        FormOdaDuzenle.radioButtonDolu.Checked = true;
                    else
                        FormOdaDuzenle.radioButtonBos.Checked = true;

                    FormOdaDuzenle.richTextBoxOdaİhtiyaçlari.Text = reader["OdaIhtiyaclari"].ToString();

                    string[] OdaRezervasyonTakvimi = (reader["OdaRezervasyonTakvimi"].ToString()).Split(',');
                    string[] OdaOzellikleri = (reader["OdaOzellikleri"].ToString()).Split(',');

                    if (OdaRezervasyonTakvimi.Length > 0 && !string.IsNullOrWhiteSpace(OdaRezervasyonTakvimi[0]))
                        FormOdaDuzenle.listBoxRezervasyonTakvimi.Items.AddRange(OdaRezervasyonTakvimi);
                    if (FormOdaDuzenle.listBoxRezervasyonTakvimi.Items.Count > 0)
                        FormOdaDuzenle.listBoxRezervasyonTakvimi.Items.RemoveAt(FormOdaDuzenle.listBoxRezervasyonTakvimi.Items.Count - 1);

                    if (OdaOzellikleri.Length > 0 && !string.IsNullOrWhiteSpace(OdaOzellikleri[0]))
                        FormOdaDuzenle.listBoxOdaÖzellikleri.Items.AddRange(OdaOzellikleri);
                    if (FormOdaDuzenle.listBoxOdaÖzellikleri.Items.Count > 0)
                        FormOdaDuzenle.listBoxOdaÖzellikleri.Items.RemoveAt(FormOdaDuzenle.listBoxOdaÖzellikleri.Items.Count - 1);
                }
                else
                {
                    MessageBox.Show("Girilen oda numarasına ait kayıt bulunamadı.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri okuma hatası: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }

            FormOdaDuzenle.Admin = admin;
            FormOdaDuzenle.Mesaj = false;
            FormOdaDuzenle.ShowDialog();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FormOdaDuzenle.Admin = admin;
            FormOdaDuzenle.Mesaj = true;
            FormOdaDuzenle.ShowDialog();
        }

        private void FormUserInterface_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Activate();
            this.BringToFront();
            this.TopMost = false;
            if (!admin)
            {
                btnEkle.Visible = false;
                btnKullanicilariDuzenle.Visible = false;
            }
            else
            {
                btnEkle.Visible = true;
                FormOdaDuzenle.btnOdaSil.Visible = true;
                btnKullanicilariDuzenle.Visible = true;
            }
            OdalariYukle();
        }

        private void btnOturumuKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formlogin = new FormLogin();
            formlogin.Show();
        }

        private void timerFLowLayoutPanetOdaEkle_Tick(object sender, EventArgs e)
        {
            OdaEkle();
            timerFLowLayoutPanetOdaEkle.Enabled = false;
        }

        private void timerFormUserInterfaceGuncelle_Tick(object sender, EventArgs e)
        {
            OdalariYukle();
            timerFormUserInterfaceGuncelle.Enabled = false;
        }

        private void btnKullanicilariDuzenle_Click(object sender, EventArgs e)
        {
            FormKullanicilariDuzenle formKullanicilariDuzenle = new FormKullanicilariDuzenle();
            formKullanicilariDuzenle.ShowDialog();
        }
    }
}