using GymManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace GymManagementSystem
{
    public partial class FMembershipManagement : Form
    {
        private MembershipType memberships;
        public FMembershipManagement()
        {
            InitializeComponent();
            List<MembershipType> memberships = LoadMembershipType();
            foreach(MembershipType membership in memberships) 
            {
                USMembership uSMembership = new USMembership(membership);
                uSMembership.membershipClicked += MembershipType_MembershipType;
                flpnlLoadMembership.Controls.Add(uSMembership);
            }
        }


        private List<MembershipType>  ConvertDataTableToMembershipType(DataTable dataTable) 
        {
            List<MembershipType> list = new List<MembershipType>();

            foreach (DataRow row in dataTable.Rows)
            {
                MembershipType mbt = new MembershipType(row["ID"].ToString(), float.Parse(row["Rate"].ToString()), row["Rank"].ToString());
                list.Add(mbt);
            }

            return list;
        }
        private List<MembershipType> LoadMembershipType()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();

            String query = "SELECT * FROM V_MembershipType";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.closeConnection();
            return ConvertDataTableToMembershipType(dataTable);
        }

        private void MembershipType_MembershipType(object? sender, EventArgs e)
        {
            USMembership clicked = (USMembership)sender;
            memberships = clicked.Membership;
            txtRank.Text = clicked.Membership.Rank;
            txtRate.Text = clicked.Membership.Rate.ToString();
            foreach (var ctr in flpnlLoadMembership.Controls)
            {
                if (((USMembership)ctr).Membership.ID != clicked.Membership.ID)
                {
                    ((USMembership)ctr).changeColor(0);

                }
                else
                {
                    ((USMembership)ctr).changeColor(1);
                }
            }
            DBConnection connection = new DBConnection();
            connection.openConnection();

            string query = "SELECT dbo.FUNC_FindNumberOfMemberByMemberShip(@MembershipID)";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.Parameters.AddWithValue("@MembershipID", clicked.Membership.ID);
            txtNumberOfMember.Text = "Number of members: " + (int)command.ExecuteScalar();
            connection.closeConnection();


        }

        ToolForPicture toolForPicture = new ToolForPicture(ToolForPicture.Type.membership);
        private void btnImage_Click(object sender, EventArgs e)
        {
            if (memberships != null)
            {
                PictureBox getPic = null;
                foreach (var ctr in flpnlLoadMembership.Controls)
                {
                    if (((USMembership)ctr).Membership.ID != memberships.ID)
                    {
                        continue;
                    }
                    getPic = ((USMembership)ctr).ChangeCard();
                }

                OpenFileDialog openFileDialog = new OpenFileDialog();
                toolForPicture.AddPicture(openFileDialog, getPic);
                toolForPicture.SavePicture(memberships.ID, openFileDialog, getPic);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Update();
        }
        private bool Update()
        {
            if (memberships != null)
            {
                DBConnection connection = new DBConnection();
                connection.openConnection();
                try
                {
                    String query = "UPDATE MembershipType SET Rank = @Rank, Rate = @Rate WHERE ID = @ID ";
                    SqlCommand command = new SqlCommand(query, connection.GetConnection());
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@Rank", txtRank.Text);
                    command.Parameters.AddWithValue("@Rate", float.Parse(txtRate.Text));
                    command.Parameters.AddWithValue("ID", memberships.ID);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); 
                    connection.closeConnection();
                    return false;
                }
                connection.closeConnection();
                flpnlLoadMembership.Controls.Clear();
                List<MembershipType> membershipsL = LoadMembershipType();
                foreach (MembershipType membership in membershipsL)
                {
                    USMembership uSMembership = new USMembership(membership);
                    uSMembership.membershipClicked += MembershipType_MembershipType;
                    flpnlLoadMembership.Controls.Add(uSMembership);
                }
                MessageBox.Show("Cập nhật thành công");
            }
            return true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            gvMbs.DataSource = ListMemberWithTotalPaymentAmount();
        }

        private DataTable ListMemberWithTotalPaymentAmount()
        {

            DBConnection connection = new DBConnection();
            connection.openConnection();

            String query = "SELECT * FROM FUNC_ListMemberWithTotalPaymentAmount(@StartDate, @EndDate)";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.Parameters.AddWithValue("@StartDate", dtpStart.Value.Date);
            command.Parameters.AddWithValue("@EndDate", dtpEnd.Value.Date);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.closeConnection();
            return dataTable;
        }


        private void NewSeason()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "PROC_NewSeason";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@StartDate", dtpStart.Value.Date);
            command.Parameters.AddWithValue("@EndDate", dtpEnd.Value.Date);
            command.ExecuteNonQuery();
            connection.closeConnection();
            MessageBox.Show("Cập nhật hạng thành công");
        }

        private void btnNewSeason_Click(object sender, EventArgs e)
        {
            NewSeason();
            flpnlLoadMembership.Controls.Clear();
            List<MembershipType> memberships = LoadMembershipType();
            foreach (MembershipType membership in memberships)
            {
                USMembership uSMembership = new USMembership(membership);
                uSMembership.membershipClicked += MembershipType_MembershipType;
                flpnlLoadMembership.Controls.Add(uSMembership);
            }
        }
    }
}
