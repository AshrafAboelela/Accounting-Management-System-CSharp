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
    public partial class deporation_value : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public deporation_value()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            string sql;
            sql = "select * from movements where move_id='" + txtnum_search.Text + "' or move_date='" + txtdate_search.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql);
            cmd.Connection = con;
            OleDbDataReader reader = cmd.ExecuteReader();
            dgv.Rows.Clear();
            while (reader.Read())
            {
                dgv.Rows.Add(reader[12], reader[13], reader[10], reader[2], reader[1], reader[6]);
            }
            con.Close();
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                OleDbConnection con = new OleDbConnection(server_connection.connstr);
                con.Open();
                string sql;
                sql = "select * from movements where move_id='" + txt_search.Text + "'";
                OleDbCommand cmd = new OleDbCommand(sql);
                cmd.Connection = con;
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    txt_name1.Text = reader[12].ToString();
                    txt_name2.Text = reader[13].ToString();
                    txt_date.Text = reader[2].ToString();
                    txt_book.Text = reader[6].ToString();
                    txt_script.Text = reader[10].ToString();
                    btn_send.Enabled = true;
                }
                else
                {
                    MessageBox.Show("عفوا لا توجد اى سجلات");
                    con.Close();
                    return;
                }
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            retriving_sql.savemethod("insert into techbook (name1,name2,date,book,value,script) values ('" + txt_name1.Text + "','" + txt_name2.Text + "','" + txt_date.Text + "','" + txt_book.Text + "','" + txt_search.Text + "','" + txt_script.Text + "')");

            btn_send.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}