
namespace ProjectAliCanSariboga
{
    partial class FormMusteriKayitlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusteriKayitlari));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMusteriKodu = new DevExpress.XtraEditors.TextEdit();
            this.sbtnStokListesi = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMusteriAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdres = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEposta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnSatici = new System.Windows.Forms.RadioButton();
            this.rbtnAlici = new System.Windows.Forms.RadioButton();
            this.sbtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdi.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtMusteriKodu);
            this.groupBox1.Controls.Add(this.sbtnStokListesi);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtMusteriAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel Bilgiler";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Müşteri Kodu";
            // 
            // txtMusteriKodu
            // 
            this.txtMusteriKodu.Location = new System.Drawing.Point(128, 37);
            this.txtMusteriKodu.Name = "txtMusteriKodu";
            this.txtMusteriKodu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriKodu.Properties.Appearance.Options.UseFont = true;
            this.txtMusteriKodu.Size = new System.Drawing.Size(196, 22);
            this.txtMusteriKodu.TabIndex = 2;
            this.txtMusteriKodu.Leave += new System.EventHandler(this.txtMusteriKodu_Leave);
            // 
            // sbtnStokListesi
            // 
            this.sbtnStokListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnStokListesi.ImageOptions.Image")));
            this.sbtnStokListesi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbtnStokListesi.Location = new System.Drawing.Point(332, 35);
            this.sbtnStokListesi.Name = "sbtnStokListesi";
            this.sbtnStokListesi.Size = new System.Drawing.Size(25, 25);
            this.sbtnStokListesi.TabIndex = 3;
            this.sbtnStokListesi.Click += new System.EventHandler(this.sbtnStokListesi_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Müşteri Adı";
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(128, 74);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAdi.Properties.Appearance.Options.UseFont = true;
            this.txtMusteriAdi.Size = new System.Drawing.Size(229, 22);
            this.txtMusteriAdi.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxIlce);
            this.groupBox2.Controls.Add(this.cbxIl);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.txtAdres);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 163);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lokasyon Bilgileri";
            // 
            // cbxIlce
            // 
            this.cbxIlce.Location = new System.Drawing.Point(257, 72);
            this.cbxIlce.Name = "cbxIlce";
            this.cbxIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxIlce.Size = new System.Drawing.Size(100, 20);
            this.cbxIlce.TabIndex = 7;
            // 
            // cbxIl
            // 
            this.cbxIl.Location = new System.Drawing.Point(97, 73);
            this.cbxIl.Name = "cbxIl";
            this.cbxIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxIl.Size = new System.Drawing.Size(100, 20);
            this.cbxIl.TabIndex = 6;
            this.cbxIl.Leave += new System.EventHandler(this.cbxIl_Leave);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(219, 75);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(22, 19);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "İlçe";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(24, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(97, 37);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Properties.Appearance.Options.UseFont = true;
            this.txtAdres.Size = new System.Drawing.Size(260, 22);
            this.txtAdres.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(24, 73);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(8, 19);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "İl";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEposta);
            this.groupBox3.Controls.Add(this.labelControl7);
            this.groupBox3.Controls.Add(this.txtTelefon);
            this.groupBox3.Controls.Add(this.labelControl8);
            this.groupBox3.Location = new System.Drawing.Point(12, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 115);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İletişim Bilgileri";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(97, 74);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.Properties.Appearance.Options.UseFont = true;
            this.txtEposta.Size = new System.Drawing.Size(135, 22);
            this.txtEposta.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(24, 40);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(45, 19);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(97, 38);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Properties.Appearance.Options.UseFont = true;
            this.txtTelefon.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d\\ \\d\\d\\ \\d\\d";
            this.txtTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefon.Size = new System.Drawing.Size(135, 22);
            this.txtTelefon.TabIndex = 2;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(24, 77);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 19);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "E-posta";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnSatici);
            this.groupBox4.Controls.Add(this.rbtnAlici);
            this.groupBox4.Location = new System.Drawing.Point(259, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(130, 115);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Müşteri Tipi";
            // 
            // rbtnSatici
            // 
            this.rbtnSatici.AutoSize = true;
            this.rbtnSatici.Location = new System.Drawing.Point(23, 73);
            this.rbtnSatici.Name = "rbtnSatici";
            this.rbtnSatici.Size = new System.Drawing.Size(60, 23);
            this.rbtnSatici.TabIndex = 4;
            this.rbtnSatici.TabStop = true;
            this.rbtnSatici.Text = "Satıcı";
            this.rbtnSatici.UseVisualStyleBackColor = true;
            // 
            // rbtnAlici
            // 
            this.rbtnAlici.AutoSize = true;
            this.rbtnAlici.Location = new System.Drawing.Point(23, 36);
            this.rbtnAlici.Name = "rbtnAlici";
            this.rbtnAlici.Size = new System.Drawing.Size(54, 23);
            this.rbtnAlici.TabIndex = 3;
            this.rbtnAlici.TabStop = true;
            this.rbtnAlici.Text = "Alıcı";
            this.rbtnAlici.UseVisualStyleBackColor = true;
            // 
            // sbtnKaydet
            // 
            this.sbtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnKaydet.ImageOptions.Image")));
            this.sbtnKaydet.Location = new System.Drawing.Point(231, 442);
            this.sbtnKaydet.Name = "sbtnKaydet";
            this.sbtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.sbtnKaydet.TabIndex = 6;
            this.sbtnKaydet.Text = "Kaydet";
            this.sbtnKaydet.Click += new System.EventHandler(this.sbtnKaydet_Click);
            // 
            // sbtnSil
            // 
            this.sbtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnSil.ImageOptions.Image")));
            this.sbtnSil.Location = new System.Drawing.Point(314, 442);
            this.sbtnSil.Name = "sbtnSil";
            this.sbtnSil.Size = new System.Drawing.Size(75, 23);
            this.sbtnSil.TabIndex = 7;
            this.sbtnSil.Text = "Sil";
            this.sbtnSil.Click += new System.EventHandler(this.sbtnSil_Click);
            // 
            // FormMusteriKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 475);
            this.Controls.Add(this.sbtnSil);
            this.Controls.Add(this.sbtnKaydet);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMusteriKayitlari";
            this.Text = "Müşteri Kayıtları";
            this.Activated += new System.EventHandler(this.FormMusteriKayitlari_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMusteriKayitlari_FormClosed);
            this.Load += new System.EventHandler(this.FormMusteriKayitlari_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdi.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMusteriKodu;
        private DevExpress.XtraEditors.SimpleButton sbtnStokListesi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMusteriAdi;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAdres;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.TextEdit txtEposta;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnSatici;
        private System.Windows.Forms.RadioButton rbtnAlici;
        private DevExpress.XtraEditors.ComboBoxEdit cbxIl;
        private DevExpress.XtraEditors.ComboBoxEdit cbxIlce;
        private DevExpress.XtraEditors.SimpleButton sbtnKaydet;
        private DevExpress.XtraEditors.SimpleButton sbtnSil;
    }
}