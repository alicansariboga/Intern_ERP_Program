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
    public partial class FormIsEmriGirisi : Form
    {
        public static string stokkodu;
        public static string isemrix;
        SqlConnection SqlConn = new SqlConnection("Data Source=DESKTOP-4M0OQRD\\SQLEXPRESS;Initial Catalog=UretimProgramiNew;Integrated Security=True");

        public FormIsEmriGirisi()
        {
            InitializeComponent();
        }

        string x1 = "0";
        void IsEmriKontrol()
        {
            {
                SqlConn.Open();
                SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_IS_EMIRLERI WHERE IS_EMRI_NUMARASI='" + txtIsEmriNumarasi.Text + "'", SqlConn);
                SqlDataReader dr = sorgu1.ExecuteReader();
                while (dr.Read())
                {
                    x1 = dr[0].ToString();
                }
                SqlConn.Close();
            }
        }


        void IsEmriBilgisiCekme()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT * FROM TBL_IS_EMIRLERI WHERE IS_EMRI_NUMARASI='"+ txtIsEmriNumarasi.Text +"'", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while(dr.Read())
            {
                txtStokKodu.Text = dr[1].ToString();
                txtStokAdi.Text = dr[2].ToString();
                txtIsEmriAciklama.Text = dr[3].ToString();
                txtIsEmriTarihi.Text = dr[4].ToString();
                txtTeslimTarihi.Text = dr[5].ToString();
                txtSiparisNumarasi.Text = dr[6].ToString();
                txtMiktar.Text = dr[7].ToString();
                txtSipKalemID.Text = dr[8].ToString();
                //Durum kismi= Y veya T
                string x = dr[9].ToString();
                if (x=="Y")
                {
                    rbtnYeni.Checked = true;
                }
                else
                {
                    rbtnTamamlanmis.Checked = true;
                }
            }
            SqlConn.Close();
            txtStokKodu.Enabled = false;
            txtMiktar.Enabled = false;
            txtSiparisNumarasi.Enabled = false;
            sbtnStokListesi.Enabled = false;
            sbtnSiparisListesi.Enabled = false;
        }

        string x2 = "0";
        void StokKartiKontrol()
        {
            {
                SqlConn.Open();
                SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_STOK_KAYITLARI WHERE STOK_KODU='" + txtStokKodu.Text + "'", SqlConn);
                SqlDataReader dr = sorgu1.ExecuteReader();
                while (dr.Read())
                {
                    x2 = dr[0].ToString();
                }
                SqlConn.Close();
            }
        }

        void StokBilgisiCekme()
        {
            {
                SqlConn.Open();
                SqlCommand sorgu1 = new SqlCommand("SELECT STOK_ADI FROM TBL_STOK_KAYITLARI WHERE STOK_KODU='" + txtStokKodu.Text + "'", SqlConn);
                SqlDataReader dr = sorgu1.ExecuteReader();
                while (dr.Read())
                {
                    txtStokAdi.Text = dr[0].ToString();
                }
                SqlConn.Close();
            }
        }
        //TBL_SIPARIS_KALEMLERI => siparis durumu guncelleme
        void SipKalemAcma()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARIS_KALEMLERI SET URETIM_DURUMU='A' WHERE SIP_KALEM_ID='"+ txtSipKalemID.Text +"'", SqlConn);
            sorgu1.ExecuteNonQuery();
            SqlConn.Close();
        }
        void SipKalemKapatma()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARIS_KALEMLERI SET URETIM_DURUMU='K' WHERE SIP_KALEM_ID='" + txtSipKalemID.Text + "'", SqlConn);
            sorgu1.ExecuteNonQuery();
            SqlConn.Close();
        }
        void SipKalemBitirme()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARIS_KALEMLERI SET URETIM_DURUMU='B' WHERE SIP_KALEM_ID='" + txtSipKalemID.Text + "'", SqlConn);
            sorgu1.ExecuteNonQuery();
            SqlConn.Close();
        }

        void IsEmriListesiCekme()
        {
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT IS_EMRI_NUMARASI, STOK_KODU, STOK_ADI, SIPARIS_NO, MIKTAR, DURUM FROM TBL_IS_EMIRLERI", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlConn.Close();
        }

        

        void SiparisNoVeMiktarCekme()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT SIPARIS_NO, MIKTAR FROM TBL_SIPARIS_KALEMLERI WHERE SIP_KALEM_ID='"+ txtSipKalemID.Text +"'", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while(dr.Read())
            {
                txtSiparisNumarasi.Text = dr[0].ToString();
                txtMiktar.Text = dr[1].ToString();
            }
            SqlConn.Close();
        }

        void Temizle()
        {
            txtIsEmriAciklama.Text = "";
            txtIsEmriTarihi.Text = "";
            txtSipKalemID.Text = "";
            txtMiktar.Text = "";
            txtSiparisNumarasi.Text = "";
            txtStokAdi.Text = "";
            txtStokKodu.Text = "";
            txtTeslimTarihi.Text = "";
            txtStokKodu.Enabled = true;
            txtMiktar.Enabled = true;
            txtSiparisNumarasi.Enabled = true;
            rbtnYeni.Checked = true;
            sbtnSiparisListesi.Enabled = true;
            sbtnStokListesi.Enabled = true;
        }

        string sn1 = "";
        void IsEmriNumarasiHesaplama()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT TOP 1 CONCAT('I', REPLICATE('0',10-(LEN(SUBSTRING(IS_EMRI_NUMARASI,2,9)+1)+1)),SUBSTRING(IS_EMRI_NUMARASI,2,9)+1) AS 'IS EMRI NUMARASI' FROM TBL_IS_EMIRLERI ORDER BY IS_EMRI_NUMARASI DESC", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                sn1 = dr[0].ToString();
            }
            SqlConn.Close();
        }

        private void sbtnIsEmriListesi_Click(object sender, EventArgs e)
        {
            FormIsEmriListesi.IsEmriNo = "IsEmriKayit";
            FormIsEmriListesi frm = new FormIsEmriListesi();
            frm.Show();
        }

        
        private void sbtnSiparisListesi_Click(object sender, EventArgs e)
        {   // is emrine uygun siparisler tablosunda stokodu text icin tanimlama yapildi.
            stokkodu = txtStokKodu.Text;
            FormIsEmrineUygunSiparisListesi frm = new FormIsEmrineUygunSiparisListesi();
            frm.Show();
        }

        private void FormIsEmriGirisi_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            IsEmriListesiCekme();
            //En son kaydedilen numara +1
            IsEmriNumarasiHesaplama();
            txtIsEmriNumarasi.Text = sn1;
        }

        private void txtIsEmriNumarasi_Leave(object sender, EventArgs e)
        {
            if(txtIsEmriNumarasi.Text=="")
            {
                txtIsEmriNumarasi.Focus();
            }
            IsEmriKontrol();
            if (Convert.ToInt16(x1) == 1)
            {
                IsEmriBilgisiCekme();
                
            }
            else
            {
                //Yeni is emri kaydi
                Temizle();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtIsEmriNumarasi.Text = x["IS_EMRI_NUMARASI"].ToString();
            IsEmriBilgisiCekme();
        }

        private void sbtnSil_Click(object sender, EventArgs e)
        {
            IsEmriKontrol();
            if(Convert.ToInt16(x1)==1)
            {
                //Silme islemi
                SqlConn.Open();
                SqlCommand sorgu1 = new SqlCommand("DELETE TBL_IS_EMIRLERI WHERE IS_EMRI_NUMARASI='"+ txtIsEmriNumarasi.Text +"'", SqlConn);
                sorgu1.ExecuteNonQuery();
                SqlConn.Close();
                SipKalemKapatma();
                Temizle();
                txtIsEmriNumarasi.Text = "";
                IsEmriListesiCekme();
            }
            else
            {
                MessageBox.Show("Böyle bir iş emri kaydı bulunmamaktadır!",  "Sipariş Emri Kontrol",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void sbtnKaydet_Click(object sender, EventArgs e)
        {
            IsEmriKontrol();
            if(Convert.ToInt16(x1) == 1)
            {   //UPDATE

                //YENI
                if (rbtnYeni.Checked == true)
                {
                    SqlConn.Open();
                    SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_IS_EMIRLERI SET IS_EMRI_ACIKLAMASI='"+ txtIsEmriAciklama.Text +"', IS_EMRI_TARIHI='"+ txtIsEmriTarihi.Text +"', TESLIM_TARIHI='"+ txtTeslimTarihi.Text +"', DURUM='Y' WHERE IS_EMRI_NUMARASI='"+ txtIsEmriNumarasi.Text +"'", SqlConn);
                    sorgu1.ExecuteNonQuery();
                    SqlConn.Close();
                    SipKalemAcma();
                    Temizle();
                    txtIsEmriNumarasi.Text = "";
                    IsEmriListesiCekme();
                }
                //ESKI
                else
                {
                    SqlConn.Open();
                    SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_IS_EMIRLERI SET IS_EMRI_ACIKLAMASI='" + txtIsEmriAciklama.Text + "', IS_EMRI_TARIHI='" + txtIsEmriTarihi.Text + "', TESLIM_TARIHI='" + txtTeslimTarihi.Text + "', DURUM='E' WHERE IS_EMRI_NUMARASI='" + txtIsEmriNumarasi.Text + "'", SqlConn);
                    sorgu1.ExecuteNonQuery();
                    SqlConn.Close();
                    SipKalemBitirme();
                    Temizle();
                    txtIsEmriNumarasi.Text = "";
                    IsEmriListesiCekme();
                }
            }
            else
            {   //INSERT

                //YENI
                if (rbtnYeni.Checked == true)
                {
                    SqlConn.Open();
                    SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_IS_EMIRLERI VALUES('" + txtIsEmriNumarasi.Text + "','" + txtStokKodu.Text + "','" + txtStokAdi.Text + "','" + txtIsEmriAciklama.Text + "','" + txtIsEmriTarihi.Text + "','" + txtTeslimTarihi.Text + "','" + txtSiparisNumarasi.Text + "','" + txtMiktar.Text.Replace(',','.') + "','" + txtSipKalemID.Text + "','Y')", SqlConn);
                    sorgu1.ExecuteNonQuery();
                    SqlConn.Close();
                    SipKalemAcma();
                    Temizle();
                    txtIsEmriNumarasi.Text = "";
                    IsEmriListesiCekme();
                }
                //ESKI
                else
                {
                    SqlConn.Open();
                    SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_IS_EMIRLERI VALUES('" + txtIsEmriNumarasi.Text + "','" + txtStokKodu.Text + "','" + txtStokAdi.Text + "','" + txtIsEmriAciklama.Text + "','" + txtIsEmriTarihi.Text + "','" + txtTeslimTarihi.Text + "','" + txtSiparisNumarasi.Text + "','" + txtMiktar.Text.Replace(',', '.') + "','" + txtSipKalemID.Text + "','E')", SqlConn);
                    sorgu1.ExecuteNonQuery();
                    SqlConn.Close();
                    SipKalemBitirme();
                    Temizle();
                    txtIsEmriNumarasi.Text = "";
                    IsEmriListesiCekme();
                }
            }
        }

        private void FormIsEmriGirisi_Activated(object sender, EventArgs e)
        {
            if (isemrix == "IsEmri")
            {
                txtIsEmriNumarasi.Text = FormIsEmriListesi.IsEmriNo;
                IsEmriBilgisiCekme();
                isemrix = "";
            }

            if (isemrix == "stok")
            {
                txtStokKodu.Text = FormStokListesi.stokKodu;
                StokBilgisiCekme();
                isemrix = "";
            }

            if (isemrix == "Siparis")
            {
                txtSipKalemID.Text = FormIsEmrineUygunSiparisListesi.kalemid;
                if (txtSipKalemID.Text == "")
                {

                }
                else
                {
                    SiparisNoVeMiktarCekme();
                    txtMiktar.Enabled = false;
                    isemrix = "";
                }
            }
            else
            {
                //nothing
            }
        }

        private void txtStokKodu_Leave(object sender, EventArgs e)
        {
            StokKartiKontrol();
            if (Convert.ToInt16(x2)==1)
            {
                StokBilgisiCekme();
                txtSiparisNumarasi.Text = "";
                txtMiktar.Text = "";
                txtSipKalemID.Text = "";
                txtStokAdi.Enabled = false;
            }
            else
            {
                txtStokKodu.Focus();
            }
        }

        private void FormIsEmriGirisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormIsEmrineUygunSiparisListesi.kalemid = "";
            isemrix = "";
            FormStokListesi.stokKodu = "";
            FormIsEmriListesi.IsEmriNo = "";
        }

        private void sbtnSiparisTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            txtIsEmriNumarasi.Text = "";
            txtIsEmriNumarasi.Focus();
        }

        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            FormStokListesi.stokKodu = "IsEmri";
            FormStokListesi frm = new FormStokListesi();
            frm.Show();
        }
    }
}
