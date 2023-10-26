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
    public partial class FLogin : Form
    {
        private Panel pnlFull;
        OpenChildForm openChildForm;
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login())
            {
                this.Controls.Clear();
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                Form home = new FHomeUser();
                pnlFull = new Panel();
                pnlFull.Dock = DockStyle.Fill;
                this.Controls.Add(pnlFull);
                openChildForm = new OpenChildForm(pnlFull);
                openChildForm.Open(home);
            }
        }
        private bool Login()
        {
            
            return true;
        }
    }
}
