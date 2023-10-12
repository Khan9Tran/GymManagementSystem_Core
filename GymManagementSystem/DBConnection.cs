using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GymManagementSystem
{
    internal class DBConnection
    {
        private SqlConnection conn;
        public DBConnection()
        {
            if (Account.Role == 1)
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-TSVFN4HJ;Initial Catalog=GymManagementDB;Integrated Security=True");
            }
            else
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-TSVFN4HJ;Initial Catalog=GymManagementDB;User Id=" + Account.UserName + ";Password=" + Account.Password + ";");
            }
        }
        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void openConnectionAdmin()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
    }
}
