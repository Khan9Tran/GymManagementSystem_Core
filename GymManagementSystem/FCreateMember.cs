using GymManagementSystem.Models;
using Microsoft.VisualBasic;
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
    public partial class FCreateMember : Form
    {
        public FCreateMember()
        {
            InitializeComponent();
            pnlLoadMBS.Hide();
            StackForm.Add(this);
        }

        private void Confirm()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            try
            {

                String query = "PROC_AddMember";
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", RandomIDGenerator.GenerateRandomID("Member", "M"));
                command.Parameters.AddWithValue("@Name", txtFullName.Text);
                command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                command.Parameters.AddWithValue("@Address", txtAddressInput.Text);
                command.Parameters.AddWithValue("@Balance", 0);
                if (rdbMale.Checked)
                {
                    command.Parameters.AddWithValue("@Gender","m");
                }
                else if
                (rdbFemale.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "f");
                }
                else
                {
                    command.Parameters.AddWithValue("@Gender", "u");
                }
                string result = (string)command.ExecuteScalar();
                MessageBox.Show(result);
                connection.closeConnection();

                if (result.Contains("thành công"))
                {
                    txtName.Text = txtFullName.Text;
                    txtPhone.Text = txtPhoneNumber.Text;
                    txtAddress.Text = txtAddressInput.Text;
                    pnlLoadMBS.Show();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void btnBuyPackage_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FPurchasePackage());
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FBMIMnagement());
        }
    }
}
