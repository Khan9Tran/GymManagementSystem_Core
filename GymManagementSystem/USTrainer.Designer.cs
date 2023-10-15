namespace GymManagementSystem
{
    partial class USTrainer
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
            this.btnTrainer = new GymManagementSystem.RJButton();
            this.SuspendLayout();
            // 
            // btnTrainer
            // 
            this.btnTrainer.BackColor = System.Drawing.Color.White;
            this.btnTrainer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTrainer.BorderRadius = 40;
            this.btnTrainer.BorderSize = 0;
            this.btnTrainer.FlatAppearance.BorderSize = 0;
            this.btnTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainer.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTrainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.btnTrainer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrainer.Location = new System.Drawing.Point(0, 0);
            this.btnTrainer.Name = "btnTrainer";
            this.btnTrainer.Size = new System.Drawing.Size(480, 80);
            this.btnTrainer.TabIndex = 0;
            this.btnTrainer.UseVisualStyleBackColor = false;
            this.btnTrainer.Click += new System.EventHandler(this.btnTrainer_Click);
            // 
            // USTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnTrainer);
            this.Name = "USTrainer";
            this.Size = new System.Drawing.Size(480, 80);
            this.Click += new System.EventHandler(this.USTrainer_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private RJButton btnTrainer;
    }
}
