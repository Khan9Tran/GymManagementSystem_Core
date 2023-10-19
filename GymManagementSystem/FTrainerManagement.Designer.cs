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
            rjButton1 = new RJButton();
            rjFlowLayoutPanel2 = new RJFlowLayoutPanel();
            btnAll = new RJButton();
            btnMale = new RJButton();
            btnFemale = new RJButton();
            btnUpComing = new RJButton();
            rjFlowLayoutPanel1 = new RJFlowLayoutPanel();
            rjPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvTrainer).BeginInit();
            rjPanel3.SuspendLayout();
            rjPanel2.SuspendLayout();
            rjPanel1.SuspendLayout();
            rjFlowLayoutPanel2.SuspendLayout();
            rjFlowLayoutPanel1.SuspendLayout();
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
            rjPanel4.Size = new Size(1625, 625);
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
            gvTrainer.Size = new Size(1631, 605);
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
            label2.Location = new Point(25, 70);
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
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(44, 181, 245);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 40;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(300, 3);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(140, 50);
            rjButton1.TabIndex = 2;
            rjButton1.Text = "Delete";
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjFlowLayoutPanel2
            // 
            rjFlowLayoutPanel2.BackColor = Color.WhiteSmoke;
            rjFlowLayoutPanel2.BorderColor = Color.PaleVioletRed;
            rjFlowLayoutPanel2.BorderRadius = 40;
            rjFlowLayoutPanel2.BorderSize = 0;
            rjFlowLayoutPanel2.Controls.Add(btnAdd);
            rjFlowLayoutPanel2.Controls.Add(btnEdit);
            rjFlowLayoutPanel2.Controls.Add(rjButton1);
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
            // btnUpComing
            // 
            btnUpComing.BackColor = Color.FromArgb(44, 181, 245);
            btnUpComing.BorderColor = Color.PaleVioletRed;
            btnUpComing.BorderRadius = 40;
            btnUpComing.BorderSize = 0;
            btnUpComing.FlatAppearance.BorderSize = 0;
            btnUpComing.FlatStyle = FlatStyle.Flat;
            btnUpComing.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpComing.ForeColor = Color.White;
            btnUpComing.Location = new Point(441, 3);
            btnUpComing.Name = "btnUpComing";
            btnUpComing.Size = new Size(140, 50);
            btnUpComing.TabIndex = 6;
            btnUpComing.Text = "UpComing";
            btnUpComing.UseVisualStyleBackColor = false;
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
            rjFlowLayoutPanel1.Controls.Add(btnUpComing);
            rjFlowLayoutPanel1.ForeColor = Color.WhiteSmoke;
            rjFlowLayoutPanel1.Location = new Point(95, 105);
            rjFlowLayoutPanel1.Name = "rjFlowLayoutPanel1";
            rjFlowLayoutPanel1.Size = new Size(596, 54);
            rjFlowLayoutPanel1.TabIndex = 7;
            // 
            // FTrainerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1820, 1080);
            Controls.Add(rjPanel4);
            Controls.Add(rjPanel3);
            Controls.Add(rjPanel2);
            Controls.Add(rjPanel1);
            Controls.Add(rjFlowLayoutPanel2);
            Controls.Add(rjFlowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FTrainerManagement";
            Text = "FTrainerManagement";
            Load += gvTrainer_Load;
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
        private RJButton rjButton1;
        private RJFlowLayoutPanel rjFlowLayoutPanel2;
        private RJButton btnAll;
        private RJButton btnMale;
        private RJButton btnFemale;
        private RJButton btnUpComing;
        private RJFlowLayoutPanel rjFlowLayoutPanel1;
    }
}