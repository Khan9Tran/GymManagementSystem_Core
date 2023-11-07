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
        public FLogin()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login() == 1)
            {
                

                if(UserInfo())
                {
                    Hide();
                    FHomeUser fHome = new FHomeUser(this);
                    fHome.Show();
                }
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

        private bool UserInfo()
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
                else
                {
                    MessageBox.Show("Đã gặp sự cố, vui lòng khởi động lại");
                    return false;
                }    
            }

            connection.closeConnection();

            return true;

        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Chuyển tới TextBox khác bằng cách gán focus vào TextBox tiếp theo
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Ngăn việc xuất hiện dấu xuống dòng trong TextBox

                // Gọi sự kiện Click của Button
                btnLogin_Click(this, null);
            }
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            txtFullName.Focus();
        }
    }
}
