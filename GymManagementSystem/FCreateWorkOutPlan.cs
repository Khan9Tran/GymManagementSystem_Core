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
    public partial class FCreateWorkOutPlan : Form
    {
        public FCreateWorkOutPlan()
        {
            InitializeComponent();
            for (int i = 0; i<10; i++)
            {
                flpnlBranch.Controls.Add(new USBranch("Texttttt","1"));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flpnlBranch_Click(object sender, EventArgs e)
        {
        }
    }
}
