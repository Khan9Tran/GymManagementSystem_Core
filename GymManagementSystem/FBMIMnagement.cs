using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            pnlChart.Controls.Add(chartBMI);
            chartBMI.Show();
            Do();
        }
        public class Measurement
        {
            public DateTime Date { get; set; }
            public double Weight { get; set; }
            public double Height { get; set; }
        }

        // Phương thức tính toán BMI
        private double CalculateBMI(double weight, double height)
        {
            // Thực hiện tính toán BMI theo công thức tương ứng
            double bmi = weight / (height * height);
            return bmi;
        }

        // Phương thức trả về danh sách lần đo
        private List<Measurement> GetMeasurements()
        {
            // Thực hiện lấy dữ liệu từ nguồn dữ liệu của bạn
            List<Measurement> measurements = new List<Measurement>();

            // Thêm các lần đo vào danh sách
            measurements.Add(new Measurement { Date = new DateTime(2022, 1, 1), Weight = 70, Height = 1.75 });
            measurements.Add(new Measurement { Date = new DateTime(2022, 2, 1), Weight = 72, Height = 1.75 });
            measurements.Add(new Measurement { Date = new DateTime(2022, 3, 1), Weight = 68, Height = 1.75 });
            // ...

            return measurements;
        }
        void Do()
        {

            // Lấy dữ liệu từ nguồn dữ liệu của bạn
            List<Measurement> measurements = GetMeasurements();

            // Tạo một series mới cho đồ thị BMI
            Series bmiSeries = new Series("BMI");

            // Thêm dữ liệu vào series
            foreach (Measurement measurement in measurements)
            {
                bmiSeries.Points.AddXY(measurement.Date, CalculateBMI(measurement.Weight, measurement.Height));
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

        private void LoadAllBMI()
        {

        }

        private void LoadBMIByPhoneMember()
        {

        }

        private void Add()
        {

        }

        private void Update()
        {

        }

        private void LatestBMI()
        {
            
        }

        private void ShowChart()
        {

        }
    }

}
