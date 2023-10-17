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
    public partial class USWorkOut : UserControl
    {
        private WorkOut workOut;
        public event EventHandler WorkOutClicked;
        public USWorkOut(WorkOut workOut)
        {
            InitializeComponent();
            this.workOut = workOut;
            lblDuration.Text = "Duration: " + (workOut.Duration).ToString()+ " minute";
            lblName.Text = workOut.Name;   
            lblType.Text = "Type: "+ workOut.Type;
        }

        internal WorkOut USCWorkOut { get => workOut; set => workOut = value; }

        public void changeColor()
        {
            if (pnlWorkout.BorderColor == Color.White)
            {
                pnlWorkout.BorderColor = Color.FromArgb(40, 181, 244);
                pnlLoad.BorderColor = Color.FromArgb(40, 181, 244);
                ptcWorkOut.BorderColor = Color.FromArgb(40, 181, 244);
            }
            else
            {
                pnlWorkout.BorderColor = Color.White;
                pnlLoad.BorderColor = Color.PaleVioletRed;
                ptcWorkOut.BorderColor = Color.PaleGoldenrod;
            }
        }

        private void pnlLoad_Click(object sender, EventArgs e)
        {
            changeColor();
            WorkOutClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ptcWorkOut_Click(object sender, EventArgs e)
        {
            changeColor();
            WorkOutClicked?.Invoke(this, EventArgs.Empty);
        }

        private void pnlWorkout_Click(object sender, EventArgs e)
        {
            changeColor();
            WorkOutClicked?.Invoke(this, EventArgs.Empty);
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            changeColor();
            WorkOutClicked?.Invoke(this, EventArgs.Empty);
        }

        private void lblType_Click(object sender, EventArgs e)
        {
            changeColor();
            WorkOutClicked?.Invoke(this, EventArgs.Empty);
        }

        private void lblDuration_Click(object sender, EventArgs e)
        {
            changeColor();
            WorkOutClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
