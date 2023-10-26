namespace GymManagementSystem
{
    partial class FTrainerManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            rjPanel4 = new RJPanel();
            gvTrainer = new DataGridView();
            lblName = new Label();
            lblAddress = new Label();
            lblPhoneNumber = new Label();
            rjPanel3 = new RJPanel();
            lblID = new Label();
            dtpTime = new DateTimePicker();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            lblTime = new Label();
            rjPanel2 = new RJPanel();
            btnSearch = new RJButton();
            rjPanel1 = new RJPanel();
            txtSearch = new TextBox();
            btnAdd = new RJButton();
            btnEdit = new RJButton();
            btnDelete = new RJButton();
            rjFlowLayoutPanel2 = new RJFlowLayoutPanel();
            btnAll = new RJButton();
            btnMale = new RJButton();
            btnFemale = new RJButton();
            rjFlowLayoutPanel1 = new RJFlowLayoutPanel();
            rjPanel5 = new RJPanel();
            txtGender = new TextBox();
            lblGender = new Label();
            lbl = new Label();
            txtBranchID = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rjPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvTrainer).BeginInit();
            rjPanel3.SuspendLayout();
            rjPanel2.SuspendLayout();
            rjPanel1.SuspendLayout();
            rjFlowLayoutPanel2.SuspendLayout();
            rjFlowLayoutPanel1.SuspendLayout();
            rjPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // rjPanel4
            // 
            rjPanel4.BackColor = Color.WhiteSmoke;
            rjPanel4.BorderColor = Color.PaleVioletRed;
            rjPanel4.BorderRadius = 40;
            rjPanel4.BorderSize = 0;
            rjPanel4.Controls.Add(gvTrainer);
            rjPanel4.ForeColor = Color.FromArgb(67, 52, 67);
            rjPanel4.Location = new Point(95, 350);
            rjPanel4.Name = "rjPanel4";
            rjPanel4.Size = new Size(631, 625);
            rjPanel4.TabIndex = 12;
            // 
            // gvTrainer
            // 
            gvTrainer.AllowUserToAddRows = false;
            gvTrainer.AllowUserToDeleteRows = false;
            gvTrainer.AllowUserToResizeColumns = false;
            gvTrainer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            gvTrainer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gvTrainer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvTrainer.BackgroundColor = Color.WhiteSmoke;
            gvTrainer.BorderStyle = BorderStyle.None;
            gvTrainer.CellBorderStyle = DataGridViewCellBorderStyle.None;
            gvTrainer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            gvTrainer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gvTrainer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(67, 52, 67);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gvTrainer.DefaultCellStyle = dataGridViewCellStyle3;
            gvTrainer.Location = new Point(3, 0);
            gvTrainer.Name = "gvTrainer";
            gvTrainer.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gvTrainer.RowHeadersVisible = false;
            gvTrainer.RowHeadersWidth = 51;
            gvTrainer.RowTemplate.Height = 29;
            gvTrainer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvTrainer.Size = new Size(619, 605);
            gvTrainer.TabIndex = 0;
            gvTrainer.CellClick += gvTrainer_CellClick;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(67, 52, 67);
            lblName.Location = new Point(469, 22);
            lblName.Name = "lblName";
            lblName.Size = new Size(71, 28);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.ForeColor = Color.FromArgb(67, 52, 67);
            lblAddress.Location = new Point(469, 72);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(90, 28);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhoneNumber.ForeColor = Color.FromArgb(67, 52, 67);
            lblPhoneNumber.Location = new Point(42, 72);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(152, 28);
            lblPhoneNumber.TabIndex = 1;
            lblPhoneNumber.Text = "PhoneNumber:";
            // 
            // rjPanel3
            // 
            rjPanel3.BackColor = Color.WhiteSmoke;
            rjPanel3.BorderColor = Color.PaleVioletRed;
            rjPanel3.BorderRadius = 40;
            rjPanel3.BorderSize = 0;
            rjPanel3.Controls.Add(lblName);
            rjPanel3.Controls.Add(lblAddress);
            rjPanel3.Controls.Add(lblPhoneNumber);
            rjPanel3.Controls.Add(lblID);
            rjPanel3.ForeColor = Color.White;
            rjPanel3.Location = new Point(95, 193);
            rjPanel3.Name = "rjPanel3";
            rjPanel3.Size = new Size(1110, 121);
            rjPanel3.TabIndex = 11;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblID.ForeColor = Color.FromArgb(67, 52, 67);
            lblID.Location = new Point(42, 19);
            lblID.Name = "lblID";
            lblID.Size = new Size(42, 30);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // dtpTime
            // 
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.Location = new Point(121, 20);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(250, 27);
            dtpTime.TabIndex = 3;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(121, 70);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(67, 52, 67);
            label2.Location = new Point(3, 56);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 1;
            label2.Text = "Date:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.ForeColor = Color.FromArgb(67, 52, 67);
            lblTime.Location = new Point(25, 20);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(58, 28);
            lblTime.TabIndex = 0;
            lblTime.Text = "Time:";
            // 
            // rjPanel2
            // 
            rjPanel2.BackColor = Color.WhiteSmoke;
            rjPanel2.BorderColor = Color.PaleVioletRed;
            rjPanel2.BorderRadius = 40;
            rjPanel2.BorderSize = 0;
            rjPanel2.Controls.Add(dtpTime);
            rjPanel2.Controls.Add(dtpDate);
            rjPanel2.Controls.Add(label2);
            rjPanel2.Controls.Add(lblTime);
            rjPanel2.ForeColor = Color.White;
            rjPanel2.Location = new Point(1280, 193);
            rjPanel2.Name = "rjPanel2";
            rjPanel2.Size = new Size(440, 121);
            rjPanel2.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 40;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = Properties.Resources.search;
            btnSearch.Location = new Point(526, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(36, 36);
            btnSearch.TabIndex = 3;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // rjPanel1
            // 
            rjPanel1.BackColor = Color.WhiteSmoke;
            rjPanel1.BorderColor = Color.Black;
            rjPanel1.BorderRadius = 40;
            rjPanel1.BorderSize = 1;
            rjPanel1.Controls.Add(txtSearch);
            rjPanel1.Controls.Add(btnSearch);
            rjPanel1.ForeColor = Color.White;
            rjPanel1.Location = new Point(697, 109);
            rjPanel1.Name = "rjPanel1";
            rjPanel1.Size = new Size(573, 52);
            rjPanel1.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.WhiteSmoke;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.FromArgb(95, 91, 92);
            txtSearch.Location = new Point(15, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(493, 31);
            txtSearch.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(44, 181, 245);
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 40;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(44, 181, 245);
            btnEdit.BorderColor = Color.PaleVioletRed;
            btnEdit.BorderRadius = 40;
            btnEdit.BorderSize = 0;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(154, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 50);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(44, 181, 245);
            btnDelete.BorderColor = Color.PaleVioletRed;
            btnDelete.BorderRadius = 40;
            btnDelete.BorderSize = 0;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(300, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 50);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // rjFlowLayoutPanel2
            // 
            rjFlowLayoutPanel2.BackColor = Color.WhiteSmoke;
            rjFlowLayoutPanel2.BorderColor = Color.PaleVioletRed;
            rjFlowLayoutPanel2.BorderRadius = 40;
            rjFlowLayoutPanel2.BorderSize = 0;
            rjFlowLayoutPanel2.Controls.Add(btnAdd);
            rjFlowLayoutPanel2.Controls.Add(btnEdit);
            rjFlowLayoutPanel2.Controls.Add(btnDelete);
            rjFlowLayoutPanel2.ForeColor = Color.White;
            rjFlowLayoutPanel2.Location = new Point(1280, 105);
            rjFlowLayoutPanel2.Name = "rjFlowLayoutPanel2";
            rjFlowLayoutPanel2.Size = new Size(446, 54);
            rjFlowLayoutPanel2.TabIndex = 8;
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.FromArgb(44, 181, 245);
            btnAll.BorderColor = Color.PaleVioletRed;
            btnAll.BorderRadius = 40;
            btnAll.BorderSize = 0;
            btnAll.FlatAppearance.BorderSize = 0;
            btnAll.FlatStyle = FlatStyle.Flat;
            btnAll.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAll.ForeColor = Color.White;
            btnAll.Location = new Point(3, 3);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(140, 50);
            btnAll.TabIndex = 3;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // btnMale
            // 
            btnMale.BackColor = Color.FromArgb(44, 181, 245);
            btnMale.BorderColor = Color.PaleVioletRed;
            btnMale.BorderRadius = 40;
            btnMale.BorderSize = 0;
            btnMale.FlatAppearance.BorderSize = 0;
            btnMale.FlatStyle = FlatStyle.Flat;
            btnMale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMale.ForeColor = Color.White;
            btnMale.Location = new Point(149, 3);
            btnMale.Name = "btnMale";
            btnMale.Size = new Size(140, 50);
            btnMale.TabIndex = 4;
            btnMale.Text = "Male";
            btnMale.UseVisualStyleBackColor = false;
            btnMale.Click += btnMale_Click;
            // 
            // btnFemale
            // 
            btnFemale.BackColor = Color.FromArgb(44, 181, 245);
            btnFemale.BorderColor = Color.PaleVioletRed;
            btnFemale.BorderRadius = 40;
            btnFemale.BorderSize = 0;
            btnFemale.FlatAppearance.BorderSize = 0;
            btnFemale.FlatStyle = FlatStyle.Flat;
            btnFemale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFemale.ForeColor = Color.White;
            btnFemale.Location = new Point(295, 3);
            btnFemale.Name = "btnFemale";
            btnFemale.Size = new Size(140, 50);
            btnFemale.TabIndex = 5;
            btnFemale.Text = "Female";
            btnFemale.UseVisualStyleBackColor = false;
            btnFemale.Click += btnFemale_Click;
            // 
            // rjFlowLayoutPanel1
            // 
            rjFlowLayoutPanel1.BackColor = Color.WhiteSmoke;
            rjFlowLayoutPanel1.BorderColor = Color.WhiteSmoke;
            rjFlowLayoutPanel1.BorderRadius = 40;
            rjFlowLayoutPanel1.BorderSize = 0;
            rjFlowLayoutPanel1.Controls.Add(btnAll);
            rjFlowLayoutPanel1.Controls.Add(btnMale);
            rjFlowLayoutPanel1.Controls.Add(btnFemale);
            rjFlowLayoutPanel1.ForeColor = Color.WhiteSmoke;
            rjFlowLayoutPanel1.Location = new Point(95, 105);
            rjFlowLayoutPanel1.Name = "rjFlowLayoutPanel1";
            rjFlowLayoutPanel1.Size = new Size(442, 54);
            rjFlowLayoutPanel1.TabIndex = 7;
            // 
            // rjPanel5
            // 
            rjPanel5.BackColor = Color.WhiteSmoke;
            rjPanel5.BorderColor = Color.PaleVioletRed;
            rjPanel5.BorderRadius = 40;
            rjPanel5.BorderSize = 0;
            rjPanel5.Controls.Add(txtGender);
            rjPanel5.Controls.Add(lblGender);
            rjPanel5.Controls.Add(lbl);
            rjPanel5.Controls.Add(txtBranchID);
            rjPanel5.Controls.Add(txtPhoneNumber);
            rjPanel5.Controls.Add(txtAddress);
            rjPanel5.Controls.Add(txtName);
            rjPanel5.Controls.Add(txtID);
            rjPanel5.Controls.Add(label1);
            rjPanel5.Controls.Add(label3);
            rjPanel5.Controls.Add(label4);
            rjPanel5.Controls.Add(label5);
            rjPanel5.ForeColor = Color.White;
            rjPanel5.Location = new Point(1119, 350);
            rjPanel5.Name = "rjPanel5";
            rjPanel5.Size = new Size(607, 612);
            rjPanel5.TabIndex = 14;
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGender.Location = new Point(349, 330);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(227, 34);
            txtGender.TabIndex = 11;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.ForeColor = Color.FromArgb(67, 52, 67);
            lblGender.Location = new Point(40, 330);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(85, 28);
            lblGender.TabIndex = 10;
            lblGender.Text = "Gender:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.ForeColor = Color.FromArgb(67, 52, 67);
            lbl.Location = new Point(40, 260);
            lbl.Name = "lbl";
            lbl.Size = new Size(105, 28);
            lbl.TabIndex = 9;
            lbl.Text = "Branch ID:";
            // 
            // txtBranchID
            // 
            txtBranchID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBranchID.Location = new Point(349, 260);
            txtBranchID.Name = "txtBranchID";
            txtBranchID.Size = new Size(227, 34);
            txtBranchID.TabIndex = 8;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNumber.Location = new Point(349, 200);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(227, 34);
            txtPhoneNumber.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(349, 140);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(227, 34);
            txtAddress.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(349, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(227, 34);
            txtName.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(349, 17);
            txtID.Name = "txtID";
            txtID.Size = new Size(227, 34);
            txtID.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(67, 52, 67);
            label1.Location = new Point(40, 80);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(67, 52, 67);
            label3.Location = new Point(40, 140);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(67, 52, 67);
            label4.Location = new Point(40, 200);
            label4.Name = "label4";
            label4.Size = new Size(152, 28);
            label4.TabIndex = 1;
            label4.Text = "PhoneNumber:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(67, 52, 67);
            label5.Location = new Point(40, 20);
            label5.Name = "label5";
            label5.Size = new Size(42, 30);
            label5.TabIndex = 0;
            label5.Text = "ID:";
            // 
            // FTrainerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1820, 1080);
            Controls.Add(rjPanel5);
            Controls.Add(rjPanel4);
            Controls.Add(rjPanel3);
            Controls.Add(rjPanel2);
            Controls.Add(rjPanel1);
            Controls.Add(rjFlowLayoutPanel2);
            Controls.Add(rjFlowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FTrainerManagement";
            Text = "FTrainerManagement";
            rjPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvTrainer).EndInit();
            rjPanel3.ResumeLayout(false);
            rjPanel3.PerformLayout();
            rjPanel2.ResumeLayout(false);
            rjPanel2.PerformLayout();
            rjPanel1.ResumeLayout(false);
            rjPanel1.PerformLayout();
            rjFlowLayoutPanel2.ResumeLayout(false);
            rjFlowLayoutPanel1.ResumeLayout(false);
            rjPanel5.ResumeLayout(false);
            rjPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RJPanel rjPanel4;
        private DataGridView gvTrainer;
        private Label lblName;
        private Label lblAddress;
        private Label lblPhoneNumber;
        private RJPanel rjPanel3;
        private Label lblID;
        private DateTimePicker dtpTime;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label lblTime;
        private RJPanel rjPanel2;
        private RJButton btnSearch;
        private RJPanel rjPanel1;
        private TextBox txtSearch;
        private RJButton btnAdd;
        private RJButton btnEdit;
        private RJButton btnDelete;
        private RJFlowLayoutPanel rjFlowLayoutPanel2;
        private RJButton btnAll;
        private RJButton btnMale;
        private RJButton btnFemale;
        private RJFlowLayoutPanel rjFlowLayoutPanel1;
        private RJPanel rjPanel5;
        private TextBox txtGender;
        private Label lblGender;
        private Label lbl;
        private TextBox txtBranchID;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private TextBox txtName;
        private TextBox txtID;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}