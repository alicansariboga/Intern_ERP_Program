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
    public partial class FormMusteriKayitlari : Form
    {
        SqlConnection SqlConn = new SqlConnection("SQL connection here");
        public FormMusteriKayitlari()
        {
            InitializeComponent();
        }

        string x1 = "0";
        void MusteriKontrol()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_MUSTERI_KAYITLARI WHERE MUSTERI_KODU = '" + txtMusteriKodu.Text + "'", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while(dr.Read())
            {
                x1 = dr[0].ToString();
            }
            SqlConn.Close();
        }

        void MusteriBilgisiCekme()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT * FROM TBL_MUSTERI_KAYITLARI WHERE MUSTERI_KODU = '" + txtMusteriKodu.Text + "'", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while(dr.Read())
            {
                txtMusteriAdi.Text = dr[1].ToString();
                txtAdres.Text = dr[2].ToString();
                cbxIl.Text = dr[3].ToString();
                cbxIlce.Text = dr[4].ToString();
                txtTelefon.Text = dr[5].ToString();
                txtEposta.Text = dr[6].ToString();
                string x = dr[7].ToString();
                if (x=="A")
                {
                    rbtnAlici.Checked = true;
                }
                else
                {
                    rbtnSatici.Checked = true;
                }
            }
            SqlConn.Close();
            //Musteri kayitlari ekrani calistigi zaman sehirler listeleniyor fakat ayni ekranda ikinci bir kayit yapilmak istenildigi zaman listelenmiyor. Dolayisiyla yeniden listelenmesi gerekmektedir.
            IlListeleme();
            IlceListeleme();
        }

        void Temizle()
        {
            txtMusteriAdi.Text = "";
            txtAdres.Text = "";
            cbxIl.Text = "";
            cbxIl.Properties.Items.Clear();
            cbxIlce.Text = "";
            cbxIlce.Properties.Items.Clear();
            txtTelefon.Text = "";
            txtEposta.Text = "";
            rbtnAlici.Checked = false;
            rbtnSatici.Checked = false;
        }

        void IlListeleme()
        {
            //ComboBox i temizler.
            cbxIl.Properties.Items.Clear();

            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT ISIM FROM TBL_IL", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                cbxIl.Properties.Items.Add(dr[0]);
            }
            SqlConn.Close();
        }

        void IlceListeleme()
        {
            //ComboBox i temizler.
            cbxIlce.Properties.Items.Clear();

            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT ISIM FROM TBL_ILCE WHERE IL_ID = '" + (cbxIl.SelectedIndex+1) + "'", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                cbxIlce.Properties.Items.Add(dr[0]);
            }
            SqlConn.Close();
        }

        private void FormMusteriKayitlari_Load(object sender, EventArgs e)
        {
            IlListeleme();
        }

        private void txtMusteriKodu_Leave(object sender, EventArgs e)
        {
            if(txtMusteriKodu.Text=="")
            {
                txtMusteriKodu.Focus();
            }
            else
            {
                MusteriKontrol();
                if (Convert.ToInt16(x1) == 1)
                {
                    //Bilgi cekme
                    MusteriBilgisiCekme();
                    IlceListeleme();
                }
                else
                {
                    Temizle();
                    //Musteri kayitlari ekrani calistigi zaman sehirler listeleniyor fakat ayni ekranda ikinci bir kayit yapilmak istenildigi zaman listelenmiyor. Dolayisiyla yeniden listelenmesi gerekmektedir.
                    IlListeleme();
                }
            }
        }
        //Musterikodu tab islevi ve burdaki textchanged cakisiyor.

        //Her il degisiminde, ilce listesi degisir.
        //private void cbxIl_TextChanged(object sender, EventArgs e)
        //{
        //    //MessageBox.Show(Convert.ToString(cbxIl.SelectedIndex+1));
        //    IlceListeleme();
        //}

        private void sbtnKaydet_Click(object sender, EventArgs e)
        {
            MusteriKontrol();
            if(Convert.ToInt16(x1)==1)
            {
                //GUNCELLEME
                if(rbtnAlici.Checked==true)
                {
                    //alici Guncelleme
                    SqlConn.Open();
                    SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_MUSTERI_KAYITLARI SET MUSTERI_ADI='" + txtMusteriAdi.Text + "', ADRES='" + txtAdres.Text + "', IL='" + cbxIl.Text + "', ILCE='" + cbxIlce.Text + "', TELEFON='" + txtTelefon.Text + "', E_POSTA='" + txtEposta.Text + "',TIP='A' WHERE MUSTERI_KODU='" + txtMusteriKodu.Text + "'", SqlConn);
                    sorgu1.ExecuteNonQuery();
                    SqlConn.Close();
                    Temizle();
                    txtMusteriKodu.Text = "";
                }
                else
                {
                    //satici guncelleme
                    SqlConn.Open();
                    SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_MUSTERI_KAYITLARI SET MUSTERI_ADI='" + txtMusteriAdi.Text + "', ADRES='" + txtAdres.Text + "', IL='" + cbxIl.Text + "', ILCE='" + cbxIlce.Text + "', TELEFON='" + txtTelefon.Text + "', E_POSTA='" + txtEposta.Text + "',TIP='S' WHERE MUSTERI_KODU='" + txtMusteriKodu.Text + "'", SqlConn);
                    sorgu1.ExecuteNonQuery();
                    SqlConn.Close();
                    Temizle();
                    txtMusteriKodu.Text = "";
                }

            }
            else
            {
                //INSERT
                if (rbtnAlici.Checked == true)
                {
                    //alici insert
                    SqlConn.Open();
                    SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_MUSTERI_KAYITLARI VALUES('" + txtMusteriKodu.Text + "', '" + txtMusteriAdi.Text + "', '" + txtAdres.Text + "', '" + cbxIl.Text + "', '" + cbxIlce.Text + "', '" + txtTelefon.Text + "', '" + txtEposta.Text + "', 'A')", SqlConn);
                    sorgu1.ExecuteNonQuery();
                    SqlConn.Close();
                    Temizle();
                    txtMusteriKodu.Text = "";
                }
                else
                {
                    //satici insert
                    SqlConn.Open();
                    SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_MUSTERI_KAYITLARI VALUES('" + txtMusteriKodu.Text + "', '" + txtMusteriAdi.Text + "', '" + txtAdres.Text + "', '" + cbxIl.Text + "', '" + cbxIlce.Text + "', '" + txtTelefon.Text + "', '" + txtEposta.Text + "', 'S')", SqlConn);
                    sorgu1.ExecuteNonQuery();
                    SqlConn.Close();
                    Temizle();
                    txtMusteriKodu.Text = "";
                }
            }
        }

        private void sbtnSil_Click(object sender, EventArgs e)
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("DELETE TBL_MUSTERI_KAYITLARI WHERE MUSTERI_KODU='" + txtMusteriKodu.Text + "'", SqlConn);
            sorgu1.ExecuteNonQuery();
            SqlConn.Close();
            Temizle();
            txtMusteriKodu.Text = "";
        }

        private void cbxIl_Leave(object sender, EventArgs e)
        {
            IlceListeleme();
            //Bu sifirlamayi guncelleme icin sehir degistiginde eski ilcelerin kalmamasi icin yapiyoruz.
            cbxIlce.Text = "";
        }

        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            //Musteri listesi ekranina nereden gelindigini tanimak icin burada musteriKayit tanimlamasi yapildi.
            //Ornegin; MusteriListesine Musteri kayittan mi gidiliyor yoksa siparis kayittan mi? Programin bunu anlamasi icin tanimlama yapilir.
            FormMusteriListesi.MusteriKodu = "MusteriKayit";
            FormMusteriListesi frm = new FormMusteriListesi();
            frm.Show();
        }

        private void FormMusteriKayitlari_Activated(object sender, EventArgs e)
        {
            if(FormMusteriListesi.MusteriKodu=="")
            {
                //Arka plan temizleme. Istege bagli degisebilir.
                //Temizle();
                //txtMusteriKodu.Text = "";
            }
            else
            {
                txtMusteriKodu.Text = FormMusteriListesi.MusteriKodu;
                MusteriBilgisiCekme();
            }
        }

        private void FormMusteriKayitlari_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MusteriKayit formu kapatildiginda sifirlansin. Bilgileri hafizada tutmasin.
            FormMusteriListesi.MusteriKodu = "";
        }
    }
}
