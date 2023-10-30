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
        Filter filter;
        private Trainer trainer;
        public FTrainerManagement()
        {
            InitializeComponent();
            filter = Filter.All;
            gvTrainer.DataSource = gvTrainer_Load(filter, "");
            HeaderText();
        }
        enum Filter
        {
            All,
            Male,
            Female
        }
        private DataTable gvTrainer_Load(Filter type, string search)
        {
            String query = "PROC_FindTrainerList";
            Employee.Role = 1;
            DBConnection connection = new DBConnection();
            connection.openConnection();
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FilterType", (int)type);
            command.Parameters.AddWithValue("@Content", txtSearch.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.closeConnection();
            return dataTable;
        }

        private void gvTrainer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvTrainer.CurrentRow != null)
            {
                lblID.Text = "ID: " + gvTrainer.CurrentRow.Cells["ID"].Value.ToString();
                lblName.Text = "Name: " + gvTrainer.CurrentRow.Cells["Name"].Value.ToString();
                lblPhoneNumber.Text = "Phone: " + gvTrainer.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                lblAddress.Text = "Address: " + gvTrainer.CurrentRow.Cells["Address"].Value.ToString();

                txtID.Text = gvTrainer.CurrentRow.Cells["ID"].Value.ToString();
                txtName.Text = gvTrainer.CurrentRow.Cells["Name"].Value.ToString();
                txtAddress.Text = gvTrainer.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                txtPhoneNumber.Text = gvTrainer.CurrentRow.Cells["Address"].Value.ToString();
                txtBranchID.Text = gvTrainer.CurrentRow.Cells["BranchID"].Value.ToString();
                txtGender.Text = gvTrainer.CurrentRow.Cells["Gender"].Value.ToString();
            }
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            filter = Filter.All;
            gvTrainer.DataSource = gvTrainer_Load(filter, txtSearch.Text);
            ChangeBtnColor(Filter.All);
        }

        private void btnMale_Click(object sender, EventArgs e)
        {
            filter = Filter.Male;
            gvTrainer.DataSource = gvTrainer_Load(filter, txtSearch.Text);
            ChangeBtnColor(Filter.Male);
        }

        private void btnFemale_Click(object sender, EventArgs e)
        {
            filter = Filter.Female;
            gvTrainer.DataSource = gvTrainer_Load(filter, txtSearch.Text);
            ChangeBtnColor(Filter.Female);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gvTrainer.DataSource = gvTrainer_Load(filter, txtSearch.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            try
            {

                String query = $"DELETE FROM Trainer WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@ID", lblID.Text.Replace("ID: ", ""));
                command.ExecuteNonQuery();
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return;
            }
            connection.closeConnection();
            MessageBox.Show("Xóa thành công");
        }
        private void HeaderText()
        {
            gvTrainer.Columns[0].HeaderText = "Trainer ID";
            gvTrainer.Columns[1].HeaderText = "Name";
            gvTrainer.Columns[2].HeaderText = "Address";
            gvTrainer.Columns[3].HeaderText = "Phone Number";
            gvTrainer.Columns[4].HeaderText = "Gender";
            gvTrainer.Columns[5].HeaderText = "Branch Name";
            gvTrainer.Columns[6].HeaderText = "Branch ID";
        }

        private void ChangeBtnColor(Filter filter)
        {
            btnAll.BackColor = Color.RoyalBlue;
            btnMale.BackColor = Color.RoyalBlue;
            btnFemale.BackColor = Color.RoyalBlue;

            if (filter == Filter.All)
            {
                btnAll.BackColor = Color.DarkBlue;
            }
            if (filter == Filter.Male)
            {
                btnMale.BackColor = Color.DarkBlue;
            }
            if (filter == Filter.Female)
            {
                btnFemale.BackColor = Color.DarkBlue;
            }
        }

        private bool Update()
        {
            if (trainer != null)
            {
                DBConnection connection = new DBConnection();
                connection.openConnection();
                try
                {
                    String query = "UPDATE Trainer WHERE ID = @ID ";
                    SqlCommand command = new SqlCommand(query, connection.GetConnection());
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);
                    command.Parameters.AddWithValue("PhoneNumber", txtPhoneNumber);
                    command.Parameters.AddWithValue("@Gender", txtGender.Text);
                    command.Parameters.AddWithValue("@BranchID", txtBranchID.Text);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.closeConnection();
                    return false;
                }
                connection.closeConnection();
                gvTrainer.Controls.Clear();
            }
            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private bool Insert()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            try
            {
                String query = "INSERT INTO Trainer (ID, Name, Address, PhoneNumber, Gender, BranchID) VALUES (@ID, @Name, @Address, @PhoneNumber, @Gender, @BranchID)";
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@ID", RandomIDGenerator.GenerateRandomID("Trainer", "TR"));
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Address", txtAddress.Text);
                command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                command.Parameters.AddWithValue("@Gender", txtGender.Text);
                command.Parameters.AddWithValue("@BranchID", txtBranchID.Text);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return false;
            }
            connection.closeConnection();
            gvTrainer.Controls.Clear();
            return true;
        }

    }
}
