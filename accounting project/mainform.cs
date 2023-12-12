using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace accounting_project
{
    public partial class mainform : RibbonForm
    {
        public mainform()
        {
            InitializeComponent();
            InitSkinGallery();
            InitGrid();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        BindingList<Person> gridDataList = new BindingList<Person>();
        void InitGrid()
        {
            gridDataList.Add(new Person("John", "Smith"));
            gridDataList.Add(new Person("Gabriel", "Smith"));
            gridDataList.Add(new Person("Ashley", "Smith", "some comment"));
            gridDataList.Add(new Person("Adrian", "Smith", "some comment"));
            gridDataList.Add(new Person("Gabriella", "Smith", "some comment"));

        }

        private void navBarControl_Click(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
           try
           {
            if (txtuser.Text == "")
            {
                MessageBox.Show("برجاء ادخال اسم المستخدم الخاص بالسيرفر");
                return;
            }
            if (txtserver.Text == "")
            {
                MessageBox.Show("برجاء ادخال اسم السيرفر");
                return;
            }
            if (txtpass.Text == "")
            {
                MessageBox.Show("برجاء ادخال كلمة المرور الخاصة بالسيرفر");
                return;
            }
            if (txtdatabase.Text == "")
            {
                MessageBox.Show("برجاء ادخال اسم قاعدة البيانات");
                return;
            }

            ADODB.Connection cn = new ADODB.Connection();
            cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=optionsdatabase.accdb;Persist Security Info=False");
            ADODB.Recordset rss = new ADODB.Recordset();
            rss.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            rss.Open("server_login",cn,ADODB.CursorTypeEnum.adOpenDynamic,ADODB.LockTypeEnum.adLockOptimistic);

            rss.AddNew();
            rss.Fields["user_name"].Value = txtuser.Text;
            rss.Fields["password"].Value = txtpass.Text;
            rss.Fields["server_name"].Value = txtserver.Text;
            rss.Fields["database"].Value = txtdatabase.Text;
            rss.Update();
            server_connection.getprovider(txtserver.Text);
            txtuser.Text="";
            txtpass.Text = "";
            txtserver.Text = "";
            txtdatabase.Text = "";

            groupControl1.Visible = false;
            groupControl2.Visible = false;
            btnexit.Visible = false;
            btnok.Visible = false;

            MessageBox.Show("تم الدخول على السيرفر بنجاح");
              }

              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            btnexit.Visible = false;
            btnok.Visible = false;
            accounting_tree tree = new accounting_tree();
            tree.MdiParent = this;
            tree.Show();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            btnexit.Visible = false;
            btnok.Visible = false;
            accounting_code acc = new accounting_code();
            acc.MdiParent = this;
            acc.Show();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            btnexit.Visible = false;
            btnok.Visible = false;
            ccurrency_code curr = new ccurrency_code();
            curr.MdiParent = this;
            curr.Show();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            btnexit.Visible = false;
            btnok.Visible = false;
            banks_type bank = new banks_type();
            bank.MdiParent = this;
            bank.Show();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            btnexit.Visible = false;
            btnok.Visible = false;
            days_type day = new days_type();
            day.MdiParent = this;
            day.Show();
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            btnexit.Visible = false;
            btnok.Visible = false;
            movements mov = new movements();
            mov.MdiParent = this;
            mov.Show();
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            btnexit.Visible = false;
            btnok.Visible = false;
            deporation_value dep = new deporation_value();
            dep.MdiParent = this;
            dep.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you want to exit", "confirm message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            btnexit.Visible = false;
            btnok.Visible = false;
            report_tree acrpt = new report_tree();
            acrpt.MdiParent = this;
            acrpt.Show();
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            btnexit.Visible = false;
            btnok.Visible = false;
            report_bank bnkrpt = new report_bank();
            bnkrpt.MdiParent = this;
            bnkrpt.Show();
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            btnexit.Visible = false;
            btnok.Visible = false;
            report_tech tecrpt = new report_tech();
            tecrpt.MdiParent = this;
            tecrpt.Show();
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            btnexit.Visible = false;
            btnok.Visible = false;
            allmove_report mvallcrpt = new allmove_report();
            mvallcrpt.MdiParent = this;
            mvallcrpt.Show();
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            btnexit.Visible = false;
            btnok.Visible = false;
            movebydatereport mvdaterpt = new movebydatereport();
            mvdaterpt.MdiParent = this;
            mvdaterpt.Show();
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            btnexit.Visible = false;
            btnok.Visible = false;
            report_acc accrpt = new report_acc();
            accrpt.MdiParent = this;
            accrpt.Show();
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("do you want to exit", "confirm message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}