﻿using GymManagementSystem.Common;
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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class FPurchasePackage : Form
    {
        private static FPurchasePackage instance;
        private string paymentID = RandomIDGenerator.GenerateRandomID("Payment", "PM");
        private string branchID = Employee.BranchID;
        private string employeeID = Employee.UserID;

        private string memberID;
        private double memberBalance;
        private string packageID;
        private double packagePrice;
        private double packageDiscount;
        private double discountAmount;
        private double paymentAmount;

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
                string packageID = row[0].ToString();
                string packageName = row[1].ToString();
                string packagePeriods = row[2].ToString();
                string packagePrice = row[3].ToString();
                string packageDesctiption = row[4].ToString();
                string packageNOPTSessions = row[5].ToString();
                if (packageNOPTSessions == "")
                {
                    packageNOPTSessions = "0";
                }
                USPackage package = new USPackage(packageID, packageName, packagePeriods, packagePrice, packageDesctiption, packageNOPTSessions);
                flpContainerPackage.Controls.Add(package);
            }

            instance = this;
            StackForm.Add(this);
        }

        private void fillPackageToUSPackage(DataTable packageTable)
        {
            flpContainerPackage.Controls.Clear();
            foreach (DataRow row in packageTable.Rows)
            {
                string packageID = row[0].ToString();
                string packageName = row[1].ToString();
                string packagePeriods = row[2].ToString();
                string packagePrice = row[3].ToString();
                string packageDesctiption = row[4].ToString();
                string packageNOPTSessions = row[5].ToString();
                if (packageNOPTSessions == "")
                {
                    packageNOPTSessions = "0";
                }
                USPackage package = new USPackage(packageID, packageName, packagePeriods, packagePrice, packageDesctiption, packageNOPTSessions);
                flpContainerPackage.Controls.Add(package);
            }
        }

        private void btnHaveTrainer_Click(object sender, EventArgs e)
        {
            btnHaveTrainer.BackColor = Color.FromArgb(40, 181, 244);
            btnNoTrainer.BackColor = Color.FromArgb(255, 255, 255);
            btnHaveTrainer.ForeColor = Color.White;
            btnNoTrainer.ForeColor = Color.FromArgb(59, 41, 55);

            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "SELECT * FROM V_PackageListHasTrainer ";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable packageTable = new DataTable();
            adapter.Fill(packageTable);
            connection.closeConnection();

            fillPackageToUSPackage(packageTable);
        }

        private void btnNoTrainer_Click(object sender, EventArgs e)
        {
            btnNoTrainer.BackColor = Color.FromArgb(40, 181, 244);
            btnHaveTrainer.BackColor = Color.FromArgb(255, 255, 255);
            btnHaveTrainer.ForeColor = Color.FromArgb(59, 41, 55);
            btnNoTrainer.ForeColor = Color.White;

            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "SELECT * FROM V_PackageListNoTrainer ";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable packageTable = new DataTable();
            adapter.Fill(packageTable);
            connection.closeConnection();

            fillPackageToUSPackage(packageTable);
        }

        public static void showDetailPackage(string packageID, string packageName, string packagePeriods, string packagePrice, string packageDesctiption, string packageNOPTSessions)
        {
            if (instance != null)
            {
                instance.packageID = packageID;
                instance.packagePrice = Double.Parse(packagePrice);
                instance.discountAmount = instance.packageDiscount * instance.packagePrice;
                instance.paymentAmount = (instance.packagePrice - instance.discountAmount) - instance.memberBalance;
                double tempBalance = 0;

                if ((instance.packagePrice - instance.discountAmount) >= instance.memberBalance)
                {
                    instance.paymentAmount = instance.packagePrice - instance.memberBalance;
                    tempBalance = 0;
                }
                else
                {
                    instance.paymentAmount = 0;
                    tempBalance = instance.memberBalance - instance.packagePrice;
                }

                instance.lblDiscount.Text = ConverToMoney.conver(instance.discountAmount.ToString());
                instance.lblDiscountUnit.Text = "VND";
                instance.lblTotalPayment.Text = ConverToMoney.conver(instance.paymentAmount.ToString());
                instance.lblDetailPkName.Text = packageName;
                instance.lblBalance.Text = ConverToMoney.conver(tempBalance.ToString());
                instance.lblDetailPkPeriod.Text = packagePeriods;
                instance.lblDetailPkPrice.Text = Math.Round(Convert.ToDouble(packagePrice), 3).ToString();

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

        private void btnSearchByPhone_Click(object sender, EventArgs e)
        {
            if (tbxPhoneNumber.Text.Length == 10)
            {
                try
                {
                    DBConnection connection = new DBConnection();
                    connection.openConnection();
                    String query = "PROC_PaymentByPhoneNumber";
                    SqlCommand command = new SqlCommand(query, connection.GetConnection());
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PhoneNumber", tbxPhoneNumber.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable memberTable = new DataTable();
                    adapter.Fill(memberTable);
                    connection.closeConnection();

                    DataRow member = memberTable.Rows[0];
                    memberID = member[0].ToString();
                    packageDiscount = Math.Round(Convert.ToDouble(member[4]), 3);
                    memberBalance = Convert.ToDouble(member[2]);

                    lblMemberName.Text = member[1].ToString();
                    lblBalance.Text = ConverToMoney.conver(Math.Round(Convert.ToDouble(member[2]), 3).ToString());
                    lblDiscount.Text = (packageDiscount * 100).ToString();
                    lblDiscountUnit.Text = "%";
                    lblDetailPkName.Text = "";
                    lblDetailPkPeriod.Text = "";
                    lblDetailPkPrice.Text = "";
                    lblDetailPkTrainer.Text = "";
                    lblDetailNOTSestion.Text = "";
                    lblDetailPkDescription.Text = "";
                    lblTotalPayment.Text = "";
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

        private void btnBuy_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO dbo.Payment VALUES (@ID, @Date, @Note, @PaymentAmount, @BranchID, @PackageID, @MemberID, @EmployeeID)";
            DBConnection connection = new DBConnection();
            DataTable dataTable = new DataTable();
            connection.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@ID", paymentID);
                command.Parameters.AddWithValue("@Date", DateTime.Now);
                command.Parameters.AddWithValue("@Note", "Empty");
                command.Parameters.AddWithValue("@PaymentAmount", packagePrice);
                command.Parameters.AddWithValue("@BranchID", branchID);
                command.Parameters.AddWithValue("@PackageID", packageID);
                command.Parameters.AddWithValue("@MemberID", memberID);
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.ExecuteScalar();
                paymentID = RandomIDGenerator.GenerateRandomID("Payment", "PM");
                MessageBox.Show("Success!!!", "Message");
                lblMemberName.Text = "";
                tbxPhoneNumber.Text = "";
                lblDetailPkName.Text = "";
                lblDetailPkPeriod.Text = "";
                lblDetailPkPrice.Text = "";
                lblDetailPkTrainer.Text = "";
                lblDetailNOTSestion.Text = "";
                lblDetailPkDescription.Text = "";
                lblBalance.Text = "";
                lblDiscount.Text = "";
                lblTotalPayment.Text = "";
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
        }
    }
}
