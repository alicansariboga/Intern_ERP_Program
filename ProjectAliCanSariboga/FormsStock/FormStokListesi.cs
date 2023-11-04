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
    public partial class FormStokListesi : Form
    {
        public static string stokKodu;
        SqlConnection SqlConn = new SqlConnection("SQL connection here");

        public FormStokListesi()
        {
            InitializeComponent();
        }

        void arama()
        {
            SqlConn.Open();
            DataTable dt = new DataTable();
            //SqlCommand sorgu1 = new SqlCommand("SELECT * FROM TBL_STOK_KAYITLARI WHERE STOK_KODU like '%" + txtStokKodu.Text + "%' and STOK_ADI like '%" + txtStokAdi.Text + "%' and GRUP_KODU like '%" + txtGrupKodu.Text + "%'", SqlConn);
            // Sütun isimlendirme
            SqlCommand sorgu1 = new SqlCommand("SELECT STOK_KODU AS [Stok Kodu], STOK_ADI AS [Stok Adı], GRUP_KODU AS [Grup Numarası], FIYAT AS [Fiyat], KDV_ORANI AS [KDV Oranı] FROM TBL_STOK_KAYITLARI WHERE STOK_KODU like '%" + txtStokKodu.Text + "%' and STOK_ADI like '%" + txtStokAdi.Text + "%' and GRUP_KODU like '%" + txtGrupKodu.Text + "%'", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlConn.Close();
        }

        private void FormStokListesi_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;  //Tablodaki degisikligi engellemek.
            arama();
        }

        private void txtStokKodu_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtStokAdi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtGrupKodu_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow satir = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(stokKodu=="Kayit")
            {
                stokKodu = satir["Stok Kodu"].ToString();
                this.Hide();
                FormStokKayitlari frm = new FormStokKayitlari();
                frm.Activate();
            }
            if (stokKodu=="SiparisKayit")
            {
                stokKodu = satir["Stok Kodu"].ToString();
                FormSiparisler.Siparisx = "Stok";
                this.Hide();
                FormSiparisler frm = new FormSiparisler();
                frm.Activate();
            }
             if (stokKodu == "IsEmri")
             {
                stokKodu = satir["Stok Kodu"].ToString();
                FormIsEmriGirisi.isemrix = "Stok";
                this.Hide();
                FormIsEmriGirisi frm = new FormIsEmriGirisi();
                frm.Activate();
            }
             if(stokKodu == "StokHareket")
            {
                stokKodu = satir["Stok Kodu"].ToString();
                FormStokHareketleri.stokhareketx = "Stok";
                this.Hide();
                FormStokHareketleri frm = new FormStokHareketleri();
                frm.Activate();
            }
        }

        private void FormStokListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            stokKodu = "";
        }
    }
}
