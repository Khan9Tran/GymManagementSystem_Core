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
    public partial class USMenuBar : UserControl
    {
        public USMenuBar()
        {
            InitializeComponent();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (Employee.Role != 1)
            {
                MessageBox.Show("Bạn không có quyền truy cập");
            }
            else
            {
                StackForm.HomeUser.ChildForm.Open(new FPaymentManagement());
            }
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            if (Employee.Role == 0 || Employee.Role == 2)
            {
                MessageBox.Show("Bạn không có quyền truy cập");
            }
            else
            {
                StackForm.HomeUser.ChildForm.Open(new FMembershipManagement());
            }
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FMemberManagement());
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FBMIMnagement());
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            if (Employee.Role == 0)
            {
                MessageBox.Show("Bạn không có quyền truy cập");
            }
            else
            {
                StackForm.HomeUser.ChildForm.Open(new FBranchManagement());
            }
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            if (Employee.Role == 0)
            {
                MessageBox.Show("Bạn không có quyền truy cập");
            }    
            else
            {
                StackForm.HomeUser.ChildForm.Open(new FEquipmentManagement());
            }
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FEquipmentMaintenance());
        }

        private void btnWorkOutPlan_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FViewWorkOutPlan());
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FTrainerManagement());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (Employee.Role != 1)
            {
                MessageBox.Show("Không có quyền truy cập");
            }
            else
            {
                StackForm.HomeUser.ChildForm.Open(new FEquipmentCategory());
            }
        }

        private void btnWorkOut_Click(object sender, EventArgs e)
        {
            if (Employee.Role == 0 || Employee.Role == 2)
            {
                MessageBox.Show("Bạn không có quyền truy cập");
            }
            else
            {
                StackForm.HomeUser.ChildForm.Open(new FWorkOutManagement());
            }
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            if (Employee.Role == 0 || Employee.Role == 2)
            {
                MessageBox.Show("Bạn không có quyền truy cập");
            }
            else
            {
                StackForm.HomeUser.ChildForm.Open(new FPackageManagement());
            }
        }
    }
}
