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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.rjPanel3 = new GymManagementSystem.RJPanel();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblTrainer = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.rjPanel4 = new GymManagementSystem.RJPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkOutPlan)).BeginInit();
            this.rjFlowLayoutPanel1.SuspendLayout();
            this.rjFlowLayoutPanel2.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            this.rjPanel2.SuspendLayout();
            this.rjPanel3.SuspendLayout();
            this.rjPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvWorkOutPlan
            // 
            this.gvWorkOutPlan.AllowUserToAddRows = false;
            this.gvWorkOutPlan.AllowUserToDeleteRows = false;
            this.gvWorkOutPlan.AllowUserToResizeColumns = false;
            this.gvWorkOutPlan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gvWorkOutPlan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvWorkOutPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvWorkOutPlan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvWorkOutPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvWorkOutPlan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvWorkOutPlan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gvWorkOutPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvWorkOutPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvWorkOutPlan.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvWorkOutPlan.Location = new System.Drawing.Point(3, 0);
            this.gvWorkOutPlan.Name = "gvWorkOutPlan";
            this.gvWorkOutPlan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvWorkOutPlan.RowHeadersVisible = false;
            this.gvWorkOutPlan.RowHeadersWidth = 51;
            this.gvWorkOutPlan.RowTemplate.Height = 29;
            this.gvWorkOutPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvWorkOutPlan.Size = new System.Drawing.Size(1631, 605);
            this.gvWorkOutPlan.TabIndex = 0;
            this.gvWorkOutPlan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvWorkOutPlan_CellClick);
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
            this.rjPanel2.Controls.Add(this.dtpTime);
            this.rjPanel2.Controls.Add(this.dtpDate);
            this.rjPanel2.Controls.Add(this.label2);
            this.rjPanel2.Controls.Add(this.lblTime);
            this.rjPanel2.ForeColor = System.Drawing.Color.White;
            this.rjPanel2.Location = new System.Drawing.Point(1279, 162);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(440, 121);
            this.rjPanel2.TabIndex = 4;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(121, 20);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(250, 27);
            this.dtpTime.TabIndex = 3;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(121, 70);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 27);
            this.dtpDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.lblTime.Location = new System.Drawing.Point(25, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(58, 28);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time:";
            // 
            // rjPanel3
            // 
            this.rjPanel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjPanel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel3.BorderRadius = 40;
            this.rjPanel3.BorderSize = 0;
            this.rjPanel3.Controls.Add(this.lblMember);
            this.rjPanel3.Controls.Add(this.lblTrainer);
            this.rjPanel3.Controls.Add(this.lblBranch);
            this.rjPanel3.Controls.Add(this.lblID);
            this.rjPanel3.ForeColor = System.Drawing.Color.White;
            this.rjPanel3.Location = new System.Drawing.Point(94, 162);
            this.rjPanel3.Name = "rjPanel3";
            this.rjPanel3.Size = new System.Drawing.Size(1110, 121);
            this.rjPanel3.TabIndex = 5;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.lblMember.Location = new System.Drawing.Point(469, 22);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(95, 28);
            this.lblMember.TabIndex = 3;
            this.lblMember.Text = "Member:";
            // 
            // lblTrainer
            // 
            this.lblTrainer.AutoSize = true;
            this.lblTrainer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.lblTrainer.Location = new System.Drawing.Point(469, 72);
            this.lblTrainer.Name = "lblTrainer";
            this.lblTrainer.Size = new System.Drawing.Size(79, 28);
            this.lblTrainer.TabIndex = 2;
            this.lblTrainer.Text = "Trainer:";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.lblBranch.Location = new System.Drawing.Point(42, 72);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(79, 28);
            this.lblBranch.TabIndex = 1;
            this.lblBranch.Text = "Branch:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.lblID.Location = new System.Drawing.Point(42, 19);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 30);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // rjPanel4
            // 
            this.rjPanel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjPanel4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel4.BorderRadius = 40;
            this.rjPanel4.BorderSize = 0;
            this.rjPanel4.Controls.Add(this.gvWorkOutPlan);
            this.rjPanel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.rjPanel4.Location = new System.Drawing.Point(94, 319);
            this.rjPanel4.Name = "rjPanel4";
            this.rjPanel4.Size = new System.Drawing.Size(1625, 625);
            this.rjPanel4.TabIndex = 6;
            // 
            // FViewWorkOutPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1820, 1080);
            this.Controls.Add(this.rjPanel4);
            this.Controls.Add(this.rjPanel3);
            this.Controls.Add(this.rjPanel2);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.rjFlowLayoutPanel2);
            this.Controls.Add(this.rjFlowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FViewWorkOutPlan";
            this.Text = "FViewWorkOutPlan";
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkOutPlan)).EndInit();
            this.rjFlowLayoutPanel1.ResumeLayout(false);
            this.rjFlowLayoutPanel2.ResumeLayout(false);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.rjPanel2.ResumeLayout(false);
            this.rjPanel2.PerformLayout();
            this.rjPanel3.ResumeLayout(false);
            this.rjPanel3.PerformLayout();
            this.rjPanel4.ResumeLayout(false);
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
        private Label label2;
        private Label lblTime;
        private DateTimePicker dtpTime;
        private DateTimePicker dtpDate;
        private Label lblMember;
        private Label lblTrainer;
        private Label lblBranch;
        private Label lblID;
        private RJPanel rjPanel4;
    }
}