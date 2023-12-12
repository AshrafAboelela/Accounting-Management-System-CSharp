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
    public partial class report_acc : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public report_acc()
        {
            InitializeComponent();
        }

        private void report_acc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet4.acc_codes' table. You can move, or remove it, as needed.
            this.acc_codesTableAdapter.Fill(this.accountingDataSet4.acc_codes);

            this.reportViewer1.RefreshReport();
        }
    }
}