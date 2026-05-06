using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;
using System.IO;

namespace OtelOdaTakipSistemi
{
    public partial class FormLogin : Form
    {
        SqlConnection bagla;

        public FormLogin()
        {
            InitializeComponent();
            btnClose.BackColor = this.BackColor;
            bagla = new SqlConnection(VeritabaniAyarlari.PersonelBaglantiCumlesiGetir());
        }

        FormUserInterface formUserInterface = new FormUserInterface();

        internal class NativeMethods
        {
            [DllImport("gdi32.dll")]
            public static extern IntPtr CreateRoundRectRgn(
                int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
                int nWidthEllipse, int nHeightEllipse);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int radius = 60;
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                this.Region = new Region(path);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            btnGiris.Region = System.Drawing.Region.FromHrgn(
                NativeMethods.CreateRoundRectRgn(0, 0, btnGiris.Width, btnGiris.Height, 25, 25));
            textBoxPersonelNo.Region = System.Drawing.Region.FromHrgn(
                NativeMethods.CreateRoundRectRgn(0, 0, textBoxPersonelNo.Width, textBoxPersonelNo.Height, 15, 15));
            textBoxPersonelSifre.Region = System.Drawing.Region.FromHrgn(
                NativeMethods.CreateRoundRectRgn(0, 0, textBoxPersonelSifre.Width, textBoxPersonelSifre.Height, 15, 15));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlCommand sorguKayit;
        SqlCommand sorguYetki;
        SqlDataReader cevap;
        public bool Admin;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (bagla.State == ConnectionState.Closed)
                {
                    sorguKayit = new SqlCommand(
                        "select * from PersonelInformation where PersonelNo = @PersonelNo and PersonelSifre = @PersonelSifre", bagla);

                    sorguKayit.Parameters.AddWithValue("@PersonelNo", textBoxPersonelNo.Text);
                    sorguKayit.Parameters.AddWithValue("@PersonelSifre", textBoxPersonelSifre.Text);

                    bagla.Open();
                    cevap = sorguKayit.ExecuteReader();

                    if (cevap.HasRows)
                    {
                        cevap.Close();
                        sorguYetki = new SqlCommand("select Admin from PersonelInformation where PersonelNo = @PersonelNO", bagla);
                        sorguYetki.Parameters.AddWithValue("PersonelNo", textBoxPersonelNo.Text);

                        object result = sorguYetki.ExecuteScalar();
                        int yetki = Convert.ToInt32(result);

                        TemelPersonel girisYapanKullanici;
                        if (yetki == 1)
                        {
                            girisYapanKullanici = new YoneticiPersonel();
                        }
                        else
                        {
                            girisYapanKullanici = new StandartPersonel();
                        }

                        formUserInterface.admin = girisYapanKullanici.YonetimPaneliErisimi();
                        formUserInterface.Show();
                        formUserInterface.Activate();
                        this.Hide();
                        bagla.Close();
                    }
                    else
                    {
                        if (bagla.State != ConnectionState.Closed)
                        {
                            bagla.Close();
                        }
                        MessageBox.Show("Personel No veya Şifre yanlış tekrar deneyiniz!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (bagla.State == ConnectionState.Open) bagla.Close();
            }
        }
    }
}