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
            rjPanel1 = new RJPanel();
            rjPanel2 = new RJPanel();
            textBox1 = new TextBox();
            rjButton1 = new RJButton();
            rjFlowLayoutPanel1.SuspendLayout();
            rjPanel1.SuspendLayout();
            rjPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // rjFlowLayoutPanel1
            // 
            rjFlowLayoutPanel1.BackColor = Color.FromArgb(230, 230, 230);
            rjFlowLayoutPanel1.BorderColor = Color.PaleVioletRed;
            rjFlowLayoutPanel1.BorderRadius = 20;
            rjFlowLayoutPanel1.BorderSize = 0;
            rjFlowLayoutPanel1.Controls.Add(flpContainerPackage);
            rjFlowLayoutPanel1.ForeColor = Color.White;
            rjFlowLayoutPanel1.Location = new Point(862, 95);
            rjFlowLayoutPanel1.Margin = new Padding(0);
            rjFlowLayoutPanel1.Name = "rjFlowLayoutPanel1";
            rjFlowLayoutPanel1.Size = new Size(921, 889);
            rjFlowLayoutPanel1.TabIndex = 0;
            // 
            // flpContainerPackage
            // 
            flpContainerPackage.AutoScroll = true;
            flpContainerPackage.BackColor = Color.FromArgb(230, 230, 230);
            flpContainerPackage.Location = new Point(3, 30);
            flpContainerPackage.Margin = new Padding(3, 30, 0, 0);
            flpContainerPackage.Name = "flpContainerPackage";
            flpContainerPackage.Size = new Size(918, 834);
            flpContainerPackage.TabIndex = 3;
            // 
            // rjPanel1
            // 
            rjPanel1.BackColor = Color.FromArgb(230, 230, 230);
            rjPanel1.BorderColor = Color.White;
            rjPanel1.BorderRadius = 20;
            rjPanel1.BorderSize = 0;
            rjPanel1.Controls.Add(rjPanel2);
            rjPanel1.Controls.Add(rjButton1);
            rjPanel1.ForeColor = Color.White;
            rjPanel1.Location = new Point(68, 95);
            rjPanel1.Name = "rjPanel1";
            rjPanel1.Size = new Size(747, 889);
            rjPanel1.TabIndex = 2;
            // 
            // rjPanel2
            // 
            rjPanel2.BackColor = Color.White;
            rjPanel2.BorderColor = Color.White;
            rjPanel2.BorderRadius = 20;
            rjPanel2.BorderSize = 0;
            rjPanel2.Controls.Add(textBox1);
            rjPanel2.ForeColor = Color.White;
            rjPanel2.Location = new Point(115, 118);
            rjPanel2.Name = "rjPanel2";
            rjPanel2.Size = new Size(450, 50);
            rjPanel2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(59, 41, 55);
            textBox1.Location = new Point(3, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(444, 31);
            textBox1.TabIndex = 0;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(59, 41, 55);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 25;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(254, 30);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(232, 49);
            rjButton1.TabIndex = 0;
            rjButton1.Text = "Purchase Package";
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // FPurchasePackage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1820, 1080);
            Controls.Add(rjPanel1);
            Controls.Add(rjFlowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(100, 0);
            Name = "FPurchasePackage";
            Text = "FRegisterPackage";
            rjFlowLayoutPanel1.ResumeLayout(false);
            rjPanel1.ResumeLayout(false);
            rjPanel2.ResumeLayout(false);
            rjPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RJFlowLayoutPanel rjFlowLayoutPanel1;
        private FlowLayoutPanel flpContainerPackage;
        private RJPanel rjPanel1;
        private RJButton rjButton1;
        private RJPanel rjPanel2;
        private TextBox textBox1;
    }
}