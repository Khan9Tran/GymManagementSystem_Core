using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class FBranchManagement : Form
    {
        public FBranchManagement()
        {
            InitializeComponent();
            gvBranch.DataSource = LoadBranch();
        }

        private DataTable LoadBranch()
        {
            DBConnection connection = new DBConnection();
            string query = "SELECT * FROM V_BranchList";
            DataTable dataTable= new DataTable();
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.closeConnection();
            }
            return dataTable;
        }

        private void gvBranch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = gvBranch.CurrentRow.Cells["ID"].Value.ToString();
                txtName.Text = gvBranch.CurrentRow.Cells["Name"].Value.ToString();
                txtAddress.Text = gvBranch.CurrentRow.Cells["Address"].Value.ToString();
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gvBranch.DataSource = FindBranch(txtSearch.Text);
        }

        private DataTable FindBranch(string content)
        {
            DBConnection connection = new DBConnection();
            string query = "SELECT * FROM dbo.FUNC_FindBranch(@Content)";
            DataTable dataTable = new DataTable();
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.AddWithValue("@Content", content);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.closeConnection();
            }
            return dataTable;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            gvBranch.DataSource = LoadBranch();
            txtSearch.Clear();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Text = RandomIDGenerator.GenerateRandomID("Branch", "BR");
            InsertBranch(txtID.Text);

        }

        private void InsertBranch(string ID)
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_AddBranch";
            DataTable dataTable = new DataTable();
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID",ID);
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Address", txtAddress.Text);
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

        }

        private void UpdateBranch()
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_UpdateBranch";
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", txtID.Text);
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Address", txtAddress.Text);
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
            gvBranch.DataSource = LoadBranch();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateBranch();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBranch();
        }

        private void DeleteBranch()
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_DeleteBranch";
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
            gvBranch.DataSource = LoadBranch();
        }
    }
}
