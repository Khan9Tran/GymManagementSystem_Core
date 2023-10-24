namespace GymManagementSystem
{
    partial class USMembership
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
            this.ptbMBS = new GymManagementSystem.RJPictureBox();
            this.rjPanel1 = new GymManagementSystem.RJPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMBS)).BeginInit();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbMBS
            // 
            this.ptbMBS.BackColor = System.Drawing.Color.Transparent;
            this.ptbMBS.BorderColor = System.Drawing.Color.White;
            this.ptbMBS.BorderRadius = 40;
            this.ptbMBS.BorderSize = 2;
            this.ptbMBS.ForeColor = System.Drawing.Color.White;
            this.ptbMBS.Location = new System.Drawing.Point(0, 0);
            this.ptbMBS.Name = "ptbMBS";
            this.ptbMBS.Size = new System.Drawing.Size(625, 373);
            this.ptbMBS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMBS.TabIndex = 0;
            this.ptbMBS.TabStop = false;
            this.ptbMBS.Click += new System.EventHandler(this.ptbMBS_Click);
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 40;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.ptbMBS);
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.Location = new System.Drawing.Point(0, 0);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(625, 373);
            this.rjPanel1.TabIndex = 1;
            // 
            // USMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rjPanel1);
            this.Name = "USMembership";
            this.Size = new System.Drawing.Size(625, 373);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMBS)).EndInit();
            this.rjPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RJPictureBox ptbMBS;
        private RJPanel rjPanel1;
    }
}
