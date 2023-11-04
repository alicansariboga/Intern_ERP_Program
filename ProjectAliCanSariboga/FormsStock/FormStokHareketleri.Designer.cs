
namespace ProjectAliCanSariboga
{
    partial class FormStokHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStokHareketleri));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sbtnStokListesi = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnUrunTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtGuncelMiktar = new DevExpress.XtraEditors.TextEdit();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGuncelMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sbtnStokListesi);
            this.groupBox3.Controls.Add(this.sbtnUrunTemizle);
            this.groupBox3.Controls.Add(this.labelControl13);
            this.groupBox3.Controls.Add(this.txtGuncelMiktar);
            this.groupBox3.Controls.Add(this.txtStokKodu);
            this.groupBox3.Controls.Add(this.labelControl10);
            this.groupBox3.Controls.Add(this.labelControl12);
            this.groupBox3.Controls.Add(this.txtGrupAdi);
            this.groupBox3.Controls.Add(this.labelControl9);
            this.groupBox3.Controls.Add(this.txtStokAdi);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1007, 145);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sipariş İçerik Bilgisi";
            // 
            // sbtnStokListesi
            // 
            this.sbtnStokListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnStokListesi.ImageOptions.Image")));
            this.sbtnStokListesi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbtnStokListesi.Location = new System.Drawing.Point(329, 53);
            this.sbtnStokListesi.Margin = new System.Windows.Forms.Padding(4);
            this.sbtnStokListesi.Name = "sbtnStokListesi";
            this.sbtnStokListesi.Size = new System.Drawing.Size(38, 37);
            this.sbtnStokListesi.TabIndex = 6;
            this.sbtnStokListesi.Click += new System.EventHandler(this.sbtnStokListesi_Click);
            // 
            // sbtnUrunTemizle
            // 
            this.sbtnUrunTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnUrunTemizle.ImageOptions.Image")));
            this.sbtnUrunTemizle.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbtnUrunTemizle.Location = new System.Drawing.Point(146, 0);
            this.sbtnUrunTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.sbtnUrunTemizle.Name = "sbtnUrunTemizle";
            this.sbtnUrunTemizle.Size = new System.Drawing.Size(34, 25);
            this.sbtnUrunTemizle.TabIndex = 13;
            this.sbtnUrunTemizle.Click += new System.EventHandler(this.sbtnUrunTemizle_Click);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(725, 108);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(123, 19);
            this.labelControl13.TabIndex = 11;
            this.labelControl13.Text = "Güncel Stok Miktarı";
            // 
            // txtGuncelMiktar
            // 
            this.txtGuncelMiktar.Enabled = false;
            this.txtGuncelMiktar.Location = new System.Drawing.Point(884, 105);
            this.txtGuncelMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuncelMiktar.Name = "txtGuncelMiktar";
            this.txtGuncelMiktar.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuncelMiktar.Properties.Appearance.Options.UseFont = true;
            this.txtGuncelMiktar.Size = new System.Drawing.Size(99, 22);
            this.txtGuncelMiktar.TabIndex = 12;
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(133, 61);
            this.txtStokKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokKodu.Properties.Appearance.Options.UseFont = true;
            this.txtStokKodu.Size = new System.Drawing.Size(188, 22);
            this.txtStokKodu.TabIndex = 2;
            this.txtStokKodu.Leave += new System.EventHandler(this.txtStokKodu_Leave);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(36, 64);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(68, 19);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Stok Kodu";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(791, 61);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(57, 19);
            this.labelControl12.TabIndex = 9;
            this.labelControl12.Text = "Grup Adı";
            // 
            // txtGrupAdi
            // 
            this.txtGrupAdi.Enabled = false;
            this.txtGrupAdi.Location = new System.Drawing.Point(884, 56);
            this.txtGrupAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrupAdi.Name = "txtGrupAdi";
            this.txtGrupAdi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGrupAdi.Properties.Appearance.Options.UseFont = true;
            this.txtGrupAdi.Size = new System.Drawing.Size(99, 22);
            this.txtGrupAdi.TabIndex = 10;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(409, 64);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(55, 19);
            this.labelControl9.TabIndex = 5;
            this.labelControl9.Text = "Stok Adı";
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Enabled = false;
            this.txtStokAdi.Location = new System.Drawing.Point(490, 61);
            this.txtStokAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokAdi.Properties.Appearance.Options.UseFont = true;
            this.txtStokAdi.Size = new System.Drawing.Size(264, 22);
            this.txtStokAdi.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gridControl1);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(13, 166);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1007, 446);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stok Hareketleri";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(4, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(999, 419);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 512;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // FormStokHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 658);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStokHareketleri";
            this.Text = "Stok Hareketleri";
            this.Activated += new System.EventHandler(this.FormStokHareketleri_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStokHareketleri_FormClosed);
            this.Load += new System.EventHandler(this.FormStokHareketleri_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGuncelMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton sbtnStokListesi;
        private DevExpress.XtraEditors.SimpleButton sbtnUrunTemizle;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtGuncelMiktar;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtGrupAdi;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}