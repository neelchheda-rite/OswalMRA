namespace OswalMRA.Views {
    partial class frmMouldPage {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddMould = new System.Windows.Forms.Button();
            this.dgvMould = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUploadMould = new System.Windows.Forms.Button();
            this.btnClearMould = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMould)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvMould, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(998, 603);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddMould, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(998, 42);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAddMould
            // 
            this.btnAddMould.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddMould.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddMould.FlatAppearance.BorderSize = 0;
            this.btnAddMould.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMould.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMould.ForeColor = System.Drawing.Color.White;
            this.btnAddMould.Location = new System.Drawing.Point(848, 0);
            this.btnAddMould.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddMould.Name = "btnAddMould";
            this.btnAddMould.Size = new System.Drawing.Size(150, 42);
            this.btnAddMould.TabIndex = 0;
            this.btnAddMould.Text = "Add Mould";
            this.btnAddMould.UseVisualStyleBackColor = false;
            this.btnAddMould.Click += new System.EventHandler(this.btnAddMould_Click);
            // 
            // dgvMould
            // 
            this.dgvMould.BackgroundColor = System.Drawing.Color.White;
            this.dgvMould.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMould.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMould.Location = new System.Drawing.Point(3, 45);
            this.dgvMould.Name = "dgvMould";
            this.dgvMould.RowTemplate.Height = 28;
            this.dgvMould.Size = new System.Drawing.Size(992, 512);
            this.dgvMould.TabIndex = 1;
            this.dgvMould.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMould_CellContentClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.btnUploadMould, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnClearMould, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 560);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(998, 43);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnUploadMould
            // 
            this.btnUploadMould.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUploadMould.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUploadMould.FlatAppearance.BorderSize = 0;
            this.btnUploadMould.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadMould.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUploadMould.ForeColor = System.Drawing.Color.White;
            this.btnUploadMould.Location = new System.Drawing.Point(703, 5);
            this.btnUploadMould.Margin = new System.Windows.Forms.Padding(5);
            this.btnUploadMould.Name = "btnUploadMould";
            this.btnUploadMould.Size = new System.Drawing.Size(139, 33);
            this.btnUploadMould.TabIndex = 0;
            this.btnUploadMould.Text = "Upload";
            this.btnUploadMould.UseVisualStyleBackColor = false;
            // 
            // btnClearMould
            // 
            this.btnClearMould.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnClearMould.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearMould.FlatAppearance.BorderSize = 0;
            this.btnClearMould.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearMould.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearMould.ForeColor = System.Drawing.Color.White;
            this.btnClearMould.Location = new System.Drawing.Point(852, 5);
            this.btnClearMould.Margin = new System.Windows.Forms.Padding(5);
            this.btnClearMould.Name = "btnClearMould";
            this.btnClearMould.Size = new System.Drawing.Size(141, 33);
            this.btnClearMould.TabIndex = 0;
            this.btnClearMould.Text = "Clear";
            this.btnClearMould.UseVisualStyleBackColor = false;
            // 
            // frmMouldPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 603);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMouldPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "mouldTest";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMould)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

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