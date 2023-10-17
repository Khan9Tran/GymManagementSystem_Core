namespace GymManagementSystem
{
    partial class USWorkOut
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
            this.pnlWorkout = new GymManagementSystem.RJPanel();
            this.ptcWorkOut = new GymManagementSystem.RJPictureBox();
            this.pnlLoad = new GymManagementSystem.RJPanel();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlWorkout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcWorkOut)).BeginInit();
            this.pnlLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorkout
            // 
            this.pnlWorkout.BackColor = System.Drawing.Color.White;
            this.pnlWorkout.BorderColor = System.Drawing.Color.White;
            this.pnlWorkout.BorderRadius = 40;
            this.pnlWorkout.BorderSize = 2;
            this.pnlWorkout.Controls.Add(this.ptcWorkOut);
            this.pnlWorkout.Controls.Add(this.pnlLoad);
            this.pnlWorkout.ForeColor = System.Drawing.Color.White;
            this.pnlWorkout.Location = new System.Drawing.Point(0, 0);
            this.pnlWorkout.Name = "pnlWorkout";
            this.pnlWorkout.Size = new System.Drawing.Size(580, 200);
            this.pnlWorkout.TabIndex = 0;
            this.pnlWorkout.Click += new System.EventHandler(this.pnlWorkout_Click);
            // 
            // ptcWorkOut
            // 
            this.ptcWorkOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ptcWorkOut.BorderColor = System.Drawing.Color.White;
            this.ptcWorkOut.BorderRadius = 40;
            this.ptcWorkOut.BorderSize = 2;
            this.ptcWorkOut.ForeColor = System.Drawing.Color.White;
            this.ptcWorkOut.Location = new System.Drawing.Point(23, 22);
            this.ptcWorkOut.Name = "ptcWorkOut";
            this.ptcWorkOut.Size = new System.Drawing.Size(138, 162);
            this.ptcWorkOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcWorkOut.TabIndex = 4;
            this.ptcWorkOut.TabStop = false;
            this.ptcWorkOut.Click += new System.EventHandler(this.ptcWorkOut_Click);
            // 
            // pnlLoad
            // 
            this.pnlLoad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLoad.BorderColor = System.Drawing.Color.White;
            this.pnlLoad.BorderRadius = 40;
            this.pnlLoad.BorderSize = 2;
            this.pnlLoad.Controls.Add(this.lblDuration);
            this.pnlLoad.Controls.Add(this.lblType);
            this.pnlLoad.Controls.Add(this.lblName);
            this.pnlLoad.ForeColor = System.Drawing.Color.White;
            this.pnlLoad.Location = new System.Drawing.Point(183, 22);
            this.pnlLoad.Name = "pnlLoad";
            this.pnlLoad.Size = new System.Drawing.Size(378, 162);
            this.pnlLoad.TabIndex = 4;
            this.pnlLoad.Click += new System.EventHandler(this.pnlLoad_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.lblDuration.Location = new System.Drawing.Point(87, 122);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(55, 23);
            this.lblDuration.TabIndex = 1;
            this.lblDuration.Text = "label1";
            this.lblDuration.Click += new System.EventHandler(this.lblDuration_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.lblType.Location = new System.Drawing.Point(16, 69);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(71, 30);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "label3";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.lblName.Location = new System.Drawing.Point(16, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 30);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "label2";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // USWorkOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlWorkout);
            this.Name = "USWorkOut";
            this.Size = new System.Drawing.Size(580, 200);
            this.pnlWorkout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcWorkOut)).EndInit();
            this.pnlLoad.ResumeLayout(false);
            this.pnlLoad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RJPanel pnlWorkout;
        private RJPanel pnlLoad;
        private Label lblDuration;
        private Label lblType;
        private Label lblName;
        private RJPictureBox ptcWorkOut;
    }
}
