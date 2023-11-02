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
using System.Windows.Forms.DataVisualization.Charting;

namespace GymManagementSystem
{
    public partial class FBMIMnagement : Form
    {
        public FBMIMnagement()
        {
            InitializeComponent();
            LoadAllBMI();
            pnlChart.Controls.Add(chartBMI);
            chartBMI.Show();
            chartBMI.Series.Clear();
            StackForm.Add(this);
        }


        void CreateChart(DataTable data)
        {
            if (data.Rows.Count <= 2)
            {
                MessageBox.Show("Dữ liệu BMI quá ít");
                chartBMI.Series.Clear();
            }
            else
            {
                chartBMI.Series.Clear();
                // Tạo một series mới cho đồ thị BMI
                Series bmiSeries = new Series("BMI");
                int index = 1;
                // Thêm dữ liệu vào series
                foreach (DataRow row in data.Rows)
                {
                    bmiSeries.Points.AddXY(row["Date"], row["Rate"]);
                    index++;
                }
                // Thêm series vào chart
                chartBMI.Series.Add(bmiSeries);

                // Đặt tên trục x và trục y
                chartBMI.ChartAreas[0].AxisX.Title = "Date";
                chartBMI.ChartAreas[0].AxisY.Title = "BMI";

                bmiSeries.ChartType = SeriesChartType.FastLine;
                bmiSeries.BorderWidth = 2;
                bmiSeries.Color = Color.FromArgb(44, 181, 245);
                chartBMI.ChartAreas[0].AxisX.LabelStyle.Angle = -45;


                // Đặt màu sắc và độ mờ cho ô phân chia chính (MajorGrid)
                chartBMI.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(200, Color.Gray);
                chartBMI.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
                chartBMI.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(200, Color.Gray);
                chartBMI.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

                // Đặt màu sắc và độ mờ cho ô phân chia phụ (MinorGrid)
                chartBMI.ChartAreas[0].AxisX.MinorGrid.LineColor = Color.FromArgb(100, Color.LightGray);
                chartBMI.ChartAreas[0].AxisX.MinorGrid.LineDashStyle = ChartDashStyle.Dot;
                chartBMI.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.FromArgb(100, Color.LightGray);
                chartBMI.ChartAreas[0].AxisY.MinorGrid.LineDashStyle = ChartDashStyle.Dot;
                // Hiển thị đồ thị
                chartBMI.DataBind();
            }

        }

        private void LoadAllBMI()
        {

            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "SELECT * FROM V_BMIList";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.closeConnection();
            gvBMI.DataSource = data;
        }

        private void Add()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "PROC_AddBMI";

            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", RandomIDGenerator.GenerateRandomID("BMI", ""));
                command.Parameters.AddWithValue("@Date", DateTime.Now);
                command.Parameters.AddWithValue("@Weight", decimal.Parse(txtInputWeight.Text));
                command.Parameters.AddWithValue("@Height", int.Parse(txtInputHeight.Text));
                command.Parameters.AddWithValue("@MemberPhone", txtPhone.Text);
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
            LoadAllBMI();
        }

        private void Update()
        {

            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "PROC_UpdateBMI";

            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", gvBMI.CurrentRow.Cells["ID"].Value.ToString());
                command.Parameters.AddWithValue("@Weight", Decimal.Parse(txtInputWeight.Text));
                command.Parameters.AddWithValue("@Height", int.Parse(txtInputHeight.Text));
                lblResult.Text = gvBMI.CurrentRow.Cells["ID"].Value.ToString() + " - Status: " + (string)command.ExecuteScalar() + " on " + DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return;
            }
            connection.closeConnection();
            MessageBox.Show("cập nhật thành công");
            LoadAllBMI();
        }


        private void ShowChart()
        {

            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "SELECT * FROM dbo.FUNC_DataForChartBMI(@PhoneNumber)  ORDER BY [Date] ASC";
            DataTable dataTable = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return;
            }
            CreateChart(dataTable);
            connection.closeConnection();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadAllBMI();
        }

        private void gvBMI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = gvBMI.CurrentRow.Cells["Name"].Value.ToString();
            txtPhone.Text = gvBMI.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            txtInputHeight.Text = gvBMI.CurrentRow.Cells["Height"].Value.ToString();
            txtInputWeight.Text = gvBMI.CurrentRow.Cells["Weight"].Value.ToString();
            lblResult.Text = gvBMI.CurrentRow.Cells["ID"].Value.ToString() + " - Status: " + gvBMI.CurrentRow.Cells["Status"].Value.ToString() + " on " + gvBMI.CurrentRow.Cells["Date"].Value.ToString();
            LoadBMI();
        }

        private void LoadBMI()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();

            String query = "PROC_LatestBMI";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            //khai báo các thuộc tính của tham số
            command.Parameters.AddWithValue("@MemberID", gvBMI.CurrentRow.Cells["MemberID"].Value.ToString());

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblStatus.Text = "Status: " + reader["Status"].ToString();
                        lblWeight.Text = "Weight: " + reader["Weight"].ToString() + " kg";
                        lblHeight.Text = "Height: " + reader["Height"].ToString() + " cm";
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

        private void Delete()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();
            String query = "DELETE BMI WHERE ID = @ID";

            try
            {
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@ID", gvBMI.CurrentRow.Cells["ID"].Value.ToString());
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.closeConnection();
                return;
            }
            MessageBox.Show("Xóa thành công");
            connection.closeConnection();
            LoadAllBMI();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindBMIByPhone();
        }

        private void FindBMIByPhone()
        {
            DBConnection connection = new DBConnection();
            connection.openConnection();

            String query = "PROC_FindMemberByPhoneNumber";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            //khai báo các thuộc tính của tham số
            command.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtName.Text = reader["Name"].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Member");
                    return;
                }
            }

            connection.openConnection();
            query = "SELECT * FROM V_BMIList WHERE PhoneNumber = @Phone";
            command = new SqlCommand(query, connection.GetConnection());
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Phone", txtPhone.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.closeConnection();
            gvBMI.DataSource = data;


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            ShowChart();
        }
    }
}
