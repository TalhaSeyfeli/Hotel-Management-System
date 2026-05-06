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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace OtelOdaTakipSistemi
{
    public partial class FormKullanicilariDuzenle : Form
    {
        SqlConnection baglanti;

        public FormKullanicilariDuzenle()
        {
            InitializeComponent();
            baglanti = new SqlConnection(VeritabaniAyarlari.PersonelBaglantiCumlesiGetir());
        }

        private void FormKullanicilariDuzenle_Load(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        void VerileriYukle()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PersonelInformation", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewPersonelInformation.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenemedi: " + ex.Message);
            }
        }

        private void btnKullaniciKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                int value;
                if (int.TryParse(textBoxPersonelNo.Text, out value) && !string.IsNullOrWhiteSpace(textBoxPersonelSifre.Text))
                {
                    int personelNo = Convert.ToInt32(textBoxPersonelNo.Text);
                    string personelSifre = textBoxPersonelSifre.Text;
                    int admin = checkBoxKullaniciAdminBilgisi.Checked ? 1 : 0;
                    string kaydet = "INSERT INTO PersonelInformation (PersonelNo, PersonelSifre, Admin) VALUES (@personelNo, @personelSifre, @admin)";

                    using (SqlCommand cmd = new SqlCommand(kaydet, baglanti))
                    {
                        cmd.Parameters.AddWithValue("@personelNo", personelNo);
                        cmd.Parameters.AddWithValue("@personelSifre", personelSifre);
                        cmd.Parameters.AddWithValue("@admin", admin);

                        if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                        cmd.ExecuteNonQuery();
                    }

                    VerileriYukle();
                }
                else
                {
                    MessageBox.Show("Lütfen verileri doğru formatta girin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt hatası: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersonelInformation.SelectedRows.Count > 0)
            {
                try
                {
                    int secilenId = Convert.ToInt32(dataGridViewPersonelInformation.SelectedRows[0].Cells["Id"].Value);
                    string sorgu = "DELETE FROM PersonelInformation WHERE Id = @Id";

                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                    using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                    {
                        cmd.Parameters.AddWithValue("@Id", secilenId);
                        cmd.ExecuteNonQuery();
                    }

                    VerileriYukle();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Ana Kullanıcı Silinemez veya Veritabanı Hatası!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open) baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.");
            }
        }
    }
}