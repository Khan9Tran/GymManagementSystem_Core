using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class FViewWorkOutPlan : Form
    {
        public FViewWorkOutPlan()
        {
            InitializeComponent();
        }
        enum Filter
        {
            All,
            Current,
            Upcoming
        }
        Filter select = Filter.All;
        private void LoadWorkOutPlan(Filter type, string search)
        {   
            //Dựa vào select thực thi sql
        }
        private void AddWorkOutPlan() 
        {
            //Chuyển Form AddWorkOutPlan
        }
        private void RemoveWorkOutPlan() 
        {
            //Thực thi câu lệnh sql
        }

        private void btnAll_Click(object sender, EventArgs e)
        {

        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {

        }

        private void btnUpcoming_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
