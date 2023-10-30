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
            rjPanel16 = new RJPanel();
            label7 = new Label();
            rjPanel17 = new RJPanel();
            txtGender = new TextBox();
            rjPanel14 = new RJPanel();
            label6 = new Label();
            rjPanel15 = new RJPanel();
            txtBranchID = new TextBox();
            rjPanel10 = new RJPanel();
            label4 = new Label();
            rjPanel11 = new RJPanel();
            txtPhoneNumber = new TextBox();
            rjPanel12 = new RJPanel();
            label5 = new Label();
            rjPanel13 = new RJPanel();
            txtAddress = new TextBox();
            rjPanel6 = new RJPanel();
            label3 = new Label();
            rjPanel9 = new RJPanel();
            txtName = new TextBox();
            rjPanel7 = new RJPanel();
            label1 = new Label();
            rjPanel8 = new RJPanel();
            txtID = new TextBox();
            rjPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvTrainer).BeginInit();
            rjPanel3.SuspendLayout();
            rjPanel1.SuspendLayout();
            rjFlowLayoutPanel2.SuspendLayout();
            rjFlowLayoutPanel1.SuspendLayout();
            rjPanel5.SuspendLayout();
            rjPanel16.SuspendLayout();
            rjPanel17.SuspendLayout();
            rjPanel14.SuspendLayout();
            rjPanel15.SuspendLayout();
            rjPanel10.SuspendLayout();
            rjPanel11.SuspendLayout();
            rjPanel12.SuspendLayout();
            rjPanel13.SuspendLayout();
            rjPanel6.SuspendLayout();
            rjPanel9.SuspendLayout();
            rjPanel7.SuspendLayout();
            rjPanel8.SuspendLayout();
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
            rjPanel4.Size = new Size(1003, 625);
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
            gvTrainer.Size = new Size(997, 605);
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
            rjPanel3.Size = new Size(1003, 121);
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
            rjPanel5.Controls.Add(rjPanel16);
            rjPanel5.Controls.Add(rjPanel14);
            rjPanel5.Controls.Add(rjPanel10);
            rjPanel5.Controls.Add(rjPanel12);
            rjPanel5.Controls.Add(rjPanel6);
            rjPanel5.Controls.Add(rjPanel7);
            rjPanel5.ForeColor = Color.White;
            rjPanel5.Location = new Point(1119, 193);
            rjPanel5.Name = "rjPanel5";
            rjPanel5.Size = new Size(607, 782);
            rjPanel5.TabIndex = 15;
            // 
            // rjPanel16
            // 
            rjPanel16.BackColor = Color.FromArgb(242, 242, 242);
            rjPanel16.BorderColor = Color.WhiteSmoke;
            rjPanel16.BorderRadius = 40;
            rjPanel16.BorderSize = 0;
            rjPanel16.Controls.Add(label7);
            rjPanel16.Controls.Add(rjPanel17);
            rjPanel16.ForeColor = Color.White;
            rjPanel16.Location = new Point(22, 511);
            rjPanel16.Name = "rjPanel16";
            rjPanel16.Size = new Size(563, 82);
            rjPanel16.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(67, 52, 67);
            label7.Location = new Point(8, 23);
            label7.Name = "label7";
            label7.Size = new Size(80, 28);
            label7.TabIndex = 4;
            label7.Text = "Gender";
            // 
            // rjPanel17
            // 
            rjPanel17.BackColor = Color.White;
            rjPanel17.BorderColor = Color.White;
            rjPanel17.BorderRadius = 40;
            rjPanel17.BorderSize = 0;
            rjPanel17.Controls.Add(txtGender);
            rjPanel17.ForeColor = Color.White;
            rjPanel17.Location = new Point(101, 12);
            rjPanel17.Name = "rjPanel17";
            rjPanel17.Size = new Size(441, 59);
            rjPanel17.TabIndex = 0;
            // 
            // txtGender
            // 
            txtGender.BackColor = Color.White;
            txtGender.BorderStyle = BorderStyle.None;
            txtGender.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtGender.ForeColor = Color.FromArgb(69, 66, 67);
            txtGender.Location = new Point(21, 16);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(401, 29);
            txtGender.TabIndex = 0;
            // 
            // rjPanel14
            // 
            rjPanel14.BackColor = Color.FromArgb(242, 242, 242);
            rjPanel14.BorderColor = Color.WhiteSmoke;
            rjPanel14.BorderRadius = 40;
            rjPanel14.BorderSize = 0;
            rjPanel14.Controls.Add(label6);
            rjPanel14.Controls.Add(rjPanel15);
            rjPanel14.ForeColor = Color.White;
            rjPanel14.Location = new Point(22, 414);
            rjPanel14.Name = "rjPanel14";
            rjPanel14.Size = new Size(563, 82);
            rjPanel14.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(67, 52, 67);
            label6.Location = new Point(8, 23);
            label6.Name = "label6";
            label6.Size = new Size(78, 28);
            label6.TabIndex = 4;
            label6.Text = "Branch";
            // 
            // rjPanel15
            // 
            rjPanel15.BackColor = Color.White;
            rjPanel15.BorderColor = Color.White;
            rjPanel15.BorderRadius = 40;
            rjPanel15.BorderSize = 0;
            rjPanel15.Controls.Add(txtBranchID);
            rjPanel15.ForeColor = Color.White;
            rjPanel15.Location = new Point(101, 12);
            rjPanel15.Name = "rjPanel15";
            rjPanel15.Size = new Size(441, 59);
            rjPanel15.TabIndex = 0;
            // 
            // txtBranchID
            // 
            txtBranchID.BackColor = Color.White;
            txtBranchID.BorderStyle = BorderStyle.None;
            txtBranchID.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtBranchID.ForeColor = Color.FromArgb(69, 66, 67);
            txtBranchID.Location = new Point(21, 16);
            txtBranchID.Name = "txtBranchID";
            txtBranchID.Size = new Size(401, 29);
            txtBranchID.TabIndex = 0;
            // 
            // rjPanel10
            // 
            rjPanel10.BackColor = Color.FromArgb(242, 242, 242);
            rjPanel10.BorderColor = Color.WhiteSmoke;
            rjPanel10.BorderRadius = 40;
            rjPanel10.BorderSize = 0;
            rjPanel10.Controls.Add(label4);
            rjPanel10.Controls.Add(rjPanel11);
            rjPanel10.ForeColor = Color.White;
            rjPanel10.Location = new Point(22, 314);
            rjPanel10.Name = "rjPanel10";
            rjPanel10.Size = new Size(563, 82);
            rjPanel10.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(67, 52, 67);
            label4.Location = new Point(8, 23);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 4;
            label4.Text = "Phone";
            // 
            // rjPanel11
            // 
            rjPanel11.BackColor = Color.White;
            rjPanel11.BorderColor = Color.White;
            rjPanel11.BorderRadius = 40;
            rjPanel11.BorderSize = 0;
            rjPanel11.Controls.Add(txtPhoneNumber);
            rjPanel11.ForeColor = Color.White;
            rjPanel11.Location = new Point(101, 12);
            rjPanel11.Name = "rjPanel11";
            rjPanel11.Size = new Size(441, 59);
            rjPanel11.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.White;
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNumber.ForeColor = Color.FromArgb(69, 66, 67);
            txtPhoneNumber.Location = new Point(21, 16);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(401, 29);
            txtPhoneNumber.TabIndex = 0;
            // 
            // rjPanel12
            // 
            rjPanel12.BackColor = Color.FromArgb(242, 242, 242);
            rjPanel12.BorderColor = Color.WhiteSmoke;
            rjPanel12.BorderRadius = 40;
            rjPanel12.BorderSize = 0;
            rjPanel12.Controls.Add(label5);
            rjPanel12.Controls.Add(rjPanel13);
            rjPanel12.ForeColor = Color.White;
            rjPanel12.Location = new Point(22, 215);
            rjPanel12.Name = "rjPanel12";
            rjPanel12.Size = new Size(563, 82);
            rjPanel12.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(67, 52, 67);
            label5.Location = new Point(8, 23);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // rjPanel13
            // 
            rjPanel13.BackColor = Color.White;
            rjPanel13.BorderColor = Color.White;
            rjPanel13.BorderRadius = 40;
            rjPanel13.BorderSize = 0;
            rjPanel13.Controls.Add(txtAddress);
            rjPanel13.ForeColor = Color.White;
            rjPanel13.Location = new Point(101, 12);
            rjPanel13.Name = "rjPanel13";
            rjPanel13.Size = new Size(441, 59);
            rjPanel13.TabIndex = 0;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.ForeColor = Color.FromArgb(69, 66, 67);
            txtAddress.Location = new Point(21, 16);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(401, 29);
            txtAddress.TabIndex = 0;
            // 
            // rjPanel6
            // 
            rjPanel6.BackColor = Color.FromArgb(242, 242, 242);
            rjPanel6.BorderColor = Color.WhiteSmoke;
            rjPanel6.BorderRadius = 40;
            rjPanel6.BorderSize = 0;
            rjPanel6.Controls.Add(label3);
            rjPanel6.Controls.Add(rjPanel9);
            rjPanel6.ForeColor = Color.White;
            rjPanel6.Location = new Point(22, 119);
            rjPanel6.Name = "rjPanel6";
            rjPanel6.Size = new Size(563, 82);
            rjPanel6.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(67, 52, 67);
            label3.Location = new Point(8, 23);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // rjPanel9
            // 
            rjPanel9.BackColor = Color.White;
            rjPanel9.BorderColor = Color.White;
            rjPanel9.BorderRadius = 40;
            rjPanel9.BorderSize = 0;
            rjPanel9.Controls.Add(txtName);
            rjPanel9.ForeColor = Color.White;
            rjPanel9.Location = new Point(101, 12);
            rjPanel9.Name = "rjPanel9";
            rjPanel9.Size = new Size(441, 59);
            rjPanel9.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.FromArgb(69, 66, 67);
            txtName.Location = new Point(21, 16);
            txtName.Name = "txtName";
            txtName.Size = new Size(401, 29);
            txtName.TabIndex = 0;
            // 
            // rjPanel7
            // 
            rjPanel7.BackColor = Color.FromArgb(242, 242, 242);
            rjPanel7.BorderColor = Color.WhiteSmoke;
            rjPanel7.BorderRadius = 40;
            rjPanel7.BorderSize = 0;
            rjPanel7.Controls.Add(label1);
            rjPanel7.Controls.Add(rjPanel8);
            rjPanel7.ForeColor = Color.White;
            rjPanel7.Location = new Point(22, 20);
            rjPanel7.Name = "rjPanel7";
            rjPanel7.Size = new Size(563, 82);
            rjPanel7.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(67, 52, 67);
            label1.Location = new Point(8, 23);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // rjPanel8
            // 
            rjPanel8.BackColor = Color.White;
            rjPanel8.BorderColor = Color.White;
            rjPanel8.BorderRadius = 40;
            rjPanel8.BorderSize = 0;
            rjPanel8.Controls.Add(txtID);
            rjPanel8.ForeColor = Color.White;
            rjPanel8.Location = new Point(101, 12);
            rjPanel8.Name = "rjPanel8";
            rjPanel8.Size = new Size(441, 59);
            rjPanel8.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.ForeColor = Color.FromArgb(69, 66, 67);
            txtID.Location = new Point(21, 16);
            txtID.Name = "txtID";
            txtID.Size = new Size(401, 29);
            txtID.TabIndex = 0;
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
            rjPanel1.ResumeLayout(false);
            rjPanel1.PerformLayout();
            rjFlowLayoutPanel2.ResumeLayout(false);
            rjFlowLayoutPanel1.ResumeLayout(false);
            rjPanel5.ResumeLayout(false);
            rjPanel16.ResumeLayout(false);
            rjPanel16.PerformLayout();
            rjPanel17.ResumeLayout(false);
            rjPanel17.PerformLayout();
            rjPanel14.ResumeLayout(false);
            rjPanel14.PerformLayout();
            rjPanel15.ResumeLayout(false);
            rjPanel15.PerformLayout();
            rjPanel10.ResumeLayout(false);
            rjPanel10.PerformLayout();
            rjPanel11.ResumeLayout(false);
            rjPanel11.PerformLayout();
            rjPanel12.ResumeLayout(false);
            rjPanel12.PerformLayout();
            rjPanel13.ResumeLayout(false);
            rjPanel13.PerformLayout();
            rjPanel6.ResumeLayout(false);
            rjPanel6.PerformLayout();
            rjPanel9.ResumeLayout(false);
            rjPanel9.PerformLayout();
            rjPanel7.ResumeLayout(false);
            rjPanel7.PerformLayout();
            rjPanel8.ResumeLayout(false);
            rjPanel8.PerformLayout();
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
        private RJPanel rjPanel16;
        private Label label7;
        private RJPanel rjPanel17;
        private TextBox txtGender;
        private RJPanel rjPanel14;
        private Label label6;
        private RJPanel rjPanel15;
        private TextBox txtBranchID;
        private RJPanel rjPanel10;
        private Label label4;
        private RJPanel rjPanel11;
        private TextBox txtPhoneNumber;
        private RJPanel rjPanel12;
        private Label label5;
        private RJPanel rjPanel13;
        private TextBox txtAddress;
        private RJPanel rjPanel6;
        private Label label3;
        private RJPanel rjPanel9;
        private TextBox txtName;
        private RJPanel rjPanel7;
        private Label label1;
        private RJPanel rjPanel8;
        private TextBox txtID;
    }
}