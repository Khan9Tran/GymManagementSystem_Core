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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace GymManagementSystem
{
    public partial class FEquipmentCategory : Form
    {
        public FEquipmentCategory()
        {
            InitializeComponent();
            gvEquipmentCategory_Load("");

        }

        private DataTable gvEquipmentCategory_Load(string search)
        {
            Employee.Role = 1;
            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "PROC_FindEquipmentCategory";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Content", txtSearch.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            gvEquipmentCategory.DataSource = dataTable;
            connection.closeConnection();
            return dataTable;
        }

        private void gvEquipmentCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = gvEquipmentCategory.CurrentRow.Cells["ID"].Value.ToString();
            txtName.Text = gvEquipmentCategory.CurrentRow.Cells["Name"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void Insert()
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_AddEquipmentCategory";
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", RandomIDGenerator.GenerateRandomID("EquipmentCategory", "EQC"));
                command.Parameters.AddWithValue("@Name", txtName.Text);
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
            gvEquipmentCategory_Load("");
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateWorkout();
        }

        private void UpdateWorkout()
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_UpdateEquipmentCategory";
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", txtID.Text);
                command.Parameters.AddWithValue("@Name", txtName.Text);
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
            gvEquipmentCategory_Load("");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEquipmentCategory();
        }

        private void DeleteEquipmentCategory()
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_DeleteEquipmentCategory";
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
            gvEquipmentCategory_Load("");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gvEquipmentCategory.DataSource = gvEquipmentCategory_Load(txtSearch.Text);
        }
    }
}
