using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem
{
    internal class OpenChildForm
    {
        private Form? currentChildForm;
        private Panel pnlLoad;

        public Form? CurrentChildForm { get => currentChildForm; set => currentChildForm = value; }

        public OpenChildForm(Panel pnlLoad)
        {
            this.pnlLoad = pnlLoad;
            currentChildForm = null;
        }

        public void Open(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            //Bắt lỗi thiếu form cha để load
            try
            {
                currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlLoad.Controls.Add(childForm);
                pnlLoad.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch
            {
                MessageBox.Show("Ấn thêm 1 lần nữa");
            }
        }
    }
}
