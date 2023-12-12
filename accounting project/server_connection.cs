using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using ADODB;

namespace accounting_project
{
    class server_connection
    {
        #region variables
        public static string user;
        public static string pass;
        public static string server;
        public static string database;
        public static string connstr;
        #endregion

        #region getconnstr
        public static void getprovider(string server_name)
        {
            try
            {
                Connection cn = new Connection();
                Recordset rs = new Recordset();
                cn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=optionsdatabase.accdb;Persist Security Info=False");

                rs.CursorLocation = CursorLocationEnum.adUseClient;
                rs.Open("select * from server_login where server_name = '"+server_name.ToString()+"'",cn,CursorTypeEnum.adOpenDynamic,LockTypeEnum.adLockOptimistic);
                if (rs.EOF)
                {
                    MessageBox.Show("عفوا اسم السيرفر غير مسجل مسبقا");
                    cn.Close();
                    return;
                } else
                {
                    user=rs.Fields[1].Value.ToString();
                    pass=rs.Fields[2].Value.ToString();
                    server=rs.Fields[3].Value.ToString();
                    database=rs.Fields[4].Value.ToString();
                }

                connstr = "Provider=SQLOLEDB.1;Password='" + pass.ToString() + "';Persist Security Info=True;User ID='" + user.ToString() + "';Initial Catalog='" + database.ToString() + "';Data Source='" + server.ToString() + "'";
               
                rs.AddNew();
                rs.Fields[5].Value = connstr.ToString();
                rs.Update();
                cn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("error message: "+ex.Message);
            }

        }
        #endregion
    }
}
