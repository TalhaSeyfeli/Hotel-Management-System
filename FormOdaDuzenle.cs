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
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Reflection.Emit;
using System.Security.Cryptography;

namespace OtelOdaTakipSistemi
{
    public partial class FormOdaDuzenle : Form
    {
        public bool Admin { get; set; }

        public bool Mesaj { get; set; }

        private FormUserInterface formUserInterface;

        private OdaYonetimi odaYoneticisi;

        public FormOdaDuzenle(FormUserInterface FormUserInterface)
        {
            InitializeComponent();
            formUserInterface = FormUserInterface;
            odaYoneticisi = new OdaYonetimi();
        }

        private void maskedTextBoxOdaNo_Click(object sender, EventArgs e)
        {
            maskedTextBoxOdaNo.SelectionStart = 0;
            maskedTextBoxOdaNo.Text = string.Empty;
        }

        private void maskedTextBoxOdaRezervasyonTakvimi_Click(object sender, EventArgs e)
        {
            maskedTextBoxOdaRezervasyonTakvimi.SelectionStart = 0;
        }

        private void FormOdaDuzenle_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Activate();
            this.BringToFront();
            this.TopMost = false;

            if (Mesaj)
            {
                btnOdaFotografiEkle.Visible = true;
                btnOdaOzellikEkle.Visible = true;
                btnOzellikSil.Visible = true;
                btnOdaSil.Visible = true;
                textBoxOdaOzellikleri.Visible = true;
                maskedTextBoxOdaNo.Enabled = true;
            }
            else if (!Mesaj && Admin)
            {
                btnOdaFotografiEkle.Visible = true;
                btnOdaOzellikEkle.Visible = true;
                btnOzellikSil.Visible = true;
                btnOdaSil.Visible = true;
                textBoxOdaOzellikleri.Visible = true;
                maskedTextBoxOdaNo.Enabled = false;
            }
            else
                maskedTextBoxOdaNo.Enabled = false;
        }

        private void btnOdaFotografiEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxOdaResmi.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnOdaKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                int odaNo = 0;
                if (!string.IsNullOrWhiteSpace(maskedTextBoxOdaNo.Text) && int.TryParse(maskedTextBoxOdaNo.Text, out int parsedNo))
                {
                    odaNo = parsedNo;
                }
                else
                {
                    MessageBox.Show("Geçerli bir oda numarası giriniz.");
                    return;
                }

                Oda yeniOda = new Oda(odaNo);

                if (radioButtonDolu.Checked)
                    yeniOda.OdaDurumu = 1;
                else
                    yeniOda.OdaDurumu = 0;

                StringBuilder sbTakvim = new StringBuilder();
                for (int i = 0; i < listBoxRezervasyonTakvimi.Items.Count; i++)
                {
                    sbTakvim.Append(listBoxRezervasyonTakvimi.Items[i] + ",");
                }
                yeniOda.RezervasyonTakvimi = sbTakvim.ToString();

                StringBuilder sbOzellik = new StringBuilder();
                for (int i = 0; i < listBoxOdaÖzellikleri.Items.Count; i++)
                {
                    sbOzellik.Append(listBoxOdaÖzellikleri.Items[i] + ",");
                }
                yeniOda.Ozellikler = sbOzellik.ToString();

                if (!string.IsNullOrWhiteSpace(richTextBoxOdaİhtiyaçlari.Text))
                    yeniOda.Ihtiyaclar = richTextBoxOdaİhtiyaçlari.Text;
                else
                    yeniOda.Ihtiyaclar = "Yok";

                yeniOda.Gorsel = pictureBoxOdaResmi.Image;

                if (KayitKontrol(yeniOda))
                {
                    bool odaVar = odaYoneticisi.OdaVarMi(yeniOda.OdaNo);

                    if (Mesaj)
                    {
                        if (odaVar)
                        {
                            MessageBox.Show("Var olan bir oda numarası seçtiniz! Tekrar deneyin.");
                            return;
                        }

                        formUserInterface.timerFLowLayoutPanetOdaEkle.Enabled = true;
                        odaYoneticisi.Ekle(yeniOda);
                        formUserInterface.timerFormUserInterfaceGuncelle.Enabled = true;
                        MessageBox.Show("Oda başarıyla kaydedildi!");
                    }
                    else
                    {
                        if (odaVar)
                        {
                            odaYoneticisi.Guncelle(yeniOda);
                            formUserInterface.timerFormUserInterfaceGuncelle.Enabled = true;
                            MessageBox.Show($"{yeniOda.OdaNo} Nolu oda bilgileri başarıyla güncelendi.");
                        }
                        else
                        {
                            MessageBox.Show("Güncellenecek oda bulunamadı (Oda No değişmiş olabilir).");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Bilgileri Doldurduğunuzdan Emin Olun!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private bool KayitKontrol(Oda oda)
        {
            bool ozellikVarMi = !string.IsNullOrWhiteSpace(oda.Ozellikler);
            bool takvimVarMi = !string.IsNullOrWhiteSpace(oda.RezervasyonTakvimi);

            if (oda.OdaNo > 0 &&
                oda.Gorsel != null &&
                ozellikVarMi &&
                takvimVarMi)
            {
                return true;
            }
            return false;
        }

        private void btnOdaRezervasyonAraligiEkle_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxOdaRezervasyonTakvimi.MaskFull)
            {
                listBoxRezervasyonTakvimi.Items.Add(maskedTextBoxOdaRezervasyonTakvimi.Text);
                maskedTextBoxOdaRezervasyonTakvimi.Clear();
            }
        }

        private void btnOdaOzellikEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxOdaOzellikleri.Text))
            {
                listBoxOdaÖzellikleri.Items.Add(textBoxOdaOzellikleri.Text);
                textBoxOdaOzellikleri.Clear();
            }
        }

        private void FormOdaDuzenle_FormClosing(object sender, FormClosingEventArgs e)
        {
            maskedTextBoxOdaNo.Clear();
            maskedTextBoxOdaRezervasyonTakvimi.Clear();
            textBoxOdaOzellikleri.Clear();
            richTextBoxOdaİhtiyaçlari.Clear();
            pictureBoxOdaResmi.Image = null;
            radioButtonBos.Checked = false;
            radioButtonDolu.Checked = false;
            listBoxRezervasyonTakvimi.Items.Clear();
            listBoxOdaÖzellikleri.Items.Clear();
        }

        private void btnOdaSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Odayı silmek istediğinize emin misiniz?",
                "Oda Sil",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.OK)
            {
                try
                {
                    int silinecekNo = Convert.ToInt32(maskedTextBoxOdaNo.Text);
                    odaYoneticisi.Sil(silinecekNo);

                    formUserInterface.timerFormUserInterfaceGuncelle.Enabled = true;
                    MessageBox.Show($"{silinecekNo} Nolu oda başarıyla silindi.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message);
                }
            }
        }

        private void btnRezervasyonSil_Click(object sender, EventArgs e)
        {
            if (listBoxRezervasyonTakvimi.SelectedIndex != -1)
                listBoxRezervasyonTakvimi.Items.RemoveAt(listBoxRezervasyonTakvimi.SelectedIndex);
        }

        private void btnOzellikSil_Click(object sender, EventArgs e)
        {
            if (listBoxOdaÖzellikleri.SelectedIndex != -1)
                listBoxOdaÖzellikleri.Items.RemoveAt(listBoxOdaÖzellikleri.SelectedIndex);
        }
    }
}