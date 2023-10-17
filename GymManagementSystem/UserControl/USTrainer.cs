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
    public partial class USTrainer : UserControl
    {
        private Trainer trainer;

        internal Trainer UsCTrainer { get => trainer; set => trainer = value; }

        public event EventHandler TrainerClicked;

        public USTrainer(Trainer trainer)
        {
            InitializeComponent();
            this.trainer = trainer;
            btnTrainer.Text = trainer.Name;
            if (trainer.Gender == "f")
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

        public void changeColor(int choice)
        {
            if (choice == 1)
            {
                btnTrainer.BackColor = Color.FromArgb(40, 181, 244);
                btnTrainer.ForeColor = Color.White;
            }
            else
            {
                btnTrainer.BackColor = Color.White;
                btnTrainer.ForeColor = Color.FromArgb(67, 52, 67);
            }
        }
    }
}
