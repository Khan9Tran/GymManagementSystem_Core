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
            itemMemberSelect = new ToolStripMenuItem();
            itemMember = new ToolStripMenuItem();
            itemMemebrship = new ToolStripMenuItem();
            itemTrainer = new ToolStripMenuItem();
            itemBranch = new ToolStripMenuItem();
            equipmentToolStripMenuItem = new ToolStripMenuItem();
            itemCategory = new ToolStripMenuItem();
            itemEquipment = new ToolStripMenuItem();
            itemWorkout = new ToolStripMenuItem();
            itemPackage = new ToolStripMenuItem();
            itemPayment = new ToolStripMenuItem();
            btnBMI = new Button();
            btnEquipmentData = new Button();
            btnLogOut = new Button();
            cmnusLogOut = new ContextMenuStrip(components);
            itemLogOut = new ToolStripMenuItem();
            itemQuit = new ToolStripMenuItem();
            pnlLoad = new Panel();
            panel1 = new Panel();
            btnBack = new Button();
            btnAccount = new Button();
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
            flowLayoutPanel1.Controls.Add(btnEquipmentData);
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
            cmnusManagement.Items.AddRange(new ToolStripItem[] { itemMemberSelect, itemTrainer, itemBranch, equipmentToolStripMenuItem, itemWorkout, itemPackage, itemPayment });
            cmnusManagement.Name = "cmnusManagement";
            cmnusManagement.RenderMode = ToolStripRenderMode.Professional;
            cmnusManagement.ShowImageMargin = false;
            cmnusManagement.Size = new Size(186, 256);
            cmnusManagement.Text = "Management";
            cmnusManagement.Opening += cmnusManagement_Opening;
            // 
            // itemMemberSelect
            // 
            itemMemberSelect.BackColor = Color.FromArgb(44, 181, 245);
            itemMemberSelect.DropDownItems.AddRange(new ToolStripItem[] { itemMember, itemMemebrship });
            itemMemberSelect.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            itemMemberSelect.ForeColor = Color.White;
            itemMemberSelect.Name = "itemMemberSelect";
            itemMemberSelect.Size = new Size(185, 32);
            itemMemberSelect.Text = "Member";
            // 
            // itemMember
            // 
            itemMember.Name = "itemMember";
            itemMember.Size = new Size(213, 32);
            itemMember.Text = "All Members";
            itemMember.Click += itemMember_Click;
            // 
            // itemMemebrship
            // 
            itemMemebrship.Name = "itemMemebrship";
            itemMemebrship.Size = new Size(213, 32);
            itemMemebrship.Text = "Membership";
            itemMemebrship.Click += itemMemebrship_Click;
            // 
            // itemTrainer
            // 
            itemTrainer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            itemTrainer.ForeColor = Color.White;
            itemTrainer.Name = "itemTrainer";
            itemTrainer.Size = new Size(185, 32);
            itemTrainer.Text = "Trainer";
            itemTrainer.Click += itemTrainer_Click;
            // 
            // itemBranch
            // 
            itemBranch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            itemBranch.ForeColor = Color.White;
            itemBranch.Name = "itemBranch";
            itemBranch.Size = new Size(185, 32);
            itemBranch.Text = "Branch";
            itemBranch.Click += itemBranch_Click;
            // 
            // equipmentToolStripMenuItem
            // 
            equipmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itemCategory, itemEquipment });
            equipmentToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            equipmentToolStripMenuItem.ForeColor = Color.White;
            equipmentToolStripMenuItem.Name = "equipmentToolStripMenuItem";
            equipmentToolStripMenuItem.Size = new Size(185, 32);
            equipmentToolStripMenuItem.Text = "Equipment";
            // 
            // itemCategory
            // 
            itemCategory.Name = "itemCategory";
            itemCategory.Size = new Size(236, 32);
            itemCategory.Text = "Category";
            itemCategory.Click += itemCategory_Click;
            // 
            // itemEquipment
            // 
            itemEquipment.Name = "itemEquipment";
            itemEquipment.Size = new Size(236, 32);
            itemEquipment.Text = "All equipments";
            itemEquipment.Click += itemEquipment_Click;
            // 
            // itemWorkout
            // 
            itemWorkout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            itemWorkout.ForeColor = Color.White;
            itemWorkout.Name = "itemWorkout";
            itemWorkout.Size = new Size(185, 32);
            itemWorkout.Text = "Workout";
            itemWorkout.Click += itemWorkout_Click;
            // 
            // itemPackage
            // 
            itemPackage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            itemPackage.ForeColor = Color.White;
            itemPackage.Name = "itemPackage";
            itemPackage.Size = new Size(185, 32);
            itemPackage.Text = "Package";
            // 
            // itemPayment
            // 
            itemPayment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            itemPayment.ForeColor = Color.White;
            itemPayment.Name = "itemPayment";
            itemPayment.Size = new Size(185, 32);
            itemPayment.Text = "Payment";
            itemPayment.Click += itemPayment_Click;
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
            // btnEquipmentData
            // 
            btnEquipmentData.BackColor = Color.Transparent;
            btnEquipmentData.BackgroundImage = Properties.Resources.equipment;
            btnEquipmentData.BackgroundImageLayout = ImageLayout.Center;
            btnEquipmentData.Cursor = Cursors.Hand;
            btnEquipmentData.FlatAppearance.BorderSize = 0;
            btnEquipmentData.FlatAppearance.MouseDownBackColor = Color.FromArgb(99, 63, 91);
            btnEquipmentData.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 63, 91);
            btnEquipmentData.FlatStyle = FlatStyle.Flat;
            btnEquipmentData.Location = new Point(23, 375);
            btnEquipmentData.Margin = new Padding(23, 27, 23, 0);
            btnEquipmentData.Name = "btnEquipmentData";
            btnEquipmentData.Size = new Size(60, 60);
            btnEquipmentData.TabIndex = 6;
            btnEquipmentData.UseVisualStyleBackColor = false;
            btnEquipmentData.Click += btnEquipmentData_Click;
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
            itemLogOut.Click += btnLogOut_Click;
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
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(btnLogOut);
            panel1.Location = new Point(0, 748);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 300);
            panel1.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = Properties.Resources.undo;
            btnBack.BackgroundImageLayout = ImageLayout.Center;
            btnBack.ContextMenuStrip = cmnusLogOut;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(99, 63, 91);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 63, 91);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(23, 33);
            btnBack.Margin = new Padding(23, 27, 23, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(60, 60);
            btnBack.TabIndex = 5;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
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
            btnAccount.Click += btnAccount_Click;
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
        private ToolStripMenuItem itemMemberSelect;
        private Panel panel1;
        private ContextMenuStrip cmnusLogOut;
        private ToolStripMenuItem itemLogOut;
        private ToolStripMenuItem itemQuit;
        private Button btnBack;
        private Button btnAccount;
        private ToolStripMenuItem itemTrainer;
        private ToolStripMenuItem itemBranch;
        private ToolStripMenuItem equipmentToolStripMenuItem;
        private ToolStripMenuItem itemCategory;
        private ToolStripMenuItem itemEquipment;
        private ToolStripMenuItem itemWorkout;
        private ToolStripMenuItem itemPackage;
        private ToolStripMenuItem itemPayment;
        private ToolStripMenuItem itemMember;
        private ToolStripMenuItem itemMemebrship;
        private Button btnEquipmentData;
    }
}