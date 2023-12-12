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
    public partial class report_tech : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public report_tech()
        {
            InitializeComponent();
        }

        private void report_tech_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet6.techbook' table. You can move, or remove it, as needed.
            this.techbookTableAdapter.Fill(this.accountingDataSet6.techbook);
            // TODO: This line of code loads data into the 'accountingDataSet7.movements' table. You can move, or remove it, as needed.
            this.movementsTableAdapter.Fill(this.accountingDataSet7.movements);

            this.reportViewer1.RefreshReport();
        }
    }
}