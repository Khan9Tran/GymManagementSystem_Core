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
    }
}
