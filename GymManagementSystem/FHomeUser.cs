using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymManagementSystem;
using GymManagementSystem.Models;

namespace GymManagementSystem
{
    public partial class FHomeUser : Form
    {

        private OpenChildForm childForm;
        private FLogin fLogin;

        public FHomeUser(FLogin fLogin)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            childForm = new OpenChildForm(pnlLoad);
            StackForm.HomeUser = this;
            StackForm.HomeUser.ChildForm.Open(new FHomeUserMenu());
            this.fLogin= fLogin;
            
         

        }

        internal OpenChildForm ChildForm { get => childForm; set => childForm = value; }


        private void btnHome_Click(object sender, EventArgs e)
        {
            childForm.Open(new FHomeUserMenu());
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            if (Employee.Role != 1)
            {
                MessageBox.Show("Không có quyền truy cập");
            }
            else
            {
                childForm.Open(new FMembershipManagement());
            }
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            cmnusManagement.Show(this, this.PointToClient(MousePosition));
        }


        private void btnBMI_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FBMIMnagement());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            cmnusLogOut.Show(this, this.PointToClient(MousePosition));
        }

        private void itemQuit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có thật sự muốn thoát", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                StackForm.ClearAll();
                Application.Exit();
            }
        }



        private void itemBMI_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FBMIMnagement());
        }

        private void itemMemebrship_Click(object sender, EventArgs e)
        {
            if (Employee.Role != 1)
            {
                MessageBox.Show("Không có quyền truy cập");
            }
            else
            {
                StackForm.HomeUser.ChildForm.Open(new FMembershipManagement());
            }
        }

        private void itemBranch_Click(object sender, EventArgs e)
        {
            if (Employee.Role != 1)
            {
                MessageBox.Show("Không có quyền truy cập");
            }
            else
            {
                StackForm.HomeUser.ChildForm.Open(new FBranchManagement());
            }
        }

        private void itemMember_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FMemberManagement());
        }

        private void itemCategory_Click(object sender, EventArgs e)
        {
            if (Employee.Role != 1)
            {
                MessageBox.Show("Không có quyền truy cập");
            }
            else
            {
                childForm.Open(new FEquipmentCategory());
            }
        }

        private void itemEquipment_Click(object sender, EventArgs e)
        {
            if (Employee.Role == 0)
            {
                MessageBox.Show("Không có quyền truy cập");
            }
            else
            {
                StackForm.HomeUser.ChildForm.Open(new FEquipmentManagement());
            }
        }


        private void btnAccount_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FEmployee());
        }

        private void itemWorkout_Click(object sender, EventArgs e)
        {
            if (Employee.Role != 1)
            {
                MessageBox.Show("Không có quyền truy cập");
            }
            else
            {
                StackForm.HomeUser.ChildForm.Open(new FWorkOutManagement());
            }
        }

        private void btnEquipmentData_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FEquipmentMaintenance());
        }

        private void itemTrainer_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FTrainerManagement());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StackForm.Back();
        }

        private void itemPayment_Click(object sender, EventArgs e)
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

        private void itemPackage_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FPackageManagement());
        }

        private void itemLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            fLogin.Show();
            StackForm.ClearAll();
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            if ( this.WindowState == FormWindowState.Maximized )
            this.WindowState = FormWindowState.Normal;
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
