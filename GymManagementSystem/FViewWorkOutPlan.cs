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
            HeaderText();
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
            fpnlWorkOut.Controls.Clear();
            String query = "PROC_FindWorkOutPlan";
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
            StackForm.HomeUser.ChildForm.Open(new FCreateWorkOutPlan());
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
            AddWorkOutPlan();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            WorkOutPlan wop = new WorkOutPlan()
            {
                ID = (lblID.Text).Replace("ID: ", ""),
                Time = dtpTime.Value.TimeOfDay,
                Date = dtpDate.Value.Date,
                MemberID = gvWorkOutPlan.CurrentRow.Cells["MemberId"].Value.ToString()
            };
            UpdateWorkOutPlan(wop);
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

                fpnlWorkOut.Controls.Clear();
                List<WorkOut> workOuts = LoadWorkOut(gvWorkOutPlan.CurrentRow.Cells["ID"].Value.ToString());
                foreach (var workOut in workOuts)
                {
                    USWorkOut wk = new USWorkOut(workOut);
                    fpnlWorkOut.Controls.Add(wk);
                };
            }    
        }

        private void UpdateWorkOutPlan(WorkOutPlan wop)
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            try
            {

                String query = "PROC_UpdateWorkOutPlan";
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Date", wop.Date);
                command.Parameters.AddWithValue("@Time", wop.Time);
                command.Parameters.AddWithValue("@ID", wop.ID);
                command.Parameters.AddWithValue("@MemberID", wop.MemberID);

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
            connection.openConnection();

            String query2 = "PROC_UpdateRemainingTS";
            SqlCommand command2 = new SqlCommand(query2, connection.GetConnection());
            command2.CommandType = CommandType.StoredProcedure;
            command2.Parameters.AddWithValue("@WorkOutPlanID", wop.ID);
            command2.ExecuteNonQuery();
            connection.closeConnection();
            MessageBox.Show("Cập nhật thành công");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            try
            {

                String query = $"DELETE FROM WorkOutPlan WHERE ID = @ID";
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


        private List<WorkOut> ConvertDataTableToWorkoutList(DataTable dataTable)
        {
            List<WorkOut> workoutList = new List<WorkOut>();

            foreach (DataRow row in dataTable.Rows)
            {
                WorkOut workOut = new WorkOut((row["ID"]).ToString(), (row["Name"]).ToString(), (row["Description"]).ToString(), (row["Type"]).ToString(), int.Parse((row["Duration"]).ToString()));
                workoutList.Add(workOut);
            }

            return workoutList;
        }
        private List<WorkOut> LoadWorkOut(string ID)
        {
            Employee.Role = 1;
            DBConnection connection = new DBConnection();
            connection.openConnection();

            String query = "SELECT * FROM FUNC_FindWorkOutByWorkOutPlan(@ID)";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            //command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID", ID);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.closeConnection();
            return ConvertDataTableToWorkoutList((dataTable));
        }
    }
}
