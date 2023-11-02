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
    public partial class FEquipmentManagement : Form
    {
        private Filter filter;
        public FEquipmentManagement()
        {
            InitializeComponent();
            filter = Filter.All;
            LoadEquipment(filter);
            LoadBranch();
            LoadCategory();
            StackForm.Add(this);
        }

        enum Filter
        {
            All,
            Avai,
            Unvai
        }
        private void LoadEquipment(Filter filter)
        {
            String query = "PROC_FindEquipment";
            DBConnection connection = new DBConnection();
            connection.openConnection();

            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FilterType", (int)filter);
            command.Parameters.AddWithValue("@Content", txtSearch.Text);
            command.Parameters.AddWithValue("@BranchID", Employee.BranchID);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.closeConnection();
            gvEquipment.DataSource = dataTable;
            gvEquipment.Columns["BranchID"].Visible = false;
            gvEquipment.Columns["CategoryID"].Visible = false;
        }


        private void gvEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = "ID: " + gvEquipment.CurrentRow.Cells["ID"].Value.ToString();
            txtName.Text = gvEquipment.CurrentRow.Cells["Name"].Value.ToString();
            txtPrice.Text = gvEquipment.CurrentRow.Cells["Price"].Value.ToString();
            if (gvEquipment.CurrentRow.Cells["Status"].Value.ToString() == "available")
                cbxStatus.SelectedIndex = 0;
            else
                cbxStatus.SelectedIndex = 1;

            foreach (DataRowView item in cbxBranch.Items)
            {
                if (item["ID"].ToString() == gvEquipment.CurrentRow.Cells["BranchID"].Value.ToString())
                {
                    cbxBranch.SelectedIndex = cbxBranch.Items.IndexOf(item);
                    break;
                }
            }

            foreach (DataRowView item in cbxCategory.Items)
            {
                if (item["ID"].ToString() == gvEquipment.CurrentRow.Cells["CategoryID"].Value.ToString())
                {
                    cbxCategory.SelectedIndex = cbxCategory.Items.IndexOf(item);
                    break;
                }
            }

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            filter = Filter.All;
            LoadEquipment(filter);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (filter == Filter.All)
            {
                filter = Filter.Avai;
            }
            else if (filter == Filter.Avai)
            {
                filter = Filter.Unvai;
            }
            else if (filter == Filter.Unvai)
            {
                filter = Filter.Avai;
            }
            LoadEquipment(filter);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadEquipment(filter);
        }


        private void LoadBranch()
        {
            DBConnection connection = new DBConnection();
            string query = "SELECT * FROM V_BranchList";
            if (Employee.BranchID != "BRRoot")
                query += $" WHERE ID = '{Employee.BranchID}'";
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

        private void LoadCategory()
        {
            DBConnection connection = new DBConnection();
            string query = "SELECT * FROM V_CategoryList";
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
            cbxCategory.DataSource = dataTable;
            cbxCategory.DisplayMember = "Name";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertBranch(RandomIDGenerator.GenerateRandomID("Equipment", "EQ"));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateBranch();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBranch();
        }


        private void InsertBranch(string ID)
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_AddEquipment";
            DataTable dataTable = new DataTable();
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Price", txtPrice.Text);
                command.Parameters.AddWithValue("@Status", cbxStatus.SelectedItem.ToString());
                command.Parameters.AddWithValue("@BranchID", (cbxBranch.SelectedItem as DataRowView)["ID"].ToString());
                command.Parameters.AddWithValue("@CategoryID", (cbxCategory.SelectedItem as DataRowView)["ID"].ToString());
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
            LoadEquipment(filter);

        }

        private void UpdateBranch()
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_UpdateEquipment";
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", gvEquipment.CurrentRow.Cells["ID"].Value.ToString());
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Price", txtPrice.Text);
                command.Parameters.AddWithValue("@Status", cbxStatus.SelectedItem.ToString());
                command.Parameters.AddWithValue("@BranchID", (cbxBranch.SelectedItem as DataRowView)["ID"].ToString());
                command.Parameters.AddWithValue("@CategoryID", (cbxCategory.SelectedItem as DataRowView)["ID"].ToString());
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
            LoadEquipment(filter);

        }



        private void DeleteBranch()
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_DeleteEquipment";
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", gvEquipment.CurrentRow.Cells["ID"].Value.ToString());
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
            LoadEquipment(filter);
            gvEquipment_CellClick(this, null);
        }

    }
}
