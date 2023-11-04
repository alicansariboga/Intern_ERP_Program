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
    public partial class FormSiparisListesi : Form
    {
        public static string SiparisNo;

        SqlConnection SqlConn = new SqlConnection("SQL connection here");

        void arama()
        {
            //TABLO BIRLESTIRME YAPILIR
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT S.SIPARIS_NO, M.MUSTERI_ADI, S.SIPARIS_TARIHI, S.TESLIM_TARIHI FROM TBL_SIPARISLER S LEFT JOIN TBL_MUSTERI_KAYITLARI M " +
                "ON S.MUSTERI_KODU=M.MUSTERI_KODU WHERE S.SIPARIS_NO LIKE '%"+ txtSiparisNumarasi.Text +"%' AND M.MUSTERI_ADI LIKE '%"+ txtMusteriAdi.Text +"%'", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlConn.Close();
        }

        public FormSiparisListesi()
        {

            InitializeComponent();
        }

        private void FormSiparisListesi_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            arama();
        }

        private void txtSiparisNumarasi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtMusteriAdi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            //Siparis listesi bircok yerde acilacak. Siparis kaydi ekranindan yapildigini belirtmek icin nesne uretilir.
            if (SiparisNo == "SiparisKayit")
            {
                SiparisNo = x["SIPARIS_NO"].ToString();
                FormSiparisler.Siparisx = "Siparis";
                //Formu kapat
                this.Hide();
                FormSiparisler frm = new FormSiparisler();
                frm.Activate();
            }
            else
            {
                //baska bir yerde kullanilacaksa(or: is emri kayit) bu kisma eklenir.
            }
        }

        private void FormSiparisListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            SiparisNo = "";
        }
    }
}
