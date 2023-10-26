﻿namespace GymManagementSystem
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMembership = new System.Windows.Forms.Button();
            this.btnManagement = new System.Windows.Forms.Button();
            this.cmnusManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemMember = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMembership = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBMI = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlLoad = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmnusLogOut = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.itemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.cmnusManagement.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cmnusLogOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.flowLayoutPanel1.Controls.Add(this.btnHome);
            this.flowLayoutPanel1.Controls.Add(this.btnMembership);
            this.flowLayoutPanel1.Controls.Add(this.btnManagement);
            this.flowLayoutPanel1.Controls.Add(this.btnBMI);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(100, 750);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::GymManagementSystem.Properties.Resources.home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(63)))), ((int)(((byte)(91)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(63)))), ((int)(((byte)(91)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(23, 27);
            this.btnHome.Margin = new System.Windows.Forms.Padding(23, 27, 23, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 60);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMembership
            // 
            this.btnMembership.BackColor = System.Drawing.Color.Transparent;
            this.btnMembership.BackgroundImage = global::GymManagementSystem.Properties.Resources.vip__1_;
            this.btnMembership.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMembership.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembership.FlatAppearance.BorderSize = 0;
            this.btnMembership.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(63)))), ((int)(((byte)(91)))));
            this.btnMembership.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(63)))), ((int)(((byte)(91)))));
            this.btnMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembership.Location = new System.Drawing.Point(23, 114);
            this.btnMembership.Margin = new System.Windows.Forms.Padding(23, 27, 23, 0);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Size = new System.Drawing.Size(60, 60);
            this.btnMembership.TabIndex = 1;
            this.btnMembership.UseVisualStyleBackColor = false;
            this.btnMembership.Click += new System.EventHandler(this.btnMembership_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnManagement.BackgroundImage = global::GymManagementSystem.Properties.Resources.folder;
            this.btnManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnManagement.ContextMenuStrip = this.cmnusManagement;
            this.btnManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagement.FlatAppearance.BorderSize = 0;
            this.btnManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(63)))), ((int)(((byte)(91)))));
            this.btnManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(63)))), ((int)(((byte)(91)))));
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.Location = new System.Drawing.Point(23, 201);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(23, 27, 23, 0);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(60, 60);
            this.btnManagement.TabIndex = 5;
            this.btnManagement.UseVisualStyleBackColor = false;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // cmnusManagement
            // 
            this.cmnusManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.cmnusManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmnusManagement.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnusManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMember,
            this.itemMembership});
            this.cmnusManagement.Name = "cmnusManagement";
            this.cmnusManagement.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmnusManagement.ShowImageMargin = false;
            this.cmnusManagement.Size = new System.Drawing.Size(175, 68);
            this.cmnusManagement.Text = "Management";
            // 
            // itemMember
            // 
            this.itemMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.itemMember.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemMember.ForeColor = System.Drawing.Color.White;
            this.itemMember.Name = "itemMember";
            this.itemMember.Size = new System.Drawing.Size(174, 32);
            this.itemMember.Text = "Member";
            this.itemMember.Click += new System.EventHandler(this.itemMember_Click);
            // 
            // itemMembership
            // 
            this.itemMembership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.itemMembership.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemMembership.ForeColor = System.Drawing.Color.White;
            this.itemMembership.Name = "itemMembership";
            this.itemMembership.Size = new System.Drawing.Size(174, 32);
            this.itemMembership.Text = "Membership";
            this.itemMembership.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.itemMembership.Click += new System.EventHandler(this.itemMembership_Click);
            // 
            // btnBMI
            // 
            this.btnBMI.BackColor = System.Drawing.Color.Transparent;
            this.btnBMI.BackgroundImage = global::GymManagementSystem.Properties.Resources.bmi;
            this.btnBMI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBMI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBMI.FlatAppearance.BorderSize = 0;
            this.btnBMI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(63)))), ((int)(((byte)(91)))));
            this.btnBMI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(63)))), ((int)(((byte)(91)))));
            this.btnBMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBMI.Location = new System.Drawing.Point(23, 288);
            this.btnBMI.Margin = new System.Windows.Forms.Padding(23, 27, 23, 0);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(60, 60);
            this.btnBMI.TabIndex = 4;
            this.btnBMI.UseVisualStyleBackColor = false;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundImage = global::GymManagementSystem.Properties.Resources.logout;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogOut.ContextMenuStrip = this.cmnusLogOut;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(63)))), ((int)(((byte)(91)))));
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(63)))), ((int)(((byte)(91)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Location = new System.Drawing.Point(17, 216);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(23, 27, 23, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(60, 60);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlLoad
            // 
            this.pnlLoad.Location = new System.Drawing.Point(100, 0);
            this.pnlLoad.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLoad.Name = "pnlLoad";
            this.pnlLoad.Size = new System.Drawing.Size(1820, 1080);
            this.pnlLoad.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Location = new System.Drawing.Point(0, 748);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 300);
            this.panel1.TabIndex = 2;
            // 
            // cmnusLogOut
            // 
            this.cmnusLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.cmnusLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmnusLogOut.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnusLogOut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemLogOut,
            this.itemQuit});
            this.cmnusLogOut.Name = "cmnusLogOut";
            this.cmnusLogOut.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmnusLogOut.ShowImageMargin = false;
            this.cmnusLogOut.Size = new System.Drawing.Size(186, 96);
            this.cmnusLogOut.TabStop = true;
            // 
            // itemLogOut
            // 
            this.itemLogOut.ForeColor = System.Drawing.Color.White;
            this.itemLogOut.Name = "itemLogOut";
            this.itemLogOut.Size = new System.Drawing.Size(185, 32);
            this.itemLogOut.Text = "Log out";
            // 
            // itemQuit
            // 
            this.itemQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.itemQuit.ForeColor = System.Drawing.Color.White;
            this.itemQuit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemQuit.Name = "itemQuit";
            this.itemQuit.Size = new System.Drawing.Size(185, 32);
            this.itemQuit.Text = "Quit";
            this.itemQuit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.itemQuit.Click += new System.EventHandler(this.itemQuit_Click);
            // 
            // FHomeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLoad);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FHomeUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.cmnusManagement.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.cmnusLogOut.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}