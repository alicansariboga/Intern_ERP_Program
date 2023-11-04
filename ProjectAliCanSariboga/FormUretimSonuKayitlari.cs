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
    public partial class FormUretimSonuKayitlari : Form
    {
        public static string uretimsx;
        SqlConnection SqlConn = new SqlConnection("Data Source=DESKTOP-4M0OQRD\\SQLEXPRESS;Initial Catalog=UretimProgramiNew;Integrated Security=True");

        public FormUretimSonuKayitlari()
        {
            InitializeComponent();
        }

        string x1 = "0";
        void UretimSonuKaydiKontrol()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_URETIM_SONU_KAYITLARI WHERE URETIM_SONU_KAYDI_NUMARASI='" + txtUretimSonuKaydiNo.Text + "'", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x1 = dr[0].ToString();
            }
            SqlConn.Close();
        }

        void UretimSonuKaydiBilgisiCekme()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT IS_EMRI_NUMARASI FROM TBL_URETIM_SONU_KAYITLARI WHERE URETIM_SONU_KAYDI_NUMARASI='" + txtUretimSonuKaydiNo.Text + "'", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtIsEmriNo.Text = dr[0].ToString();
            }
            SqlConn.Close();
            //girilen kayit degistirilemez.
            txtIsEmriNo.Enabled = false;
            sbtnIsEmriListesi.Enabled = false;
        }

        string x2 = "0";
        void IsEmriKontrol()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_IS_EMIRLERI WHERE IS_EMRI_NUMARASI='" + txtIsEmriNo.Text + "'", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x2 = dr[0].ToString();
            }
            SqlConn.Close();
        }

        void IsEmriBilgisiCekme()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT IE.SIPARIS_NO,IE.STOK_KODU,IE.STOK_ADI,IE.SIP_KALEM_ID,IE.MIKTAR,SIP.MUSTERI_KODU,MK.MUSTERI_ADI FROM TBL_IS_EMIRLERI IE LEFT JOIN TBL_SIPARISLER SIP ON IE.SIPARIS_NO = SIP.SIPARIS_NO LEFT JOIN TBL_MUSTERI_KAYITLARI MK ON SIP.MUSTERI_KODU = MK.MUSTERI_KODU WHERE IE.IS_EMRI_NUMARASI='"+ txtIsEmriNo.Text +"'", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtSiparisNo.Text = dr[0].ToString();
                txtStokKodu.Text = dr[1].ToString();
                txtStokAdi.Text = dr[2].ToString();
                txtSipkalemID.Text = dr[3].ToString();
                txtMiktar.Text = dr[4].ToString();
                txtMusteriKodu.Text = dr[5].ToString();
                txtMusteriAdi.Text = dr[6].ToString();
            }
            SqlConn.Close();
        }

        //uretime Acma
        void StokUretimeAlma()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARIS_KALEMLERI SET URETIM_DURUMU='A' WHERE SIP_KALEM_ID='"+ txtSipkalemID.Text +"'", SqlConn);
            sorgu1.ExecuteNonQuery();
        }
        //Uretimi Bítirme - Sevke hazirlama
        void StokSevkeHazirlama()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARIS_KALEMLERI SET URETIM_DURUMU='B' WHERE SIP_KALEM_ID='" + txtSipkalemID.Text + "'", SqlConn);
            sorgu1.ExecuteNonQuery();
            SqlConn.Close();
        }
        //Is emri Yeni
        void IsEmriniAcma()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_IS_EMIRLERI SET DURUM='Y' WHERE IS_EMRI_NUMARASI='" + txtIsEmriNo.Text + "'", SqlConn);
            sorgu1.ExecuteNonQuery();
            SqlConn.Close();
        }
        //Is emri Eski
        void IsEmriniKapatma()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_IS_EMIRLERI SET DURUM='E' WHERE IS_EMRI_NUMARASI='" + txtIsEmriNo.Text + "'", SqlConn);
            sorgu1.ExecuteNonQuery();
            SqlConn.Close();
        }

        void Temizle()
        {
            txtIsEmriNo.Text = "";
            txtSipkalemID.Text = "";
            txtMiktar.Text = "";
            txtMusteriAdi.Text = "";
            txtMusteriKodu.Text = "";
            txtSiparisNo.Text = "";
            txtStokAdi.Text = "";
            txtStokKodu.Text = "";
            txtIsEmriNo.Enabled = true;
            sbtnIsEmriListesi.Enabled = true;
        }

        //stok hareket kaydi -- stok hareketleri ile ilgili
        void StokHareketKaydiGirisi()
        {
            SqlConn.Open();
            //C_MIKTAR = cikis miktari baslangic hep 0 dir ve aciklama sabit olarak uretimdir.
            SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_STOK_HAREKETLERI VALUES ('" + txtUretimSonuKaydiNo.Text + "','" + txtIsEmriNo.Text + "','" + txtStokKodu.Text + "','" + txtStokAdi.Text + "','" + txtMiktar.Text.Replace(',', '.') + "','0','" + txtMusteriAdi.Text + "','URETIM') ", SqlConn);
            sorgu1.ExecuteNonQuery();
            SqlConn.Close();
        }
        //stok hareket kaydi silme -- stok hareketleri ile ilgili
        void StokHareketKaydiSilme()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("DELETE TBL_STOK_HAREKETLERI WHERE URETIM_SONU_KAYDI_NUMARASI='" + txtUretimSonuKaydiNo.Text + "' ", SqlConn);
            sorgu1.ExecuteNonQuery();
            SqlConn.Close();
        }

        string sn1 = "";
        void UretimSonuNumarasiHesaplama()
        {
            SqlConn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT TOP 1 CONCAT('U', REPLICATE('0',10-(LEN(SUBSTRING(URETIM_SONU_KAYDI_NUMARASI,2,9)+1)+1)),SUBSTRING(URETIM_SONU_KAYDI_NUMARASI,2,9)+1) AS 'URETIM SONU KAYDI NUMARASI' FROM TBL_URETIM_SONU_KAYITLARI ORDER BY URETIM_SONU_KAYDI_NUMARASI DESC", SqlConn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                sn1 = dr[0].ToString();
            }
            SqlConn.Close();
        }

        private void FormUretimSonuKayitlari_Load(object sender, EventArgs e)
        {
            //En son kaydedilen numara +1
            UretimSonuNumarasiHesaplama();
            txtUretimSonuKaydiNo.Text = sn1;
        }

        private void txtIsEmriNo_Leave(object sender, EventArgs e)
        {
            if (txtIsEmriNo.Text == "")
            {
                txtIsEmriNo.Focus();
            }
            else
            {
                IsEmriKontrol();
                if (Convert.ToInt16(x2) == 1)
                {
                    IsEmriBilgisiCekme();
                }
                else
                {
                    MessageBox.Show("Bu sipariş numarasına ait üretim sonu kaydı bulunmamaktadır!", "Üretim sonu kaydı kontrol", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtIsEmriNo.Focus();
                }
            }
        }

        private void txtUretimSonuKaydiNo_Leave(object sender, EventArgs e)
        {
            if (txtUretimSonuKaydiNo.Text == "")
            {
                txtUretimSonuKaydiNo.Focus();
            }
            else
            {
                UretimSonuKaydiKontrol();
                if (Convert.ToInt16(x1) == 1)
                {
                    UretimSonuKaydiBilgisiCekme();
                    IsEmriBilgisiCekme();
                }
                else
                {
                    Temizle();
                    txtIsEmriNo.Enabled = true;
                    sbtnIsEmriListesi.Enabled = true;
                }
            }
        }

        private void sbtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUretimSonuKaydiNo.Text == "" || txtIsEmriNo.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Olan Alanları Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Temizle();
            }
            else
            {
                UretimSonuKaydiKontrol();
                if (Convert.ToInt16(x1) == 1)
                {
                    MessageBox.Show("Mevcut üretim sonu kaydı bulunmamaktadır!", "Üretim sonu kaydı kontrol", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    //INSERT
                    StokSevkeHazirlama();
                    IsEmriniKapatma();
                    StokHareketKaydiGirisi();
                    SqlConn.Open();
                    SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_URETIM_SONU_KAYITLARI (URETIM_SONU_KAYDI_NUMARASI, IS_EMRI_NUMARASI, STOK_KODU, STOK_ADI, MIKTAR, SIPARIS_NUMARASI, SIP_KALEM_ID, MUSTERI_KODU, MUSTERI_ADI) VALUES('"+ txtUretimSonuKaydiNo.Text +"','"+ txtIsEmriNo.Text +"','"+ txtStokKodu.Text +"','"+ txtStokAdi.Text +"','"+ txtMiktar.Text.Replace(',','.') +"','"+ txtSiparisNo.Text +"','"+ txtSipkalemID.Text +"','"+ txtMusteriKodu.Text +"','"+ txtMusteriAdi.Text +"')", SqlConn);
                    sorgu1.ExecuteNonQuery();
                    SqlConn.Close();
                    Temizle();
                    txtUretimSonuKaydiNo.Text = "";
                }
            }
        }

        private void sbtnSil_Click(object sender, EventArgs e)
        {
            if (txtUretimSonuKaydiNo.Text == "" || txtIsEmriNo.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Olan Alanları Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Temizle();
            }
            else
            {
                //DELETE
                UretimSonuKaydiKontrol();
                if (Convert.ToInt16(x1) == 1)
                {
                    StokUretimeAlma();
                    IsEmriniAcma();
                    StokHareketKaydiSilme();
                    SqlConn.Open();
                    SqlCommand sorgu1 = new SqlCommand("DELETE TBL_URETIM_SONU_KAYITLARI WHERE URETIM_SONU_KAYDI_NUMARASI='" + txtUretimSonuKaydiNo.Text + "'", SqlConn);
                    sorgu1.ExecuteNonQuery();
                    SqlConn.Close();
                    Temizle();
                    txtUretimSonuKaydiNo.Text = "";
                }
                else
                {
                    MessageBox.Show("Mevcut üretim sonu kaydı bulunmamaktadır!", "Üretim sonu kaydı kontrol", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void sbtnIsEmriListesi_Click(object sender, EventArgs e)
        {
            FormIsEmriListesi.IsEmriNo = "UretimSonuKayit";
            FormIsEmriListesi frm = new FormIsEmriListesi();
            frm.Show();
        }

        private void FormUretimSonuKayitlari_Activated(object sender, EventArgs e)
        {
            if (uretimsx == "IsEmri")
            {
                txtIsEmriNo.Text = FormIsEmriListesi.IsEmriNo;
                IsEmriBilgisiCekme();
                uretimsx = "";
            }
            if(uretimsx == "UretimSonu")
            {
                txtIsEmriNo.Text = FormUretimSonuKaydiListeleri.UretimSonuKayitNo;
                UretimSonuKaydiBilgisiCekme();
                IsEmriBilgisiCekme();
                uretimsx = "";
            }
        }

        private void FormUretimSonuKayitlari_FormClosed(object sender, FormClosedEventArgs e)
        {
            uretimsx = "";
        }

        private void sbtnUretimSonuKaydiListe_Click(object sender, EventArgs e)
        {
            FormUretimSonuKaydiListeleri.UretimSonuKayitNo = "UretimSonuKayit";
            FormUretimSonuKaydiListeleri frm = new FormUretimSonuKaydiListeleri();
            frm.Show();
        }
    }
}
