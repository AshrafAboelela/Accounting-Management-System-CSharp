namespace accounting_project
{
    partial class report_tech
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.movementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet7 = new accounting_project.accountingDataSet7();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.movementsTableAdapter = new accounting_project.accountingDataSet7TableAdapters.movementsTableAdapter();
            this.accountingDataSet6 = new accounting_project.accountingDataSet6();
            this.techbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techbookTableAdapter = new accounting_project.accountingDataSet6TableAdapters.techbookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.movementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techbookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // movementsBindingSource
            // 
            this.movementsBindingSource.DataMember = "movements";
            this.movementsBindingSource.DataSource = this.accountingDataSet7;
            // 
            // accountingDataSet7
            // 
            this.accountingDataSet7.DataSetName = "accountingDataSet7";
            this.accountingDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(773, 49);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(773, 31);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.techbookBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "accounting_project.tech.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 55);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(761, 357);
            this.reportViewer1.TabIndex = 2;
            // 
            // movementsTableAdapter
            // 
            this.movementsTableAdapter.ClearBeforeFill = true;
            // 
            // accountingDataSet6
            // 
            this.accountingDataSet6.DataSetName = "accountingDataSet6";
            this.accountingDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techbookBindingSource
            // 
            this.techbookBindingSource.DataMember = "techbook";
            this.techbookBindingSource.DataSource = this.accountingDataSet6;
            // 
            // techbookTableAdapter
            // 
            this.techbookTableAdapter.ClearBeforeFill = true;
            // 
            // report_tech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 449);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "report_tech";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "تقارير القيود التى تم ترحيلها";
            this.Load += new System.EventHandler(this.report_tech_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techbookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource movementsBindingSource;
        private accountingDataSet7 accountingDataSet7;
        private accountingDataSet7TableAdapters.movementsTableAdapter movementsTableAdapter;
        private System.Windows.Forms.BindingSource techbookBindingSource;
        private accountingDataSet6 accountingDataSet6;
        private accountingDataSet6TableAdapters.techbookTableAdapter techbookTableAdapter;
    }
}