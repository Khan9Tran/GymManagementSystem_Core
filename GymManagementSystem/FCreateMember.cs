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
        }

        private void Confirm()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            try
            {

                String query = "INSERT INTO Member(ID, Name, PhoneNumber, Address, Balance, Gender) VALUES (@ID, @Name, @PhoneNumber, @Address, @Balance, @Gender)";
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@ID", txtID.Text);
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
                command.ExecuteNonQuery();
                connection.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Đăng ký thành công");
            txtName.Text = txtFullName.Text;
            txtPhone.Text = txtPhoneNumber.Text;
            txtAddress.Text = txtAddressInput.Text;
            pnlLoadMBS.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Confirm();
        }

    }
}
