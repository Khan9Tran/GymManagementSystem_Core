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
    public partial class FEquipmentMaintenance : Form
    {
        public FEquipmentMaintenance()
        {
            InitializeComponent();
            filter = Filter.All;
            LoadEquipment(filter);
            if (Employee.Role == 0)
                pnlLoadData.Visible = false;
            StackForm.Add(this);

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

        private void btnReport_Click(object sender, EventArgs e)
        {
            SetUnavailable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMaintenanceData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteMaintenanceData();
        }

        private void txtNewEquip_Click(object sender, EventArgs e)
        {
            NewEqip();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadEquipment(filter);
        }

        enum Filter
        {
            All,
            Avai,
            Unvai
        }

        Filter filter;

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
            gvEquipment.Columns["Price"].Visible = false;
            gvEquipment.Columns["CategoryID"].Visible = false;
        }

        private void SetUnavailable()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            try
            {

                String query = "PROC_SetUnavailable";
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", gvEquipment.CurrentRow.Cells["ID"].Value.ToString());
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
            MessageBox.Show("Đã thêm vào danh sách thiết bị hư hỏng");
            LoadEquipment(filter);
        }

        private void gvEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LoadMaintenanceData(gvEquipment.CurrentRow.Cells["ID"].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Không có thông tin ");
            }
        }

        private void LoadMaintenanceData(string ID)
        {
            try
            {
                String query = "PROC_FindMaintenanceData";
                DBConnection connection = new DBConnection();
                connection.openConnection();

                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", ID);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                connection.closeConnection();
                gvMaintenance.DataSource = dataTable;
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddMaintenanceData()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            try
            {

                String query = "PROC_AddMaintenanceData";
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", RandomIDGenerator.GenerateRandomID("Equipment", "ED"));
                command.Parameters.AddWithValue("@EquipmentID", gvEquipment.CurrentRow.Cells["ID"].Value.ToString());
                command.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                command.Parameters.AddWithValue("@Cost", Decimal.Parse(txtCost.Text));
                command.Parameters.AddWithValue("@Description", txtDesc.Text);
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
            LoadMaintenanceData(gvEquipment.CurrentRow.Cells["ID"].Value.ToString());
            LoadEquipment(filter);
            MessageBox.Show("Thêm thành công");
        }


        private void DeleteMaintenanceData()
        {

            DBConnection connection = new DBConnection();
            connection.openConnection();
            try
            {

                String query = "DELETE MaintenanceData WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@ID", gvMaintenance.CurrentRow.Cells["ID"].Value.ToString());
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
            LoadMaintenanceData(gvEquipment.CurrentRow.Cells["ID"].Value.ToString());
            LoadEquipment(filter);
            MessageBox.Show("Xóa thành công");
        }

        private void NewEqip()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            try
            {

                String query = "PROC_ReplaceEquipment";
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", RandomIDGenerator.GenerateRandomID("Equipment", "ED"));
                command.Parameters.AddWithValue("@EquipmentID", gvEquipment.CurrentRow.Cells["ID"].Value.ToString());
                command.Parameters.AddWithValue("@Date", DateTime.Now.Date);
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
            LoadMaintenanceData(gvEquipment.CurrentRow.Cells["ID"].Value.ToString());
            LoadEquipment(filter);
            MessageBox.Show("Thay thế thành công");
        }
    }
    
}
