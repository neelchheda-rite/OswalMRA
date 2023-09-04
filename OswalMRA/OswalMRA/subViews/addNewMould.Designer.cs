namespace OswalMRA.subViews
{
    partial class addNewMould
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
            baseOuterGrid = new TableLayoutPanel();
            titlePanel = new Panel();
            titleGrid = new TableLayoutPanel();
            titleLabel = new Label();
            closeLabel = new Label();
            buttonGrid = new TableLayoutPanel();
            btnAdd = new Button();
            btnCancel = new Button();
            baseGrid = new TableLayoutPanel();
            firstGrid = new TableLayoutPanel();
            codeTextBox = new TextBox();
            nameTextBox = new TextBox();
            codeLabel = new Label();
            nameLabel = new Label();
            secondGrid = new TableLayoutPanel();
            descriptionLabel = new Label();
            descriptionTextBox = new TextBox();
            thirdGrid = new TableLayoutPanel();
            columnLabel = new Label();
            rowLabel = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            baseOuterGrid.SuspendLayout();
            titlePanel.SuspendLayout();
            titleGrid.SuspendLayout();
            buttonGrid.SuspendLayout();
            baseGrid.SuspendLayout();
            firstGrid.SuspendLayout();
            secondGrid.SuspendLayout();
            thirdGrid.SuspendLayout();
            SuspendLayout();
            // 
            // baseOuterGrid
            // 
            baseOuterGrid.ColumnCount = 1;
            baseOuterGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            baseOuterGrid.Controls.Add(titlePanel, 0, 0);
            baseOuterGrid.Controls.Add(buttonGrid, 0, 2);
            baseOuterGrid.Controls.Add(baseGrid, 0, 1);
            baseOuterGrid.Dock = DockStyle.Fill;
            baseOuterGrid.Location = new Point(0, 0);
            baseOuterGrid.Margin = new Padding(0);
            baseOuterGrid.Name = "baseOuterGrid";
            baseOuterGrid.RowCount = 4;
            baseOuterGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            baseOuterGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 77F));
            baseOuterGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            baseOuterGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            baseOuterGrid.Size = new Size(488, 345);
            baseOuterGrid.TabIndex = 0;
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.FromArgb(41, 128, 185);
            titlePanel.Controls.Add(titleGrid);
            titlePanel.Dock = DockStyle.Fill;
            titlePanel.Location = new Point(0, 0);
            titlePanel.Margin = new Padding(0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(488, 24);
            titlePanel.TabIndex = 1;
            // 
            // titleGrid
            // 
            titleGrid.ColumnCount = 2;
            titleGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93F));
            titleGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            titleGrid.Controls.Add(titleLabel, 0, 0);
            titleGrid.Controls.Add(closeLabel, 1, 0);
            titleGrid.Dock = DockStyle.Fill;
            titleGrid.Location = new Point(0, 0);
            titleGrid.Margin = new Padding(0);
            titleGrid.Name = "titleGrid";
            titleGrid.RowCount = 1;
            titleGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            titleGrid.Size = new Size(488, 24);
            titleGrid.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Left;
            titleLabel.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Margin = new Padding(0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(130, 24);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "   Add New Mould";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // closeLabel
            // 
            closeLabel.AutoSize = true;
            closeLabel.Dock = DockStyle.Fill;
            closeLabel.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point);
            closeLabel.ForeColor = Color.White;
            closeLabel.Location = new Point(453, 0);
            closeLabel.Margin = new Padding(0);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new Size(35, 24);
            closeLabel.TabIndex = 0;
            closeLabel.Text = "X";
            closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            closeLabel.Click += closeLabel_Click;
            closeLabel.MouseEnter += closeLabel_MouseEnter;
            closeLabel.MouseLeave += closeLabel_MouseLeave;
            // 
            // buttonGrid
            // 
            buttonGrid.ColumnCount = 5;
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            buttonGrid.Controls.Add(btnAdd, 1, 0);
            buttonGrid.Controls.Add(btnCancel, 3, 0);
            buttonGrid.Dock = DockStyle.Fill;
            buttonGrid.Location = new Point(0, 289);
            buttonGrid.Margin = new Padding(0);
            buttonGrid.Name = "buttonGrid";
            buttonGrid.RowCount = 1;
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            buttonGrid.Size = new Size(488, 34);
            buttonGrid.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(41, 128, 185);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(48, 0);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(277, 0);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(161, 34);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // baseGrid
            // 
            baseGrid.ColumnCount = 1;
            baseGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            baseGrid.Controls.Add(firstGrid, 0, 0);
            baseGrid.Controls.Add(secondGrid, 0, 1);
            baseGrid.Controls.Add(thirdGrid, 0, 2);
            baseGrid.Dock = DockStyle.Fill;
            baseGrid.Location = new Point(0, 24);
            baseGrid.Margin = new Padding(0);
            baseGrid.Name = "baseGrid";
            baseGrid.RowCount = 4;
            baseGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            baseGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            baseGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            baseGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            baseGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            baseGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            baseGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            baseGrid.Size = new Size(488, 265);
            baseGrid.TabIndex = 3;
            // 
            // firstGrid
            // 
            firstGrid.ColumnCount = 5;
            firstGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            firstGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            firstGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            firstGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            firstGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            firstGrid.Controls.Add(codeTextBox, 1, 2);
            firstGrid.Controls.Add(nameTextBox, 3, 2);
            firstGrid.Controls.Add(codeLabel, 1, 0);
            firstGrid.Controls.Add(nameLabel, 3, 0);
            firstGrid.Dock = DockStyle.Fill;
            firstGrid.Location = new Point(0, 0);
            firstGrid.Margin = new Padding(0);
            firstGrid.Name = "firstGrid";
            firstGrid.RowCount = 3;
            firstGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            firstGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            firstGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            firstGrid.Size = new Size(488, 79);
            firstGrid.TabIndex = 0;
            // 
            // codeTextBox
            // 
            codeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            codeTextBox.BackColor = SystemColors.Control;
            codeTextBox.BorderStyle = BorderStyle.None;
            codeTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            codeTextBox.ForeColor = Color.FromArgb(41, 128, 185);
            codeTextBox.Location = new Point(48, 42);
            codeTextBox.Margin = new Padding(0);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(170, 29);
            codeTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BackColor = SystemColors.Control;
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            nameTextBox.ForeColor = Color.FromArgb(41, 128, 185);
            nameTextBox.Location = new Point(266, 42);
            nameTextBox.Margin = new Padding(0);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(170, 29);
            nameTextBox.TabIndex = 0;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Dock = DockStyle.Fill;
            codeLabel.FlatStyle = FlatStyle.Flat;
            codeLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            codeLabel.Location = new Point(48, 0);
            codeLabel.Margin = new Padding(0);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(170, 35);
            codeLabel.TabIndex = 1;
            codeLabel.Text = "Code";
            codeLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Dock = DockStyle.Fill;
            nameLabel.FlatStyle = FlatStyle.Flat;
            nameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(266, 0);
            nameLabel.Margin = new Padding(0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(170, 35);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // secondGrid
            // 
            secondGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            secondGrid.ColumnCount = 3;
            secondGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            secondGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            secondGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            secondGrid.Controls.Add(descriptionLabel, 1, 0);
            secondGrid.Controls.Add(descriptionTextBox, 1, 2);
            secondGrid.Location = new Point(0, 79);
            secondGrid.Margin = new Padding(0);
            secondGrid.Name = "secondGrid";
            secondGrid.RowCount = 3;
            secondGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            secondGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            secondGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            secondGrid.Size = new Size(488, 79);
            secondGrid.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Dock = DockStyle.Fill;
            descriptionLabel.FlatStyle = FlatStyle.Flat;
            descriptionLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(48, 0);
            descriptionLabel.Margin = new Padding(0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(390, 35);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description";
            descriptionLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BackColor = SystemColors.Control;
            descriptionTextBox.BorderStyle = BorderStyle.None;
            descriptionTextBox.Dock = DockStyle.Fill;
            descriptionTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionTextBox.ForeColor = Color.FromArgb(41, 128, 185);
            descriptionTextBox.Location = new Point(48, 42);
            descriptionTextBox.Margin = new Padding(0);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(390, 29);
            descriptionTextBox.TabIndex = 1;
            // 
            // thirdGrid
            // 
            thirdGrid.ColumnCount = 5;
            thirdGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            thirdGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            thirdGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            thirdGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            thirdGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            thirdGrid.Controls.Add(columnLabel, 1, 0);
            thirdGrid.Controls.Add(rowLabel, 3, 0);
            thirdGrid.Controls.Add(comboBox1, 1, 2);
            thirdGrid.Controls.Add(comboBox2, 3, 2);
            thirdGrid.Dock = DockStyle.Fill;
            thirdGrid.Location = new Point(0, 158);
            thirdGrid.Margin = new Padding(0);
            thirdGrid.Name = "thirdGrid";
            thirdGrid.RowCount = 3;
            thirdGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            thirdGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            thirdGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            thirdGrid.Size = new Size(488, 79);
            thirdGrid.TabIndex = 2;
            // 
            // columnLabel
            // 
            columnLabel.AutoSize = true;
            columnLabel.Dock = DockStyle.Fill;
            columnLabel.FlatStyle = FlatStyle.Flat;
            columnLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            columnLabel.Location = new Point(48, 0);
            columnLabel.Margin = new Padding(0);
            columnLabel.Name = "columnLabel";
            columnLabel.Size = new Size(170, 35);
            columnLabel.TabIndex = 1;
            columnLabel.Text = "Column";
            columnLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // rowLabel
            // 
            rowLabel.AutoSize = true;
            rowLabel.Dock = DockStyle.Fill;
            rowLabel.FlatStyle = FlatStyle.Flat;
            rowLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rowLabel.Location = new Point(266, 0);
            rowLabel.Margin = new Padding(0);
            rowLabel.Name = "rowLabel";
            rowLabel.Size = new Size(170, 35);
            rowLabel.TabIndex = 2;
            rowLabel.Text = "Row";
            rowLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Control;
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.FromArgb(41, 128, 185);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(48, 42);
            comboBox1.Margin = new Padding(0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 38);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.Control;
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.ForeColor = Color.FromArgb(41, 128, 185);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(266, 42);
            comboBox2.Margin = new Padding(0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 38);
            comboBox2.TabIndex = 4;
            // 
            // addNewMould
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(488, 345);
            ControlBox = false;
            Controls.Add(baseOuterGrid);
            ForeColor = Color.FromArgb(41, 128, 185);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "addNewMould";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            KeyDown += addMouldTest_KeyDown;
            baseOuterGrid.ResumeLayout(false);
            titlePanel.ResumeLayout(false);
            titleGrid.ResumeLayout(false);
            titleGrid.PerformLayout();
            buttonGrid.ResumeLayout(false);
            baseGrid.ResumeLayout(false);
            firstGrid.ResumeLayout(false);
            firstGrid.PerformLayout();
            secondGrid.ResumeLayout(false);
            secondGrid.PerformLayout();
            thirdGrid.ResumeLayout(false);
            thirdGrid.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel baseOuterGrid;
        private Panel titlePanel;
        private TableLayoutPanel titleGrid;
        private Label titleLabel;
        private Label closeLabel;
        private TableLayoutPanel buttonGrid;
        private Button btnAdd;
        private Button btnCancel;
        private TableLayoutPanel baseGrid;
        private TableLayoutPanel firstGrid;
        private TextBox codeTextBox;
        private TextBox nameTextBox;
        private Label codeLabel;
        private Label nameLabel;
        private TableLayoutPanel secondGrid;
        private TableLayoutPanel thirdGrid;
        private Label columnLabel;
        private Label rowLabel;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}