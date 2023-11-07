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
            this.rjPanel7 = new GymManagementSystem.RJPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlName = new GymManagementSystem.RJPanel();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlPass = new GymManagementSystem.RJPanel();
            this.lblPass = new System.Windows.Forms.Label();
            this.rjPanel2 = new GymManagementSystem.RJPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new GymManagementSystem.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rjPanel7.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.pnlPass.SuspendLayout();
            this.rjPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjPanel7
            // 
            this.rjPanel7.BackColor = System.Drawing.Color.White;
            this.rjPanel7.BorderColor = System.Drawing.Color.White;
            this.rjPanel7.BorderRadius = 40;
            this.rjPanel7.BorderSize = 2;
            this.rjPanel7.Controls.Add(this.label1);
            this.rjPanel7.Controls.Add(this.pnlName);
            this.rjPanel7.ForeColor = System.Drawing.Color.White;
            this.rjPanel7.Location = new System.Drawing.Point(89, 94);
            this.rjPanel7.Name = "rjPanel7";
            this.rjPanel7.Size = new System.Drawing.Size(622, 82);
            this.rjPanel7.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "User name";
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.White;
            this.pnlName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.pnlName.BorderRadius = 40;
            this.pnlName.BorderSize = 2;
            this.pnlName.Controls.Add(this.txtFullName);
            this.pnlName.ForeColor = System.Drawing.Color.White;
            this.pnlName.Location = new System.Drawing.Point(220, 14);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(366, 59);
            this.pnlName.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.White;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.txtFullName.Location = new System.Drawing.Point(21, 15);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(304, 29);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.txtPassword.Location = new System.Drawing.Point(21, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(304, 29);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // pnlPass
            // 
            this.pnlPass.BackColor = System.Drawing.Color.White;
            this.pnlPass.BorderColor = System.Drawing.Color.White;
            this.pnlPass.BorderRadius = 40;
            this.pnlPass.BorderSize = 2;
            this.pnlPass.Controls.Add(this.lblPass);
            this.pnlPass.Controls.Add(this.rjPanel2);
            this.pnlPass.ForeColor = System.Drawing.Color.White;
            this.pnlPass.Location = new System.Drawing.Point(89, 217);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(622, 82);
            this.pnlPass.TabIndex = 7;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblPass.Location = new System.Drawing.Point(23, 28);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(101, 28);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Password";
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.White;
            this.rjPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.rjPanel2.BorderRadius = 40;
            this.rjPanel2.BorderSize = 2;
            this.rjPanel2.Controls.Add(this.txtPassword);
            this.rjPanel2.ForeColor = System.Drawing.Color.White;
            this.rjPanel2.Location = new System.Drawing.Point(220, 12);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(366, 59);
            this.rjPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(260, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 45);
            this.label2.TabIndex = 8;
            this.label2.Text = "MONSTER GYM";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.btnLogin.BorderRadius = 40;
            this.btnLogin.BorderSize = 2;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = global::GymManagementSystem.Properties.Resources.gym;
            this.btnLogin.Location = new System.Drawing.Point(330, 346);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(188, 50);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.label3.Location = new System.Drawing.Point(12, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Designed by NHOM4";
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlPass);
            this.Controls.Add(this.rjPanel7);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monster gym";
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.rjPanel7.ResumeLayout(false);
            this.rjPanel7.PerformLayout();
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlPass.ResumeLayout(false);
            this.pnlPass.PerformLayout();
            this.rjPanel2.ResumeLayout(false);
            this.rjPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJPanel rjPanel7;
        private Label label1;
        private RJPanel pnlName;
        private RJPanel pnlPass;
        private Label lblPass;
        private RJPanel rjPanel2;
        private Label label2;
        private RJButton btnLogin;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtFullName;
    }
}