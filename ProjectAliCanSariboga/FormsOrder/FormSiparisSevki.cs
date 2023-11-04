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
    public partial class FormSiparisSevki : Form
    {
        SqlConnection SqlConn = new SqlConnection("SQL connection here");

        public FormSiparisSevki()
        {
            InitializeComponent();
        }

        void MusteriListesiCekme()
        {
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT MUSTERI_KODU, MUSTERI_ADI FROM TBL_MUSTERI_KAYITLARI", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            //Lookup edit icerisinde tablo
            searchLookUpEdit1.Properties.ValueMember = "MUSTERI_KODU";
            searchLookUpEdit1.Properties.DisplayMember = "MUSTERI_ADI";
            searchLookUpEdit1.Properties.DataSource = dt;
            SqlConn.Close();
        }

        void SiparisListesiCekme()
        {
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT SIPARIS_NO, TESLIM_TARIHI, TOPLAM_TUTAR FROM TBL_SIPARISLER WHERE SIPARIS_NO NOT IN (SELECT DISTINCT SIPARIS_NO FROM TBL_SIPARIS_KALEMLERI WHERE URETIM_DURUMU='A' OR URETIM_DURUMU='K' OR URETIM_DURUMU='S') AND MUSTERI_KODU='"+ searchLookUpEdit1.EditValue +"'", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gControlSiparis.DataSource = dt;
            SqlConn.Close();
        }

        private void FormSiparisSevki_Load(object sender, EventArgs e)
        {
            gViewSiparis.OptionsBehavior.Editable = false;
            gViewUrunler.OptionsBehavior.Editable = false;
            MusteriListesiCekme();
        }

        private void sbtnMusteriSiparişRaporu_Click(object sender, EventArgs e)
        {
            SiparisListesiCekme();
        }

        string z = null;
        /*
        private void gridView2_Click(object sender, EventArgs e)
        {
            DataRow x = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            z = x["SIPARIS_NO"].ToString();
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT STOK_KODU, STOK_ADI, MIKTAR, URUN_ACIKLAMASI, SIP_KALEM_ID FROM TBL_SIPARIS_KALEMLERI WHERE SIPARIS_NO='" + z + "'", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlConn.Close();
        } */

        private void gViewSiparis_Click(object sender, EventArgs e)
        {
            DataRow x = gViewSiparis.GetDataRow(gViewSiparis.FocusedRowHandle);
            z = x["SIPARIS_NO"].ToString();
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT STOK_KODU, STOK_ADI, MIKTAR, URUN_ACIKLAMASI, SIP_KALEM_ID FROM TBL_SIPARIS_KALEMLERI WHERE SIPARIS_NO='" + z + "'", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gControlUrunler.DataSource = dt;
            SqlConn.Close();
        }

        private void sbtnSiparisSevkEt_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(gViewUrunler.RowCount.ToString());
            //listeleme dongusu
            for (int i = 0; i <= x-1; i++)
            {
                string musteriKodu = "";
                string stokKodu = "";
                string stokAdi = "";
                string miktar = "";
                string musteriAdi = "";
                string kalemID = gViewUrunler.GetRowCellValue(i, "SIP_KALEM_ID").ToString();
                SqlConn.Open();
                SqlCommand sorgu1 = new SqlCommand("SELECT S.MUSTERI_KODU, SK.STOK_KODU, SK.STOK_ADI, SK.MIKTAR, MK.MUSTERI_ADI FROM TBL_SIPARIS_KALEMLERI SK LEFT JOIN TBL_SIPARISLER S ON SK.SIPARIS_NO=S.SIPARIS_NO LEFT JOIN TBL_MUSTERI_KAYITLARI MK ON S.MUSTERI_KODU=MK.MUSTERI_KODU WHERE SIP_KALEM_ID='" + kalemID +"'", SqlConn);
                SqlDataReader dr = sorgu1.ExecuteReader();
                while (dr.Read())
                {
                    musteriKodu = dr[0].ToString();
                    stokKodu = dr[1].ToString();
                    stokAdi = dr[2].ToString();
                    miktar = dr[3].ToString();
                    musteriAdi = dr[4].ToString();
                }
                SqlConn.Close();

                SqlConn.Open();
                //SEVKIYAT KAYDI
                SqlCommand sorgu2 = new SqlCommand("INSERT INTO TBL_STOK_HAREKETLERI VALUES ('" + musteriKodu + "','','" + stokKodu + "','" + stokAdi + "','0','"+ miktar.Replace(',','.') +"','" + musteriAdi + "','SEVKIYAT') ", SqlConn);
                sorgu2.ExecuteNonQuery();
                SqlConn.Close();
            }
            //uretim durumu guncelleme
            SqlConn.Open();
            SqlCommand sorgu3 = new SqlCommand("UPDATE TBL_SIPARIS_KALEMLERI SET URETIM_DURUMU='S' WHERE SIPARIS_NO='"+ z +"'", SqlConn);
            sorgu3.ExecuteNonQuery();
            SqlConn.Close();
            SiparisListesiCekme();
            gControlUrunler.DataSource = "";
        }
    }
}
