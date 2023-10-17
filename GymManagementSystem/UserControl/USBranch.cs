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
    public partial class USBranch : UserControl
    {
        private Branch branch;
        internal Branch UsCBranch { get => branch; set => branch = value; }

        public event EventHandler BranchClicked;
        
        public USBranch() { }

        public USBranch(Branch branch)
        {
            InitializeComponent();
            btnBranch.Text = branch.Name;
            this.branch = branch;
        }


        

        private void btnBranch_Click(object sender, EventArgs e)
        {
            BranchClicked?.Invoke(this, EventArgs.Empty);
        }

        private void USBranch_Click(object sender, EventArgs e)
        {

        }

        public void changeColor(int choice)
        {
            if (choice == 1)
            {
                btnBranch.BackColor = Color.FromArgb(40, 181, 244);
                btnBranch.ForeColor = Color.White;
            }
            else
            {
                btnBranch.BackColor = Color.White;
                btnBranch.ForeColor = Color.FromArgb(67, 52, 67);
            }    
        }
    }
}
