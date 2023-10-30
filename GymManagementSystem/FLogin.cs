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
    public partial class FLogin : Form
    {
        private Panel pnlFull;
        OpenChildForm openChildForm;
        FHomeUser home;
        public FLogin()
        {
            InitializeComponent();
            home = new FHomeUser();
            pnlFull = new Panel();
            pnlFull.Dock = DockStyle.Fill;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login() == 1)
            {
                this.Controls.Clear();
                this.Controls.Add(pnlFull);
                openChildForm = new OpenChildForm(pnlFull);
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;


                UserInfo();

                openChildForm.Open(home);
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
        }
        private int Login()
        {
            int tmp = 0;
            DBConnection connection = new DBConnection();
            string query = "SELECT dbo.FUNC_LoginAuthentication(@UserName, @Password)";
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.AddWithValue("@UserName", txtFullName.Text);
                command.Parameters.AddWithValue("@Password", txtPassword.Text);
                tmp = ((int)command.ExecuteScalar());
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return 0;
            }
            connection.closeConnection();
            return tmp;
        }

        private void UserInfo()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();

            String query = "PROC_UserInfo";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            //khai báo các thuộc tính của tham số
            command.Parameters.AddWithValue("@Username", txtFullName.Text);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Employee.UserID = reader["EmployeeID"].ToString();
                        Employee.Name = reader["Name"].ToString();
                        Employee.BranchID = reader["ID"].ToString();
                        Employee.Password = reader["Password"].ToString();
                        Employee.BranchName = reader["BranchName"].ToString();
                        Employee.UserName = reader["UserName"].ToString();
                        Employee.Role = int.Parse(reader["Role"].ToString());

                    }
                }
            }

            connection.closeConnection();

        }
    }
}
