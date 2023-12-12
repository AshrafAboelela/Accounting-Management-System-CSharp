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
    public partial class banks_type : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public banks_type()
        {
            InitializeComponent();
        }

        Boolean record = false;
        #region cleartxt
        public void cleartxt()
        {
            txt_code.Text = "";
            txt_nameara.Text = "";
            txt_nameeng.Text = "";
            add_ara.Text = "";
            add_eng.Text = "";
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
            if (add_ara.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                add_ara.Select();
                return;
            }
            if (add_eng.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                add_eng.Select();
                return;
            }
            retriving_sql.savemethod("insert into bank_types (bank_id,bank_name_ara,bank_name_eng,bank_add_ara,bank_add_eng) values ('" + txt_code.Text + "','" + txt_nameara.Text + "','" + txt_nameeng.Text + "','" + add_ara.Text + "','" + add_eng.Text + "')");
            cleartxt();
            btn_save.Enabled = false;
            btn_new.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            retriving_sql.updatemethod("update bank_types set bank_name_ara='" + txt_nameara.Text + "',bank_name_eng='" + txt_nameeng.Text + "',bank_add_ara='" + add_ara.Text + "',bank_add_eng='" + add_eng.Text + "' where bank_id='" + txt_search.Text + "'");
            cleartxt();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            string sqlstatement;
            sqlstatement = "select * from bank_types where bank_id='" + txt_search.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sqlstatement);
            cmd.Connection = con;
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                txt_code.Text = reader[1].ToString();
                txt_nameara.Text = reader[2].ToString();
                txt_nameeng.Text = reader[3].ToString();
                add_ara.Text = reader[4].ToString();
                add_eng.Text = reader[5].ToString();
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
            retriving_sql.deletemethod("delete from bank_types where bank_id='" + txt_search.Text + "'");
            cleartxt();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}