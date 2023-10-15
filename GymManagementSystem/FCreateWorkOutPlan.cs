using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class FCreateWorkOutPlan : Form
    {
        public FCreateWorkOutPlan()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                USBranch branch = new USBranch("Texttttt", $"{i}");
                flpnlBranch.Controls.Add(branch);
                branch.BranchClicked += Branch_BranchClicked;

            }

        }

        private void Branch_BranchClicked(object? sender, EventArgs e)
        {
            USBranch clickedUSBranch = (USBranch)sender;
            string clickedID = clickedUSBranch.ID;

            MessageBox.Show("Đã nhấp vào USBranch có ID: " + clickedID);
        }

    }
}
