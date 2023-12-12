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
using System.Data.SqlClient;
using System.Data.OleDb;

namespace accounting_project
{
    public partial class days_type : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public days_type()
        {
            InitializeComponent();
        }

        Boolean record = false;
        #region cleartxt
        public void cleartxt()
        {
            txt_code.Text = "";
            txt_dayara.Text = "";
            txt_dayeng.Text = "";
            txt_search.Text = "";
            chk.Checked = false;
        }
        #endregion

        private void btn_new_Click(object sender, EventArgs e)
        {
            cleartxt();
            record = true;
            btn_save.Enabled = true;
            btn_new.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_code.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_code.Select();
                return;
            }
            if (txt_dayara.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_dayara.Select();
                return;
            }
            if (txt_dayeng.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_dayeng.Select();
                return;
            }
            retriving_sql.savemethod("insert into days_types (day_id,day_types,eng_des,view_check) values ('" + txt_code.Text + "','" + txt_dayara.Text + "','" + txt_dayeng.Text + "','" + chk.Checked.ToString() + "')");
            cleartxt();
            btn_save.Enabled = false;
            btn_new.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            retriving_sql.updatemethod("update days_types set day_types='" + txt_dayara.Text + "',eng_des='" + txt_dayeng.Text + "',view_check='" + chk.Checked.ToString() + "' where day_id='" + txt_search.Text + "'");
            cleartxt();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            retriving_sql.deletemethod("delete from days_types where day_id='" + txt_search.Text + "'");
            cleartxt();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            string sql;
            sql = "select * from days_types where day_id='" + txt_search.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql);
            cmd.Connection = con;
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                txt_code.Text = reader[1].ToString();
                txt_dayara.Text = reader[2].ToString();
                txt_dayeng.Text = reader[3].ToString();
                chk.Checked = reader.GetBoolean(4);
            }
            else
            {
                MessageBox.Show("عفوا لا توجد اى سجلات");
                con.Close();
                return;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}