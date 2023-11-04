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
    public partial class FormIsEmrineUygunSiparisListesi : Form
    {
        public static string kalemid;
        SqlConnection SqlConn = new SqlConnection("SQL connection here");

        public FormIsEmrineUygunSiparisListesi()
        {
            InitializeComponent();
        }

        private void FormIsEmrineUygunSiparisListesi_Load_1(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;

            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT SIPARIS_NO, STOK_KODU, STOK_ADI, MIKTAR, SIP_KALEM_ID FROM TBL_SIPARIS_KALEMLERI WHERE STOK_KODU='" + FormIsEmriGirisi.stokkodu + "' AND URETIM_DURUMU='K'", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlConn.Close();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            kalemid = x["SIP_KALEM_ID"].ToString();
            FormIsEmriGirisi.isemrix = "Siparis";
            this.Hide();
            FormIsEmriGirisi frm = new FormIsEmriGirisi();
            frm.Activate();
        }

        private void FormIsEmrineUygunSiparisListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            kalemid = "";
        }
    }
}
