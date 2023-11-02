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
    public partial class FMemberManagement : Form
    {
        public FMemberManagement()
        {
            InitializeComponent();
            filter = Filter.None;
            gvMember.DataSource = LoadMember(filter, "");
            try
            {
                gvMember.Columns[2].Visible = false;
                gvMember.Columns[3].HeaderText = "Phone";
                gvMember.Columns[6].HeaderText = "Rank";
                gvMember.Columns[7].HeaderText = "Package";
                gvMember.Columns[8].Visible = false;
                gvMember.Columns[9].Visible = false;
            }
            catch
            (Exception ex)
            {

            }
        }

        Filter filter;

        private enum Filter
        {
            None,
            StillValid,
            OutOfDate
        }

        private DataTable LoadMember(Filter type, string search)
        {
            String query = "PROC_FindAllMember";
            DBConnection connection = new DBConnection();
            DataTable dataTable = new DataTable();

            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FilterType", (int)type);
                command.Parameters.AddWithValue("@Content", txtSearch.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.closeConnection();
            }
            return dataTable;

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            filter = Filter.None;
            gvMember.DataSource = LoadMember(filter, txtSearch.Text);
        }


        private void btnExpired_Click(object sender, EventArgs e)
        {
            filter = Filter.OutOfDate;
            gvMember.DataSource = LoadMember(filter, txtSearch.Text);
            try
            {
                gvMember.Columns[2].Visible = false;
                gvMember.Columns[3].HeaderText = "Phone";
                gvMember.Columns[6].HeaderText = "Rank";
                gvMember.Columns[7].HeaderText = "Package";
                gvMember.Columns[8].Visible = false;
                gvMember.Columns[9].Visible = false;
            }
            catch
            (Exception ex)
            {

            }
        }

        private void btnStillValid_Click(object sender, EventArgs e)
        {

            filter = Filter.StillValid;
            gvMember.DataSource = LoadMember(filter, txtSearch.Text);
            try
            {
                gvMember.Columns[2].Visible = false;
                gvMember.Columns[3].HeaderText = "Phone";
                gvMember.Columns[6].HeaderText = "Rank";
                gvMember.Columns[7].HeaderText = "Package";
                gvMember.Columns[8].Visible = false;
                gvMember.Columns[9].Visible = false;
            }
            catch
            (Exception ex)
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gvMember.DataSource = LoadMember(filter, txtSearch.Text);
            try
            {
                gvMember.Columns[2].Visible = false;
                gvMember.Columns[3].HeaderText = "Phone";
                gvMember.Columns[6].HeaderText = "Rank";
                gvMember.Columns[7].HeaderText = "Package";
                gvMember.Columns[8].Visible = false;
                gvMember.Columns[9].Visible = false;
            }
            catch
            (Exception ex)
            {

            }
        }

        private void gvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFullName.Text = gvMember.CurrentRow.Cells["Name"].Value.ToString();
            txtPhone.Text = gvMember.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            if (gvMember.CurrentRow.Cells["Gender"].Value.ToString() == "m")
                txtGender.Text = "Male";
            else if (gvMember.CurrentRow.Cells["Gender"].Value.ToString() == "f")
                txtGender.Text = "Female";
            else
                txtGender.Text = "Unknown";
            txtAddress.Text = gvMember.CurrentRow.Cells["Address"].Value.ToString();
            lblBalance.Text = "Balance " + gvMember.CurrentRow.Cells["Balance"].Value.ToString() + "đ";
            lblPackage.Text = gvMember.CurrentRow.Cells["MemberPackage"].Value.ToString();
            lblRemainingTS.Text = "Session with PT " + gvMember.CurrentRow.Cells["RemainingTS"].Value.ToString();
            try
            {
                lblDate.Text = ((DateTime)gvMember.CurrentRow.Cells["EndOfPackageDate"].Value).ToString("dd/MM/yyyy");
            }
            catch
            {
                lblDate.Text = "Unknown";
            }
            LoadMembership();
            LoadBMI();
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FPurchasePackage());
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FBMIMnagement());
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FCreateMember());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Update())
            {
                MessageBox.Show("Cập nhật thành công");
            }    

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            try
            {

                String query = "DELETE Member WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@ID", gvMember.CurrentRow.Cells["ID"].Value.ToString());
                command.ExecuteNonQuery();
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return;
            }
            MessageBox.Show("Xóa thành công");
            connection.closeConnection();
            gvMember.DataSource = LoadMember(filter, txtSearch.Text);
            return;
        }
        private bool Update()
    {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            try
            {

                String query = "PROC_UpdateMember";
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", txtFullName.Text);
                command.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
                command.Parameters.AddWithValue("@Address", txtAddress.Text);
                command.Parameters.AddWithValue("@Gender", txtGender.Text);
                command.Parameters.AddWithValue("@ID", gvMember.CurrentRow.Cells["ID"].Value.ToString());
                command.ExecuteNonQuery();
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connection.closeConnection();
            }
            gvMember.DataSource = LoadMember(filter, txtSearch.Text);
            return true;
        }


        ToolForPicture tfPicture = new ToolForPicture(ToolForPicture.Type.membership);
        private void LoadMembership()
        {
            DBConnection connection = new DBConnection();
            string cardName = null;
            connection.openConnection();
            try
            {
                String query = "SELECT dbo.FUNC_FindMembershipByRank(@Rank)";
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.AddWithValue("@Rank", gvMember.CurrentRow.Cells["MemberRank"].Value.ToString());
                cardName = (string)command.ExecuteScalar();
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.closeConnection();
            }
            if (cardName != null && cardName != "None")
                tfPicture.GetPicture(cardName, ptcRank);
        }

        private void LoadBMI()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();

            String query = "PROC_LatestBMI";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            //khai báo các thuộc tính của tham số
            command.Parameters.AddWithValue("@MemberID", gvMember.CurrentRow.Cells["ID"].Value.ToString());

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblStatus.Text = "Status: " +reader["Status"].ToString();
                        lblWeight.Text = reader["Weight"].ToString() + " kg";
                        lblHeight.Text = reader["Height"].ToString() + " cm";
                    }
                }
                else
                {
                    lblStatus.Text = "Status: No Record";
                    lblWeight.Text = "";
                    lblHeight.Text = "";
                }
            }

            connection.closeConnection();

        }
    }
}
