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

namespace GymManagementSystem
{
    public partial class FHomeUser : Form
    {

        private OpenChildForm childForm;
        public FHomeUser()
        {
            InitializeComponent();
            childForm = new OpenChildForm(pnlLoad);
            StackForm.HomeUser = this;
            childForm.Open(new FHomeUserMenu());
        }

        internal OpenChildForm ChildForm { get => childForm; set => childForm = value; }


        private void btnHome_Click(object sender, EventArgs e)
        {
            childForm.Open(new FHomeUserMenu());
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            childForm.Open(new FMembershipManagement());
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


        private void cmnusManagement_Opening(object sender, CancelEventArgs e)
        {

        }

        private void itemBMI_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FBMIMnagement());
        }

        private void itemMemebrship_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FMembershipManagement());
        }

        private void itemBranch_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FBranchManagement());
        }

        private void itemMember_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FMemberManagement());
        }

        private void itemCategory_Click(object sender, EventArgs e)
        {

        }

        private void itemEquipment_Click(object sender, EventArgs e)
        {

        }

        private void itemMaintenance_Click(object sender, EventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            StackForm.HomeUser.ChildForm.Open(new FEmployee());
        }
    }
}
