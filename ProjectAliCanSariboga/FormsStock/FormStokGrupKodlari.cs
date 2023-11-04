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
    public partial class FormStokGrupKodlari : Form
    {
        SqlConnection SqlConn = new SqlConnection("SQL connection here");
        public FormStokGrupKodlari()
        {
            InitializeComponent();
        }

        // grup kodu kontrolu
        string x1 = "0";
        void grupKoduKontrol()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_GRUP_KODU WHERE GRUP_KODU = '" + txtGrupKodu.Text + "'", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x1 = dr[0].ToString();
            }
            SqlConn.Close();
        }

        void temizle()
        {
            txtGrupAdi.Text = "";
            txtGrupKodu.Text = "";
        }

        void grupKoduListeleme()
        {
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT * FROM TBL_GRUP_KODU", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlConn.Close();
        }

        void GrupKoduBilgisiCekme()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT GRUP_ADI FROM TBL_GRUP_KODU WHERE GRUP_KODU='" + txtGrupKodu.Text + "'", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtGrupAdi.Text = dr[0].ToString();
            }
            SqlConn.Close();
        }

        private void FormStokGrupKodlari_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            grupKoduListeleme();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            DataRow satir = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtGrupKodu.Text = satir["GRUP_KODU"].ToString();
            txtGrupAdi.Text = satir["GRUP_ADI"].ToString();
        }

        private void txtGrupKodu_Leave(object sender, EventArgs e)
        {
            grupKoduKontrol();
            if(Convert.ToInt16(x1)==1)
            {
                GrupKoduBilgisiCekme();
            }
            else
            {
                txtGrupAdi.Text = "";
            }
        }

        private void sbtnKaydet_Click(object sender, EventArgs e)
        {
            grupKoduKontrol();
            if(Convert.ToInt16(x1)==1)
            {
                // Guncelleme
                SqlConn.Open();
                SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_GRUP_KODU SET GRUP_ADI = '" + txtGrupAdi.Text + "' WHERE GRUP_KODU = '" + txtGrupKodu.Text + "'", SqlConn);
                sorgu1.ExecuteNonQuery(); //sorgu calisir
                SqlConn.Close();
                temizle();
                grupKoduListeleme();
            }
            else
            {
                // Yeni Kayit
                SqlConn.Open();
                SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_GRUP_KODU (GRUP_KODU, GRUP_ADI) VALUES ('" + txtGrupKodu.Text + "', '" + txtGrupAdi.Text + "')", SqlConn);
                sorgu1.ExecuteNonQuery();
                SqlConn.Close();
                temizle();
                grupKoduListeleme();
            }
        }

        private void sbtnSil_Click(object sender, EventArgs e)
        {
            grupKoduKontrol();
            if(Convert.ToInt16(x1)==1)
            {
                SqlConn.Open();
                SqlCommand sorgu1 = new SqlCommand("DELETE TBL_GRUP_KODU WHERE GRUP_KODU='" + txtGrupKodu.Text + "' ", SqlConn);
                sorgu1.ExecuteNonQuery();
                SqlConn.Close();
                temizle();
                grupKoduListeleme();
            }
            else
            {
                // oyle bir kod yoksa islem yapilmaz.
            }
            
        }
    }
}
