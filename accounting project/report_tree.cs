using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace accounting_project
{
    public partial class report_tree : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public report_tree()
        {
            InitializeComponent();
        }

        private void report_tree_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet2.tree_m' table. You can move, or remove it, as needed.
            this.tree_mTableAdapter.Fill(this.accountingDataSet2.tree_m);
            // TODO: This line of code loads data into the 'accountingDataSet1.tree_e' table. You can move, or remove it, as needed.
            this.tree_eTableAdapter.Fill(this.accountingDataSet1.tree_e);
            // TODO: This line of code loads data into the 'accountingDataSet3.tree_r' table. You can move, or remove it, as needed.
            this.tree_rTableAdapter.Fill(this.accountingDataSet3.tree_r);
            // TODO: This line of code loads data into the 'accountingDataSet.tree_s' table. You can move, or remove it, as needed.
            this.tree_sTableAdapter.Fill(this.accountingDataSet.tree_s);

            this.reportViewer_s.RefreshReport();
            this.reportViewer_e.RefreshReport();
            this.reportViewer_r.RefreshReport();
            this.reportViewer_m.RefreshReport();
        }
    }
}