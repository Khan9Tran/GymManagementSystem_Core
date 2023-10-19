using GymManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class FTrainerManagement : Form
    {
        public FTrainerManagement()
        {
            InitializeComponent();
        }
        enum Filter
        {
            All,
            Male,
            Female,
            Upcoming
        }
        private void gvTrainer_Load(object sender, EventArgs e)
        {
            Employee.Role = 1;
            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "SELECT * FROM V_TrainerList";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            gvTrainer.DataSource = dataTable;
            connection.closeConnection();

        }

        private void gvTrainer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvTrainer.CurrentRow != null)
            {
                lblID.Text = "ID: " + gvTrainer.CurrentRow.Cells["ID"].Value.ToString();
                lblName.Text = "Name: " + gvTrainer.CurrentRow.Cells["Name"].Value.ToString();
                lblPhoneNumber.Text = "Phone: " + gvTrainer.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                lblAddress.Text = "Address: " + gvTrainer.CurrentRow.Cells["Address"].Value.ToString();
            }
        }

        private void btnMale_Click(object sender, EventArgs e)
        {
            Employee.Role = 1;
            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "SELECT * FROM V_TrainerList WHERE GENDER = 'm'";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            gvTrainer.DataSource = dataTable;
            connection.closeConnection();
        }

        private void btnFemale_Click(object sender, EventArgs e)
        {
            Employee.Role = 1;
            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "SELECT * FROM V_TrainerList WHERE GENDER = 'f'";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            gvTrainer.DataSource = dataTable;
            connection.closeConnection();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Employee.Role = 1;
            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "SELECT * FROM V_TrainerList";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            gvTrainer.DataSource = dataTable;
            connection.closeConnection();
        }
    }
}
