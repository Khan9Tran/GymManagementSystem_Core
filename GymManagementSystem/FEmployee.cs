using GymManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace GymManagementSystem
{
    public partial class FEmployee : Form
    {
        private int pass = 0;
        private int management = 0;
        public FEmployee()
        {
            InitializeComponent();
            LoadInfo();
            pnlPass.Hide();
            pnlLoadManagement.Hide();
            LoadEmployee();
            LoadBranch();
            StackForm.Add(this);
        }

        private void LoadInfo()
        {
            txtYourBranch.Text = Employee.BranchName;
            txtYourUser.Text = Employee.UserName;
            if (Employee.Role == 1)
            {
                txtYourRole.Text = "Super Admin";
            } 
            else if (Employee.Role == 2) 
            {
                txtYourRole.Text = "Manager";
            }    
            else
            {
                txtYourRole.Text = "Staff";
            }
            txtYourName.Text = Employee.Name;

        }
        private void LoadBranch()
        {
            DBConnection connection = new DBConnection();
            string query = "SELECT * FROM V_BranchList";
            DataTable dataTable = new DataTable();
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.closeConnection();
            }
            cbxBranch.DataSource = dataTable;
            cbxBranch.DisplayMember = "Name";

        }
        private void txtChangePass_Click(object sender, EventArgs e)
        {
            if (pass == 0)
            {
                pnlPass.Show();
                pass = 1;
            }
            else
            {
                pnlPass.Hide();
                pass = 0;
            }    
        }

        private void txtManagement_Click(object sender, EventArgs e)
        {
            if (Employee.Role == 0)
            {
                MessageBox.Show("Chỉ Admin, Manager mới truy cập được chức năng này");
            }
            else
            {

                if (management == 0)
                {
                    pnlLoadManagement.Show();
                    management = 1;
                }
                else
                {
                    pnlLoadManagement.Hide();
                    management = 0;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertEmployee();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateEmployee();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetPassword();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadEmployee();
            txtSearch.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindEmployee(txtSearch.Text);
        }

        private void gvEmployee_Click(object sender, EventArgs e)
        {

        }

        private void LoadEmployee()
        {
            DBConnection connection = new DBConnection();
            string query = "SELECT * FROM V_EmployeeList";
            DataTable dataTable = new DataTable();
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.closeConnection();
            }
            gvEmployee.DataSource = dataTable;
            gvEmployee.Columns["Password"].Visible = false;
            gvEmployee.Columns["BranchID"].Visible = false;
        }

        private void txtStaff_Click(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            string query = "SELECT * FROM V_EmployeeList WHERE Role = '0'";
            DataTable dataTable = new DataTable();
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.closeConnection();
            }
            gvEmployee.DataSource = dataTable;
            gvEmployee.Columns["Password"].Visible = false;
            gvEmployee.Columns["BranchID"].Visible = false;
            txtSearch.Clear();
        }

        private void txtAdmin_Click(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            string query = "SELECT * FROM V_EmployeeList WHERE Role = '1'";
            DataTable dataTable = new DataTable();
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.closeConnection();
            }
            gvEmployee.DataSource = dataTable;
            gvEmployee.Columns["Password"].Visible = false;
            gvEmployee.Columns["BranchID"].Visible = false;
            txtSearch.Clear();
        }

        private void txtManager_Click(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            string query = "SELECT * FROM V_EmployeeList WHERE Role = '2'";
            DataTable dataTable = new DataTable();
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.closeConnection();
            }
            gvEmployee.DataSource = dataTable;
            gvEmployee.Columns["Password"].Visible = false;
            gvEmployee.Columns["BranchID"].Visible = false;
            txtSearch.Clear();
        }

        private void FindEmployee(string content)
        {
            DBConnection connection = new DBConnection();
            string query = "SELECT * FROM dbo.FUNC_FindEmployee(@Content)";
            DataTable dataTable = new DataTable();
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.AddWithValue("@Content", content);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.closeConnection();
            }
            gvEmployee.DataSource = dataTable;
            gvEmployee.Columns["Password"].Visible = false;
            gvEmployee.Columns["BranchID"].Visible = false;
        }

        private void InsertEmployee()
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_AddEmployee";
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", RandomIDGenerator.GenerateRandomID("Employee","E"));
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@UserName", txtUSer.Text);
                command.Parameters.AddWithValue("@Role", cbxRole.SelectedIndex.ToString());
                command.Parameters.AddWithValue("@YourRole", Employee.Role);
                command.Parameters.AddWithValue("@BranchID", (cbxBranch.SelectedItem as DataRowView)["ID"].ToString());
                command.Parameters.AddWithValue("@Password", txtPass.Text);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return;
            }
            connection.closeConnection();
            MessageBox.Show("Thêm thành công");
            LoadEmployee();

        }

        private void gvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtName.Text = gvEmployee.CurrentRow.Cells["Name"].Value.ToString();
                txtUSer.Text = gvEmployee.CurrentRow.Cells["UserName"].Value.ToString();
                txtPass.Text = gvEmployee.CurrentRow.Cells["Password"].Value.ToString();
                cbxRole.SelectedIndex = int.Parse(gvEmployee.CurrentRow.Cells["Role"].Value.ToString());

                foreach (DataRowView item in cbxBranch.Items)
                {
                    if (item["ID"].ToString() == gvEmployee.CurrentRow.Cells["BranchID"].Value.ToString())
                    {
                        cbxBranch.SelectedIndex = cbxBranch.Items.IndexOf(item);
                        break;
                    }
                }
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ResetPassword()
        {
            if (Employee.Role == 2 && gvEmployee.CurrentRow.Cells["Role"].Value.ToString() == "1")
            {
                MessageBox.Show("Bạn không có đủ quyền");
                return;
            }    

            DBConnection connection = new DBConnection();
            string query = "PROC_ResetPasswordToDefault";
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", gvEmployee.CurrentRow.Cells["ID"].Value.ToString());
                command.Parameters.AddWithValue("@YourRole", Employee.Role);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return;
            }
            connection.closeConnection();
            MessageBox.Show("Reset thành công: password mới là 123456");
        }

        private void UpdateEmployee()
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_UpdateEmployeeInfo";
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@UserName", txtUSer.Text);
                command.Parameters.AddWithValue("@Role", cbxRole.SelectedIndex.ToString());
                command.Parameters.AddWithValue("@BranchID", (cbxBranch.SelectedItem as DataRowView)["ID"].ToString());
                command.Parameters.AddWithValue("@YourRole", Employee.Role);
                command.Parameters.AddWithValue("@Password", txtPass.Text);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return;
            }
            connection.closeConnection();
            MessageBox.Show("Cập nhật thành công");
            LoadEmployee();

        }

        private void DeleteEmployee()
        {  
            DBConnection connection = new DBConnection();
            string query = "PROC_DeleteEmployee";
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName", txtUSer.Text);
                command.Parameters.AddWithValue("@YourRole", Employee.Role);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return;
            }
            connection.closeConnection();
            MessageBox.Show("Xóa thành công");
            LoadEmployee();
        }
        private void ChangePass()
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_ChangePassword";
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Password", txtPassword.Text);
                command.Parameters.AddWithValue("@UserName", txtYourName.Text);
                command.Parameters.AddWithValue("@NewPassword", txtNewPass.Text);
                command.Parameters.AddWithValue("@ReEnterPassword", txtReEnterPass.Text);
                MessageBox.Show((string)command.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return;
            }
            connection.closeConnection();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ChangePass();
        }
    }
}
