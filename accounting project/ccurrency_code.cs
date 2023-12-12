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
    public partial class ccurrency_code : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ccurrency_code()
        {
            InitializeComponent();
        }
        Boolean record = false;

        #region cleartxt
        public void cleartxt()
        {
            txt_code.Text = "";
            txt_curr.Text = "";
            txt_currara.Text = "";
            txt_curreng.Text = "";
            txt_date.Text = "";
            txt_rate.Text = "";
            txt_search.Text = "";

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
            if (txt_curr.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_curr.Select();
                return;
            }
            if (txt_currara.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_currara.Select();
                return;
            }
            if (txt_curreng.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_curreng.Select();
                return;
            }
            if (txt_date.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_date.Select();
                return;
            }
            if (txt_rate.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_rate.Select();
                return;
            }
            retriving_sql.savemethod("insert into money_code (curr_id,date,curr_name_ara,curr_name_eng,cost_rate,curr_name_ext) values ('" + txt_code.Text + "','" + txt_date.Text + "','" + txt_currara.Text + "','" + txt_curreng.Text + "','" + txt_rate.Text + "','" + txt_curr.Text + "')");
            cleartxt();
            btn_save.Enabled = false;
            btn_new.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            retriving_sql.updatemethod("update money_code set curr_name_ara='" + txt_currara.Text + "',curr_name_eng='" + txt_curreng.Text + "',cost_rate='" + txt_rate.Text + "',curr_name_ext='" + txt_curr.Text + "' where curr_id='" + txt_search.Text + "'");
            cleartxt();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            retriving_sql.deletemethod("delete from money_code where curr_id='" + txt_search.Text + "'");
            cleartxt();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            string sqlstatement;
            sqlstatement = "select * from money_code where curr_id='" + txt_search.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sqlstatement);
            cmd.Connection = con;
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                txt_code.Text = reader[1].ToString();
                txt_curr.Text = reader[6].ToString();
                txt_currara.Text = reader[3].ToString();
                txt_curreng.Text = reader[4].ToString();
                txt_date.Text = reader[2].ToString();
                txt_rate.Text = reader[5].ToString();
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