using GymManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO.Packaging;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class FCreateWorkOutPlan : Form
    {
        private Branch branch;
        private Trainer trainer;
        private List<WorkOut> workOuts = new List<WorkOut>();
        private Member member;

        public FCreateWorkOutPlan()
        {
            InitializeComponent();
            StackForm.Add(this);
            List<Branch> branches = LoadBranch();
            for (int i = 0; i < branches.Count; i++)
            {
                USBranch branch = new USBranch(branches[i]);
                flpnlBranch.Controls.Add(branch);
                branch.BranchClicked += Branch_BranchClicked;

            }
            List<WorkOut> workOuts = LoadWorkOut();
            foreach (var workOut in workOuts)
            {
                USWorkOut wk = new USWorkOut(workOut);
                flpnlWorkout.Controls.Add(wk);
                wk.WorkOutClicked += Workout_WorkoutClicked;
            };
            countWO = 0;
            totalTime = 0;
        }    


        private void Branch_BranchClicked(object? sender, EventArgs e)
        {
            USBranch clickedUSBranch = (USBranch)sender;
            branch = clickedUSBranch.UsCBranch;
            foreach (var ctr in flpnlBranch.Controls)
            {
                if (((USBranch)ctr).UsCBranch.ID != branch.ID)
                {
                    ((USBranch)ctr).changeColor(0);

                }    
                else
                {
                    ((USBranch)ctr).changeColor(1);
                }    
            }
            flpnlTrainer.Controls.Clear();
            List<Trainer> trainers = FindTrainerByBranchAndContent(txtTrainer.Text,branch.ID);
            foreach (var trainer in trainers)
            {
                USTrainer tmp = new USTrainer(trainer);
                tmp.TrainerClicked += Trainer_TrainerClicked;
                flpnlTrainer.Controls.Add(tmp);
            }
            
        }

        private void Trainer_TrainerClicked(object? sender, EventArgs e)
        {
            USTrainer clickedUSTrainer = (USTrainer)sender;
            trainer = clickedUSTrainer.UsCTrainer;

            foreach (var ctr in flpnlTrainer.Controls)
            {
                if (((USTrainer)ctr).UsCTrainer.ID != trainer.ID)
                {
                    ((USTrainer)ctr).changeColor(0);
                }
                else
                {
                    ((USTrainer)ctr).changeColor(1);
                }
            }

            btnNoTrainer.BackColor = Color.White;
            btnNoTrainer.ForeColor = Color.FromArgb(67, 52, 67);
        }
        private int countWO;
        private int totalTime;
        

        private void Workout_WorkoutClicked(object? sender, EventArgs e)
        {
            USWorkOut clickedUSWorkOut = (USWorkOut)sender;
            foreach (var wk in workOuts)
            {
                if (wk.ID == clickedUSWorkOut.USCWorkOut.ID)
                {
                    countWO--;
                    workOuts.Remove(wk);
                    txtNumberOfWorkouts.Text = countWO.ToString();
                    totalTime -= clickedUSWorkOut.USCWorkOut.Duration;
                    dtpCompletionTime.Value = (dtpTime.Value).AddMinutes(totalTime);
                    return;
                    
                }
            }
            countWO++;
            txtNumberOfWorkouts.Text = countWO.ToString();
            workOuts.Add(clickedUSWorkOut.USCWorkOut);
            totalTime += clickedUSWorkOut.USCWorkOut.Duration;
            dtpCompletionTime.Value = (dtpTime.Value).AddMinutes(totalTime);

        }
        private void btnNoTrainer_Click(object sender, EventArgs e)
        {
            
            trainer = null;
            btnNoTrainer.BackColor = Color.Red;
            btnNoTrainer.ForeColor = Color.White;
            foreach (var ctr in flpnlTrainer.Controls)
            {

                ((USTrainer)ctr).changeColor(0);
  
            }


        }

        private void ShowInfo(Member member)
        {
            txtName.Text = member.Name;
            lblPackageDate.Text = member.EndOfPackageDate.ToString("dd/MM/yyyy");
            lblRemaingTS.Text = member.RemainingTS.ToString();
        }    

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            ShowInfo(FindMember(txtPhoneNumber.Text));
        }

        private Member FindMember(string phoneNumber)
        {
            member = new Member();
            DBConnection connection = new DBConnection();
            connection.openConnection();

            String query = "PROC_FindMemberByPhoneNumber";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            //khai báo các thuộc tính của tham số
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                           member.Name = reader["Name"].ToString();
                           member.ID = reader["ID"].ToString();
                           try
                           {
                            member.RemainingTS = int.Parse(reader["RemainingTS"].ToString());
                           }    
                           catch
                           {
                            member.RemainingTS = 0;
                           }   
                           member.EndOfPackageDate = DateTime.Parse(reader["EndOfPackageDate"].ToString());

                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Member");
                }
            }

            connection.closeConnection();

            return member;

        }

        private List<Branch> LoadBranch()
        {
            Employee.Role = 1;
            DBConnection connection = new DBConnection();
            connection.openConnection();
     
            String query = "SELECT * FROM V_BranchList";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.closeConnection();
            return ConvertDataTableToBranchList(dataTable);
        }
        private List<Branch> FindBranch(string content)
        {
            Employee.Role = 1;
            DBConnection connection = new DBConnection();
            connection.openConnection();

            String query = "PROC_FindBranchByContent";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Content", content);


            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.closeConnection();
            return ConvertDataTableToBranchList(dataTable);
        }

        private List<Branch> ConvertDataTableToBranchList(DataTable dataTable)
        {
            List<Branch> branchList = new List<Branch>();

            foreach (DataRow row in dataTable.Rows)
            {
                Branch branch = new Branch((row["ID"]).ToString(), (row["Name"]).ToString(),(row["Address"]).ToString());
                branchList.Add(branch);
            }

            return branchList;
        }

        private List<Trainer> ConvertDataTableToTrainerList(DataTable dataTable)
        {
            List<Trainer> trainerList = new List<Trainer>();

            foreach (DataRow row in dataTable.Rows)
            {
                Trainer trainer = new Trainer((row["ID"]).ToString(), (row["Name"]).ToString(), (row["Address"]).ToString(), (row["PhoneNumber"]).ToString(), (row["Gender"]).ToString(), (row["BranchID"]).ToString());
                trainerList.Add(trainer);
            }

            return trainerList;
        }

        private void btnFindBranch_Click(object sender, EventArgs e)
        {
            branch = null;
            trainer = null;
            flpnlTrainer.Controls.Clear();
            flpnlBranch.Controls.Clear();
            List<Branch> branches = FindBranch(txtBranch.Text);
            for (int i = 0; i < branches.Count; i++)
            {
                USBranch branch = new USBranch(branches[i]);
                flpnlBranch.Controls.Add(branch);
                branch.BranchClicked += Branch_BranchClicked;

            }
        }

        private List<Trainer> FindTrainerByBranchAndContent(string content, string branch)
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();

            String query = "PROC_FindTrainerByBranchAndContent";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Content", content);
            command.Parameters.AddWithValue("@Branch", branch);


            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.closeConnection();
            return ConvertDataTableToTrainerList(dataTable);
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            if (branch != null)
            {
                flpnlTrainer.Controls.Clear();
                List<Trainer> trainers = FindTrainerByBranchAndContent(txtTrainer.Text, branch.ID);
                foreach (var trainer in trainers)
                {
                    USTrainer tmp = new USTrainer(trainer);
                    tmp.TrainerClicked += Trainer_TrainerClicked;
                    flpnlTrainer.Controls.Add(tmp);
                }
            }    
            else
            {
                MessageBox.Show("Vui lòng chọn Branch");
            }    
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
        private List<WorkOut> LoadWorkOut()
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
            connection.closeConnection();
            return ConvertDataTableToWorkoutList(dataTable);
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            dtpCompletionTime.Value = (dtpTime.Value).AddMinutes(totalTime);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ConfirmPlan())
                ConfirmWorkOut();
        }

        private bool ConfirmPlan()
        {
            txtID.Text = RandomIDGenerator.GenerateRandomID("WorkOutPlan", "P");
            DBConnection connection = new DBConnection();
            connection.openConnection();
            try
            {
                
                String query = "PROC_AddWorkOutPlan";
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MemberID", member.ID);
                command.Parameters.AddWithValue("@BranchID", branch.ID);
                if (trainer != null)
                    command.Parameters.AddWithValue("@TrainerID", trainer.ID);
                command.Parameters.AddWithValue("@Date", dtpDate.Value);
                command.Parameters.AddWithValue("@Time", dtpTime.Value.TimeOfDay);
                command.Parameters.AddWithValue("@ID", txtID.Text);
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
                return false;
            }
            connection.closeConnection();
            txtBranchResult.Text = branch.ID;
            txtTrainerResult.Text = trainer.Name;
            return true;
                
        }

        private void ConfirmWorkOut()
        {
            Employee.Role = 1;
            DBConnection connection = new DBConnection();
            connection.openConnection();
            foreach (var workOut in workOuts)
            {
                try
                {

                    String query = "PROC_AddPlanDetails";
                    SqlCommand command = new SqlCommand(query, connection.GetConnection());
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@WorkOutPlanID", txtID.Text);
                    command.Parameters.AddWithValue("@WorkOutID", workOut.ID); 
                    command.ExecuteNonQuery();
                   
                }
                catch
                (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.closeConnection();
                    return;
                }
                
            }
            connection.closeConnection();
            connection.openConnection();

            String query2 = "PROC_UpdateRemainingTS";
            SqlCommand command2 = new SqlCommand(query2, connection.GetConnection());
            command2.CommandType = CommandType.StoredProcedure;
            command2.Parameters.AddWithValue("@WorkOutPlanID", txtID.Text);
            command2.ExecuteNonQuery();
            connection.closeConnection();
            MessageBox.Show("Thêm thành công");
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FViewWorkOutPlan());
        }

    }
}
