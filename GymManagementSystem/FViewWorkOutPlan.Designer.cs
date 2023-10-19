using GymManagementSystem;

namespace GymManagementSystem
{
    partial class FViewWorkOutPlan
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
            this.gvWorkOutPlan = new System.Windows.Forms.DataGridView();
            this.rjFlowLayoutPanel1 = new GymManagementSystem.RJFlowLayoutPanel();
            this.btnAll = new GymManagementSystem.RJButton();
            this.btnCurrent = new GymManagementSystem.RJButton();
            this.btnInDay = new GymManagementSystem.RJButton();
            this.btnUpComing = new GymManagementSystem.RJButton();
            this.rjFlowLayoutPanel2 = new GymManagementSystem.RJFlowLayoutPanel();
            this.btnAdd = new GymManagementSystem.RJButton();
            this.btnEdit = new GymManagementSystem.RJButton();
            this.rjButton1 = new GymManagementSystem.RJButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rjPanel1 = new GymManagementSystem.RJPanel();
            this.btnSearch = new GymManagementSystem.RJButton();
            this.rjPanel2 = new GymManagementSystem.RJPanel();
            this.rjPanel3 = new GymManagementSystem.RJPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkOutPlan)).BeginInit();
            this.rjFlowLayoutPanel1.SuspendLayout();
            this.rjFlowLayoutPanel2.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvWorkOutPlan
            // 
            this.gvWorkOutPlan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvWorkOutPlan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvWorkOutPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWorkOutPlan.Location = new System.Drawing.Point(100, 317);
            this.gvWorkOutPlan.Name = "gvWorkOutPlan";
            this.gvWorkOutPlan.RowHeadersWidth = 51;
            this.gvWorkOutPlan.RowTemplate.Height = 29;
            this.gvWorkOutPlan.Size = new System.Drawing.Size(1625, 665);
            this.gvWorkOutPlan.TabIndex = 0;
            // 
            // rjFlowLayoutPanel1
            // 
            this.rjFlowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjFlowLayoutPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.rjFlowLayoutPanel1.BorderRadius = 40;
            this.rjFlowLayoutPanel1.BorderSize = 0;
            this.rjFlowLayoutPanel1.Controls.Add(this.btnAll);
            this.rjFlowLayoutPanel1.Controls.Add(this.btnCurrent);
            this.rjFlowLayoutPanel1.Controls.Add(this.btnInDay);
            this.rjFlowLayoutPanel1.Controls.Add(this.btnUpComing);
            this.rjFlowLayoutPanel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rjFlowLayoutPanel1.Location = new System.Drawing.Point(94, 74);
            this.rjFlowLayoutPanel1.Name = "rjFlowLayoutPanel1";
            this.rjFlowLayoutPanel1.Size = new System.Drawing.Size(596, 54);
            this.rjFlowLayoutPanel1.TabIndex = 1;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.btnAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAll.BorderRadius = 40;
            this.btnAll.BorderSize = 0;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(3, 3);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(140, 50);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnCurrent
            // 
            this.btnCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.btnCurrent.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCurrent.BorderRadius = 40;
            this.btnCurrent.BorderSize = 0;
            this.btnCurrent.FlatAppearance.BorderSize = 0;
            this.btnCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrent.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCurrent.ForeColor = System.Drawing.Color.White;
            this.btnCurrent.Location = new System.Drawing.Point(149, 3);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(140, 50);
            this.btnCurrent.TabIndex = 4;
            this.btnCurrent.Text = "Current";
            this.btnCurrent.UseVisualStyleBackColor = false;
            this.btnCurrent.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // btnInDay
            // 
            this.btnInDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.btnInDay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInDay.BorderRadius = 40;
            this.btnInDay.BorderSize = 0;
            this.btnInDay.FlatAppearance.BorderSize = 0;
            this.btnInDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInDay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInDay.ForeColor = System.Drawing.Color.White;
            this.btnInDay.Location = new System.Drawing.Point(295, 3);
            this.btnInDay.Name = "btnInDay";
            this.btnInDay.Size = new System.Drawing.Size(140, 50);
            this.btnInDay.TabIndex = 5;
            this.btnInDay.Text = "In Day";
            this.btnInDay.UseVisualStyleBackColor = false;
            this.btnInDay.Click += new System.EventHandler(this.btnInDay_Click);
            // 
            // btnUpComing
            // 
            this.btnUpComing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.btnUpComing.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpComing.BorderRadius = 40;
            this.btnUpComing.BorderSize = 0;
            this.btnUpComing.FlatAppearance.BorderSize = 0;
            this.btnUpComing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpComing.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpComing.ForeColor = System.Drawing.Color.White;
            this.btnUpComing.Location = new System.Drawing.Point(441, 3);
            this.btnUpComing.Name = "btnUpComing";
            this.btnUpComing.Size = new System.Drawing.Size(140, 50);
            this.btnUpComing.TabIndex = 6;
            this.btnUpComing.Text = "UpComing";
            this.btnUpComing.UseVisualStyleBackColor = false;
            this.btnUpComing.Click += new System.EventHandler(this.btnUpcoming_Click);
            // 
            // rjFlowLayoutPanel2
            // 
            this.rjFlowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjFlowLayoutPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjFlowLayoutPanel2.BorderRadius = 40;
            this.rjFlowLayoutPanel2.BorderSize = 0;
            this.rjFlowLayoutPanel2.Controls.Add(this.btnAdd);
            this.rjFlowLayoutPanel2.Controls.Add(this.btnEdit);
            this.rjFlowLayoutPanel2.Controls.Add(this.rjButton1);
            this.rjFlowLayoutPanel2.ForeColor = System.Drawing.Color.White;
            this.rjFlowLayoutPanel2.Location = new System.Drawing.Point(1279, 74);
            this.rjFlowLayoutPanel2.Name = "rjFlowLayoutPanel2";
            this.rjFlowLayoutPanel2.Size = new System.Drawing.Size(446, 54);
            this.rjFlowLayoutPanel2.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 40;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 40;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(154, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 50);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 40;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(300, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(140, 50);
            this.rjButton1.TabIndex = 2;
            this.rjButton1.Text = "Delete";
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.txtSearch.Location = new System.Drawing.Point(15, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(493, 31);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjPanel1.BorderColor = System.Drawing.Color.Black;
            this.rjPanel1.BorderRadius = 40;
            this.rjPanel1.BorderSize = 1;
            this.rjPanel1.Controls.Add(this.txtSearch);
            this.rjPanel1.Controls.Add(this.btnSearch);
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.Location = new System.Drawing.Point(696, 78);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(573, 52);
            this.rjPanel1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 40;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::GymManagementSystem.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(526, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel2.BorderRadius = 40;
            this.rjPanel2.BorderSize = 0;
            this.rjPanel2.ForeColor = System.Drawing.Color.White;
            this.rjPanel2.Location = new System.Drawing.Point(1279, 162);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(440, 121);
            this.rjPanel2.TabIndex = 4;
            // 
            // rjPanel3
            // 
            this.rjPanel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjPanel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel3.BorderRadius = 40;
            this.rjPanel3.BorderSize = 0;
            this.rjPanel3.ForeColor = System.Drawing.Color.White;
            this.rjPanel3.Location = new System.Drawing.Point(94, 162);
            this.rjPanel3.Name = "rjPanel3";
            this.rjPanel3.Size = new System.Drawing.Size(1110, 121);
            this.rjPanel3.TabIndex = 5;
            // 
            // FViewWorkOutPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1820, 1080);
            this.Controls.Add(this.rjPanel3);
            this.Controls.Add(this.rjPanel2);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.rjFlowLayoutPanel2);
            this.Controls.Add(this.rjFlowLayoutPanel1);
            this.Controls.Add(this.gvWorkOutPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FViewWorkOutPlan";
            this.Text = "FViewWorkOutPlan";
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkOutPlan)).EndInit();
            this.rjFlowLayoutPanel1.ResumeLayout(false);
            this.rjFlowLayoutPanel2.ResumeLayout(false);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView gvWorkOutPlan;
        private RJFlowLayoutPanel rjFlowLayoutPanel1;
        private RJFlowLayoutPanel rjFlowLayoutPanel2;
        private RJButton btnAdd;
        private RJButton btnEdit;
        private RJButton btnAll;
        private RJButton btnCurrent;
        private RJButton btnInDay;
        private TextBox txtSearch;
        private RJPanel rjPanel1;
        private RJButton btnSearch;
        private RJButton rjButton1;
        private RJButton btnUpComing;
        private RJPanel rjPanel2;
        private RJPanel rjPanel3;
    }
}