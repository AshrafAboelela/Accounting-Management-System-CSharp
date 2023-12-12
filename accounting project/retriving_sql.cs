using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace accounting_project
{
    class retriving_sql
    {
        #region save
        public static void savemethod(string savestatment)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(server_connection.connstr);
                con.Open();
                OleDbCommand cmd = new OleDbCommand(savestatment);
                cmd.Connection = con;
                int aff = cmd.ExecuteNonQuery();
                MessageBox.Show("تم حفظ عدد"+aff.ToString());
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region update
        public static void updatemethod(string updatestatment)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(server_connection.connstr);
                con.Open();
                OleDbCommand cmd = new OleDbCommand(updatestatment);
                cmd.Connection = con;
                int aff = cmd.ExecuteNonQuery();
                MessageBox.Show("تم تعديل عدد" + aff.ToString());
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region delete
        public static void deletemethod(string deletestatment)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(server_connection.connstr);
                con.Open();
                OleDbCommand cmd = new OleDbCommand(deletestatment);
                cmd.Connection = con;
                int aff = cmd.ExecuteNonQuery();
                MessageBox.Show("تم حذف عدد" + aff.ToString());
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

    }
}
