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
        private void LoadWorkOutPlan()
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
    }
}
