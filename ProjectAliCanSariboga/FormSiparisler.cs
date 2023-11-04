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
    public partial class FormSiparisler : Form
    {
        public static string Siparisx;

        string SipKalem = "";
        SqlConnection SqlConn = new SqlConnection("Data Source=DESKTOP-4M0OQRD\\SQLEXPRESS;Initial Catalog=UretimProgramiNew;Integrated Security=True");
        public FormSiparisler()
        {
            InitializeComponent();
        }

        string x1 = "0";
        void SiparisKontrol()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_SIPARISLER WHERE SIPARIS_NO='"+ txtSiparisNumarasi.Text +"'", SqlConn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while(dr1.Read())
            {
                x1 = dr1[0].ToString();
            }
            SqlConn.Close();
        }

        //hem siparis hem de siparis listesinden veri cekilecegi icin 1 ve 2 olarak isimlendirme yapilir.
        void SiparisBilgisiCekme1()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT * FROM TBL_SIPARISLER WHERE SIPARIS_NO='"+ txtSiparisNumarasi.Text +"'", SqlConn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                txtMusteriKodu.Text = dr1[1].ToString();
                txtSiparisTarihi.Text = dr1[2].ToString();
                txtTeslimTarihi.Text = dr1[3].ToString();
                txtToplamTutar.Text = dr1[4].ToString();
            }
            SqlConn.Close();
        }

        //Gridview aracinin icerisini doldurmak icin.
        void SiparisBilgisiCekme2()
        {
            SqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT STOK_KODU, STOK_ADI, MIKTAR, FIYAT, KDV, SIP_KALEM_ID FROM TBL_SIPARIS_KALEMLERI WHERE SIPARIS_NO='"+ txtSiparisNumarasi.Text +"'", SqlConn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlConn.Close();
        }

        //Musteri Kontrolu
        string x2 = "0";
        void MusteriKontrol()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_MUSTERI_KAYITLARI WHERE MUSTERI_KODU = '" + txtMusteriKodu.Text + "'", SqlConn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x2 = dr1[0].ToString();
            }
            SqlConn.Close();
        }

        //MusteriBilgisi Cekme
        void MusteriBilgisiCekme()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT MUSTERI_ADI, IL, ILCE FROM TBL_MUSTERI_KAYITLARI WHERE MUSTERI_KODU = '" + txtMusteriKodu.Text + "'", SqlConn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                txtMusteriAdi.Text = dr1[0].ToString();
                txtIl.Text = dr1[1].ToString();
                txtIlce.Text = dr1[2].ToString();
            }
            SqlConn.Close();
        }

        string x3 = "0";
        void StokKontrol()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_STOK_KAYITLARI WHERE STOK_KODU='"+ txtStokKodu.Text +"'", SqlConn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x3 = dr1[0].ToString();
            }
            SqlConn.Close();
        }

        void StokBilgisiCekme()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT STOK_ADI, FIYAT, KDV_ORANI FROM TBL_STOK_KAYITLARI WHERE STOK_KODU='"+ txtStokKodu.Text +"'", SqlConn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                txtStokAdi.Text = dr1[0].ToString();
                txtFiyat.Text = dr1[1].ToString();
                txtKdv.Text = dr1[2].ToString();
            }
            SqlConn.Close();
        }

        void GenelToplam()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT SUM((MIKTAR*FIYAT)*((KDV/100)+1)) FROM TBL_SIPARIS_KALEMLERI WHERE SIPARIS_NO='"+ txtSiparisNumarasi.Text +"' GROUP BY SIPARIS_NO", SqlConn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                txtToplamTutar.Text = dr1[0].ToString();
            }
            SqlConn.Close();
        }

        string x4 = "0";
        void SiparisKalemSayma()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_SIPARIS_KALEMLERI WHERE SIPARIS_NO='"+ txtSiparisNumarasi.Text +"'", SqlConn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x4=dr1[0].ToString();
            }
            SqlConn.Close();
        }

        // Siparis icerik bilgisi (Form)
        void Temizle1()
        {
            txtStokAdi.Text = "";
            txtStokKodu.Text = "";
            txtUrunAciklama.Text = "";
            txtFiyat.Text = "";
            txtKdv.Text = "";
            txtMiktar.Text = "";
        }        
        
        //Genel bilgiler (Form)
        void Temizle2()
        {
            txtSiparisTarihi.Text = "";
            txtTeslimTarihi.Text = "";
            txtMusteriKodu.Text = "";
            txtMusteriAdi.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtToplamTutar.Text = "";
            Temizle1();
        }

        string x5 = "0";
        void SipKalemIsEmriKontrol()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT URETIM_DURUMU FROM TBL_SIPARIS_KALEMLERI WHERE SIP_KALEM_ID='"+ SipKalem +"'", SqlConn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x5 = dr1[0].ToString();
            }
            SqlConn.Close();
        }

        string x6 = "0";
        void SipGenelIsEmriKontrol()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(URETIM_DURUMU) FROM TBL_SIPARIS_KALEMLERI WHERE SIPARIS_NO='"+ txtSiparisNumarasi.Text +"' AND (URETIM_DURUMU='A' OR URETIM_DURUMU='B' OR URETIM_DURUMU='S')", SqlConn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x6 = dr1[0].ToString();
            }
            SqlConn.Close();
        }

        string sn1 = "";
        void SiparisNumarasiHesaplama()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT TOP 1 CONCAT('S', REPLICATE('0',10-(LEN(SUBSTRING(SIPARIS_NO,2,9)+1)+1)),SUBSTRING(SIPARIS_NO,2,9)+1) AS 'SIPARIS NUMARASI' FROM TBL_SIPARISLER ORDER BY SIPARIS_NO DESC", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                sn1 = dr[0].ToString();
            }
            SqlConn.Close();
        }

        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            // siparis listesi konumu icin tanimlama.
            FormSiparisListesi.SiparisNo = "SiparisKayit";
            FormSiparisListesi frm = new FormSiparisListesi();
            frm.Show();
        }

        private void FormSiparisler_Load(object sender, EventArgs e)
        {
            //tablodaki degisiklige izin vermez.
            gridView1.OptionsBehavior.Editable = false;
            //Ekran ilk acildiginda bu bolumler degistirilemez.
            txtStokAdi.Enabled = false;
            txtKdv.Enabled = false;
            txtFiyat.Enabled = false;
            txtUrunAciklama.Enabled = false;
            txtMiktar.Enabled = false;
            //en son kaydedilen siparis numarasi +1
            SiparisNumarasiHesaplama();
            txtSiparisNumarasi.Text = sn1;
        }

        private void txtSiparisNumarasi_Leave(object sender, EventArgs e)
        {
            txtMusteriAdi.Enabled = false;
            txtIl.Enabled = false;
            txtIlce.Enabled = false;
            txtStokKodu.Enabled = true;

            SiparisKontrol();
            if(Convert.ToInt16(x1)==1)
            {
                SiparisBilgisiCekme1();
                SiparisBilgisiCekme2();
                MusteriBilgisiCekme();
                txtMusteriKodu.Enabled = false; //musteri kodu degistirilemez.
            }
            else
            {
                if (txtSiparisNumarasi.Text=="")
                {
                    txtSiparisNumarasi.Focus();
                }
                else
                {
                    //Yeni Siparis
                    Temizle2(); // temizle1 de beraber calisiyor.
                    SiparisBilgisiCekme2(); // tabloyu da temizlemek icin calistirilir.
                    txtMusteriKodu.Enabled = true; // yeni kayitta musteri kodu degistirilebilir olmali.
                }
            }

        }

        private void txtMusteriKodu_Leave(object sender, EventArgs e)
        {
            MusteriKontrol();
            if(Convert.ToInt16(x2)==1)
            {
                MusteriBilgisiCekme();
            }
            else
            {
                txtMusteriKodu.Focus();
            }
        }
        
        private void txtStokKodu_Leave(object sender, EventArgs e)
        {
            StokKontrol();
            if(Convert.ToInt16(x3)==1)
            {
                StokBilgisiCekme();
                txtUrunAciklama.Enabled = true;
                txtMiktar.Enabled = true;
                txtFiyat.Enabled = true;
                txtKdv.Enabled = true;
                txtMiktar.Enabled = true;
                txtMiktar.Text = "0,00";
            }
            else
            {
                txtStokKodu.Focus();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtStokKodu.Text = x["STOK_KODU"].ToString();
            txtStokAdi.Text = x["STOK_ADI"].ToString();
            txtFiyat.Text = x["FIYAT"].ToString();
            txtMiktar.Text = x["MIKTAR"].ToString();
            txtKdv.Text = x["KDV"].ToString();
            SipKalem = x["SIP_KALEM_ID"].ToString(); // doubleClick ile SIP_KALEM_ID Hafizaya alinir.
            txtStokKodu.Enabled = false; //degisiklik yapilmasi icin stok karti bilgilerine gidilmesi gerek. Bu ekrandan degisiklik yapilamaz.
            txtMiktar.Enabled = true;
            txtKdv.Enabled = true;
            txtFiyat.Enabled = true;
            txtUrunAciklama.Enabled = true;
        }

        private void sbtnKaydet_Click(object sender, EventArgs e)
        {
            if(SipKalem=="")
            {
                //INSERT
                SqlConn.Open();
                //Yeni kayitta uretim durumu default Kapali olur.
                SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_SIPARIS_KALEMLERI (SIPARIS_NO, STOK_KODU, STOK_ADI, MIKTAR, URUN_ACIKLAMASI, FIYAT, KDV, URETIM_DURUMU) VALUES('"+ txtSiparisNumarasi.Text + "', '"+ txtStokKodu.Text +"', '"+ txtStokAdi.Text +"', '"+ txtMiktar.Text.Replace(',','.') +"', '"+ txtUrunAciklama.Text +"', '"+ txtFiyat.Text.Replace(',','.') +"', '"+ txtKdv.Text.Replace(',','.') +"', 'K')", SqlConn);
                sorgu1.ExecuteNonQuery();
                SqlConn.Close();
                Temizle1();
                SiparisBilgisiCekme2();
                GenelToplam();
            }
            else
            {
                //UPDATE
                SqlConn.Open();
                SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARIS_KALEMLERI SET MIKTAR='"+ txtMiktar.Text.Replace(',','.') +"', URUN_ACIKLAMASI='"+ txtUrunAciklama.Text +"', FIYAT='"+ txtFiyat.Text.Replace(',','.') +"', KDV='"+ txtKdv.Text.Replace(',','.') +"' WHERE SIP_KALEM_ID='"+ SipKalem +"'", SqlConn);
                sorgu1.ExecuteNonQuery();
                SqlConn.Close();
                Temizle1();
                SiparisBilgisiCekme2();
                GenelToplam();
            }

            SiparisKontrol();
            if(Convert.ToInt16(x1)==1)
            {
                //teslim tarihi-siparistarihi-geneltoplam degisir
                SqlConn.Open();
                SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARISLER SET SIPARIS_TARIHI='"+ txtSiparisTarihi.Text +"', TESLIM_TARIHI='"+ txtTeslimTarihi.Text +"', TOPLAM_TUTAR='"+ txtToplamTutar.Text.Replace(',','.') +"' WHERE SIPARIS_NO='"+ txtSiparisNumarasi.Text +"'", SqlConn);
                sorgu1.ExecuteNonQuery();
                SqlConn.Close();
            }
            else
            {
                SqlConn.Open();
                SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_SIPARISLER (SIPARIS_NO, MUSTERI_KODU, SIPARIS_TARIHI, TESLIM_TARIHI, TOPLAM_TUTAR) VALUES ('"+ txtSiparisNumarasi.Text +"','"+ txtMusteriKodu.Text +"','"+ txtSiparisTarihi.Text + "','"+ txtTeslimTarihi.Text + "','"+ txtToplamTutar.Text.Replace(',','.') +"')", SqlConn);
                sorgu1.ExecuteNonQuery();
                SqlConn.Close();
            }
        }

        private void sbtnSil_Click(object sender, EventArgs e)
        {
            SipKalemIsEmriKontrol();
            if (x5 == "K")
            {
                SqlConn.Open();
                SqlCommand sorgu1 = new SqlCommand("DELETE TBL_SIPARIS_KALEMLERI WHERE SIP_KALEM_ID='" + SipKalem + "'", SqlConn);
                sorgu1.ExecuteNonQuery();
                SqlConn.Close();
                Temizle1();
                SiparisBilgisiCekme2();
                SipKalem = ""; //silindigi icin yenisi default bos olsun.
                txtStokKodu.Enabled = true;
                //Kalem sayma islemi yapilir. Gnel toplam "0" olabilir.
                SiparisKalemSayma();
                if(Convert.ToInt16(x4)==0)
                {
                    //genel toplam sifirla - delete
                    /*
                    SqlConn.Open();
                    SqlCommand sorgu3 = new SqlCommand("DELETE TBL_SIPARISLER WHERE SIPARIS_NO='" + txtSiparisNumarasi.Text + "'", SqlConn);
                    sorgu3.ExecuteNonQuery();
                    SqlConn.Close();
                    SqlConn.Open();
                    SqlCommand sorgu4 = new SqlCommand("DELETE TBL_SIPARIS_KALEMLERI WHERE SIPARIS_NO='" + txtSiparisNumarasi.Text + "'", SqlConn);
                    sorgu4.ExecuteNonQuery();
                    SqlConn.Close();
                    Temizle2();
                    txtSiparisNumarasi.Text = "";
                    SiparisBilgisiCekme2(); 
                    */
                    txtToplamTutar.Text = "0,00";
                }
                else
                {
                    GenelToplam(); //tekrar kalem hesabi yapilir.
                }
                SqlConn.Open();
                //Toplam tutarin hesaplanmasi icin tekrardan sorgu acilir ve sql verileri alinir
                SqlCommand sorgu2 = new SqlCommand("UPDATE TBL_SIPARISLER SET SIPARIS_TARIHI = '"+ txtSiparisTarihi.Text +"', TESLIM_TARIHI = '"+ txtTeslimTarihi.Text +"', TOPLAM_TUTAR = '"+ txtToplamTutar.Text +"' WHERE SIPARIS_NO = '"+ txtSiparisNumarasi.Text +"'", SqlConn);
                sorgu2.ExecuteNonQuery();
                SqlConn.Close();
            }
            else
            {
                MessageBox.Show("Bu sipariş kalemine ait iş emri bulunmaktadır!", "İş emri kontrol", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void sbtnSiparisSil_Click(object sender, EventArgs e)
        {
            SipGenelIsEmriKontrol();
            if(Convert.ToInt16(x6)==0)
            {
                //DELETE
                SqlConn.Open();
                SqlCommand sorgu1 = new SqlCommand("DELETE TBL_SIPARISLER WHERE SIPARIS_NO='"+ txtSiparisNumarasi.Text +"'", SqlConn);
                sorgu1.ExecuteNonQuery();
                SqlConn.Close();
                SqlConn.Open();
                SqlCommand sorgu2 = new SqlCommand("DELETE TBL_SIPARIS_KALEMLERI WHERE SIPARIS_NO='" + txtSiparisNumarasi.Text + "'", SqlConn);
                sorgu2.ExecuteNonQuery();
                SqlConn.Close();
                Temizle2();
                txtSiparisNumarasi.Text = "";
                SiparisBilgisiCekme2();
            }
            else
            {
                MessageBox.Show("Bu siparise ait is emri kaydi ya da kayitlari bulunmaktadir.");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //Bu butonun sebebi ise siparis fiyat degisikligi olmadan sadece tarih degisikligi vb. olursa eger bu buton etkili olacaktir. Diger kaydet butonu fiyatlar ve kodlar ile alakalidir.
            SiparisKontrol();
            if (Convert.ToInt16(x1) == 1)
            {
                //teslim tarihi-siparistarihi-geneltoplam degisir
                SqlConn.Open();
                SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARISLER SET SIPARIS_TARIHI='" + txtSiparisTarihi.Text + "', TESLIM_TARIHI='" + txtTeslimTarihi.Text + "', TOPLAM_TUTAR='" + txtToplamTutar.Text.Replace(',', '.') + "' WHERE SIPARIS_NO='" + txtSiparisNumarasi.Text + "'", SqlConn);
                sorgu1.ExecuteNonQuery();
                SqlConn.Close();
            }
            else
            {
                SqlConn.Open();
                SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_SIPARISLER (SIPARIS_NO, MUSTERI_KODU, SIPARIS_TARIHI, TESLIM_TARIHI, TOPLAM_TUTAR) VALUES ('" + txtSiparisNumarasi.Text + "','" + txtMusteriKodu.Text + "','" + txtSiparisTarihi.Text + "','" + txtTeslimTarihi.Text + "','" + txtToplamTutar.Text.Replace(',', '.') + "')", SqlConn);
                sorgu1.ExecuteNonQuery();
                SqlConn.Close();
            }
            SiparisBilgisiCekme1();
            SiparisBilgisiCekme2();
            Temizle2();
            txtSiparisNumarasi.Text = "";
;        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //bu module nereden geldigi tanimlanir.
            FormMusteriListesi.MusteriKodu = "SiparisKayit";
            FormMusteriListesi frm = new FormMusteriListesi();
            frm.Show();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            FormStokListesi.stokKodu = "SiparisKayit";
            FormStokListesi frm = new FormStokListesi();
            frm.Show();
        }

        private void FormSiparisler_Activated(object sender, EventArgs e)
        {
            //Form nereden geliyor. Bunun ayrimi yapilir.
            if(Siparisx=="Siparis")
            {
                if (FormSiparisListesi.SiparisNo == "")
                {
                    //nothing
                }
                else
                {
                    //listede double-click ile deger, kayit ekranina atanir.
                    txtSiparisNumarasi.Text = FormSiparisListesi.SiparisNo;
                    SiparisBilgisiCekme1();
                    SiparisBilgisiCekme2();
                    MusteriBilgisiCekme();
                }
            }

            if (Siparisx == "Musteri")
            {
                if (FormMusteriListesi.MusteriKodu == "")
                {
                    //nothing
                }
                else
                {
                    txtMusteriKodu.Text = FormMusteriListesi.MusteriKodu;
                    MusteriBilgisiCekme();
                }
            }
            if (Siparisx == "Stok")
            {
                if (FormStokListesi.stokKodu == "")
                {
                    //nothing
                }
                else
                {
                    txtStokKodu.Text = FormStokListesi.stokKodu;
                    StokBilgisiCekme();
                }
            }
        }

        private void FormSiparisler_FormClosed(object sender, FormClosedEventArgs e)
        {
            //hafiza temizleme
            Siparisx = "";
            FormSiparisListesi.SiparisNo = "";
            FormMusteriListesi.MusteriKodu = "";
            FormStokListesi.stokKodu = "";
            Temizle2();
            txtSiparisNumarasi.Text = "";
        }
    }
}
