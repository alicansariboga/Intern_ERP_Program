
namespace ProjectAliCanSariboga
{
    partial class FormStokKayitlari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStokKayitlari));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.sbtnGrupKodListesi = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnStokListesi = new DevExpress.XtraEditors.SimpleButton();
            this.txtGrupAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtKdvOrani = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sbtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvOrani.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(113, 37);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokKodu.Properties.Appearance.Options.UseFont = true;
            this.txtStokKodu.Size = new System.Drawing.Size(162, 22);
            this.txtStokKodu.TabIndex = 2;
            this.txtStokKodu.Leave += new System.EventHandler(this.txtStokKodu_Leave);
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(113, 74);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokAdi.Properties.Appearance.Options.UseFont = true;
            this.txtStokAdi.Size = new System.Drawing.Size(193, 22);
            this.txtStokAdi.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Stok Adı";
            // 
            // txtGrupKodu
            // 
            this.txtGrupKodu.Location = new System.Drawing.Point(113, 111);
            this.txtGrupKodu.Name = "txtGrupKodu";
            this.txtGrupKodu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGrupKodu.Properties.Appearance.Options.UseFont = true;
            this.txtGrupKodu.Size = new System.Drawing.Size(62, 22);
            this.txtGrupKodu.TabIndex = 5;
            this.txtGrupKodu.Leave += new System.EventHandler(this.txtGrupKodu_Leave);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(24, 114);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 19);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Grup Kodu";
            // 
            // sbtnGrupKodListesi
            // 
            this.sbtnGrupKodListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnGrupKodListesi.ImageOptions.Image")));
            this.sbtnGrupKodListesi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbtnGrupKodListesi.Location = new System.Drawing.Point(181, 107);
            this.sbtnGrupKodListesi.Name = "sbtnGrupKodListesi";
            this.sbtnGrupKodListesi.Size = new System.Drawing.Size(25, 25);
            this.sbtnGrupKodListesi.TabIndex = 6;
            this.sbtnGrupKodListesi.Click += new System.EventHandler(this.sbtnGrupKodListesi_Click);
            // 
            // sbtnStokListesi
            // 
            this.sbtnStokListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnStokListesi.ImageOptions.Image")));
            this.sbtnStokListesi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbtnStokListesi.Location = new System.Drawing.Point(281, 34);
            this.sbtnStokListesi.Name = "sbtnStokListesi";
            this.sbtnStokListesi.Size = new System.Drawing.Size(25, 25);
            this.sbtnStokListesi.TabIndex = 3;
            this.sbtnStokListesi.Click += new System.EventHandler(this.sbtnStokListesi_Click);
            // 
            // txtGrupAdi
            // 
            this.txtGrupAdi.Enabled = false;
            this.txtGrupAdi.Location = new System.Drawing.Point(212, 110);
            this.txtGrupAdi.Name = "txtGrupAdi";
            this.txtGrupAdi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGrupAdi.Properties.Appearance.Options.UseFont = true;
            this.txtGrupAdi.Size = new System.Drawing.Size(94, 22);
            this.txtGrupAdi.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtGrupAdi);
            this.groupBox1.Controls.Add(this.txtStokKodu);
            this.groupBox1.Controls.Add(this.sbtnStokListesi);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.sbtnGrupKodListesi);
            this.groupBox1.Controls.Add(this.txtStokAdi);
            this.groupBox1.Controls.Add(this.txtGrupKodu);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel Bilgiler";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(26, 28);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 19);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Fiyat";
            // 
            // txtFiyat
            // 
            this.txtFiyat.EditValue = "0,00";
            this.txtFiyat.Location = new System.Drawing.Point(113, 25);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Properties.Appearance.Options.UseFont = true;
            this.txtFiyat.Size = new System.Drawing.Size(83, 22);
            this.txtFiyat.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(26, 65);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 19);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "KDV Oranı";
            // 
            // txtKdvOrani
            // 
            this.txtKdvOrani.EditValue = "0,00";
            this.txtKdvOrani.Location = new System.Drawing.Point(113, 62);
            this.txtKdvOrani.Name = "txtKdvOrani";
            this.txtKdvOrani.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKdvOrani.Properties.Appearance.Options.UseFont = true;
            this.txtKdvOrani.Size = new System.Drawing.Size(83, 22);
            this.txtKdvOrani.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFiyat);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.txtKdvOrani);
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiyat Bilgisi";
            // 
            // sbtnKaydet
            // 
            this.sbtnKaydet.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnKaydet.Appearance.Options.UseFont = true;
            this.sbtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnKaydet.ImageOptions.Image")));
            this.sbtnKaydet.Location = new System.Drawing.Point(236, 230);
            this.sbtnKaydet.Name = "sbtnKaydet";
            this.sbtnKaydet.Size = new System.Drawing.Size(96, 25);
            this.sbtnKaydet.TabIndex = 11;
            this.sbtnKaydet.Text = "Kaydet";
            this.sbtnKaydet.Click += new System.EventHandler(this.sbnKaydet_Click);
            // 
            // sbtnSil
            // 
            this.sbtnSil.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnSil.Appearance.Options.UseFont = true;
            this.sbtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnSil.ImageOptions.Image")));
            this.sbtnSil.Location = new System.Drawing.Point(236, 265);
            this.sbtnSil.Name = "sbtnSil";
            this.sbtnSil.Size = new System.Drawing.Size(96, 25);
            this.sbtnSil.TabIndex = 12;
            this.sbtnSil.Text = "Sil";
            this.sbtnSil.Click += new System.EventHandler(this.sbtnSil_Click);
            // 
            // sbtnTemizle
            // 
            this.sbtnTemizle.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnTemizle.Appearance.Options.UseFont = true;
            this.sbtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnTemizle.ImageOptions.Image")));
            this.sbtnTemizle.Location = new System.Drawing.Point(236, 199);
            this.sbtnTemizle.Name = "sbtnTemizle";
            this.sbtnTemizle.Size = new System.Drawing.Size(96, 25);
            this.sbtnTemizle.TabIndex = 13;
            this.sbtnTemizle.Text = "Temizle";
            this.sbtnTemizle.Click += new System.EventHandler(this.sbtnTemizle_Click);
            // 
            // FormStokKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 307);
            this.Controls.Add(this.sbtnTemizle);
            this.Controls.Add(this.sbtnSil);
            this.Controls.Add(this.sbtnKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormStokKayitlari";
            this.Text = "Stok Kartı Kayıtları";
            this.Activated += new System.EventHandler(this.FormStokKayitlari_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStokKayitlari_FormClosed);
            this.Load += new System.EventHandler(this.FormStokKayitlari_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormStokKayitlari_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvOrani.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtGrupKodu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton sbtnGrupKodListesi;
        private DevExpress.XtraEditors.SimpleButton sbtnStokListesi;
        private DevExpress.XtraEditors.TextEdit txtGrupAdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtKdvOrani;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton sbtnKaydet;
        private DevExpress.XtraEditors.SimpleButton sbtnSil;
        private DevExpress.XtraEditors.SimpleButton sbtnTemizle;
    }
}