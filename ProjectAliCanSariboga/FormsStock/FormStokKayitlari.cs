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
    public partial class FormStokKayitlari : Form
    {
        SqlConnection SqlConn = new SqlConnection("SQL connection here");

        public FormStokKayitlari()
        {
            InitializeComponent();
        }

        string x1 = "0";
        // Stok kodu kontrolu
        void stokKartiKontrol()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_STOK_KAYITLARI WHERE STOK_KODU = '" + txtStokKodu.Text + "'", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x1 = dr[0].ToString();
            }
            SqlConn.Close();
        }

        string x2 = "0";
        // Grup kodu kontrolu
        void grupKoduKontrol()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT count(*) FROM TBL_GRUP_KODU WHERE GRUP_KODU = '" + txtGrupKodu.Text + "'", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x2 = dr[0].ToString();
            }
            SqlConn.Close();
        }

        void StokBilgisiCekme()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT * FROM TBL_STOK_KAYITLARI WHERE STOK_KODU = '" + txtStokKodu.Text + "'", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtStokAdi.Text = dr[1].ToString();
                txtGrupKodu.Text = dr[2].ToString();
                txtFiyat.Text = dr[3].ToString();
                txtKdvOrani.Text = dr[4].ToString();
            }
            SqlConn.Close();
        } // txtGrupAdi -> properties -> behavior -> enabled = false atandi cunku grup adi kisminda manuel degisiklik yapilamaz.

        void GrupBilgisiCekme()
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

        void temizle()
        {
            //  txtStokKodu.Text = "";
            txtStokAdi.Text = "";
            txtGrupKodu.Text = "";
            txtFiyat.Text = "";
            txtKdvOrani.Text = "";
        }

        private void FormStokKayitlari_Load(object sender, EventArgs e)
        {
            //pencere buyume engelleme
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            txtFiyat.Text = "0,00";
            txtKdvOrani.Text = "0,00";
        }

        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            FormStokListesi.stokKodu = "Kayit";
            FormStokListesi frm = new FormStokListesi();
            frm.Show();
        }

        private void sbtnGrupKodListesi_Click(object sender, EventArgs e)
        {
            FormStokGrupKodlari frm = new FormStokGrupKodlari();
            frm.Show();
        }

        private void txtStokKodu_Leave(object sender, EventArgs e)
        {
            if (txtStokKodu.Text == "")
            {
                txtStokKodu.Focus();
            }
            else
            {
                FormStokListesi.stokKodu = txtStokKodu.Text;
                stokKartiKontrol();
                if (Convert.ToInt16(x1) == 1)
                {
                    StokBilgisiCekme();
                    GrupBilgisiCekme();
                }
                else
                {
                    temizle();
                    txtFiyat.Text = "0,00";
                    txtKdvOrani.Text = "0,00";
                }
            }
        }

        // StokListesi -> Stok Kayitlari activated(double-click)
        private void FormStokKayitlari_Activated(object sender, EventArgs e)
        {
            if(FormStokListesi.stokKodu=="")
            {
                temizle();
                txtStokKodu.Text = "";
            }
            else
            {
                txtStokKodu.Text = FormStokListesi.stokKodu;
                StokBilgisiCekme();
                GrupBilgisiCekme();
            }
            
        }

        private void txtGrupKodu_Leave(object sender, EventArgs e)
        {
            grupKoduKontrol();
            if(Convert.ToInt16(x2)==1)
            {
                GrupBilgisiCekme();
            }
            else
            {
                txtGrupKodu.Focus();
            }
        }

        private void FormStokKayitlari_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormStokListesi.stokKodu = "";
        }

        private void sbnKaydet_Click(object sender, EventArgs e)
        {
            //Zorunlu alan
            if (txtStokAdi.Text == "" || txtStokKodu.Text == "" || txtGrupKodu.Text == "")
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.");
            }
            else
            {
                stokKartiKontrol();
                if (Convert.ToInt16(x1) == 1)
                {
                    //grup kodu kontrolu - kayıt
                    grupKoduKontrol();
                    if (Convert.ToInt16(x2) == 1)
                    {
                        // Guncelleme
                        SqlConn.Open();
                        SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_STOK_KAYITLARI SET STOK_ADI='" + txtStokAdi.Text + "', GRUP_KODU='" + txtGrupKodu.Text + "', FIYAT='" + txtFiyat.Text.Replace(',', '.') + "', KDV_ORANI='" + txtKdvOrani.Text.Replace(',', '.') + "' WHERE STOK_KODU='" + txtStokKodu.Text + "'", SqlConn); //Fiyat icin input olarak ',' kullanilsa bile replace fonksiyonu ile '.' donusumu yapilir.
                        sorgu1.ExecuteNonQuery(); //sorgu calisir
                        SqlConn.Close();
                        temizle();
                        txtStokKodu.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Grup kodu bulunamadı.");
                        txtGrupKodu.Focus();
                    }
                }
                else
                {
                    //grup kodu kontrolu - kayıt
                    grupKoduKontrol();
                    if (Convert.ToInt16(x2) == 1)
                    {
                        // Yeni Kayit
                        SqlConn.Open();
                        SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_STOK_KAYITLARI VALUES('" + txtStokKodu.Text + "','" + txtStokAdi.Text + "','" + txtGrupKodu.Text + "','" + txtFiyat.Text.Replace(',', '.') + "','" + txtKdvOrani.Text.Replace(',', '.') + "')", SqlConn);
                        sorgu1.ExecuteNonQuery();
                        SqlConn.Close();
                        temizle();
                        txtStokKodu.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Grup kodu bulunamadı.");
                        txtGrupKodu.Focus();
                    }
                }
            }
        }

        private void sbtnSil_Click(object sender, EventArgs e)
        {
            stokKartiKontrol();
            if(Convert.ToInt16(x1)==1)
            {
                SqlConn.Open();
                SqlCommand sorgu1 = new SqlCommand("DELETE TBL_STOK_KAYITLARI WHERE STOK_KODU='" + txtStokKodu.Text + "'", SqlConn);
                sorgu1.ExecuteNonQuery();
                SqlConn.Close();
                temizle();
                txtStokKodu.Text = "";
            }
            else
            {
                MessageBox.Show("Böyle bir stok kodu bulunamadı.");
            }
        }

        private void sbtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
            txtStokKodu.Text = "";
        }

        //ESC ile cikis
        private void FormStokKayitlari_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Hide();
            }

        //KAYDET
            if(e.KeyCode==Keys.Enter)
            {
                sbtnKaydet.PerformClick();
            }
        }
    }
}
