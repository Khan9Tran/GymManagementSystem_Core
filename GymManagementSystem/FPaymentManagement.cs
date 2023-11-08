using GymManagementSystem.Common;
using GymManagementSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace GymManagementSystem
{
    public partial class FPaymentManagement : Form
    {
        private double totalIncome;
        private double totalExpense;
        private double fundBalance;
        private DataTable paymentPurchaseTable;
        private DataTable maintenanceTable;
        public FPaymentManagement()
        {
            InitializeComponent();
            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "PROC_PaymentPackageList";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable paymentPurchaseTable = new DataTable();
            adapter.Fill(paymentPurchaseTable);
            this.paymentPurchaseTable = paymentPurchaseTable;
            dgvListData.DataSource = paymentPurchaseTable;
            connection.closeConnection();

            calcAndShow();
            StackForm.Add(this);

        }

        private void calcAndShow()
        {
            totalIncome = caclTotalIncome();
            totalExpense = caclTotalExpense();
            fundBalance = calcFundBalance();
            lblTotalIncome.Text = ConverToMoney.conver(totalIncome.ToString());
            lblTotalExpense.Text = ConverToMoney.conver(totalExpense.ToString());
            lblFundBalance.Text = ConverToMoney.conver(fundBalance.ToString());
        }

        private double caclTotalIncome()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "PROC_CalcSum";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TableName", "Payment");
            command.Parameters.AddWithValue("@ColumnName", "PaymentAmount");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable totalIncomeTable = new DataTable();
            adapter.Fill(totalIncomeTable);

            DataRow totalIncomeRow = totalIncomeTable.Rows[0];
            if (totalIncomeRow[0].ToString() != "")
            {
                return Math.Round(Convert.ToDouble(totalIncomeRow[0]), 3);
            }
            else
            {
                return 0;
            }
        }

        private double caclTotalExpense()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "PROC_CalcSum";
            query = "PROC_CalcSum";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TableName", "MaintenanceData");
            command.Parameters.AddWithValue("@ColumnName", "Cost");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable totalExpenseTable = new DataTable();
            adapter.Fill(totalExpenseTable);
            connection.closeConnection();

            DataRow totalExpenseRow = totalExpenseTable.Rows[0];
            if (totalExpenseRow[0].ToString() != "")
            {
                return Math.Round(Convert.ToDouble(totalExpenseRow[0]), 3);
            }
            else
            {
                return 0;
            }
        }

        private double calcFundBalance()
        {
            double temp = totalIncome - totalExpense;
            if (temp > 0)
            {
                return temp;
            }
            else
            {
                return 0;
            }
        }

        private void loadListIncome()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "PROC_PaymentPackageList";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable paymentPurchaseTable = new DataTable();
            adapter.Fill(paymentPurchaseTable);
            this.paymentPurchaseTable = paymentPurchaseTable;
            dgvListData.DataSource = paymentPurchaseTable;
            connection.closeConnection();
        }

        private void btnShowListIncome_Click(object sender, EventArgs e)
        {
            loadListIncome();
        }

        private void loadListExpense()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "PROC_PaymentEquipmentMaintenanceList";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable maintenanceDataTable = new DataTable();
            adapter.Fill(maintenanceDataTable);
            this.maintenanceTable = maintenanceDataTable;
            dgvListData.DataSource = maintenanceDataTable;
            connection.closeConnection();
        }

        private void btnShowListExpense_Click(object sender, EventArgs e)
        {
            loadListExpense();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Employee.Role != 1)
            {
                MessageBox.Show("Bạn không đủ quyền thực hiện thao tác này!!!");
                return;
            }
            String id = dgvListData.CurrentRow.Cells["ID"].Value.ToString()!;
            if (id.Contains("PM"))
            {
                DBConnection connection = new DBConnection();
                connection.openConnection();
                try
                {
                    String query = "DELETE Payment WHERE ID = @ID";
                    SqlCommand command = new SqlCommand(query, connection.GetConnection());
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ID", id);
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
                loadListIncome();
                calcAndShow();
                connection.closeConnection();
            }
            else
            {
                if (id.Contains("ED"))
                {
                    DBConnection connection = new DBConnection();
                    connection.openConnection();
                    try
                    {
                        String query = "DELETE MaintenanceData WHERE ID = @ID";
                        SqlCommand command = new SqlCommand(query, connection.GetConnection());
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@ID", id);
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
                    loadListExpense();
                    calcAndShow();
                    connection.closeConnection();
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxPhoneNumber.Text.Length == 10)
            {
                try
                {
                    DBConnection connection = new DBConnection();
                    connection.openConnection();
                    String query = "PROC_FindListPaymentByPhoneNumber";
                    SqlCommand command = new SqlCommand(query, connection.GetConnection());
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PhoneNumber", tbxPhoneNumber.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable listPaymentTable = new DataTable();
                    adapter.Fill(listPaymentTable);
                    connection.closeConnection();
                    if(listPaymentTable.Rows.Count > 0)
                    {
                        dgvListData.DataSource = listPaymentTable;
                    }
                    else
                    {
                        string message = "Số điện thoại không tồn tại!!!";
                        string title = "Error";
                        MessageBox.Show(message, title);
                    }
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            listOptionExport.Show(1700, 200);
        }

        private void exportDatatableToCSV(DataTable dataTable, string fileName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";
            saveFileDialog.Title = "Save CSV File";
            saveFileDialog.FileName = fileName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.UTF8))
                {
                    // Ghi header
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        sw.Write(dataTable.Columns[i].ColumnName);
                        if (i < dataTable.Columns.Count - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();

                    // Ghi dữ liệu
                    foreach (DataRow row in dataTable.Rows)
                    {
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            sw.Write(row[i].ToString());
                            if (i < dataTable.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show("Save success!!!");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exportDatatableToCSV(paymentPurchaseTable, "listIncome");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            exportDatatableToCSV(maintenanceTable, "listExpense");
        }

        private void FPaymentManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
