namespace OswalMRA.Views
{
    partial class frmMouldPage
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAddMould = new Button();
            dgvMould = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnUploadMould = new Button();
            btnClearMould = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMould).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvMould, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.Size = new Size(873, 476);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.Controls.Add(btnAddMould, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(873, 33);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAddMould
            // 
            btnAddMould.BackColor = Color.FromArgb(41, 128, 185);
            btnAddMould.Dock = DockStyle.Fill;
            btnAddMould.FlatAppearance.BorderSize = 0;
            btnAddMould.FlatStyle = FlatStyle.Flat;
            btnAddMould.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddMould.ForeColor = Color.White;
            btnAddMould.Location = new Point(742, 0);
            btnAddMould.Margin = new Padding(0);
            btnAddMould.Name = "btnAddMould";
            btnAddMould.Size = new Size(131, 33);
            btnAddMould.TabIndex = 0;
            btnAddMould.Text = "Add Mould";
            btnAddMould.UseVisualStyleBackColor = false;
            //btnAddMould.Click += btnAddMould_Click;
            // 
            // dgvMould
            // 
            dgvMould.BackgroundColor = Color.White;
            dgvMould.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMould.Dock = DockStyle.Fill;
            dgvMould.Location = new Point(3, 35);
            dgvMould.Margin = new Padding(3, 2, 3, 2);
            dgvMould.Name = "dgvMould";
            dgvMould.RowTemplate.Height = 28;
            dgvMould.Size = new Size(867, 405);
            dgvMould.TabIndex = 1;
            //dgvMould.CellContentClick += dgvMould_CellContentClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.Controls.Add(btnUploadMould, 1, 0);
            tableLayoutPanel3.Controls.Add(btnClearMould, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 442);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(873, 34);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // btnUploadMould
            // 
            btnUploadMould.BackColor = Color.FromArgb(41, 128, 185);
            btnUploadMould.Dock = DockStyle.Fill;
            btnUploadMould.FlatAppearance.BorderSize = 0;
            btnUploadMould.FlatStyle = FlatStyle.Flat;
            btnUploadMould.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnUploadMould.ForeColor = Color.White;
            btnUploadMould.Location = new Point(615, 4);
            btnUploadMould.Margin = new Padding(4, 4, 4, 4);
            btnUploadMould.Name = "btnUploadMould";
            btnUploadMould.Size = new Size(122, 26);
            btnUploadMould.TabIndex = 0;
            btnUploadMould.Text = "Upload";
            btnUploadMould.UseVisualStyleBackColor = false;
            // 
            // btnClearMould
            // 
            btnClearMould.BackColor = Color.FromArgb(41, 128, 185);
            btnClearMould.Dock = DockStyle.Fill;
            btnClearMould.FlatAppearance.BorderSize = 0;
            btnClearMould.FlatStyle = FlatStyle.Flat;
            btnClearMould.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearMould.ForeColor = Color.White;
            btnClearMould.Location = new Point(745, 4);
            btnClearMould.Margin = new Padding(4, 4, 4, 4);
            btnClearMould.Name = "btnClearMould";
            btnClearMould.Size = new Size(124, 26);
            btnClearMould.TabIndex = 0;
            btnClearMould.Text = "Clear";
            btnClearMould.UseVisualStyleBackColor = false;
            // 
            // frmMouldPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 476);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMouldPage";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "mouldTest";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMould).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAddMould;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnUploadMould;
        private Button btnClearMould;
        private DataGridView dgvMould;
    }
}