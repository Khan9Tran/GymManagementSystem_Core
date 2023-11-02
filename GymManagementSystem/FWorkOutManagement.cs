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
            gvWorkOut_Load();
            toolForPicture = new ToolForPicture(ToolForPicture.Type.workOut);
        }

        private DataTable gvWorkOut_Load()
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

            gvWorkOut.DataSource = dataTable;
            connection.closeConnection();
            return dataTable;
        }

        private void gvWorkOut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = gvWorkOut.CurrentRow.Cells["ID"].Value.ToString();
            txtName.Text = gvWorkOut.CurrentRow.Cells["Name"].Value.ToString();
            txtType.Text = gvWorkOut.CurrentRow.Cells["Type"].Value.ToString();
            txtDescription.Text = gvWorkOut.CurrentRow.Cells["Description"].Value.ToString();
            txtDuration.Text = gvWorkOut.CurrentRow.Cells["Duration"].Value.ToString();

            try
            {
                toolForPicture.GetPicture(gvWorkOut.CurrentRow.Cells["ID"].Value.ToString(), ptcImageWO);
            }
            catch
            {

            }
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
            gvWorkOut_Load();

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
            gvWorkOut_Load();
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
            gvWorkOut_Load();

        }

        ToolForPicture toolForPicture;

        private void LoadImg()
        {

        }

        private void ptcImageWO_Click(object sender, EventArgs e)
        {
            toolForPicture.AddPicture(ofdPic, ptcImageWO);
            if (ptcImageWO.Image != null)
            {
                toolForPicture.SavePicture(gvWorkOut.CurrentRow.Cells["ID"].Value.ToString(), ofdPic, ptcImageWO);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gvWorkOut.DataSource = FindWorkout(txtSearch.Text);
        }

        private DataTable FindWorkout(string content)
        {
            DBConnection connection = new DBConnection();
            string query = "SELECT * FROM dbo.FUNC_FindWorkout(@Content)";
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
    }
}
