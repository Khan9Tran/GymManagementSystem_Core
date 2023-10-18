using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymManagementSystem;

namespace GymManagementSystem
{
    public partial class FHomeUser : Form
    {

        private OpenChildForm openChildForm;
        public FHomeUser()
        {
            InitializeComponent();
            OpenChildForm openChildForm = new OpenChildForm(pnlLoad);
        }

        internal OpenChildForm OCF { get => openChildForm; set => openChildForm = value; }

        private void FHome_Load(object sender, EventArgs e)
        {
            openChildForm.Open(new FHomeUserMenu());
        }
    }
}
