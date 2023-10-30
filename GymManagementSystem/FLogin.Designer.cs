namespace GymManagementSystem
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            rjPanel7 = new RJPanel();
            label1 = new Label();
            rjPanel8 = new RJPanel();
            txtFullName = new TextBox();
            rjPanel1 = new RJPanel();
            lblPass = new Label();
            rjPanel2 = new RJPanel();
            txtPassword = new TextBox();
            label2 = new Label();
            btnLogin = new RJButton();
            label3 = new Label();
            rjPanel7.SuspendLayout();
            rjPanel8.SuspendLayout();
            rjPanel1.SuspendLayout();
            rjPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // rjPanel7
            // 
            rjPanel7.BackColor = Color.White;
            rjPanel7.BorderColor = Color.White;
            rjPanel7.BorderRadius = 40;
            rjPanel7.BorderSize = 2;
            rjPanel7.Controls.Add(label1);
            rjPanel7.Controls.Add(rjPanel8);
            rjPanel7.ForeColor = Color.White;
            rjPanel7.Location = new Point(89, 94);
            rjPanel7.Name = "rjPanel7";
            rjPanel7.Size = new Size(622, 82);
            rjPanel7.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(59, 41, 55);
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 4;
            label1.Text = "User name";
            // 
            // rjPanel8
            // 
            rjPanel8.BackColor = Color.White;
            rjPanel8.BorderColor = Color.FromArgb(44, 181, 245);
            rjPanel8.BorderRadius = 40;
            rjPanel8.BorderSize = 2;
            rjPanel8.Controls.Add(txtFullName);
            rjPanel8.ForeColor = Color.White;
            rjPanel8.Location = new Point(220, 14);
            rjPanel8.Name = "rjPanel8";
            rjPanel8.Size = new Size(366, 59);
            rjPanel8.TabIndex = 0;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.ForeColor = Color.FromArgb(44, 181, 245);
            txtFullName.Location = new Point(31, 15);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(304, 29);
            txtFullName.TabIndex = 0;
            // 
            // rjPanel1
            // 
            rjPanel1.BackColor = Color.White;
            rjPanel1.BorderColor = Color.White;
            rjPanel1.BorderRadius = 40;
            rjPanel1.BorderSize = 2;
            rjPanel1.Controls.Add(lblPass);
            rjPanel1.Controls.Add(rjPanel2);
            rjPanel1.ForeColor = Color.White;
            rjPanel1.Location = new Point(89, 217);
            rjPanel1.Name = "rjPanel1";
            rjPanel1.Size = new Size(622, 82);
            rjPanel1.TabIndex = 7;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.ForeColor = Color.FromArgb(59, 41, 55);
            lblPass.Location = new Point(23, 28);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(101, 28);
            lblPass.TabIndex = 4;
            lblPass.Text = "Password";
            // 
            // rjPanel2
            // 
            rjPanel2.BackColor = Color.White;
            rjPanel2.BorderColor = Color.FromArgb(44, 181, 245);
            rjPanel2.BorderRadius = 40;
            rjPanel2.BorderSize = 2;
            rjPanel2.Controls.Add(txtPassword);
            rjPanel2.ForeColor = Color.White;
            rjPanel2.Location = new Point(220, 12);
            rjPanel2.Name = "rjPanel2";
            rjPanel2.Size = new Size(366, 59);
            rjPanel2.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(44, 181, 245);
            txtPassword.Location = new Point(31, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(304, 29);
            txtPassword.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(44, 181, 245);
            label2.Location = new Point(260, 21);
            label2.Name = "label2";
            label2.Size = new Size(273, 45);
            label2.TabIndex = 8;
            label2.Text = "MONSTER GYM";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.BorderColor = Color.FromArgb(44, 181, 245);
            btnLogin.BorderRadius = 40;
            btnLogin.BorderSize = 2;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Image = Properties.Resources.gym;
            btnLogin.Location = new Point(330, 346);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(188, 50);
            btnLogin.TabIndex = 9;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(67, 52, 67);
            label3.Location = new Point(12, 421);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 10;
            label3.Text = "Designed by NHOM4";
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 41, 55);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(rjPanel1);
            Controls.Add(rjPanel7);
            ForeColor = SystemColors.ControlLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monster gym";
            rjPanel7.ResumeLayout(false);
            rjPanel7.PerformLayout();
            rjPanel8.ResumeLayout(false);
            rjPanel8.PerformLayout();
            rjPanel1.ResumeLayout(false);
            rjPanel1.PerformLayout();
            rjPanel2.ResumeLayout(false);
            rjPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RJPanel rjPanel7;
        private Label label1;
        private RJPanel rjPanel8;
        private TextBox txtFullName;
        private RJPanel rjPanel1;
        private Label lblPass;
        private RJPanel rjPanel2;
        private Label label2;
        private RJButton btnLogin;
        private Label label3;
        private TextBox txtPassword;
    }
}