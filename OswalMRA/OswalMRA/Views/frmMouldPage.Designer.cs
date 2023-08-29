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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.baseOuterGrid = new System.Windows.Forms.TableLayoutPanel();
            this.upperButtonGrid = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataTableMould = new System.Windows.Forms.DataGridView();
            this.bottomButtonGrid = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.baseOuterGrid.SuspendLayout();
            this.upperButtonGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableMould)).BeginInit();
            this.bottomButtonGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseOuterGrid
            // 
            this.baseOuterGrid.ColumnCount = 3;
            this.baseOuterGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.baseOuterGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.baseOuterGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.baseOuterGrid.Controls.Add(this.upperButtonGrid, 1, 1);
            this.baseOuterGrid.Controls.Add(this.dataTableMould, 1, 3);
            this.baseOuterGrid.Controls.Add(this.bottomButtonGrid, 1, 5);
            this.baseOuterGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseOuterGrid.Location = new System.Drawing.Point(0, 0);
            this.baseOuterGrid.Margin = new System.Windows.Forms.Padding(0);
            this.baseOuterGrid.Name = "baseOuterGrid";
            this.baseOuterGrid.RowCount = 7;
            this.baseOuterGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.baseOuterGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.baseOuterGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.baseOuterGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.baseOuterGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.baseOuterGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.baseOuterGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.baseOuterGrid.Size = new System.Drawing.Size(871, 605);
            this.baseOuterGrid.TabIndex = 0;
            // 
            // upperButtonGrid
            // 
            this.upperButtonGrid.ColumnCount = 2;
            this.upperButtonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.upperButtonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.upperButtonGrid.Controls.Add(this.btnAdd, 1, 0);
            this.upperButtonGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperButtonGrid.Location = new System.Drawing.Point(60, 30);
            this.upperButtonGrid.Margin = new System.Windows.Forms.Padding(0);
            this.upperButtonGrid.Name = "upperButtonGrid";
            this.upperButtonGrid.RowCount = 1;
            this.upperButtonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.upperButtonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.upperButtonGrid.Size = new System.Drawing.Size(749, 36);
            this.upperButtonGrid.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(599, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataTableMould
            // 
            this.dataTableMould.AllowUserToAddRows = false;
            this.dataTableMould.AllowUserToDeleteRows = false;
            this.dataTableMould.AllowUserToResizeColumns = false;
            this.dataTableMould.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableMould.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTableMould.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTableMould.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableMould.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataTableMould.BackgroundColor = System.Drawing.Color.White;
            this.dataTableMould.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTableMould.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataTableMould.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableMould.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTableMould.ColumnHeadersHeight = 50;
            this.dataTableMould.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableMould.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTableMould.EnableHeadersVisualStyles = false;
            this.dataTableMould.Location = new System.Drawing.Point(60, 96);
            this.dataTableMould.Margin = new System.Windows.Forms.Padding(0);
            this.dataTableMould.Name = "dataTableMould";
            this.dataTableMould.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataTableMould.RowHeadersVisible = false;
            this.dataTableMould.RowHeadersWidth = 45;
            this.dataTableMould.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataTableMould.RowTemplate.Height = 28;
            this.dataTableMould.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTableMould.Size = new System.Drawing.Size(749, 411);
            this.dataTableMould.TabIndex = 1;
            this.dataTableMould.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellContentClick);
            // 
            // bottomButtonGrid
            // 
            this.bottomButtonGrid.ColumnCount = 2;
            this.bottomButtonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.bottomButtonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bottomButtonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.bottomButtonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.bottomButtonGrid.Controls.Add(this.btnUpload, 1, 0);
            this.bottomButtonGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomButtonGrid.Location = new System.Drawing.Point(60, 537);
            this.bottomButtonGrid.Margin = new System.Windows.Forms.Padding(0);
            this.bottomButtonGrid.Name = "bottomButtonGrid";
            this.bottomButtonGrid.RowCount = 1;
            this.bottomButtonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomButtonGrid.Size = new System.Drawing.Size(749, 36);
            this.bottomButtonGrid.TabIndex = 2;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(599, 0);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(150, 36);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            // 
            // frmMouldPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 605);
            this.Controls.Add(this.baseOuterGrid);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMouldPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mould Management";
            this.baseOuterGrid.ResumeLayout(false);
            this.upperButtonGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableMould)).EndInit();
            this.bottomButtonGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel baseOuterGrid;
        private TableLayoutPanel upperButtonGrid;
        private Button btnAdd;
        private DataGridView dataTableMould;
        private TableLayoutPanel bottomButtonGrid;
        private Button btnUpload;
    }
}