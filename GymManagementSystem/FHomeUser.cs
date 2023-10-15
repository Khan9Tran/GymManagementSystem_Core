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
    public partial class FHomeUser : Form
    {

        OpenChildForm openChildForm;
        public FHomeUser()
        {
            InitializeComponent();
            openChildForm = new OpenChildForm(pnlLoad);
        }

        private void FHome_Load(object sender, EventArgs e)
        {
            openChildForm.Open(new FHomeUserMenu());
        }
    }
}
