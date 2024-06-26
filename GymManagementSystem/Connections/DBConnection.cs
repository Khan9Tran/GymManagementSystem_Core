﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GymManagementSystem.Models;

namespace GymManagementSystem
{
    internal class DBConnection
    {
        private SqlConnection conn;
        public DBConnection()
        {
            if (Employee.Name != "")
            {
                conn = new SqlConnection(@"Data Source=.;Initial Catalog=GymManagerDB; USER ID=" + Employee.UserName + ";Password=" + Employee.Password + ";");
            }
            else
            {
                
                conn = new SqlConnection("Data Source=.;Initial Catalog=GymManagerDB;Integrated Security=True");
            }    
        }

        public SqlConnection GetConnection()
        {
            return conn;
        }
        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            conn.Close();
        }
    }
}
