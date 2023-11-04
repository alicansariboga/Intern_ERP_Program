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

namespace ProjectAliCanSariboga
{
    public partial class FormGenelRapor : Form
    {
        SqlConnection SqlConn = new SqlConnection("SQL connection here");

        public FormGenelRapor()
        {
            InitializeComponent();
        }

        void sevkeHazirSiparisListeleme()
        {
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT SIP.SIPARIS_NO AS 'SİPARİŞ NUMARASI', MK.MUSTERI_ADI AS 'MÜŞTERİ ADI', SIP.TESLIM_TARIHI AS 'TESLİM TARİHİ', SIP.TOPLAM_TUTAR 'TOPLAM TUTAR' FROM TBL_SIPARISLER SIP LEFT JOIN TBL_MUSTERI_KAYITLARI MK ON SIP.MUSTERI_KODU = MK.MUSTERI_KODU WHERE SIPARIS_NO NOT IN (SELECT DISTINCT SIPARIS_NO FROM TBL_SIPARIS_KALEMLERI WHERE URETIM_DURUMU = 'K' OR URETIM_DURUMU = 'S' OR URETIM_DURUMU = 'A')",SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gControlSevkeHazirSiparisListesi.DataSource = dt;
            SqlConn.Close();
        }

        void stokKontrolRaporu()
        {
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT SK.STOK_KODU AS 'STOK KODU', SK.STOK_ADI AS 'STOK ADI', (SELECT ISNULL(SUM(MIKTAR), 0) FROM TBL_SIPARIS_KALEMLERI SIP WHERE SIP.STOK_KODU = SK.STOK_KODU) AS 'SIPARIS MIKTARI', (SELECT ISNULL(SUM(MIKTAR), 0) FROM TBL_IS_EMIRLERI IE WHERE IE.STOK_KODU = SK.STOK_KODU) AS 'IS EMRI MIKTARI', (SELECT ISNULL(SUM(G_MIKTAR) - SUM(C_MIKTAR), 0) FROM TBL_STOK_HAREKETLERI SH WHERE SH.STOK_KODU = SK.STOK_KODU) AS 'STOK MIKTARI' FROM TBL_STOK_KAYITLARI SK", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gControlStokKontrolRaporu.DataSource = dt;
            SqlConn.Close();
        }

        void eksikIsEmirleri()
        {
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT STOK_KODU AS 'STOK KODU', STOK_ADI AS 'STOK ADI', MIKTAR AS 'MIKTAR', SIP_KALEM_ID AS 'SIPARIS ID' FROM TBL_SIPARIS_KALEMLERI WHERE URETIM_DURUMU='K'", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gControlIsEmriVerilmesiGerekenSiparisler.DataSource = dt;
            SqlConn.Close();
        }
        
        void urunSatisRaporu()
        {
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT TOP 25 STOK_ADI AS 'STOK_ADI', SUM(MIKTAR) AS 'TOPLAM SATIS MIKTARI' FROM TBL_SIPARIS_KALEMLERI SIP GROUP BY STOK_ADI ORDER BY SUM(MIKTAR) DESC", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gControlUrunSatisRaporu.DataSource = dt;
            SqlConn.Close();
        }

        void musteriListeleme()
        {
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT TOP 10 MUSTERI_ADI AS 'MUSTERI ADI', SUM(TOPLAM_TUTAR) AS 'TOPLAM CIRO' FROM TBL_SIPARISLER SIP LEFT JOIN TBL_MUSTERI_KAYITLARI MK ON SIP.MUSTERI_KODU = MK.MUSTERI_KODU GROUP BY MK.MUSTERI_ADI ORDER BY SUM(TOPLAM_TUTAR) DESC", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
           gControlMusteriCiroRaporu.DataSource = dt;
            SqlConn.Close();
        }

        private void FormGenelRapor_Load(object sender, EventArgs e)
        {
            sevkeHazirSiparisListeleme();
            stokKontrolRaporu();
            eksikIsEmirleri();
            urunSatisRaporu();
            musteriListeleme();

            gViewStokKontrolRaporu.OptionsBehavior.Editable = false;
            gViewMusteriCiroRaporu.OptionsBehavior.Editable = false;
            gViewUrunSatisRaporu.OptionsBehavior.Editable = false;
            gViewSevkeHazirSiparisListesi.OptionsBehavior.Editable = false;
            gViewIsEmriVerilmesiGerekenSiparisler.OptionsBehavior.Editable = false;
        }
    }
}
