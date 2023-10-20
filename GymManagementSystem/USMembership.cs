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
    public partial class USMembership : UserControl
    {
        private MembershipType membership;
        public event EventHandler membershipClicked;
        public USMembership(MembershipType membership)
        {
            InitializeComponent();
            tfPicture = new ToolForPicture(ToolForPicture.Type.membership);
            this.membership = membership;
            tfPicture.GetPicture(membership.ID, ptbMBS);
        }

        public MembershipType Membership { get => membership; set => membership = value; }

        private ToolForPicture tfPicture;
        public PictureBox ChangeCard()
        {
            return ptbMBS;
        }
        public void changeColor(int choice)
        {
            if (choice == 1)
            {
                ptbMBS.BorderColor = Color.FromArgb(40, 181, 244);
            }
            else
            {
                ptbMBS.BorderColor = Color.White;
            }
        }


        private void ptbMBS_Click(object sender, EventArgs e)
        {

            membershipClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
