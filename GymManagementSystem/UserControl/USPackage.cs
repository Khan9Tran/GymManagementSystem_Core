﻿using GymManagementSystem.Common;
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
        string packageID;
        string packageName;
        string packagePeriods;
        string packagePrice;
        string packageDesctiption;
        string packageNOPTSessions;
        ToolForPicture tool;
        public USPackage(string packageID, string packageName, string packagePeriods, string packagePrice, string packageDesctiption, string packageNOPTSessions)
        {
            InitializeComponent();
            this.packageID = packageID;
            this.packageName = packageName;
            this.packagePeriods = packagePeriods;
            this.packagePrice = ConverToMoney.conver(Math.Round(Double.Parse(packagePrice), 3).ToString ());
            this.packageDesctiption = packageDesctiption;
            this.packageNOPTSessions = packageNOPTSessions;
            tool = new ToolForPicture(ToolForPicture.Type.package);
            tool.GetPicture(this.packageID, ptcHinh);
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
            FPurchasePackage.showDetailPackage(packageID, packageName, packagePeriods, packagePrice, packageDesctiption, packageNOPTSessions);
        }
    }
}
