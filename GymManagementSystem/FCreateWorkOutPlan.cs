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
        private string branchId = null;
        private string trainerId = null;
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
            for (int i = 0; i < 10; i++)
            {
                USTrainer trainer = new USTrainer("Texttttt", "m", $"{i}",$"{i}");
                flpnlTrainer.Controls.Add(trainer);
                trainer.TrainerClicked += Trainer_TrainerClicked;

            }

        }

        private void Branch_BranchClicked(object? sender, EventArgs e)
        {
            USBranch clickedUSBranch = (USBranch)sender;
            branchId = clickedUSBranch.UsCBranch.ID;
            foreach (var ctr in flpnlBranch.Controls)
            {
                if (((USBranch)ctr).UsCBranch.ID != branchId)
                {
                    ((USBranch)ctr).changeColor(0);
                }    
                else
                {
                    ((USBranch)ctr).changeColor(1);
                }    
            }    
        }

        private void Trainer_TrainerClicked(object? sender, EventArgs e)
        {
            USTrainer clickedUSTrainer = (USTrainer)sender;
            trainerId = clickedUSTrainer.TrainerID;

            foreach (var ctr in flpnlTrainer.Controls)
            {
                if (((USTrainer)ctr).TrainerID != trainerId)
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
            
            trainerId = null;
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
    }
}
