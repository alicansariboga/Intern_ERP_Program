
namespace ProjectAliCanSariboga
{
    partial class FormSiparisSevki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSiparisSevki));
            this.sbtnMusteriSiparişRaporu = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gControlSiparis = new DevExpress.XtraGrid.GridControl();
            this.gViewSiparis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gControlUrunler = new DevExpress.XtraGrid.GridControl();
            this.gViewUrunler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sbtnSiparisSevkEt = new DevExpress.XtraEditors.SimpleButton();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gControlSiparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewSiparis)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gControlUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // sbtnMusteriSiparişRaporu
            // 
            this.sbtnMusteriSiparişRaporu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnMusteriSiparişRaporu.ImageOptions.Image")));
            this.sbtnMusteriSiparişRaporu.Location = new System.Drawing.Point(377, 21);
            this.sbtnMusteriSiparişRaporu.Name = "sbtnMusteriSiparişRaporu";
            this.sbtnMusteriSiparişRaporu.Size = new System.Drawing.Size(187, 45);
            this.sbtnMusteriSiparişRaporu.TabIndex = 1;
            this.sbtnMusteriSiparişRaporu.Text = "Müşteri Sipariş Raporu";
            this.sbtnMusteriSiparişRaporu.Click += new System.EventHandler(this.sbtnMusteriSiparişRaporu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gControlSiparis);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sevke Hazır Sipariş Listesi";
            // 
            // gControlSiparis
            // 
            this.gControlSiparis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gControlSiparis.Location = new System.Drawing.Point(3, 22);
            this.gControlSiparis.MainView = this.gViewSiparis;
            this.gControlSiparis.Name = "gControlSiparis";
            this.gControlSiparis.Size = new System.Drawing.Size(546, 154);
            this.gControlSiparis.TabIndex = 0;
            this.gControlSiparis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewSiparis});
            // 
            // gViewSiparis
            // 
            this.gViewSiparis.GridControl = this.gControlSiparis;
            this.gViewSiparis.Name = "gViewSiparis";
            this.gViewSiparis.OptionsView.ShowGroupPanel = false;
            this.gViewSiparis.Click += new System.EventHandler(this.gViewSiparis_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gControlUrunler);
            this.groupBox2.Location = new System.Drawing.Point(15, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 225);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seçili Siparişin İçeriği";
            // 
            // gControlUrunler
            // 
            this.gControlUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gControlUrunler.Location = new System.Drawing.Point(3, 22);
            this.gControlUrunler.MainView = this.gViewUrunler;
            this.gControlUrunler.Name = "gControlUrunler";
            this.gControlUrunler.Size = new System.Drawing.Size(543, 200);
            this.gControlUrunler.TabIndex = 0;
            this.gControlUrunler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewUrunler});
            // 
            // gViewUrunler
            // 
            this.gViewUrunler.GridControl = this.gControlUrunler;
            this.gViewUrunler.Name = "gViewUrunler";
            this.gViewUrunler.OptionsView.ShowGroupPanel = false;
            // 
            // sbtnSiparisSevkEt
            // 
            this.sbtnSiparisSevkEt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.sbtnSiparisSevkEt.Location = new System.Drawing.Point(377, 516);
            this.sbtnSiparisSevkEt.Name = "sbtnSiparisSevkEt";
            this.sbtnSiparisSevkEt.Size = new System.Drawing.Size(187, 45);
            this.sbtnSiparisSevkEt.TabIndex = 4;
            this.sbtnSiparisSevkEt.Text = "Siparişi Sevk Et";
            this.sbtnSiparisSevkEt.Click += new System.EventHandler(this.sbtnSiparisSevkEt_Click);
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(18, 21);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(281, 20);
            this.searchLookUpEdit1.TabIndex = 5;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // FormSiparisSevki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 658);
            this.Controls.Add(this.searchLookUpEdit1);
            this.Controls.Add(this.sbtnSiparisSevkEt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sbtnMusteriSiparişRaporu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSiparisSevki";
            this.Text = "Sipariş Sevki";
            this.Load += new System.EventHandler(this.FormSiparisSevki_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gControlSiparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewSiparis)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gControlUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton sbtnMusteriSiparişRaporu;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gControlSiparis;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewSiparis;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gControlUrunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewUrunler;
        private DevExpress.XtraEditors.SimpleButton sbtnSiparisSevkEt;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    }
}