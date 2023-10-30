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
    public partial class USPackage : UserControl
    {
        string packageName;
        string packagePeriods;
        string packagePrice;
        string packageDesctiption;
        string packageNOPTSessions;

        public USPackage(string packageName, string packagePeriods, string packagePrice, string packageDesctiption, string packageNOPTSessions)
        {
            InitializeComponent();
            this.packageName = packageName;
            this.packagePeriods = packagePeriods;
            this.packagePrice = packagePrice;
            this.packageDesctiption = packageDesctiption;
            this.packageNOPTSessions = packageNOPTSessions;
            showPackage();
        }

        public void showPackage()
        {
            btnPkName.Text = packageName;
            lblPkPeriods.Text = packagePeriods;
            lblPkPrice.Text = packagePrice;
            lblPkDescription.Text = packageDesctiption;
            lblPkNumberOfTrainerSessions.Text = packageNOPTSessions;
        }

        private void btnPkSelect_Click(object sender, EventArgs e)
        {
            FPurchasePackage.showDetailPackage(packageName, packagePeriods, packagePrice, packageDesctiption, packageNOPTSessions);
        }
    }
}
