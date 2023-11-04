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
    public partial class FormUretimSonuKaydiListeleri : Form
    {
        public static string UretimSonuKayitNo;
        SqlConnection SqlConn = new SqlConnection("SQL connection here");

        public FormUretimSonuKaydiListeleri()
        {
            InitializeComponent();
        }

        void arama()
        {
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT URETIM_SONU_KAYDI_NUMARASI, IS_EMRI_NUMARASI, STOK_KODU, STOK_ADI, SIPARIS_NUMARASI, MUSTERI_ADI FROM TBL_URETIM_SONU_KAYITLARI WHERE URETIM_SONU_KAYDI_NUMARASI LIKE '%"+ txtUretimSonuKaydiNo.Text +"%' AND SIPARIS_NUMARASI LIKE '%"+ txtSiparisNo.Text +"%' AND STOK_KODU LIKE '%"+ txtStokKodu.Text +"%' AND STOK_ADI LIKE '%"+ txtStokAdi.Text +"%' AND MUSTERI_ADI LIKE '%"+ txtMusteriAdi.Text +"%' AND IS_EMRI_NUMARASI LIKE'%"+ txtIsEmriNo.Text +"%'", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlConn.Close();
        }

        private void FormUretimSonuKaydiListeleri_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            arama();
        }

        private void txtUretimSonuKaydiNo_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtSiparisNo_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtStokKodu_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtIsEmriNo_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtMusteriAdi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtStokAdi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (UretimSonuKayitNo == "UretimSonuKayit")
            {
                UretimSonuKayitNo = x["URETIM_SONU_KAYDI_NUMARASI"].ToString();
                FormUretimSonuKayitlari.uretimsx = "UretimSonu";
                //Formu kapat
                this.Hide();
                FormUretimSonuKayitlari frm = new FormUretimSonuKayitlari();
                frm.Activate();
            }
        }
    }
}
