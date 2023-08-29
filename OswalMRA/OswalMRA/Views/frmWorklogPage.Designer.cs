namespace OswalMRA.Views {
    partial class frmWorklogPage {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            PresentationControls.CheckBoxProperties checkBoxProperties6 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties2 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties3 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties4 = new PresentationControls.CheckBoxProperties();
            this.baseGrid = new System.Windows.Forms.TableLayoutPanel();
            this.dataTableWorkLog = new System.Windows.Forms.DataGridView();
            this.searchActionsGrid = new System.Windows.Forms.TableLayoutPanel();
            this.rowSearch = new PresentationControls.CheckBoxComboBox();
            this.columnSearch = new PresentationControls.CheckBoxComboBox();
            this.userSearch = new PresentationControls.CheckBoxComboBox();
            this.statusSearch = new PresentationControls.CheckBoxComboBox();
            this.mouldSearch = new PresentationControls.CheckBoxComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelGrid = new System.Windows.Forms.TableLayoutPanel();
            this.mouldLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.columnLabel = new System.Windows.Forms.Label();
            this.rowLabel = new System.Windows.Forms.Label();
            this.baseGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableWorkLog)).BeginInit();
            this.searchActionsGrid.SuspendLayout();
            this.labelGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseGrid
            // 
            this.baseGrid.ColumnCount = 3;
            this.baseGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.baseGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.baseGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.baseGrid.Controls.Add(this.dataTableWorkLog, 1, 3);
            this.baseGrid.Controls.Add(this.searchActionsGrid, 1, 1);
            this.baseGrid.Controls.Add(this.labelGrid, 1, 0);
            this.baseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseGrid.Location = new System.Drawing.Point(0, 0);
            this.baseGrid.Margin = new System.Windows.Forms.Padding(0);
            this.baseGrid.Name = "baseGrid";
            this.baseGrid.RowCount = 7;
            this.baseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.baseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.baseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.baseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.baseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.baseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.baseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.baseGrid.Size = new System.Drawing.Size(755, 489);
            this.baseGrid.TabIndex = 0;
            // 
            // dataTableWorkLog
            // 
            this.dataTableWorkLog.AllowUserToAddRows = false;
            this.dataTableWorkLog.AllowUserToDeleteRows = false;
            this.dataTableWorkLog.AllowUserToResizeColumns = false;
            this.dataTableWorkLog.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableWorkLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataTableWorkLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTableWorkLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableWorkLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataTableWorkLog.BackgroundColor = System.Drawing.Color.White;
            this.dataTableWorkLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTableWorkLog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataTableWorkLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableWorkLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataTableWorkLog.ColumnHeadersHeight = 50;
            this.dataTableWorkLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableWorkLog.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataTableWorkLog.EnableHeadersVisualStyles = false;
            this.dataTableWorkLog.Location = new System.Drawing.Point(52, 77);
            this.dataTableWorkLog.Margin = new System.Windows.Forms.Padding(0);
            this.dataTableWorkLog.Name = "dataTableWorkLog";
            this.dataTableWorkLog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataTableWorkLog.RowHeadersVisible = false;
            this.dataTableWorkLog.RowHeadersWidth = 45;
            this.dataTableWorkLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataTableWorkLog.RowTemplate.Height = 28;
            this.dataTableWorkLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTableWorkLog.Size = new System.Drawing.Size(649, 332);
            this.dataTableWorkLog.TabIndex = 2;
            // 
            // searchActionsGrid
            // 
            this.searchActionsGrid.ColumnCount = 11;
            this.searchActionsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.searchActionsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.searchActionsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.searchActionsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.searchActionsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.searchActionsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.searchActionsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.searchActionsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.searchActionsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.searchActionsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.searchActionsGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.searchActionsGrid.Controls.Add(this.rowSearch, 8, 0);
            this.searchActionsGrid.Controls.Add(this.columnSearch, 6, 0);
            this.searchActionsGrid.Controls.Add(this.userSearch, 4, 0);
            this.searchActionsGrid.Controls.Add(this.statusSearch, 2, 0);
            this.searchActionsGrid.Controls.Add(this.mouldSearch, 0, 0);
            this.searchActionsGrid.Controls.Add(this.btnSearch, 10, 0);
            this.searchActionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchActionsGrid.Location = new System.Drawing.Point(52, 24);
            this.searchActionsGrid.Margin = new System.Windows.Forms.Padding(0);
            this.searchActionsGrid.Name = "searchActionsGrid";
            this.searchActionsGrid.RowCount = 1;
            this.searchActionsGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchActionsGrid.Size = new System.Drawing.Size(649, 29);
            this.searchActionsGrid.TabIndex = 0;
            // 
            // rowSearch
            // 
            this.rowSearch.BackColor = System.Drawing.SystemColors.Control;
            checkBoxProperties6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rowSearch.CheckBoxProperties = checkBoxProperties6;
            this.rowSearch.DisplayMemberSingleItem = "";
            this.rowSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rowSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rowSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rowSearch.FormattingEnabled = true;
            this.rowSearch.Location = new System.Drawing.Point(436, 0);
            this.rowSearch.Margin = new System.Windows.Forms.Padding(0);
            this.rowSearch.MaxDropDownItems = 100;
            this.rowSearch.Name = "rowSearch";
            this.rowSearch.Size = new System.Drawing.Size(58, 29);
            this.rowSearch.TabIndex = 26;
            this.rowSearch.Text = "Row";
            // 
            // columnSearch
            // 
            this.columnSearch.BackColor = System.Drawing.SystemColors.Control;
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.columnSearch.CheckBoxProperties = checkBoxProperties1;
            this.columnSearch.DisplayMemberSingleItem = "";
            this.columnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.columnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.columnSearch.FormattingEnabled = true;
            this.columnSearch.Location = new System.Drawing.Point(366, 0);
            this.columnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.columnSearch.MaxDropDownItems = 100;
            this.columnSearch.Name = "columnSearch";
            this.columnSearch.Size = new System.Drawing.Size(58, 29);
            this.columnSearch.TabIndex = 25;
            this.columnSearch.Text = "Col";
            // 
            // userSearch
            // 
            this.userSearch.BackColor = System.Drawing.SystemColors.Control;
            checkBoxProperties2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userSearch.CheckBoxProperties = checkBoxProperties2;
            this.userSearch.DisplayMemberSingleItem = "";
            this.userSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userSearch.FormattingEnabled = true;
            this.userSearch.Location = new System.Drawing.Point(244, 0);
            this.userSearch.Margin = new System.Windows.Forms.Padding(0);
            this.userSearch.MaxDropDownItems = 100;
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(110, 29);
            this.userSearch.TabIndex = 24;
            this.userSearch.Text = "User";
            // 
            // statusSearch
            // 
            this.statusSearch.BackColor = System.Drawing.SystemColors.Control;
            checkBoxProperties3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statusSearch.CheckBoxProperties = checkBoxProperties3;
            this.statusSearch.DisplayMemberSingleItem = "";
            this.statusSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statusSearch.FormattingEnabled = true;
            this.statusSearch.Location = new System.Drawing.Point(122, 0);
            this.statusSearch.Margin = new System.Windows.Forms.Padding(0);
            this.statusSearch.MaxDropDownItems = 100;
            this.statusSearch.Name = "statusSearch";
            this.statusSearch.Size = new System.Drawing.Size(110, 29);
            this.statusSearch.TabIndex = 23;
            this.statusSearch.Text = "Status";
            // 
            // mouldSearch
            // 
            this.mouldSearch.BackColor = System.Drawing.SystemColors.Control;
            checkBoxProperties4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mouldSearch.CheckBoxProperties = checkBoxProperties4;
            this.mouldSearch.DisplayMemberSingleItem = "";
            this.mouldSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mouldSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mouldSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mouldSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mouldSearch.FormattingEnabled = true;
            this.mouldSearch.Location = new System.Drawing.Point(0, 0);
            this.mouldSearch.Margin = new System.Windows.Forms.Padding(0);
            this.mouldSearch.MaxDropDownItems = 100;
            this.mouldSearch.Name = "mouldSearch";
            this.mouldSearch.Size = new System.Drawing.Size(110, 29);
            this.mouldSearch.TabIndex = 22;
            this.mouldSearch.Text = "Mould";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(526, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 29);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelGrid
            // 
            this.labelGrid.ColumnCount = 11;
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.labelGrid.Controls.Add(this.mouldLabel, 0, 0);
            this.labelGrid.Controls.Add(this.statusLabel, 2, 0);
            this.labelGrid.Controls.Add(this.userLabel, 4, 0);
            this.labelGrid.Controls.Add(this.columnLabel, 6, 0);
            this.labelGrid.Controls.Add(this.rowLabel, 8, 0);
            this.labelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGrid.Location = new System.Drawing.Point(52, 0);
            this.labelGrid.Margin = new System.Windows.Forms.Padding(0);
            this.labelGrid.Name = "labelGrid";
            this.labelGrid.RowCount = 1;
            this.labelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.labelGrid.Size = new System.Drawing.Size(649, 24);
            this.labelGrid.TabIndex = 1;
            // 
            // mouldLabel
            // 
            this.mouldLabel.AutoSize = true;
            this.mouldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mouldLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mouldLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mouldLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.mouldLabel.Location = new System.Drawing.Point(0, 0);
            this.mouldLabel.Margin = new System.Windows.Forms.Padding(0);
            this.mouldLabel.Name = "mouldLabel";
            this.mouldLabel.Size = new System.Drawing.Size(110, 24);
            this.mouldLabel.TabIndex = 0;
            this.mouldLabel.Text = "Mould";
            this.mouldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.statusLabel.Location = new System.Drawing.Point(122, 0);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(110, 24);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.userLabel.Location = new System.Drawing.Point(244, 0);
            this.userLabel.Margin = new System.Windows.Forms.Padding(0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(110, 24);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "User";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // columnLabel
            // 
            this.columnLabel.AutoSize = true;
            this.columnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.columnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.columnLabel.Location = new System.Drawing.Point(366, 0);
            this.columnLabel.Margin = new System.Windows.Forms.Padding(0);
            this.columnLabel.Name = "columnLabel";
            this.columnLabel.Size = new System.Drawing.Size(58, 24);
            this.columnLabel.TabIndex = 3;
            this.columnLabel.Text = "Column";
            this.columnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rowLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.rowLabel.Location = new System.Drawing.Point(436, 0);
            this.rowLabel.Margin = new System.Windows.Forms.Padding(0);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(58, 24);
            this.rowLabel.TabIndex = 4;
            this.rowLabel.Text = "Row";
            this.rowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmWorklogPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 489);
            this.ControlBox = false;
            this.Controls.Add(this.baseGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWorklogPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Log";
            this.Load += new System.EventHandler(this.worklogTest_Load);
            this.baseGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableWorkLog)).EndInit();
            this.searchActionsGrid.ResumeLayout(false);
            this.labelGrid.ResumeLayout(false);
            this.labelGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel baseGrid;
        private TableLayoutPanel searchActionsGrid;
        private Button btnSearch;
        private PresentationControls.CheckBoxComboBox mouldSearch;
        private PresentationControls.CheckBoxComboBox statusSearch;
        private PresentationControls.CheckBoxComboBox userSearch;
        private PresentationControls.CheckBoxComboBox columnSearch;
        private PresentationControls.CheckBoxComboBox rowSearch;
        private TableLayoutPanel labelGrid;
        private Label mouldLabel;
        private Label statusLabel;
        private Label userLabel;
        private Label columnLabel;
        private Label rowLabel;
        private DataGridView dataTableWorkLog;
    }
}