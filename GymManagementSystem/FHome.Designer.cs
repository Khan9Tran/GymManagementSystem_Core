namespace GymManagementSystem
{
    partial class FHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            flpHome = new FlowLayoutPanel();
            btnIconHome = new Button();
            btnHome = new Button();
            flowLayoutPanel1.SuspendLayout();
            flpHome.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(59, 41, 55);
            flowLayoutPanel1.Controls.Add(flpHome);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 1041);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flpHome
            // 
            flpHome.BackColor = Color.Transparent;
            flpHome.Controls.Add(btnIconHome);
            flpHome.Controls.Add(btnHome);
            flpHome.Location = new Point(0, 0);
            flpHome.Margin = new Padding(0);
            flpHome.Name = "flpHome";
            flpHome.Size = new Size(250, 65);
            flpHome.TabIndex = 1;
            // 
            // btnIconHome
            // 
            btnIconHome.BackColor = Color.Transparent;
            btnIconHome.BackgroundImage = Properties.Resources.home;
            btnIconHome.BackgroundImageLayout = ImageLayout.Center;
            btnIconHome.FlatAppearance.BorderSize = 0;
            btnIconHome.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnIconHome.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnIconHome.FlatStyle = FlatStyle.Flat;
            btnIconHome.Location = new Point(3, 3);
            btnIconHome.Name = "btnIconHome";
            btnIconHome.Size = new Size(60, 60);
            btnIconHome.TabIndex = 0;
            btnIconHome.UseVisualStyleBackColor = false;
            btnIconHome.MouseLeave += btnIconHome_MouseLeave;
            btnIconHome.MouseHover += btnIconHome_MouseHover;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHome.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.FromArgb(158, 159, 155);
            btnHome.Location = new Point(69, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(170, 60);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.MouseLeave += btnHome_MouseLeave;
            btnHome.MouseHover += btnHome_MouseHover;
            // 
            // FHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(flowLayoutPanel1);
            Name = "FHome";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            flowLayoutPanel1.ResumeLayout(false);
            flpHome.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flpHome;
        private Button btnIconHome;
        private Button btnHome;
    }
}