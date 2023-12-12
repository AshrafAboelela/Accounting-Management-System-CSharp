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
    public partial class accounting_code : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public accounting_code()
        {
            InitializeComponent();
        }
        Boolean record = false;

        #region bind
        public void bind_cmb_curr()
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            string sql;
            sql = "select * from money_code";
            OleDbCommand cmd = new OleDbCommand(sql);
            cmd.Connection = con;
            OleDbDataReader reader = cmd.ExecuteReader();
            cmb_curr.Items.Clear();
            while (reader.Read())
            {
                cmb_curr.Items.Add(reader[1].ToString());
            }
            con.Close();
        }
        #endregion

        #region cleartxt
        public void cleartxt()
        {
            txt_code.Text = "";
            txt_nameara.Text = "";
            txt_nameeng.Text = "";
            txt_date.Text = "";
            txt_rate.Text = "";
            txt_value1.Text = "";
            txt_value2.Text = "";
            txt_balance1.Text = "";
            txt_balance2.Text = "";
            cmb_centers.Text = "";
            txt_search.Text = "";
            cmb_curr.Text = "";
            cmb_final.Text = "";
            cmb_nature.Text = "";
            chk.Checked = false;
        }
        #endregion


        private void accounting_code_Load(object sender, EventArgs e)
        {
            bind_cmb_curr();
        }

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
            if (txt_nameara.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_nameara.Select();
                return;
            }
            if (txt_nameeng.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_nameeng.Select();
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
            if (txt_value1.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_value1.Select();
                return;
            }
            if (txt_value2.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_value2.Select();
                return;
            }
            if (txt_balance1.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_balance1.Select();
                return;
            }
            if (txt_balance2.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_balance2.Select();
                return;
            }

            if (cmb_centers.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                cmb_centers.Select();
                return;
            }
            if (cmb_curr.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                cmb_curr.Select();
                return;
            }
            if (cmb_final.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                cmb_final.Select();
                return;
            }
            if (cmb_nature.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                cmb_nature.Select();
                return;
            }
            retriving_sql.savemethod("insert into acc_codes (acc_code,acc_name_ara,acc_name_eng,last_acc,final_deporation,nature,date,curr_code,convert_rate,cost_center,balance1,balance2,value1,value2) values ('" + txt_code.Text + "','" + txt_nameara.Text+ "','" + txt_nameeng.Text+ "','" + chk.Checked.ToString() + "','" + cmb_final.Text + "','" + cmb_nature.Text + "','" + txt_date.Text + "','" + cmb_curr.Text + "','" + txt_rate.Text + "','" + cmb_centers.Text + "','" + txt_balance1.Text + "','" + txt_balance1.Text + "','" + txt_value1.Text + "','" + txt_value2.Text + "')");      
            cleartxt();
            btn_save.Enabled = false;
            btn_new.Enabled = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            string sqlstatement;
            sqlstatement = "select * from acc_codes where acc_code='" + txt_search.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sqlstatement);
            cmd.Connection = con;
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                txt_code.Text = reader[1].ToString();
                txt_nameara.Text = reader[2].ToString();
                txt_nameeng.Text = reader[3].ToString();
                txt_date.Text = reader[7].ToString();
                txt_rate.Text = reader[9].ToString();
                txt_value1.Text = reader[14].ToString();
                txt_value2.Text = reader[15].ToString();
                txt_balance1.Text = reader[12].ToString();
                txt_balance2.Text = reader[13].ToString();
                cmb_centers.Text = reader[10].ToString();             
                cmb_curr.Text = reader[8].ToString();
                cmb_final.Text = reader[5].ToString();
                cmb_nature.Text = reader[6].ToString();
                chk.Checked = reader.GetBoolean(4);
            }
            else
            {
                MessageBox.Show("عفوا لا توجد اى سجلات");
                con.Close();
                return;
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            retriving_sql.deletemethod("delete from acc_codes where acc_code='" + txt_search.Text + "'");
            cleartxt();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            retriving_sql.updatemethod("update acc_codes set acc_name_ara='" + txt_nameara.Text + "',acc_name_eng='" + txt_nameeng.Text + "',last_acc='" + chk.Checked.ToString() + "',final_deporation='" + cmb_final.Text + "',nature='" + cmb_nature.Text + "',date='" + txt_date.Text + "',curr_code='" + cmb_curr.Text + "',convert_rate='" + txt_rate.Text + "',cost_center='" + cmb_centers.Text + "',balance1='" + txt_balance1.Text + "',balance2='" + txt_balance2.Text + "',value1='" + txt_value1.Text + "',value2='" + txt_value2.Text + "' where acc_code='" + txt_search.Text + "'");
            cleartxt();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

