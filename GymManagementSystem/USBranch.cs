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
        private string iD;
        public event EventHandler BranchClicked;
        
        public USBranch(String BranchName, String ID)
        {
            InitializeComponent();
            btnBranch.Text = BranchName;
            iD = ID;
        }


        public string ID { get => iD; set => iD = value; }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            BranchClicked?.Invoke(this, EventArgs.Empty);
        }

        private void USBranch_Click(object sender, EventArgs e)
        {

        }
    }
}
