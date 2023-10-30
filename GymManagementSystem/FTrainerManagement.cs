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
        private int manage;
        public FTrainerManagement()
        {
            InitializeComponent();
            manage = 0;
            filter = Filter.All;
            pnlManage.Hide();
            gvTrainer_Load(filter, "");
            LoadBranch();
        }
        enum Filter
        {
            All,
            Male,
            Female
        }
        private void gvTrainer_Load(Filter type, string search)
        {
            String query = "PROC_FindTrainerList";
            DBConnection connection = new DBConnection();
            connection.openConnection();
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FilterType", (int)type);
            command.Parameters.AddWithValue("@Content", txtSearch.Text);
            command.Parameters.AddWithValue("@BranchID", Employee.BranchID);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.closeConnection();
            gvTrainer.DataSource = dataTable;
            HeaderText();
            gvTrainer.Columns["Gender"].Visible = false;
            gvTrainer.Columns["BranchID"].Visible = false;
        }

        private void gvTrainer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvTrainer.CurrentRow != null)
            {
                lblID.Text = "ID: " + gvTrainer.CurrentRow.Cells["ID"].Value.ToString();
                lblName.Text = "Name: " + gvTrainer.CurrentRow.Cells["Name"].Value.ToString();
                txtName.Text = gvTrainer.CurrentRow.Cells["Name"].Value.ToString();
                txtAddress.Text = gvTrainer.CurrentRow.Cells["Address"].Value.ToString();
                txtPhoneNumber.Text = gvTrainer.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                foreach (DataRowView item in cbxBranch.Items)
                {
                    if (item["ID"].ToString() == gvTrainer.CurrentRow.Cells["BranchID"].Value.ToString())
                    {
                        cbxBranch.SelectedIndex = cbxBranch.Items.IndexOf(item);
                        break;
                    }
                }
                if (gvTrainer.CurrentRow.Cells["Gender"].Value.ToString() == "m")
                    cbxGender.SelectedIndex = 0;
                else if (gvTrainer.CurrentRow.Cells["Gender"].Value.ToString() == "f")
                    cbxGender.SelectedIndex = 1;
                else cbxGender.SelectedIndex = 2;
                LoadSchedule(gvTrainer.CurrentRow.Cells["ID"].Value.ToString(), dtpDate.Value.Date);


            }
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            filter = Filter.All;
            gvTrainer_Load(filter, txtSearch.Text);
            ChangeBtnColor(Filter.All);
        }

        private void btnMale_Click(object sender, EventArgs e)
        {
            filter = Filter.Male;
            gvTrainer_Load(filter, txtSearch.Text);
            ChangeBtnColor(Filter.Male);
        }

        private void btnFemale_Click(object sender, EventArgs e)
        {
            filter = Filter.Female;
            gvTrainer_Load(filter, txtSearch.Text);
            ChangeBtnColor(Filter.Female);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gvTrainer_Load(filter, txtSearch.Text);
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
            gvTrainer_Load(filter, txtSearch.Text);
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
            DBConnection connection = new DBConnection();
            connection.openConnection();
            try
            {
                String query = "PROC_UpdateTrainer";
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Address", txtAddress.Text);
                command.Parameters.AddWithValue("PhoneNumber", txtPhoneNumber.Text);
                command.Parameters.AddWithValue("@Gender", cbxGender.SelectedItem.ToString());
                command.Parameters.AddWithValue("@BranchID", (cbxBranch.SelectedItem as DataRowView)["ID"].ToString());
                command.Parameters.AddWithValue("@ID", gvTrainer.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show((string)command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return false;
            }
            connection.closeConnection();
            gvTrainer.Controls.Clear();
            gvTrainer_Load(filter, txtSearch.Text);
            
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
                String query = "PROC_InsertTrainer";
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", RandomIDGenerator.GenerateRandomID("Trainer", "TR"));
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Address", txtAddress.Text);
                command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                command.Parameters.AddWithValue("@Gender", cbxGender.SelectedItem.ToString());
                command.Parameters.AddWithValue("@BranchID", (cbxBranch.SelectedItem as DataRowView)["ID"].ToString());
                MessageBox.Show((string)command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return false;
            }
            connection.closeConnection();
            gvTrainer_Load(filter,txtSearch.Text);
            return true;
        }
        private void LoadBranch()
        { 
            DBConnection connection = new DBConnection();
            string query = "SELECT * FROM V_BranchList";
            if (Employee.BranchID != "BRRoot") query += $" WHERE ID = '{Employee.BranchID}'";
            DataTable dataTable = new DataTable();
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
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
            cbxBranch.DataSource = dataTable;
            cbxBranch.DisplayMember = "Name";

        }
      
        private void btnManage_Click(object sender, EventArgs e)
        {
            if (Employee.Role == 3)
            {
                MessageBox.Show("Bạn không có quyền truy cập");
            }
            else
            {  
                if (manage == 0)
                {
                    pnlManage.Show();
                    manage = 1;
                }
                else
                {
                    pnlManage.Hide();
                    manage = 0;
                }    

            }    
        }

        private void LoadSchedule(string ID, DateTime date)
        {
            DBConnection connection = new DBConnection();
            string query = "SELECT * FROM dbo.FUNC_TrainerSchedule(@TrainerID, @Date)";
            DataTable dataTable = new DataTable();
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.AddWithValue("@TrainerID", ID);
                command.Parameters.AddWithValue("@Date", date.Date);
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
            gvSchedule.DataSource = dataTable;
        }



    }
}
