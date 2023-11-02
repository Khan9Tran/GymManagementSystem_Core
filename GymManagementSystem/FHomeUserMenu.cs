using GymManagementSystem.Models;
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
            if (Employee.BranchID != null)
                lblBranch.Text = Employee.BranchName;
            else
                lblBranch.Text = "All Branch";
        }

        private void fpnlViewSchedule_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FViewWorkOutPlan());

        }

        private void fpnlRegisterMenber_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FCreateMember());
        }

        private void fpnlPurshasePackage_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FPurchasePackage());
        }
        private void fpnlNewPlan_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FCreateWorkOutPlan());
        }
    }
}
