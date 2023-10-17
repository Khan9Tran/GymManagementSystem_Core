using GymManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        public FCreateWorkOutPlan()
        {
            InitializeComponent();
            List<Branch> branches = LoadBranch();
            for (int i = 0; i < branches.Count; i++)
            {
                USBranch branch = new USBranch(branches[i]);
                flpnlBranch.Controls.Add(branch);
                branch.BranchClicked += Branch_BranchClicked;

            }

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

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            txtName.Text = FindMember(txtPhoneNumber.Text);
        }

        private string FindMember(string phoneNumber)
        {
            string name = "";
            Employee.Role = 1;
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
                       name = reader["Name"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Member");
                }
            }

            connection.closeConnection();

            return name;

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


    }
}
