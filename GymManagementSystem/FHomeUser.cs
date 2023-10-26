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

        private void FHome_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            childForm.Open(new FHomeUserMenu());
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            childForm.Open(new FMembershipManagement());
        }
    }
}
