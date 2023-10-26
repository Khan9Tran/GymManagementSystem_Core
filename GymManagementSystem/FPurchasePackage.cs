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
    public partial class FPurchasePackage : Form
    {
        public FPurchasePackage()
        {
            InitializeComponent();
            USPackage package = new USPackage();
            flpContainerPackage.Controls.Add(package);
            USPackage package1 = new USPackage();
            flpContainerPackage.Controls.Add(package1);
            USPackage package2 = new USPackage();
            flpContainerPackage.Controls.Add(package2);
            USPackage package3 = new USPackage();
            flpContainerPackage.Controls.Add(package3);
            USPackage package4 = new USPackage();
            flpContainerPackage.Controls.Add(package4);
            USPackage package5 = new USPackage();
            flpContainerPackage.Controls.Add(package5);
            USPackage package6 = new USPackage();
            flpContainerPackage.Controls.Add(package6);
            USPackage package7 = new USPackage();
            flpContainerPackage.Controls.Add(package7);
            USPackage package8 = new USPackage();
            flpContainerPackage.Controls.Add(package8);
            USPackage package9 = new USPackage();
            flpContainerPackage.Controls.Add(package9);
        }

        private void rjPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHaveTrainer_MouseHover(object sender, EventArgs e)
        {
            btnHaveTrainer.BackColor = Color.FromArgb(40, 181, 244);
        }

        private void btnHaveTrainer_MouseLeave(object sender, EventArgs e)
        {
            btnHaveTrainer.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnNoTrainer_MouseHover(object sender, EventArgs e)
        {
            btnNoTrainer.BackColor = Color.FromArgb(40, 181, 244);
        }

        private void btnNoTrainer_MouseLeave(object sender, EventArgs e)
        {
            btnNoTrainer.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnHaveTrainer_Click(object sender, EventArgs e)
        {
            btnHaveTrainer.BackColor = Color.FromArgb(40, 181, 244);
            btnNoTrainer.BackColor = Color.FromArgb(255, 255, 255);
            btnHaveTrainer.ForeColor = Color.White;
            btnNoTrainer.ForeColor = Color.FromArgb(59, 41, 55);
        }

        private void btnNoTrainer_Click(object sender, EventArgs e)
        {
            btnNoTrainer.BackColor = Color.FromArgb(40, 181, 244);
            btnHaveTrainer.BackColor = Color.FromArgb(255, 255, 255);
            btnHaveTrainer.ForeColor = Color.FromArgb(59, 41, 55);
            btnNoTrainer.ForeColor = Color.White;
        }
    }
}
