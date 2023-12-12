namespace accounting_project
{
    partial class report_tree
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer_s = new Microsoft.Reporting.WinForms.ReportViewer();
            this.accountingDataSet = new accounting_project.accountingDataSet();
            this.tree_sBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tree_sTableAdapter = new accounting_project.accountingDataSetTableAdapters.tree_sTableAdapter();
            this.accountingDataSet3 = new accounting_project.accountingDataSet3();
            this.tree_rBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tree_rTableAdapter = new accounting_project.accountingDataSet3TableAdapters.tree_rTableAdapter();
            this.accountingDataSet1 = new accounting_project.accountingDataSet1();
            this.tree_eBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tree_eTableAdapter = new accounting_project.accountingDataSet1TableAdapters.tree_eTableAdapter();
            this.accountingDataSet2 = new accounting_project.accountingDataSet2();
            this.tree_mBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tree_mTableAdapter = new accounting_project.accountingDataSet2TableAdapters.tree_mTableAdapter();
            this.reportViewer_e = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer_r = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer_m = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_sBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_rBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_eBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_mBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(719, 49);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 523);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(719, 31);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "تقرير عن المصروفات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "تقرير عن الإيرادات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "تقرير عن الإلتزامات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "تقرير عن الأصول";
            // 
            // reportViewer_s
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tree_sBindingSource;
            this.reportViewer_s.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer_s.LocalReport.ReportEmbeddedResource = "accounting_project.tree_s.rdlc";
            this.reportViewer_s.Location = new System.Drawing.Point(372, 76);
            this.reportViewer_s.Name = "reportViewer_s";
            this.reportViewer_s.Size = new System.Drawing.Size(341, 208);
            this.reportViewer_s.TabIndex = 22;
            // 
            // accountingDataSet
            // 
            this.accountingDataSet.DataSetName = "accountingDataSet";
            this.accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tree_sBindingSource
            // 
            this.tree_sBindingSource.DataMember = "tree_s";
            this.tree_sBindingSource.DataSource = this.accountingDataSet;
            // 
            // tree_sTableAdapter
            // 
            this.tree_sTableAdapter.ClearBeforeFill = true;
            // 
            // accountingDataSet3
            // 
            this.accountingDataSet3.DataSetName = "accountingDataSet3";
            this.accountingDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tree_rBindingSource
            // 
            this.tree_rBindingSource.DataMember = "tree_r";
            this.tree_rBindingSource.DataSource = this.accountingDataSet3;
            // 
            // tree_rTableAdapter
            // 
            this.tree_rTableAdapter.ClearBeforeFill = true;
            // 
            // accountingDataSet1
            // 
            this.accountingDataSet1.DataSetName = "accountingDataSet1";
            this.accountingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tree_eBindingSource
            // 
            this.tree_eBindingSource.DataMember = "tree_e";
            this.tree_eBindingSource.DataSource = this.accountingDataSet1;
            // 
            // tree_eTableAdapter
            // 
            this.tree_eTableAdapter.ClearBeforeFill = true;
            // 
            // accountingDataSet2
            // 
            this.accountingDataSet2.DataSetName = "accountingDataSet2";
            this.accountingDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tree_mBindingSource
            // 
            this.tree_mBindingSource.DataMember = "tree_m";
            this.tree_mBindingSource.DataSource = this.accountingDataSet2;
            // 
            // tree_mTableAdapter
            // 
            this.tree_mTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer_e
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tree_eBindingSource;
            this.reportViewer_e.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer_e.LocalReport.ReportEmbeddedResource = "accounting_project.tree_e.rdlc";
            this.reportViewer_e.Location = new System.Drawing.Point(372, 311);
            this.reportViewer_e.Name = "reportViewer_e";
            this.reportViewer_e.Size = new System.Drawing.Size(341, 206);
            this.reportViewer_e.TabIndex = 26;
            // 
            // reportViewer_r
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.tree_rBindingSource;
            this.reportViewer_r.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer_r.LocalReport.ReportEmbeddedResource = "accounting_project.tree_r.rdlc";
            this.reportViewer_r.Location = new System.Drawing.Point(12, 76);
            this.reportViewer_r.Name = "reportViewer_r";
            this.reportViewer_r.Size = new System.Drawing.Size(325, 208);
            this.reportViewer_r.TabIndex = 27;
            // 
            // reportViewer_m
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.tree_mBindingSource;
            this.reportViewer_m.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer_m.LocalReport.ReportEmbeddedResource = "accounting_project.tree_m.rdlc";
            this.reportViewer_m.Location = new System.Drawing.Point(12, 308);
            this.reportViewer_m.Name = "reportViewer_m";
            this.reportViewer_m.Size = new System.Drawing.Size(338, 209);
            this.reportViewer_m.TabIndex = 28;
            // 
            // report_tree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 554);
            this.Controls.Add(this.reportViewer_m);
            this.Controls.Add(this.reportViewer_r);
            this.Controls.Add(this.reportViewer_e);
            this.Controls.Add(this.reportViewer_s);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "report_tree";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "تقارير شجرة الحسابات";
            this.Load += new System.EventHandler(this.report_tree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_sBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_rBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_eBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_mBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_s;
        private System.Windows.Forms.BindingSource tree_sBindingSource;
        private accountingDataSet accountingDataSet;
        private accountingDataSetTableAdapters.tree_sTableAdapter tree_sTableAdapter;
        private System.Windows.Forms.BindingSource tree_rBindingSource;
        private accountingDataSet3 accountingDataSet3;
        private accountingDataSet3TableAdapters.tree_rTableAdapter tree_rTableAdapter;
        private System.Windows.Forms.BindingSource tree_eBindingSource;
        private accountingDataSet1 accountingDataSet1;
        private accountingDataSet1TableAdapters.tree_eTableAdapter tree_eTableAdapter;
        private System.Windows.Forms.BindingSource tree_mBindingSource;
        private accountingDataSet2 accountingDataSet2;
        private accountingDataSet2TableAdapters.tree_mTableAdapter tree_mTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_e;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_r;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_m;
    }
}