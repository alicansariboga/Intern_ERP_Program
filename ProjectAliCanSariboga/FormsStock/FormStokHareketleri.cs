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
    public partial class FormStokHareketleri : Form
    {
        public static string stokhareketx;
        SqlConnection SqlConn = new SqlConnection("SQL connection here");

        public FormStokHareketleri()
        {
            InitializeComponent();
        }

        void StokBilgisiCekme()
        {
            //stok bilgisi
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT SK.STOK_ADI, GK.GRUP_ADI FROM TBL_STOK_KAYITLARI SK LEFT JOIN TBL_GRUP_KODU GK ON SK.GRUP_KODU=GK.GRUP_KODU WHERE STOK_KODU='"+ txtStokKodu.Text +"'", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtStokAdi.Text = dr[0].ToString();
                txtGrupAdi.Text = dr[1].ToString();
            }
            SqlConn.Close();
            //stok miktari
            SqlConn.Open();
            SqlCommand sorgu2 = new SqlCommand("SELECT ISNULL((SUM(G_MIKTAR))-(SUM(C_MIKTAR)),0) AS 'STOK_MIKTARI' FROM TBL_STOK_HAREKETLERI WHERE STOK_KODU='"+ txtStokKodu.Text +"'", SqlConn);
            SqlDataReader dr1 = sorgu2.ExecuteReader();
            while (dr1.Read())
            {
                txtGuncelMiktar.Text = dr1[0].ToString();
            }
            SqlConn.Close();
        }

        void StokHareketListesiCekme()
        {
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT URETIM_SONU_KAYDI_NUMARASI AS 'URETIM SONU KAYDI', IS_EMRI_NUMARASI AS 'IS EMRI NUMARASI', ACIKLAMA, STOK_KODU AS 'STOK KODU', STOK_ADI AS 'STOK ADI', G_MIKTAR AS 'URETIM MIKTARI', C_MIKTAR AS 'SEVK MIKTARI', MUSTERI_ADI AS 'MISTERI ADI' FROM TBL_STOK_HAREKETLERI WHERE STOK_KODU='"+ txtStokKodu.Text +"'", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlConn.Close();
        }

        void Temizle()
        {
            txtStokKodu.Text = "";
            txtStokAdi.Text = "";
            txtGrupAdi.Text = "";
            txtGuncelMiktar.Text = "";
            gridControl1.DataSource = ""; //tablo temizleme
        }



        private void FormStokHareketleri_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            DataGridView dg = sender as DataGridView;
            string tur = Convert.ToString(gridView1.GetRowCellValue(e.RowHandle, "ACIKLAMA"));
            if (tur == "URETİM")
            {
                e.Appearance.BackColor = Color.Green;
            }
            else
            {
                e.Appearance.BackColor = Color.Red;
            }
        }

        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            FormStokListesi.stokKodu = "StokHareket";
            FormStokListesi frm = new FormStokListesi();
            frm.Show();
        }

        private void txtStokKodu_Leave(object sender, EventArgs e)
        {
            StokBilgisiCekme();
            StokHareketListesiCekme();
        }

        private void sbtnUrunTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void FormStokHareketleri_Activated(object sender, EventArgs e)
        {
            if (stokhareketx == "Stok")
            {
                txtStokKodu.Text = FormStokListesi.stokKodu;
                StokBilgisiCekme();
                StokHareketListesiCekme();
                stokhareketx = "";
            }
        }

        private void FormStokHareketleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormStokListesi.stokKodu = "";
            stokhareketx = "";
        }
    }
}
