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
            lblBalance.Text = "Balance " + gvMember.CurrentRow.Cells["Balance"].Value.ToString() +"đ";
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
        }
    }
}
