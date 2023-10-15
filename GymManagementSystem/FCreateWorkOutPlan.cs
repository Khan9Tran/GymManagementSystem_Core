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
        private string branchId = null;
        public FCreateWorkOutPlan()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                USBranch branch = new USBranch("Texttttt", $"{i}");
                flpnlBranch.Controls.Add(branch);
                branch.BranchClicked += Branch_BranchClicked;

            }
            for (int i = 0; i < 10; i++)
            {
                USTrainer trainer = new USTrainer("Texttttt", "m", $"{i}",$"{i}");
                flpnlTrainer.Controls.Add(trainer);
                trainer.TrainerClicked += Trainer_TrainerClicked;

            }

        }

        private void Branch_BranchClicked(object? sender, EventArgs e)
        {
            USBranch clickedUSBranch = (USBranch)sender;
            branchId = clickedUSBranch.ID;
            foreach (var ctr in flpnlBranch.Controls)
            {
                if (((USBranch)ctr).ID != branchId)
                {
                    ((USBranch)ctr).changeColor(0);
                }    
                else
                {
                    ((USBranch)ctr).changeColor(1);
                }    
            }    
        }

        private void Trainer_TrainerClicked(object? sender, EventArgs e)
        {
            USTrainer clickedUSTrainer = (USTrainer)sender;
            string clickedID = clickedUSTrainer.TrainerID;

            MessageBox.Show("Đã nhấp vào Trainer: " + clickedID);
        }
    }
}
