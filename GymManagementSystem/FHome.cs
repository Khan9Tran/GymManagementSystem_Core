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
    public partial class FHome : Form
    {
        public FHome()
        {
            InitializeComponent();
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnIconHome.BackColor = ColorTranslator.FromHtml("#633f5b");
            btnHome.BackColor = ColorTranslator.FromHtml("#633f5b");
            flpHome.BackColor = ColorTranslator.FromHtml("#633f5b");
        }

        private void btnIconHome_MouseHover(object sender, EventArgs e)
        {
            btnIconHome.BackColor = ColorTranslator.FromHtml("#633f5b");
            btnHome.BackColor = ColorTranslator.FromHtml("#633f5b");
            flpHome.BackColor = ColorTranslator.FromHtml("#633f5b");
        }

        private void btnIconHome_MouseLeave(object sender, EventArgs e)
        {
            btnIconHome.BackColor = ColorTranslator.FromHtml("#3b2937");
            btnHome.BackColor = ColorTranslator.FromHtml("#3b2937");
            flpHome.BackColor = ColorTranslator.FromHtml("#3b2937");
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnIconHome.BackColor = ColorTranslator.FromHtml("#3b2937");
            btnHome.BackColor = ColorTranslator.FromHtml("#3b2937");
            flpHome.BackColor = ColorTranslator.FromHtml("#3b2937");
        }
    }
}
