using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace OtelOdaTakipSistemi
{
    public static class VeritabaniAyarlari
    {
        public static string BaglantiCumlesiGetir()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectRoot = Directory.GetParent(basePath).Parent.Parent.FullName;
            string dbPath = Path.Combine(projectRoot, "VeriTabani", "OdaBilgileri.mdf");
            return $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;Connect Timeout=30;";
        }

        public static string PersonelBaglantiCumlesiGetir()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectRoot = Directory.GetParent(basePath).Parent.Parent.FullName;
            string dbPath = Path.Combine(projectRoot, "VeriTabani", "PersonelKayitlari.mdf");
            return $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;Connect Timeout=30;";
        }
    }

    public interface IOdaIslemleri
    {
        void Ekle(Oda oda);
        void Guncelle(Oda oda);
        void Sil(int odaNo);
    }

    public abstract class TemelPersonel
    {
        public int PersonelNo { get; set; }
        public string Sifre { get; set; }
        public abstract bool YonetimPaneliErisimi();
    }

    public class YoneticiPersonel : TemelPersonel
    {
        public override bool YonetimPaneliErisimi()
        {
            return true;
        }
    }

    public class StandartPersonel : TemelPersonel
    {
        public override bool YonetimPaneliErisimi()
        {
            return false;
        }
    }

    public class Oda
    {
        private int _odaNo;
        public int OdaNo
        {
            get { return _odaNo; }
            set
            {
                if (value <= 0) throw new ArgumentException("Oda no negatif olamaz");
                _odaNo = value;
            }
        }

        private string _ozellikler;
        public string Ozellikler
        {
            get { return _ozellikler; }
            set { _ozellikler = value ?? ""; }
        }

        public int OdaDurumu { get; set; }
        public string RezervasyonTakvimi { get; set; }
        public string Ihtiyaclar { get; set; }
        public Image Gorsel { get; set; }

        public Oda()
        {
            Ihtiyaclar = "Yok";
        }

        public Oda(int odaNo) : this()
        {
            OdaNo = odaNo;
        }
    }

    public class OdaYonetimi : IOdaIslemleri
    {
        SqlConnection baglanti;

        public OdaYonetimi()
        {
            baglanti = new SqlConnection(VeritabaniAyarlari.BaglantiCumlesiGetir());
        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null) return new byte[0];
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        public void Ekle(Oda oda)
        {
            try
            {
                byte[] resimBytes = ImageToByteArray(oda.Gorsel);
                string query = "INSERT INTO OdaBilgileri(FotografGorsel, OdaIhtiyaclari, OdaOzellikleri, OdaRezervasyonTakvimi, OdaNo, OdaDurumu) VALUES (@Gorsel, @Ihtiyaclar, @Ozellikler, @RezervasyonTakvimi, @OdaNo, @OdaDurumu)";

                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                using (SqlCommand cmd = new SqlCommand(query, baglanti))
                {
                    cmd.Parameters.AddWithValue("@Gorsel", resimBytes);
                    cmd.Parameters.AddWithValue("@Ihtiyaclar", oda.Ihtiyaclar ?? "Yok");
                    cmd.Parameters.AddWithValue("@Ozellikler", oda.Ozellikler ?? "");
                    cmd.Parameters.AddWithValue("@RezervasyonTakvimi", oda.RezervasyonTakvimi ?? "");
                    cmd.Parameters.AddWithValue("@OdaNo", oda.OdaNo);
                    cmd.Parameters.AddWithValue("@OdaDurumu", oda.OdaDurumu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        public void Guncelle(Oda oda)
        {
            try
            {
                byte[] resimBytes = ImageToByteArray(oda.Gorsel);
                string guncelle = "UPDATE OdaBilgileri SET FotografGorsel = @FotografGorsel, OdaIhtiyaclari = @OdaIhtiyaclari, OdaOzellikleri = @OdaOzellikleri, OdaRezervasyonTakvimi = @OdaRezervasyonTakvimi, OdaDurumu = @OdaDurumu WHERE OdaNo = @OdaNo";

                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                using (SqlCommand cmd = new SqlCommand(guncelle, baglanti))
                {
                    cmd.Parameters.AddWithValue("@FotografGorsel", resimBytes);
                    cmd.Parameters.AddWithValue("@OdaIhtiyaclari", oda.Ihtiyaclar ?? "Yok");
                    cmd.Parameters.AddWithValue("@OdaOzellikleri", oda.Ozellikler ?? "");
                    cmd.Parameters.AddWithValue("@OdaRezervasyonTakvimi", oda.RezervasyonTakvimi ?? "");
                    cmd.Parameters.AddWithValue("@OdaDurumu", oda.OdaDurumu);
                    cmd.Parameters.AddWithValue("@OdaNo", oda.OdaNo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Güncelleme sırasında hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        public void Sil(int odaNo)
        {
            try
            {
                string sql = "DELETE FROM OdaBilgileri WHERE OdaNo = @OdaNo";
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                using (SqlCommand cmd = new SqlCommand(sql, baglanti))
                {
                    cmd.Parameters.AddWithValue("@OdaNo", odaNo);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        public bool OdaVarMi(int odaNo)
        {
            bool varMi = false;
            string sorgu = "select count(*) from OdaBilgileri where OdaNo = @OdaNo";
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();

            using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
            {
                cmd.Parameters.AddWithValue("@OdaNo", odaNo);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                varMi = count > 0;
            }
            baglanti.Close();
            return varMi;
        }
    }
}