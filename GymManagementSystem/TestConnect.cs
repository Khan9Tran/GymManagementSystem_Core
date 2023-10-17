using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymManagementSystem;
using GymManagementSystem.Models;

namespace GymManagementSystem
{
    public partial class TestConnect : Form
    {
        public TestConnect()
        {
            InitializeComponent();
        }

        private void TestConnect_Load(object sender, EventArgs e)
        {
            Employee.Role = 1;
            DBConnection connection = new DBConnection();
            connection.openConnection();

            String query = "SELECT * FROM Package";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dgPackage.DataSource = dataTable;
        }
    }
}
