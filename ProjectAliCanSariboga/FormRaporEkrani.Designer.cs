
namespace ProjectAliCanSariboga
{
    partial class FormRaporEkrani
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRaporEkrani));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIS_EMRI_NUMARASI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOK_KODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOK_ADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_EMRI_ACIKLAMASI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISEMRITARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTESLIMTARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIPARIS_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMIKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIP_KALEM_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1904, 831);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_UretimProgramiNew_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIS_EMRI_NUMARASI,
            this.colSTOK_KODU,
            this.colSTOK_ADI,
            this.colIS_EMRI_ACIKLAMASI,
            this.colISEMRITARIHI,
            this.colTESLIMTARIHI,
            this.colSIPARIS_NO,
            this.colMIKTAR,
            this.colSIP_KALEM_ID,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIS_EMRI_NUMARASI
            // 
            this.colIS_EMRI_NUMARASI.FieldName = "IS_EMRI_NUMARASI";
            this.colIS_EMRI_NUMARASI.Name = "colIS_EMRI_NUMARASI";
            this.colIS_EMRI_NUMARASI.Visible = true;
            this.colIS_EMRI_NUMARASI.VisibleIndex = 1;
            this.colIS_EMRI_NUMARASI.Width = 187;
            // 
            // colSTOK_KODU
            // 
            this.colSTOK_KODU.FieldName = "STOK_KODU";
            this.colSTOK_KODU.Name = "colSTOK_KODU";
            this.colSTOK_KODU.Visible = true;
            this.colSTOK_KODU.VisibleIndex = 2;
            this.colSTOK_KODU.Width = 187;
            // 
            // colSTOK_ADI
            // 
            this.colSTOK_ADI.FieldName = "STOK_ADI";
            this.colSTOK_ADI.Name = "colSTOK_ADI";
            this.colSTOK_ADI.Visible = true;
            this.colSTOK_ADI.VisibleIndex = 3;
            this.colSTOK_ADI.Width = 187;
            // 
            // colIS_EMRI_ACIKLAMASI
            // 
            this.colIS_EMRI_ACIKLAMASI.FieldName = "IS_EMRI_ACIKLAMASI";
            this.colIS_EMRI_ACIKLAMASI.Name = "colIS_EMRI_ACIKLAMASI";
            this.colIS_EMRI_ACIKLAMASI.Visible = true;
            this.colIS_EMRI_ACIKLAMASI.VisibleIndex = 4;
            this.colIS_EMRI_ACIKLAMASI.Width = 187;
            // 
            // colISEMRITARIHI
            // 
            this.colISEMRITARIHI.FieldName = "IS EMRI TARIHI";
            this.colISEMRITARIHI.Name = "colISEMRITARIHI";
            this.colISEMRITARIHI.Visible = true;
            this.colISEMRITARIHI.VisibleIndex = 5;
            this.colISEMRITARIHI.Width = 187;
            // 
            // colTESLIMTARIHI
            // 
            this.colTESLIMTARIHI.FieldName = "TESLIM TARIHI";
            this.colTESLIMTARIHI.Name = "colTESLIMTARIHI";
            this.colTESLIMTARIHI.Visible = true;
            this.colTESLIMTARIHI.VisibleIndex = 6;
            this.colTESLIMTARIHI.Width = 187;
            // 
            // colSIPARIS_NO
            // 
            this.colSIPARIS_NO.FieldName = "SIPARIS_NO";
            this.colSIPARIS_NO.Name = "colSIPARIS_NO";
            this.colSIPARIS_NO.Visible = true;
            this.colSIPARIS_NO.VisibleIndex = 7;
            this.colSIPARIS_NO.Width = 187;
            // 
            // colMIKTAR
            // 
            this.colMIKTAR.FieldName = "MIKTAR";
            this.colMIKTAR.Name = "colMIKTAR";
            this.colMIKTAR.Visible = true;
            this.colMIKTAR.VisibleIndex = 8;
            this.colMIKTAR.Width = 187;
            // 
            // colSIP_KALEM_ID
            // 
            this.colSIP_KALEM_ID.FieldName = "SIP_KALEM_ID";
            this.colSIP_KALEM_ID.Name = "colSIP_KALEM_ID";
            this.colSIP_KALEM_ID.Visible = true;
            this.colSIP_KALEM_ID.VisibleIndex = 9;
            this.colSIP_KALEM_ID.Width = 213;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Uretim";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 177;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Location = DevExpress.XtraEditors.ImageLocation.Default;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Uretimi Yap", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.ContextImageOptions.Image")));
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // FormRaporEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 831);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormRaporEkrani";
            this.Text = "URETIM PROGRAMI";
            this.Load += new System.EventHandler(this.FormRaporEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_EMRI_NUMARASI;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOK_KODU;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOK_ADI;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_EMRI_ACIKLAMASI;
        private DevExpress.XtraGrid.Columns.GridColumn colISEMRITARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTESLIMTARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSIPARIS_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colMIKTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colSIP_KALEM_ID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}