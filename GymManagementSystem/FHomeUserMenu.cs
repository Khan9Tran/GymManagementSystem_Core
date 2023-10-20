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
    public partial class FHomeUserMenu : Form
    {
        public FHomeUserMenu()
        {
            InitializeComponent();
        }

        private void ptcViewSchedule_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FViewWorkOutPlan());
        }

        private void lblViewSchedule_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FViewWorkOutPlan());
        }

        private void fpnlViewSchedule_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FViewWorkOutPlan());

        }

        private void fpnlLoadViewShcedule_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FViewWorkOutPlan());
        }

        private void ptcNewSchedule_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FCreateWorkOutPlan());
        }

        private void lblNewSchedule_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FCreateWorkOutPlan());
        }

        private void fpnlNewSchedule_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FCreateWorkOutPlan());
        }

        private void fpnlLoadNewChedule_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FCreateWorkOutPlan());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
