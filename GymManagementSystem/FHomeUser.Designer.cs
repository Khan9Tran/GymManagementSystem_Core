namespace GymManagementSystem
{
    partial class FHomeUser
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
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnHome = new Button();
            btnMembership = new Button();
            btnManagement = new Button();
            cmnusManagement = new ContextMenuStrip(components);
            itemMember = new ToolStripMenuItem();
            itemMembership = new ToolStripMenuItem();
            btnBMI = new Button();
            btnLogOut = new Button();
            cmnusLogOut = new ContextMenuStrip(components);
            itemLogOut = new ToolStripMenuItem();
            itemQuit = new ToolStripMenuItem();
            pnlLoad = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            btnAccount = new Button();
            trainerToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanel1.SuspendLayout();
            cmnusManagement.SuspendLayout();
            cmnusLogOut.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(59, 41, 55);
            flowLayoutPanel1.Controls.Add(btnHome);
            flowLayoutPanel1.Controls.Add(btnMembership);
            flowLayoutPanel1.Controls.Add(btnManagement);
            flowLayoutPanel1.Controls.Add(btnBMI);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(100, 750);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImage = Properties.Resources.home;
            btnHome.BackgroundImageLayout = ImageLayout.Center;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(99, 63, 91);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 63, 91);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Location = new Point(23, 27);
            btnHome.Margin = new Padding(23, 27, 23, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(60, 60);
            btnHome.TabIndex = 0;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnMembership
            // 
            btnMembership.BackColor = Color.Transparent;
            btnMembership.BackgroundImage = Properties.Resources.vip__1_;
            btnMembership.BackgroundImageLayout = ImageLayout.Center;
            btnMembership.Cursor = Cursors.Hand;
            btnMembership.FlatAppearance.BorderSize = 0;
            btnMembership.FlatAppearance.MouseDownBackColor = Color.FromArgb(99, 63, 91);
            btnMembership.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 63, 91);
            btnMembership.FlatStyle = FlatStyle.Flat;
            btnMembership.Location = new Point(23, 114);
            btnMembership.Margin = new Padding(23, 27, 23, 0);
            btnMembership.Name = "btnMembership";
            btnMembership.Size = new Size(60, 60);
            btnMembership.TabIndex = 1;
            btnMembership.UseVisualStyleBackColor = false;
            btnMembership.Click += btnMembership_Click;
            // 
            // btnManagement
            // 
            btnManagement.BackColor = Color.Transparent;
            btnManagement.BackgroundImage = Properties.Resources.folder;
            btnManagement.BackgroundImageLayout = ImageLayout.Center;
            btnManagement.ContextMenuStrip = cmnusManagement;
            btnManagement.Cursor = Cursors.Hand;
            btnManagement.FlatAppearance.BorderSize = 0;
            btnManagement.FlatAppearance.MouseDownBackColor = Color.FromArgb(99, 63, 91);
            btnManagement.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 63, 91);
            btnManagement.FlatStyle = FlatStyle.Flat;
            btnManagement.Location = new Point(23, 201);
            btnManagement.Margin = new Padding(23, 27, 23, 0);
            btnManagement.Name = "btnManagement";
            btnManagement.Size = new Size(60, 60);
            btnManagement.TabIndex = 5;
            btnManagement.UseVisualStyleBackColor = false;
            btnManagement.Click += btnManagement_Click;
            // 
            // cmnusManagement
            // 
            cmnusManagement.BackColor = Color.FromArgb(44, 181, 245);
            cmnusManagement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmnusManagement.ImageScalingSize = new Size(20, 20);
            cmnusManagement.Items.AddRange(new ToolStripItem[] { itemMember, itemMembership, trainerToolStripMenuItem });
            cmnusManagement.Name = "cmnusManagement";
            cmnusManagement.RenderMode = ToolStripRenderMode.Professional;
            cmnusManagement.ShowImageMargin = false;
            cmnusManagement.Size = new Size(186, 128);
            cmnusManagement.Text = "Management";
            // 
            // itemMember
            // 
            itemMember.BackColor = Color.FromArgb(44, 181, 245);
            itemMember.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            itemMember.ForeColor = Color.White;
            itemMember.Name = "itemMember";
            itemMember.Size = new Size(185, 32);
            itemMember.Text = "Member";
            itemMember.Click += itemMember_Click;
            // 
            // itemMembership
            // 
            itemMembership.BackColor = Color.FromArgb(44, 181, 245);
            itemMembership.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            itemMembership.ForeColor = Color.White;
            itemMembership.Name = "itemMembership";
            itemMembership.Size = new Size(185, 32);
            itemMembership.Text = "Membership";
            itemMembership.TextImageRelation = TextImageRelation.ImageAboveText;
            itemMembership.Click += itemMembership_Click;
            // 
            // btnBMI
            // 
            btnBMI.BackColor = Color.Transparent;
            btnBMI.BackgroundImage = Properties.Resources.bmi;
            btnBMI.BackgroundImageLayout = ImageLayout.Center;
            btnBMI.Cursor = Cursors.Hand;
            btnBMI.FlatAppearance.BorderSize = 0;
            btnBMI.FlatAppearance.MouseDownBackColor = Color.FromArgb(99, 63, 91);
            btnBMI.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 63, 91);
            btnBMI.FlatStyle = FlatStyle.Flat;
            btnBMI.Location = new Point(23, 288);
            btnBMI.Margin = new Padding(23, 27, 23, 0);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(60, 60);
            btnBMI.TabIndex = 4;
            btnBMI.UseVisualStyleBackColor = false;
            btnBMI.Click += btnBMI_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.BackgroundImage = Properties.Resources.logout;
            btnLogOut.BackgroundImageLayout = ImageLayout.Center;
            btnLogOut.ContextMenuStrip = cmnusLogOut;
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(99, 63, 91);
            btnLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 63, 91);
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Location = new Point(23, 216);
            btnLogOut.Margin = new Padding(23, 27, 23, 0);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(60, 60);
            btnLogOut.TabIndex = 3;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // cmnusLogOut
            // 
            cmnusLogOut.BackColor = Color.FromArgb(44, 181, 245);
            cmnusLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmnusLogOut.ImageScalingSize = new Size(20, 20);
            cmnusLogOut.Items.AddRange(new ToolStripItem[] { itemLogOut, itemQuit });
            cmnusLogOut.Name = "cmnusLogOut";
            cmnusLogOut.RenderMode = ToolStripRenderMode.Professional;
            cmnusLogOut.ShowImageMargin = false;
            cmnusLogOut.Size = new Size(128, 68);
            cmnusLogOut.TabStop = true;
            // 
            // itemLogOut
            // 
            itemLogOut.ForeColor = Color.White;
            itemLogOut.Name = "itemLogOut";
            itemLogOut.Size = new Size(127, 32);
            itemLogOut.Text = "Log out";
            // 
            // itemQuit
            // 
            itemQuit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            itemQuit.ForeColor = Color.White;
            itemQuit.ImageScaling = ToolStripItemImageScaling.None;
            itemQuit.Name = "itemQuit";
            itemQuit.Size = new Size(127, 32);
            itemQuit.Text = "Quit";
            itemQuit.TextAlign = ContentAlignment.BottomCenter;
            itemQuit.Click += itemQuit_Click;
            // 
            // pnlLoad
            // 
            pnlLoad.Location = new Point(100, 0);
            pnlLoad.Margin = new Padding(0);
            pnlLoad.Name = "pnlLoad";
            pnlLoad.Size = new Size(1820, 1080);
            pnlLoad.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 41, 55);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(btnLogOut);
            panel1.Location = new Point(0, 748);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 300);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.undo;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.ContextMenuStrip = cmnusLogOut;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(99, 63, 91);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 63, 91);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(23, 33);
            button1.Margin = new Padding(23, 27, 23, 0);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.Transparent;
            btnAccount.BackgroundImage = Properties.Resources.user;
            btnAccount.BackgroundImageLayout = ImageLayout.Center;
            btnAccount.ContextMenuStrip = cmnusLogOut;
            btnAccount.Cursor = Cursors.Hand;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatAppearance.MouseDownBackColor = Color.FromArgb(99, 63, 91);
            btnAccount.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 63, 91);
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Location = new Point(23, 120);
            btnAccount.Margin = new Padding(23, 27, 23, 0);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(60, 60);
            btnAccount.TabIndex = 4;
            btnAccount.UseVisualStyleBackColor = false;
            // 
            // trainerToolStripMenuItem
            // 
            trainerToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            trainerToolStripMenuItem.ForeColor = Color.White;
            trainerToolStripMenuItem.Name = "trainerToolStripMenuItem";
            trainerToolStripMenuItem.Size = new Size(185, 32);
            trainerToolStripMenuItem.Text = "Trainer";
            trainerToolStripMenuItem.Click += itemTrainer_Click;
            // 
            // FHomeUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel1);
            Controls.Add(pnlLoad);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FHomeUser";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            flowLayoutPanel1.ResumeLayout(false);
            cmnusManagement.ResumeLayout(false);
            cmnusLogOut.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnHome;
        private Panel pnlLoad;
        private Button btnMembership;
        private Button btnBMI;
        private Button btnLogOut;
        private Button btnManagement;
        private ContextMenuStrip cmnusManagement;
        private ToolStripMenuItem itemMember;
        private ToolStripMenuItem itemMembership;
        private Panel panel1;
        private ContextMenuStrip cmnusLogOut;
        private ToolStripMenuItem itemLogOut;
        private ToolStripMenuItem itemQuit;
        private Button button1;
        private Button btnAccount;
        private ToolStripMenuItem trainerToolStripMenuItem;
    }
}