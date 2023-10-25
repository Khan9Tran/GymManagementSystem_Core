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
            gvMember.DataSource = LoadMember(Filter.None, "");
        }

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
    }
}
