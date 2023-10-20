namespace GymManagementSystem
{
    partial class FPurchasePackage
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
            rjFlowLayoutPanel1 = new RJFlowLayoutPanel();
            flpContainerPackage = new FlowLayoutPanel();
            rjFlowLayoutPanel2 = new RJFlowLayoutPanel();
            rjFlowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // rjFlowLayoutPanel1
            // 
            rjFlowLayoutPanel1.BackColor = Color.FromArgb(230, 230, 230);
            rjFlowLayoutPanel1.BorderColor = Color.PaleVioletRed;
            rjFlowLayoutPanel1.BorderRadius = 40;
            rjFlowLayoutPanel1.BorderSize = 0;
            rjFlowLayoutPanel1.Controls.Add(flpContainerPackage);
            rjFlowLayoutPanel1.ForeColor = Color.White;
            rjFlowLayoutPanel1.Location = new Point(865, 95);
            rjFlowLayoutPanel1.Name = "rjFlowLayoutPanel1";
            rjFlowLayoutPanel1.Size = new Size(918, 889);
            rjFlowLayoutPanel1.TabIndex = 0;
            // 
            // flpContainerPackage
            // 
            flpContainerPackage.AutoScroll = true;
            flpContainerPackage.BackColor = Color.FromArgb(230, 230, 230);
            flpContainerPackage.Location = new Point(0, 0);
            flpContainerPackage.Margin = new Padding(0);
            flpContainerPackage.Name = "flpContainerPackage";
            flpContainerPackage.Size = new Size(918, 858);
            flpContainerPackage.TabIndex = 3;
            // 
            // rjFlowLayoutPanel2
            // 
            rjFlowLayoutPanel2.BackColor = Color.MediumSlateBlue;
            rjFlowLayoutPanel2.BorderColor = Color.PaleVioletRed;
            rjFlowLayoutPanel2.BorderRadius = 40;
            rjFlowLayoutPanel2.BorderSize = 0;
            rjFlowLayoutPanel2.ForeColor = Color.White;
            rjFlowLayoutPanel2.Location = new Point(65, 95);
            rjFlowLayoutPanel2.Name = "rjFlowLayoutPanel2";
            rjFlowLayoutPanel2.Size = new Size(750, 889);
            rjFlowLayoutPanel2.TabIndex = 1;
            // 
            // FPurchasePackage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1820, 1080);
            Controls.Add(rjFlowLayoutPanel2);
            Controls.Add(rjFlowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(100, 0);
            Name = "FPurchasePackage";
            Text = "FRegisterPackage";
            rjFlowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private RJFlowLayoutPanel rjFlowLayoutPanel1;
        private FlowLayoutPanel flpContainerPackage;
        private RJFlowLayoutPanel rjFlowLayoutPanel2;
    }
}