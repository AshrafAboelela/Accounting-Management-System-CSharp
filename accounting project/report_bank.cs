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
    public partial class report_bank : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public report_bank()
        {
            InitializeComponent();
        }

        private void report_bank_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet5.bank_types' table. You can move, or remove it, as needed.
            this.bank_typesTableAdapter.Fill(this.accountingDataSet5.bank_types);

            this.reportViewer1.RefreshReport();
        }
    }
}