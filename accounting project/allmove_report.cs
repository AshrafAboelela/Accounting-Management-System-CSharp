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
    public partial class allmove_report : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public allmove_report()
        {
            InitializeComponent();
        }

        private void allmove_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet7.movements' table. You can move, or remove it, as needed.
            this.movementsTableAdapter.Fill(this.accountingDataSet7.movements);

            this.reportViewer1.RefreshReport();
        }
    }
}