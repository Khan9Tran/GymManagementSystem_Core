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
    public partial class USTrainer : UserControl
    {
        private string trainerID;
        private string branchID;

        public string TrainerID { get => trainerID; set => trainerID = value; }
        public string BranchID { get => branchID; set => branchID = value; }

        public event EventHandler TrainerClicked;

        public USTrainer(string Name, string gender, string trainerID, string branchID)
        {
            InitializeComponent();
            this.trainerID = trainerID;
            this.branchID = branchID;
            btnTrainer.Text = Name;
            if (gender == "f")
            {
                btnTrainer.Image = global::GymManagementSystem.Properties.Resources.femenine;
            }
            else
            {
                btnTrainer.Image = global::GymManagementSystem.Properties.Resources.male;
            } 
            
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            TrainerClicked?.Invoke(this, EventArgs.Empty);
        }

        private void USTrainer_Click(object sender, EventArgs e)
        {

        }
    }
}
