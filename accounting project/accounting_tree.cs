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
    public partial class accounting_tree : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public accounting_tree()
        {
            InitializeComponent();
        }
        
        #region functions

        #region tree_e
        public void bind_tree_e()
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            OleDbCommand cmd_e = new OleDbCommand("select * from tree_e");
            cmd_e.Connection = con;
            OleDbDataReader reader_e = cmd_e.ExecuteReader();
            treeView1.Nodes[3].Nodes.Clear();
            while (reader_e.Read())
            {
                treeView1.Nodes[3].Nodes.Add(reader_e[1].ToString());
            }
            con.Close();
        }
        #endregion

        #region tree_m
        public void bind_tree_m()
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            OleDbCommand cmd_m = new OleDbCommand("select * from tree_m");
            cmd_m.Connection = con;
            OleDbDataReader reader_m = cmd_m.ExecuteReader();
            treeView1.Nodes[2].Nodes.Clear();
            while (reader_m.Read())
            {
                treeView1.Nodes[2].Nodes.Add(reader_m[1].ToString());
            }
            con.Close();
        }
        #endregion

        #region tree_r
        public void bind_tree_r()
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            OleDbCommand cmd_r = new OleDbCommand("select * from tree_r");
            cmd_r.Connection = con;
            OleDbDataReader reader_r = cmd_r.ExecuteReader();
            treeView1.Nodes[1].Nodes.Clear();
            while (reader_r.Read())
            {
                treeView1.Nodes[1].Nodes.Add(reader_r[1].ToString());
            }
            con.Close();
        }
        #endregion

        #region tree_s
        public void bind_tree_s()
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            OleDbCommand cmd_s = new OleDbCommand("select * from tree_s");
            cmd_s.Connection = con;
            OleDbDataReader reader_s = cmd_s.ExecuteReader();
            treeView1.Nodes[0].Nodes.Clear();
            while (reader_s.Read())
            {
                treeView1.Nodes[0].Nodes.Add(reader_s[1].ToString());
            }
            con.Close();
        }
        #endregion

        #region cmb_s
        public void bind_cmb_s()
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            OleDbCommand cmd_cs = new OleDbCommand("select * from tree_s");
            cmd_cs.Connection = con;
            OleDbDataReader reader_cs = cmd_cs.ExecuteReader();
            cmb_s.Items.Clear();
            while (reader_cs.Read())
            {
             cmb_s.Items.Add(reader_cs[1].ToString());
            }
            con.Close();
        }
        #endregion

        #region cmb_r
        public void bind_cmb_r()
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            OleDbCommand cmd_cr = new OleDbCommand("select * from tree_r");
            cmd_cr.Connection = con;
            OleDbDataReader reader_cr = cmd_cr.ExecuteReader();
            cmb_r.Items.Clear();
            while (reader_cr.Read())
            {
                cmb_r.Items.Add(reader_cr[1].ToString());
            }
            con.Close();
        }
        #endregion

        #region cmb_m
        public void bind_cmb_m()
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            OleDbCommand cmd_cm = new OleDbCommand("select * from tree_m");
            cmd_cm.Connection = con;
            OleDbDataReader reader_cm = cmd_cm.ExecuteReader();
            cmb_m.Items.Clear();
            while (reader_cm.Read())
            {
                cmb_m.Items.Add(reader_cm[1].ToString());
            }
            con.Close();
        }
        #endregion

        #region cmb_e
        public void bind_cmb_e()
        {
            OleDbConnection con = new OleDbConnection(server_connection.connstr);
            con.Open();
            OleDbCommand cmd_ce = new OleDbCommand("select * from tree_e");
            cmd_ce.Connection = con;
            OleDbDataReader reader_ce = cmd_ce.ExecuteReader();
            cmb_e.Items.Clear();
            while (reader_ce.Read())
            {
                cmb_e.Items.Add(reader_ce[1].ToString());
            }
            con.Close();
        }
        #endregion

        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_s.Text == "")
            {
                MessageBox.Show("برجاء ادخال اسم الاصل");
                return;
            }
            if (txtprice_s.Text == "")
            {
                MessageBox.Show("برجاء ادخال سعر الأصل");
                return;
            }
            retriving_sql.savemethod("insert into tree_s (name,price) values ('" + txt_s.Text + "','" + txtprice_s.Text + "')");
            txt_s.Text = "";
            txtprice_s.Text = "";
            bind_tree_s();
            bind_cmb_s();
        }

        private void accounting_tree_Load(object sender, EventArgs e)
        {
            bind_tree_e();
            bind_tree_m();
            bind_tree_r();
            bind_tree_s();
            bind_cmb_e();
            bind_cmb_m();
            bind_cmb_r();
            bind_cmb_s();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_r.Text == "")
            {
                MessageBox.Show("برجاء ادخال اسم الالتزام");
                return;
            }
            if (txtprice_r.Text == "")
            {
                MessageBox.Show("برجاء ادخال سعر الالتزام");
                return;
            }
            retriving_sql.savemethod("insert into tree_r (name,price) values ('" + txt_r.Text + "','" + txtprice_r.Text + "')");
            txt_r.Text = "";
            txtprice_r.Text = "";
            bind_tree_r();
            bind_cmb_r();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txt_m.Text == "")
            {
                MessageBox.Show("برجاء ادخال اسم المصروف");
                return;
            }
            if (txtprice_m.Text == "")
            {
                MessageBox.Show("برجاء ادخال سعر المصروف");
                return;
            }
            retriving_sql.savemethod("insert into tree_m (name,price) values ('" + txt_m.Text + "','" + txtprice_m.Text + "')");
            txt_m.Text = "";
            txtprice_m.Text = "";
            bind_tree_m();
            bind_cmb_m();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txt_e.Text == "")
            {
                MessageBox.Show("برجاء ادخال اسم الإيراد");
                return;
            }
            if (txtprice_e.Text == "")
            {
                MessageBox.Show("برجاء ادخال سعر الإيراد");
                return;
            }
            retriving_sql.savemethod("insert into tree_e (name,price) values ('" + txt_e.Text + "','" + txtprice_e.Text + "')");
            txt_e.Text = "";
            txtprice_e.Text = "";
            bind_tree_e();
            bind_cmb_e();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            retriving_sql.deletemethod("delete from tree_s where name='" + cmb_s.Text + "'");
            cmb_s.Text = "";
            bind_tree_s();
            bind_cmb_s();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             retriving_sql.deletemethod("delete from tree_r where name='" + cmb_r.Text + "'");
             cmb_r.Text = "";
             bind_tree_r();
             bind_cmb_r();
        }

        private void button5_Click(object sender, EventArgs e)
        {
             retriving_sql.deletemethod("delete from tree_m where name='" + cmb_m.Text + "'");
             cmb_m.Text = "";
             bind_tree_m();
             bind_cmb_m();
        }

        private void button7_Click(object sender, EventArgs e)
        {
             retriving_sql.deletemethod("delete from tree_e where name='" + cmb_e.Text + "'");
             cmb_e.Text = "";
             bind_tree_e();
             bind_cmb_e();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}