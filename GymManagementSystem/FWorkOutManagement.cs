using GymManagementSystem.Models;
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

namespace GymManagementSystem
{
    public partial class FWorkOutManagement : Form
    {
        public FWorkOutManagement()
        {
            InitializeComponent();
            gvBranch_Load();
        }

        private DataTable gvBranch_Load()
        {
            Employee.Role = 1;
            DBConnection connection = new DBConnection();
            connection.openConnection();

            String query = "SELECT * FROM V_WorkOutList";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            gvBranch.DataSource = dataTable;
            connection.closeConnection();
            return dataTable;
        }

        private void gvBranch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = gvBranch.CurrentRow.Cells["ID"].Value.ToString();
            txtName.Text = gvBranch.CurrentRow.Cells["Name"].Value.ToString();
            txtType.Text = gvBranch.CurrentRow.Cells["Type"].Value.ToString();
            txtDescription.Text = gvBranch.CurrentRow.Cells["Description"].Value.ToString();
            txtDuration.Text = gvBranch.CurrentRow.Cells["Duration"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_DeleteWorkout";
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", txtID.Text);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return;
            }
            connection.closeConnection();
            MessageBox.Show("Xóa thành công");
            gvBranch_Load();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void Insert()
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_AddWorkout";
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", RandomIDGenerator.GenerateRandomID("Workout", "WO"));
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Type", txtType.Text);
                command.Parameters.AddWithValue("@Description", txtDescription.Text);
                command.Parameters.AddWithValue("@Duration", Int32.Parse(txtDuration.Text));
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return;
            }
            connection.closeConnection();
            MessageBox.Show("Thêm thành công");
            gvBranch_Load();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateWorkout();
        }

        private void UpdateWorkout()
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_UpdateWorkout";
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", txtID.Text);
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Type", txtType.Text);
                command.Parameters.AddWithValue("@Description", txtDescription.Text);
                command.Parameters.AddWithValue("@Duration", Int32.Parse(txtDuration.Text));
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return;
            }
            connection.closeConnection();
            MessageBox.Show("Cập nhật thành công");
            gvBranch_Load();

        }
    }
}
