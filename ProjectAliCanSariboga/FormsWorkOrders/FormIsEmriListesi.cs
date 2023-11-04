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
    public partial class FormIsEmriListesi : Form
    {
        public static string IsEmriNo;
        
        SqlConnection SqlConn = new SqlConnection("SQL connection here");

        public FormIsEmriListesi()
        {
            InitializeComponent();
        }

        void arama()
        {
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT IS_EMRI_NUMARASI, STOK_KODU, STOK_ADI, SIPARIS_NO FROM TBL_IS_EMIRLERI WHERE IS_EMRI_NUMARASI LIKE '%"+ txtIsEmriNumarasi.Text +"%' AND STOK_KODU LIKE '%"+ txtStokKodu.Text +"%' AND STOK_ADI LIKE '%"+ txtStokAdi.Text +"%' AND SIPARIS_NO LIKE '%"+ txtSiparisNumarasi.Text +"%'", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlConn.Close();
        }
        void arama2()
        {
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT IS_EMRI_NUMARASI, STOK_KODU, STOK_ADI, SIPARIS_NO FROM TBL_IS_EMIRLERI WHERE IS_EMRI_NUMARASI LIKE '%" + txtIsEmriNumarasi.Text + "%' AND STOK_KODU LIKE '%" + txtStokKodu.Text + "%' AND STOK_ADI LIKE '%" + txtStokAdi.Text + "%' AND SIPARIS_NO LIKE '%" + txtSiparisNumarasi.Text + "%' AND DURUM='Y'", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlConn.Close();
        }



        private void FormIsEmriListesi_Load(object sender, EventArgs e)
        {
            //arama();
            gridView1.OptionsBehavior.Editable = false;
            //yeni kayitta da normal arama yapilmamali.Liste cikmamali.
            if (IsEmriNo == "UretimSonuKayit")
            {
                arama2();
            }
            else
            {
                arama();
            }
        }

        /*
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (IsEmriNo == "IsEmriKayit")
            {
                IsEmriNo = x["IS_EMRI_NUMARASI"].ToString();
                FormIsEmriGirisi.isemrix = "IsEmri";
                //Formu kapat
                this.Hide();
                FormIsEmriGirisi frm = new FormIsEmriGirisi();
                frm.Activate();
            }
            if (IsEmriNo == "UretimSonuKayit")
            {
                IsEmriNo = x["IS_EMRI_NUMARASI"].ToString();
                FormUretimSonuKayitlari.uretimsx = "IsEmri";
                //Formu kapat
                this.Hide();
                FormUretimSonuKayitlari frm = new FormUretimSonuKayitlari();
                frm.Activate();
            }
        }*/

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (IsEmriNo == "IsEmriKayit")
            {
                IsEmriNo = x["IS_EMRI_NUMARASI"].ToString();
                FormIsEmriGirisi.isemrix = "IsEmri";
                //Formu kapat
                this.Hide();
                FormIsEmriGirisi frm = new FormIsEmriGirisi();
                frm.Activate();
            }
            if (IsEmriNo == "UretimSonuKayit")
            {
                IsEmriNo = x["IS_EMRI_NUMARASI"].ToString();
                FormUretimSonuKayitlari.uretimsx = "IsEmri";
                //Formu kapat
                this.Hide();
                FormUretimSonuKayitlari frm = new FormUretimSonuKayitlari();
                frm.Activate();
            }
        }

        private void txtIsEmriNumarasi_TextChanged(object sender, EventArgs e)
        {
            //arama();
            //yeni kayitta da normal arama yapilmamali.Liste cikmamali.
            if (IsEmriNo == "UretimSonuKayit")
            {
                arama2();
            }
            else
            {
                arama();
            }
        }

        private void txtSiparisNumarasi_TextChanged(object sender, EventArgs e)
        {
            //arama();
            //yeni kayitta da normal arama yapilmamali.Liste cikmamali.
            if (IsEmriNo == "UretimSonuKayit")
            {
                arama2();
            }
            else
            {
                arama();
            }
        }

        private void txtStokKodu_TextChanged(object sender, EventArgs e)
        {
            //arama();
            //yeni kayitta da normal arama yapilmamali.Liste cikmamali.
            if (IsEmriNo == "UretimSonuKayit")
            {
                arama2();
            }
            else
            {
                arama();
            }
        }

        private void txtStokAdi_TextChanged(object sender, EventArgs e)
        {
            //arama();
            //yeni kayitta da normal arama yapilmamali.Liste cikmamali.
            if (IsEmriNo == "UretimSonuKayit")
            {
                arama2();
            }
            else
            {
                arama();
            }
        }

        private void FormIsEmriListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsEmriNo = "";
        }
    }
}
