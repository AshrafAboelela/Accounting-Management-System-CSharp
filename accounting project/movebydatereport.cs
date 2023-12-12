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
using Microsoft.Reporting.WinForms;
using System.Data.OleDb;

namespace accounting_project
{
    public partial class movebydatereport : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public movebydatereport()
        {
            InitializeComponent();
        }

        private void movebydatereport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet7.movements' table. You can move, or remove it, as needed.
            this.movementsTableAdapter.Fill(this.accountingDataSet7.movements);
     this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDataSource rp = new ReportDataSource();
            rp.Name = "DataSet1";
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from movements where move_date='" + textBox1.Text + "'");
            cmd.Connection = con;
            OleDbDataAdapter adapt = new OleDbDataAdapter(cmd);
            DataTable t = new DataTable();
            adapt.Fill(t);
            rp.Value = t;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.Refresh();
            reportViewer1.RefreshReport();
        }
    }
}