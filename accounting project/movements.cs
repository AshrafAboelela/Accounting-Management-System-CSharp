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
    public partial class movements : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public movements()
        {
            InitializeComponent();
        }

        Boolean record = false;

        #region bind_days_types
        public void bind_days_types()
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            string sql;
            sql = "select * from days_types";
            OleDbCommand cmd = new OleDbCommand(sql);
            cmd.Connection = con;
            OleDbDataReader reader_days = cmd.ExecuteReader();
            cmb_days.Items.Clear();
            while (reader_days.Read())
            {
                cmb_days.Items.Add(reader_days[2].ToString());
            }
            con.Close();
        }
        #endregion

        #region bind_curr_codes
        public void bind_curr_codes()
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            string sql;
            sql = "select * from money_code";
            OleDbCommand cmd = new OleDbCommand(sql);
            cmd.Connection = con;
            OleDbDataReader reader_curr = cmd.ExecuteReader();
            cmb_curr.Items.Clear();
            while (reader_curr.Read())
            {
                cmb_curr.Items.Add(reader_curr[1].ToString());
            }
            con.Close();
        }
        #endregion

        #region bind_grid
        public void bind_grid()
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            string sql;
            sql = "select * from movements";
            OleDbCommand cmd = new OleDbCommand(sql);
            cmd.Connection = con;
            OleDbDataReader reader_move = cmd.ExecuteReader();
            dgv.Rows.Clear();
            while (reader_move.Read())
            {
                dgv.Rows.Add(reader_move[12], reader_move[13], reader_move[10], reader_move[2], reader_move[1], reader_move[6]);
            }
            con.Close();
        }
        #endregion

        #region cleartxt
        public void cleartxt()
        {
            txt_profit.Text = "";
            txt_num.Text = "";
            txt_numto.Text = "";
            txt_numfrom.Text = "";
            txt_value1.Text = "";
            txt_value2.Text = "";
            txt_valueara.Text = "";
            txt_valueeng.Text = "";
            txt_date.Text = "";
            txt_book.Text = "";
            txt_name2.Text = "";
            txt_name1.Text = "";
            txt_rate.Text = "";
            txt_search.Text = "";
            cmb_curr.Text = "";
            cmb_days.Text = "";
        }
        #endregion

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            cleartxt();
            record = true;
            btn_save.Enabled = true;
            btn_new.Enabled = false;

        }

        private void movements_Load(object sender, EventArgs e)
        {
            bind_days_types();
            bind_curr_codes();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_numfrom.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_numfrom.Select();
                return;
            }
            if (txt_num.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_num.Select();
                return;
            }
            if (txt_numto.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_numto.Select();
                return;
            }
            if (cmb_curr.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                cmb_curr.Select();
                return;
            }
            if (txt_valueara.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_valueara.Select();
                return;
            }
            if (txt_valueeng.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_valueeng.Select();
                return;
            }
            if (cmb_days.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                cmb_days.Select();
                return;
            }

            if (txt_book.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_book.Select();
                return;
            }
            if (txt_date.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_date.Select();
                return;
            }
            if (txt_name1.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_name1.Select();
                return;
            }
            if (txt_name2.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_name2.Select();
                return;
            }
            if (txt_rate.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات الضرورية");
                txt_rate.Select();
                return;
            }
            retriving_sql.savemethod("insert into movements (move_id,move_date,to_file,from_file,book_id,day_kind,curr_code,cost_rate,move_des_ara,move_des_eng,name1,name2) values ('" + txt_num.Text + "','" + txt_date.Text + "','" + txt_numto.Text + "','" + txt_numfrom.Text + "','" + txt_book.Text + "','" + cmb_days.Text + "','" + cmb_curr.Text + "','" + txt_rate.Text + "','" + txt_valueara.Text + "','" + txt_valueeng.Text + "','" + txt_name1.Text + "','" + txt_name2.Text + "')");

            cleartxt();
            bind_grid();
            btn_save.Enabled = false;
            btn_new.Enabled = true;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            bind_grid();
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            #region get total of name 1

            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            string sql;
            sql = "select sum(name1) as tottal from movements";
            OleDbCommand cmd = new OleDbCommand(sql);
            cmd.Connection = con;
            OleDbDataReader readername1 = cmd.ExecuteReader();
            readername1.Read();
            if (readername1.HasRows)
            {
                txt_value1.Text = readername1["tottal"].ToString();
            }
            con.Close();
            #endregion

            #region get total of name 2

            OleDbConnection con2 = new OleDbConnection(server_connection.connstr);
            con2.Open();
            string sql2;
            sql2 = "select sum(name2) as total from movements";
            OleDbCommand cmd2 = new OleDbCommand(sql2);
            cmd2.Connection = con2;
            OleDbDataReader readername2 = cmd2.ExecuteReader();
            readername2.Read();
            if (readername2.HasRows)
            {
                txt_value2.Text = readername2["total"].ToString();
            }
            con.Close();
            #endregion

            #region get profit of name 1 & name 2
            txt_profit.Text = (double.Parse(txt_value1.Text) - double.Parse(txt_value2.Text)).ToString();
            #endregion

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            string sqlstatement;
            sqlstatement = "select * from movements where move_id='" + txt_search.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sqlstatement);
            cmd.Connection = con;
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                txt_num.Text = reader[1].ToString();
                txt_numto.Text = reader[3].ToString();
                txt_numfrom.Text = reader[4].ToString();
                txt_valueara.Text = reader[10].ToString();
                txt_valueeng.Text = reader[11].ToString();
                txt_date.Text = reader[2].ToString();
                txt_book.Text = reader[6].ToString();
                txt_name1.Text = reader[12].ToString();
                txt_name2.Text = reader[13].ToString();
                txt_rate.Text = reader[9].ToString();
                cmb_curr.Text = reader[8].ToString();
                cmb_days.Text = reader[7].ToString();
            }
            else
            {
                MessageBox.Show("عفوا لا توجد اى سجلات");
                con.Close();
                return;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            retriving_sql.updatemethod("update movements set move_date='" + txt_date.Text + "',to_file='" + txt_numto.Text + "',from_file='" + txt_numfrom.Text + "',book_id='" + txt_book.Text + "',day_kind='" + cmb_days.Text + "',curr_code='" + cmb_curr.Text + "',cost_rate='" + txt_rate.Text + "',move_des_ara='" + txt_valueara.Text + "',move_des_eng='" + txt_valueeng.Text + "',name1='" + txt_name1.Text + "',name2='" + txt_name2.Text + "' where move_id='" + txt_search.Text + "'");
            cleartxt();
            bind_grid();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            retriving_sql.deletemethod("delete from movements where move_id='" + txt_search.Text + "'");
            cleartxt();
            bind_grid();
        }


    }
}