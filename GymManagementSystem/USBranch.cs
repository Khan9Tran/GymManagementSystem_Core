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
        public string ID;
        public USBranch(String BranchName, String ID)
        {
            InitializeComponent();
            btnBranch.Text = BranchName;
            this.ID = ID;
        }

    }
}
