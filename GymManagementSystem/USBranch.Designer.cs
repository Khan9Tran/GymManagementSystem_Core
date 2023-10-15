namespace GymManagementSystem
{
    partial class USBranch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBranch = new GymManagementSystem.RJButton();
            this.SuspendLayout();
            // 
            // btnBranch
            // 
            this.btnBranch.BackColor = System.Drawing.Color.White;
            this.btnBranch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBranch.BorderRadius = 40;
            this.btnBranch.BorderSize = 0;
            this.btnBranch.FlatAppearance.BorderSize = 0;
            this.btnBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBranch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.btnBranch.Location = new System.Drawing.Point(0, 0);
            this.btnBranch.Name = "btnBranch";
            this.btnBranch.Size = new System.Drawing.Size(234, 54);
            this.btnBranch.TabIndex = 0;
            this.btnBranch.UseVisualStyleBackColor = false;
            this.btnBranch.Click += new System.EventHandler(this.btnBranch_Click);
            // 
            // USBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnBranch);
            this.Name = "USBranch";
            this.Size = new System.Drawing.Size(234, 54);
            this.Click += new System.EventHandler(this.USBranch_Click);
            this.ResumeLayout(false);

        }

        #endregion

        public RJButton btnBranch;
    }
}
