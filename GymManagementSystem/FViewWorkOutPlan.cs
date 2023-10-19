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
    public partial class FViewWorkOutPlan : Form
    {
        Filter filter;
        public FViewWorkOutPlan()
        {
            InitializeComponent();
            filter = Filter.All;
            gvWorkOutPlan.DataSource = LoadWorkOutPlan(filter,"");
        }
        enum Filter
        {
            All,
            InDay,
            Current,
            Upcoming
        }
        private DataTable LoadWorkOutPlan(Filter type, string search)
        {
            String query = "PROC_FindWorkOutPlan";
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

        private void HeaderText()
        {
            gvWorkOutPlan.Columns[1].HeaderText = "Member ID";
            gvWorkOutPlan.Columns[2].HeaderText = "Member";
            gvWorkOutPlan.Columns[3].HeaderText = "Trainer ID";
            gvWorkOutPlan.Columns[4].HeaderText = "Trainer";
            gvWorkOutPlan.Columns[5].HeaderText = "Branch ID";
            gvWorkOutPlan.Columns[6].HeaderText = "Branch";
        }
        private void AddWorkOutPlan() 
        {
            
            //Chuyển Form AddWorkOutPlan
        }
        private void RemoveWorkOutPlan() 
        {
            //Thực thi câu lệnh sql
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            filter = Filter.All;
            gvWorkOutPlan.DataSource = LoadWorkOutPlan(filter, txtSearch.Text);
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            filter = Filter.Current;
            gvWorkOutPlan.DataSource = LoadWorkOutPlan(filter, txtSearch.Text);
        }

        private void btnUpcoming_Click(object sender, EventArgs e)
        {
            filter = Filter.Upcoming;
            gvWorkOutPlan.DataSource = LoadWorkOutPlan(filter, txtSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInDay_Click(object sender, EventArgs e)
        {
            filter = Filter.InDay;
            gvWorkOutPlan.DataSource = LoadWorkOutPlan(filter, txtSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gvWorkOutPlan.DataSource = LoadWorkOutPlan(filter, txtSearch.Text);
        }


        private void gvWorkOutPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvWorkOutPlan.CurrentRow != null)
            {
                lblID.Text = "ID: " + gvWorkOutPlan.CurrentRow.Cells["ID"].Value.ToString();
                lblBranch.Text = "Branch: "  + gvWorkOutPlan.CurrentRow.Cells["BranchName"].Value.ToString();
                lblMember.Text = "Member: " + gvWorkOutPlan.CurrentRow.Cells["MemberName"].Value.ToString();
                lblTrainer.Text = "Trainer: " + gvWorkOutPlan.CurrentRow.Cells["TrainerName"].Value.ToString();
                dtpDate.Value = (DateTime)gvWorkOutPlan.CurrentRow.Cells["Date"].Value;
                dtpTime.Value = (DateTime)gvWorkOutPlan.CurrentRow.Cells["Date"].Value + (TimeSpan)gvWorkOutPlan.CurrentRow.Cells["Time"].Value;
            }    
        }
    }
}
