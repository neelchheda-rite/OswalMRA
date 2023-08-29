namespace OswalMRA.Views {
    partial class frmInventoryPage {
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
            PresentationControls.CheckBoxProperties checkBoxProperties3 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            this.baseGrid = new System.Windows.Forms.TableLayoutPanel();
            this.dataTableInventory = new System.Windows.Forms.DataGridView();
            this.searchActionGrid = new System.Windows.Forms.TableLayoutPanel();
            this.mouldSearch = new PresentationControls.CheckBoxComboBox();
            this.userSearch = new PresentationControls.CheckBoxComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelGrid = new System.Windows.Forms.TableLayoutPanel();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.mouldLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.baseGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableInventory)).BeginInit();
            this.searchActionGrid.SuspendLayout();
            this.labelGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseGrid
            // 
            this.baseGrid.ColumnCount = 3;
            this.baseGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.baseGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.baseGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.baseGrid.Controls.Add(this.dataTableInventory, 1, 3);
            this.baseGrid.Controls.Add(this.searchActionGrid, 1, 1);
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
            this.baseGrid.Size = new System.Drawing.Size(871, 605);
            this.baseGrid.TabIndex = 0;
            // 
            // dataTableInventory
            // 
            this.dataTableInventory.AllowUserToAddRows = false;
            this.dataTableInventory.AllowUserToDeleteRows = false;
            this.dataTableInventory.AllowUserToResizeColumns = false;
            this.dataTableInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataTableInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTableInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataTableInventory.BackgroundColor = System.Drawing.Color.White;
            this.dataTableInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTableInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataTableInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataTableInventory.ColumnHeadersHeight = 50;
            this.dataTableInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableInventory.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataTableInventory.EnableHeadersVisualStyles = false;
            this.dataTableInventory.Location = new System.Drawing.Point(60, 96);
            this.dataTableInventory.Margin = new System.Windows.Forms.Padding(0);
            this.dataTableInventory.Name = "dataTableInventory";
            this.dataTableInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataTableInventory.RowHeadersVisible = false;
            this.dataTableInventory.RowHeadersWidth = 45;
            this.dataTableInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataTableInventory.RowTemplate.Height = 28;
            this.dataTableInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTableInventory.Size = new System.Drawing.Size(749, 411);
            this.dataTableInventory.TabIndex = 3;
            // 
            // searchActionGrid
            // 
            this.searchActionGrid.ColumnCount = 9;
            this.searchActionGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.searchActionGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.searchActionGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.searchActionGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.searchActionGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.searchActionGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.searchActionGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.searchActionGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.searchActionGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.searchActionGrid.Controls.Add(this.mouldSearch, 4, 0);
            this.searchActionGrid.Controls.Add(this.userSearch, 6, 0);
            this.searchActionGrid.Controls.Add(this.btnSearch, 8, 0);
            this.searchActionGrid.Controls.Add(this.dateTimePicker1, 0, 0);
            this.searchActionGrid.Controls.Add(this.dateTimePicker2, 2, 0);
            this.searchActionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchActionGrid.Location = new System.Drawing.Point(60, 30);
            this.searchActionGrid.Margin = new System.Windows.Forms.Padding(0);
            this.searchActionGrid.Name = "searchActionGrid";
            this.searchActionGrid.RowCount = 1;
            this.searchActionGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchActionGrid.Size = new System.Drawing.Size(749, 36);
            this.searchActionGrid.TabIndex = 0;
            // 
            // mouldSearch
            // 
            this.mouldSearch.BackColor = System.Drawing.SystemColors.Control;
            checkBoxProperties3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mouldSearch.CheckBoxProperties = checkBoxProperties3;
            this.mouldSearch.DisplayMemberSingleItem = "";
            this.mouldSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mouldSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mouldSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mouldSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mouldSearch.FormattingEnabled = true;
            this.mouldSearch.Location = new System.Drawing.Point(282, 0);
            this.mouldSearch.Margin = new System.Windows.Forms.Padding(0);
            this.mouldSearch.MaxDropDownItems = 100;
            this.mouldSearch.Name = "mouldSearch";
            this.mouldSearch.Size = new System.Drawing.Size(112, 29);
            this.mouldSearch.TabIndex = 25;
            this.mouldSearch.Text = "Mould";
            // 
            // userSearch
            // 
            this.userSearch.BackColor = System.Drawing.SystemColors.Control;
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userSearch.CheckBoxProperties = checkBoxProperties1;
            this.userSearch.DisplayMemberSingleItem = "";
            this.userSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userSearch.FormattingEnabled = true;
            this.userSearch.Location = new System.Drawing.Point(423, 0);
            this.userSearch.Margin = new System.Windows.Forms.Padding(0);
            this.userSearch.MaxDropDownItems = 100;
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(112, 29);
            this.userSearch.TabIndex = 26;
            this.userSearch.Text = "Mould";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(594, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 36);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 26);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.Value = new System.DateTime(2023, 8, 28, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Location = new System.Drawing.Point(141, 0);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(112, 26);
            this.dateTimePicker2.TabIndex = 28;
            // 
            // labelGrid
            // 
            this.labelGrid.ColumnCount = 8;
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.labelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.labelGrid.Controls.Add(this.fromLabel, 0, 0);
            this.labelGrid.Controls.Add(this.toLabel, 2, 0);
            this.labelGrid.Controls.Add(this.mouldLabel, 4, 0);
            this.labelGrid.Controls.Add(this.userLabel, 6, 0);
            this.labelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGrid.Location = new System.Drawing.Point(60, 0);
            this.labelGrid.Margin = new System.Windows.Forms.Padding(0);
            this.labelGrid.Name = "labelGrid";
            this.labelGrid.RowCount = 1;
            this.labelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.labelGrid.Size = new System.Drawing.Size(749, 30);
            this.labelGrid.TabIndex = 1;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.fromLabel.Location = new System.Drawing.Point(0, 0);
            this.fromLabel.Margin = new System.Windows.Forms.Padding(0);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(112, 30);
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "From";
            this.fromLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.toLabel.Location = new System.Drawing.Point(141, 0);
            this.toLabel.Margin = new System.Windows.Forms.Padding(0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(112, 30);
            this.toLabel.TabIndex = 1;
            this.toLabel.Text = "To";
            this.toLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mouldLabel
            // 
            this.mouldLabel.AutoSize = true;
            this.mouldLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mouldLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mouldLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mouldLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.mouldLabel.Location = new System.Drawing.Point(282, 0);
            this.mouldLabel.Margin = new System.Windows.Forms.Padding(0);
            this.mouldLabel.Name = "mouldLabel";
            this.mouldLabel.Size = new System.Drawing.Size(112, 30);
            this.mouldLabel.TabIndex = 2;
            this.mouldLabel.Text = "Mould";
            this.mouldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.userLabel.Location = new System.Drawing.Point(423, 0);
            this.userLabel.Margin = new System.Windows.Forms.Padding(0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(112, 30);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "User";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inventoryTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 605);
            this.ControlBox = false;
            this.Controls.Add(this.baseGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inventoryTest";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.inventoryTest_Load);
            this.baseGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableInventory)).EndInit();
            this.searchActionGrid.ResumeLayout(false);
            this.labelGrid.ResumeLayout(false);
            this.labelGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel baseGrid;
        private TableLayoutPanel searchActionGrid;
        private Button btnSearch;
        private PresentationControls.CheckBoxComboBox userSearch;
        private PresentationControls.CheckBoxComboBox mouldSearch;
        private TableLayoutPanel labelGrid;
        private Label fromLabel;
        private Label toLabel;
        private Label mouldLabel;
        private Label userLabel;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataTableInventory;
    }
}