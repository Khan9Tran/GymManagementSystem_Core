namespace GymManagementSystem
{
    partial class TestConnect
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
            dgPackage = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            PackageName = new DataGridViewTextBoxColumn();
            Periods = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            NumberOfPTSessions = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgPackage).BeginInit();
            SuspendLayout();
            // 
            // dgPackage
            // 
            dgPackage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPackage.Columns.AddRange(new DataGridViewColumn[] { ID, PackageName, Periods, Price, Description, NumberOfPTSessions });
            dgPackage.Location = new Point(129, 143);
            dgPackage.Name = "dgPackage";
            dgPackage.RowHeadersWidth = 51;
            dgPackage.RowTemplate.Height = 29;
            dgPackage.Size = new Size(874, 265);
            dgPackage.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // PackageName
            // 
            PackageName.DataPropertyName = "Name";
            PackageName.HeaderText = "Name";
            PackageName.MinimumWidth = 6;
            PackageName.Name = "PackageName";
            PackageName.Width = 125;
            // 
            // Periods
            // 
            Periods.DataPropertyName = "Periods";
            Periods.HeaderText = "Periods";
            Periods.MinimumWidth = 6;
            Periods.Name = "Periods";
            Periods.Width = 125;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // NumberOfPTSessions
            // 
            NumberOfPTSessions.DataPropertyName = "NumberOfPTSessions";
            NumberOfPTSessions.HeaderText = "NumberOfPTSessions";
            NumberOfPTSessions.MinimumWidth = 6;
            NumberOfPTSessions.Name = "NumberOfPTSessions";
            NumberOfPTSessions.Width = 200;
            // 
            // TestConnect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 552);
            Controls.Add(dgPackage);
            Name = "TestConnect";
            Text = "TestConnect";
            Load += TestConnect_Load;
            ((System.ComponentModel.ISupportInitialize)dgPackage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgPackage;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PackageName;
        private DataGridViewTextBoxColumn Periods;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn NumberOfPTSessions;
    }
}