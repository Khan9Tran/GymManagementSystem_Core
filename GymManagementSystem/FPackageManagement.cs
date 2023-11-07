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

namespace GymManagementSystem
{
    public partial class FPackageManagement : Form
    {
        public FPackageManagement()
        {
            InitializeComponent();
            StackForm.Add(this);
            filter = Filter.all;
            LoadPackage("", filter);
            tool = new ToolForPicture(ToolForPicture.Type.package);
        }

        ToolForPicture tool;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadPackage(txtSearch.Text, filter);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPackage();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdatePackage();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeletePackage();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (filter == Filter.trainer)
                {
                    filter = Filter.noTrainer;
                }
            else
                { filter = Filter.trainer; }
            LoadPackage(txtSearch.Text, filter);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            filter= Filter.all;
            LoadPackage(txtSearch.Text, filter);
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            tool.AddPicture(ofdPackage, ptcImage);
            if (ptcImage.Image != null)
            {
                tool.SavePicture(gvPackage.CurrentRow.Cells["ID"].Value.ToString(),ofdPackage,ptcImage);
            }    
        }

        enum Filter
        {
            all,
            trainer,
            noTrainer
        }

        Filter filter;
        private void LoadPackage(string content, Filter filter)
        {
            try
            {
                DBConnection connection = new DBConnection();
                string query = "PROC_FindAllPackages";
                DataTable dataTable = new DataTable();
                connection.openConnection();
                try
                {

                    SqlCommand command = new SqlCommand(query, connection.GetConnection());
                    command.Parameters.AddWithValue("@FilterType", (int)filter);
                    command.Parameters.AddWithValue("@Content", txtSearch.Text);
                    command.CommandType = CommandType.StoredProcedure;
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
                gvPackage.DataSource = dataTable;
                if (dataTable .Rows.Count > 0)
                {
                    gvPackage.Columns["NumberOfPTSessions"].HeaderText = "PT Sessions";
                }
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddPackage()
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_AddPackage";
            DataTable dataTable = new DataTable();
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                //add value
                command.Parameters.AddWithValue("@ID", RandomIDGenerator.GenerateRandomID("Package","PK"));
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Periods", Convert.ToInt32(txtPeriods.Text));
                command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                command.Parameters.AddWithValue("@Description", txtDesc.Text);
                command.Parameters.AddWithValue("@NumberOfPTSessions", Convert.ToInt32(txtNumberPTSession.Text));
                MessageBox.Show((string)command.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.closeConnection();
            LoadPackage(txtSearch.Text, filter);
        }
        private void UpdatePackage()
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_UpdatePackage";
            DataTable dataTable = new DataTable();
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                //add value
                command.Parameters.AddWithValue("@ID", gvPackage.CurrentRow.Cells["ID"].Value.ToString());
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Periods", Convert.ToInt32(txtPeriods.Text));
                command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                command.Parameters.AddWithValue("@Description", txtDesc.Text);
                command.Parameters.AddWithValue("@NumberOfPTSessions", Convert.ToInt32(txtNumberPTSession.Text));
                MessageBox.Show((string)command.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.closeConnection();
            LoadPackage(txtSearch.Text, filter);
        }
        private void DeletePackage()
        {
            DBConnection connection = new DBConnection();
            string query = "PROC_DeletePackage";
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", gvPackage.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show((string)command.ExecuteScalar());
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.closeConnection();
            LoadPackage(txtSearch.Text, filter);
        }

        private void gvPackage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblID.Text = gvPackage.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = gvPackage.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = gvPackage.CurrentRow.Cells[3].Value.ToString();
                txtDesc.Text = gvPackage.CurrentRow.Cells[4].Value.ToString();
                txtNumberPTSession.Text = gvPackage.CurrentRow.Cells[5].Value.ToString();
                if (txtNumberPTSession.Text == "")
                {
                    txtNumberPTSession.Text = "0";
                }    
                txtPeriods.Text = gvPackage.CurrentRow.Cells[2].Value.ToString();
                tool.GetPicture(gvPackage.CurrentRow.Cells[0].Value.ToString(), ptcImage);
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
