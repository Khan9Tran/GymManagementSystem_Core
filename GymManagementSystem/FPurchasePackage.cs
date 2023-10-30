using GymManagementSystem.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class FPurchasePackage : Form
    {
        private static FPurchasePackage instance;

        public FPurchasePackage()
        {
            InitializeComponent();

            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "SELECT * FROM V_PackageList";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable packageTable = new DataTable();
            adapter.Fill(packageTable);
            connection.closeConnection();

            foreach (DataRow row in packageTable.Rows)
            {
                string packageName = row[1].ToString();
                string packagePeriods = row[2].ToString();
                string packagePrice = row[3].ToString();
                string packageDesctiption = row[4].ToString();
                string packageNOPTSessions = row[5].ToString();
                if (packageNOPTSessions == "")
                {
                    packageNOPTSessions = "0";
                }
                USPackage package = new USPackage(packageName, packagePeriods, packagePrice, packageDesctiption, packageNOPTSessions);
                flpContainerPackage.Controls.Add(package);
            }

            instance = this;
        }

        private void btnHaveTrainer_Click(object sender, EventArgs e)
        {
            btnHaveTrainer.BackColor = Color.FromArgb(40, 181, 244);
            btnNoTrainer.BackColor = Color.FromArgb(255, 255, 255);
            btnHaveTrainer.ForeColor = Color.White;
            btnNoTrainer.ForeColor = Color.FromArgb(59, 41, 55);
        }

        private void btnNoTrainer_Click(object sender, EventArgs e)
        {
            btnNoTrainer.BackColor = Color.FromArgb(40, 181, 244);
            btnHaveTrainer.BackColor = Color.FromArgb(255, 255, 255);
            btnHaveTrainer.ForeColor = Color.FromArgb(59, 41, 55);
            btnNoTrainer.ForeColor = Color.White;

            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "SELECT * FROM ";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable packageTable = new DataTable();
            adapter.Fill(packageTable);
            connection.closeConnection();

            foreach (DataRow row in packageTable.Rows)
            {
                string packageName = row[1].ToString();
                string packagePeriods = row[2].ToString();
                string packagePrice = row[3].ToString();
                string packageDesctiption = row[4].ToString();
                string packageNOPTSessions = row[5].ToString();
                if (packageNOPTSessions == "")
                {
                    packageNOPTSessions = "0";
                }
                USPackage package = new USPackage(packageName, packagePeriods, packagePrice, packageDesctiption, packageNOPTSessions);
                flpContainerPackage.Controls.Add(package);
            }
        }

        public static void showDetailPackage(string packageName, string packagePeriods, string packagePrice, string packageDesctiption, string packageNOPTSessions)
        {
            if (instance != null)
            {
                instance.lblDetailPkName.Text = packageName;
                instance.lblDetailPkPeriod.Text = packagePeriods;
                instance.lblDetailPkPrice.Text = packagePrice;
                if (packageNOPTSessions == "")
                {
                    instance.lblDetailPkTrainer.Text = "No";
                }
                else
                {
                    instance.lblDetailPkTrainer.Text = "Yes";
                }
                instance.lblDetailNOTSestion.Text = packageNOPTSessions;
                instance.lblDetailPkDescription.Text = packageDesctiption;
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (tbxPhoneNumber.Text.Length == 10)
            {
                try
                {
                    DBConnection connection = new DBConnection();
                    connection.openConnection();
                    String query = "PROC_FindMemberByPhoneNumber";
                    SqlCommand command = new SqlCommand(query, connection.GetConnection());
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PhoneNumber", tbxPhoneNumber.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable memberTable = new DataTable();
                    adapter.Fill(memberTable);
                    connection.closeConnection();

                    DataRow member = memberTable.Rows[0];
                    lblMemberName.Text = member[1].ToString();
                }
                catch
                {
                    string message = "Số điện thoại không tồn tại!!!";
                    string title = "Error";
                    MessageBox.Show(message, title);
                }

            }
            else
            {
                string message = "Số điện thoại không hợp lệ!!!";
                string title = "Error";
                MessageBox.Show(message, title);
            }
        }
    }
}
