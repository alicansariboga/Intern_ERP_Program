using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAliCanSariboga
{
    public partial class FormMainPage : Form
    {
        public FormMainPage()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormStokKayitlari frm = new FormStokKayitlari();
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormMusteriKayitlari frm = new FormMusteriKayitlari();
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSiparisler frm = new FormSiparisler();
            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormStokHareketleri frm = new FormStokHareketleri();
            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormIsEmriGirisi frm = new FormIsEmriGirisi();
            frm.Show();
        }

        private void Üe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormUretimSonuKayitlari frm = new FormUretimSonuKayitlari();
            frm.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSiparisSevki frm = new FormSiparisSevki();
            frm.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormGenelRapor frm = new FormGenelRapor();
            //ana ekranda alt kismin gosterilmesi islemi
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormRaporEkrani frm = new FormRaporEkrani();
            //ana ekranda alt kismin gosterilmesi islemi
            frm.MdiParent = this;
            frm.Show();
        }

        private void FormMainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
