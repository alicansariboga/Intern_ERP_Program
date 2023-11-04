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
    public partial class FormMusteriListesi : Form
    {
        public static string MusteriKodu;
        SqlConnection SqlConn = new SqlConnection("Data Source=DESKTOP-4M0OQRD\\SQLEXPRESS;Initial Catalog=UretimProgramiNew;Integrated Security=True");

        public FormMusteriListesi()
        {
            InitializeComponent();
        }

        void arama()
        {
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT MUSTERI_KODU, MUSTERI_ADI, IL, ILCE FROM TBL_MUSTERI_KAYITLARI WHERE MUSTERI_KODU LIKE '%"+ txtMusteriKodu.Text +"%' AND MUSTERI_ADI LIKE '%"+ txtMusteriAdi.Text +"%' AND IL LIKE '%"+ txtIl.Text +"%' AND ILCE LIKE '%"+ txtIlce.Text +"%'", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlConn.Close();
        }

        private void FormMusteriListesi_Load(object sender, EventArgs e)
        {
            //tablo uzerinde duzenleme engeli
            gridView1.OptionsBehavior.Editable = false;
            arama();
        }

        private void txtMusteriKodu_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtMusteriAdi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtIl_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtIlce_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(MusteriKodu=="MusteriKayit")
            {
                MusteriKodu = x["MUSTERI_KODU"].ToString();
                //Formu kapat
                this.Hide();
                FormMusteriKayitlari frm = new FormMusteriKayitlari();
                frm.Activate();
            }
            else
            {
                if (MusteriKodu == "SiparisKayit")
                {
                    MusteriKodu = x["MUSTERI_KODU"].ToString();
                    FormSiparisler.Siparisx = "Musteri";
                    //Formu kapat
                    this.Hide();
                    FormSiparisler frm = new FormSiparisler();
                    frm.Activate();
                }
                else
                {

                }
            }
        }

        private void FormMusteriListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            MusteriKodu = "";
        }
    }
}
