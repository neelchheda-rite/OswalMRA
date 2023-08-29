namespace OswalMRA
{
    partial class addNewUser
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
            tlpButton = new TableLayoutPanel();
            tlpFooterRow = new TableLayoutPanel();
            btnClear = new Button();
            btnSave = new Button();
            tlpHeader = new TableLayoutPanel();
            tlpHeaderRow = new TableLayoutPanel();
            tlpLabel = new TableLayoutPanel();
            tlpFooter = new TableLayoutPanel();
            lblBarcode = new Label();
            lblName = new Label();
            lblRole = new Label();
            lblIsActive = new Label();
            txtBoxBarcode = new TextBox();
            txtBoxName = new TextBox();
            cmbRole = new ComboBox();
            checkBoxIsActive = new CheckBox();
            tlpButton.SuspendLayout();
            tlpFooterRow.SuspendLayout();
            tlpHeader.SuspendLayout();
            tlpLabel.SuspendLayout();
            tlpFooter.SuspendLayout();
            SuspendLayout();
            // 
            // tlpButton
            // 
            tlpButton.ColumnCount = 3;
            tlpButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpButton.Controls.Add(tlpFooterRow, 1, 0);
            tlpButton.Dock = DockStyle.Fill;
            tlpButton.Location = new Point(0, 236);
            tlpButton.Margin = new Padding(0);
            tlpButton.Name = "tlpButton";
            tlpButton.RowCount = 2;
            tlpButton.RowStyles.Add(new RowStyle(SizeType.Percent, 45.71429F));
            tlpButton.RowStyles.Add(new RowStyle(SizeType.Percent, 54.28571F));
            tlpButton.Size = new Size(466, 70);
            tlpButton.TabIndex = 2;
            // 
            // tlpFooterRow
            // 
            tlpFooterRow.ColumnCount = 2;
            tlpFooterRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFooterRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFooterRow.Controls.Add(btnClear, 1, 0);
            tlpFooterRow.Controls.Add(btnSave, 0, 0);
            tlpFooterRow.Dock = DockStyle.Fill;
            tlpFooterRow.Location = new Point(93, 0);
            tlpFooterRow.Margin = new Padding(0);
            tlpFooterRow.Name = "tlpFooterRow";
            tlpFooterRow.RowCount = 1;
            tlpFooterRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFooterRow.Size = new Size(279, 32);
            tlpFooterRow.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(41, 128, 185);
            btnClear.Dock = DockStyle.Fill;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(139, 0);
            btnClear.Margin = new Padding(0);
            btnClear.MaximumSize = new Size(0, 32);
            btnClear.MinimumSize = new Size(0, 32);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 32);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(41, 128, 185);
            btnSave.Dock = DockStyle.Fill;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(0, 0);
            btnSave.Margin = new Padding(0);
            btnSave.MaximumSize = new Size(0, 32);
            btnSave.MinimumSize = new Size(0, 32);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 32);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // tlpHeader
            // 
            tlpHeader.ColumnCount = 1;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpHeader.Controls.Add(tlpHeaderRow, 0, 0);
            tlpHeader.Controls.Add(tlpLabel, 0, 1);
            tlpHeader.Controls.Add(tlpButton, 0, 2);
            tlpHeader.Dock = DockStyle.Fill;
            tlpHeader.Location = new Point(0, 0);
            tlpHeader.Margin = new Padding(0);
            tlpHeader.Name = "tlpHeader";
            tlpHeader.RowCount = 3;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 15.48387F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 84.51613F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tlpHeader.Size = new Size(466, 306);
            tlpHeader.TabIndex = 1;
            // 
            // tlpHeaderRow
            // 
            tlpHeaderRow.BackColor = Color.FromArgb(41, 128, 185);
            tlpHeaderRow.ColumnCount = 1;
            tlpHeaderRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpHeaderRow.Dock = DockStyle.Top;
            tlpHeaderRow.Location = new Point(0, 0);
            tlpHeaderRow.Margin = new Padding(0);
            tlpHeaderRow.MaximumSize = new Size(0, 47);
            tlpHeaderRow.MinimumSize = new Size(0, 47);
            tlpHeaderRow.Name = "tlpHeaderRow";
            tlpHeaderRow.RowCount = 1;
            tlpHeaderRow.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpHeaderRow.Size = new Size(466, 47);
            tlpHeaderRow.TabIndex = 0;
            // 
            // tlpLabel
            // 
            tlpLabel.ColumnCount = 3;
            tlpLabel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.727862F));
            tlpLabel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.27214F));
            tlpLabel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tlpLabel.Controls.Add(tlpFooter, 1, 1);
            tlpLabel.Dock = DockStyle.Fill;
            tlpLabel.Location = new Point(0, 36);
            tlpLabel.Margin = new Padding(0);
            tlpLabel.Name = "tlpLabel";
            tlpLabel.RowCount = 2;
            tlpLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.56886F));
            tlpLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 84.43114F));
            tlpLabel.Size = new Size(466, 200);
            tlpLabel.TabIndex = 1;
            // 
            // tlpFooter
            // 
            tlpFooter.ColumnCount = 4;
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.11111F));
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.88889F));
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 68F));
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            tlpFooter.Controls.Add(lblBarcode, 0, 1);
            tlpFooter.Controls.Add(lblName, 2, 1);
            tlpFooter.Controls.Add(lblRole, 0, 2);
            tlpFooter.Controls.Add(lblIsActive, 2, 2);
            tlpFooter.Controls.Add(txtBoxBarcode, 1, 1);
            tlpFooter.Controls.Add(txtBoxName, 3, 1);
            tlpFooter.Controls.Add(cmbRole, 1, 2);
            tlpFooter.Controls.Add(checkBoxIsActive, 3, 2);
            tlpFooter.Dock = DockStyle.Fill;
            tlpFooter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tlpFooter.Location = new Point(7, 31);
            tlpFooter.Margin = new Padding(0);
            tlpFooter.Name = "tlpFooter";
            tlpFooter.RowCount = 4;
            tlpFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 31.85841F));
            tlpFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 68.14159F));
            tlpFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tlpFooter.Size = new Size(450, 169);
            tlpFooter.TabIndex = 0;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Dock = DockStyle.Fill;
            lblBarcode.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBarcode.Location = new Point(3, 26);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(61, 56);
            lblBarcode.TabIndex = 0;
            lblBarcode.Text = "Barcode";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(219, 26);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 56);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Dock = DockStyle.Fill;
            lblRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRole.Location = new Point(3, 82);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(61, 45);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Dock = DockStyle.Fill;
            lblIsActive.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIsActive.Location = new Point(219, 82);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(62, 45);
            lblIsActive.TabIndex = 3;
            lblIsActive.Text = "IsActive";
            // 
            // txtBoxBarcode
            // 
            txtBoxBarcode.Dock = DockStyle.Fill;
            txtBoxBarcode.Location = new Point(67, 26);
            txtBoxBarcode.Margin = new Padding(0);
            txtBoxBarcode.Name = "txtBoxBarcode";
            txtBoxBarcode.Size = new Size(149, 25);
            txtBoxBarcode.TabIndex = 4;
            txtBoxBarcode.TextChanged += txtBoxBarcode_TextChanged;
            // 
            // txtBoxName
            // 
            txtBoxName.Dock = DockStyle.Fill;
            txtBoxName.Location = new Point(284, 26);
            txtBoxName.Margin = new Padding(0);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(166, 25);
            txtBoxName.TabIndex = 5;
            txtBoxName.TextChanged += txtBoxName_TextChanged;
            // 
            // cmbRole
            // 
            cmbRole.Dock = DockStyle.Fill;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(67, 82);
            cmbRole.Margin = new Padding(0);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(149, 25);
            cmbRole.TabIndex = 6;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // checkBoxIsActive
            // 
            checkBoxIsActive.AutoSize = true;
            checkBoxIsActive.Location = new Point(287, 85);
            checkBoxIsActive.MaximumSize = new Size(0, 21);
            checkBoxIsActive.MinimumSize = new Size(0, 21);
            checkBoxIsActive.Name = "checkBoxIsActive";
            checkBoxIsActive.Size = new Size(65, 21);
            checkBoxIsActive.TabIndex = 7;
            checkBoxIsActive.Text = "Active";
            checkBoxIsActive.UseVisualStyleBackColor = true;
            checkBoxIsActive.CheckedChanged += checkBoxIsActive_CheckedChanged;
            // 
            // addNewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 306);
            Controls.Add(tlpHeader);
            Name = "addNewUser";
            ShowIcon = false;
            Text = "Add New User";
            tlpButton.ResumeLayout(false);
            tlpFooterRow.ResumeLayout(false);
            tlpHeader.ResumeLayout(false);
            tlpLabel.ResumeLayout(false);
            tlpFooter.ResumeLayout(false);
            tlpFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpButton;
        private TableLayoutPanel tlpFooterRow;
        private Button btnClear;
        private Button btnSave;
        private TableLayoutPanel tlpHeader;
        private TableLayoutPanel tlpHeaderRow;
        private TableLayoutPanel tlpLabel;
        private TableLayoutPanel tlpFooter;
        private Label lblBarcode;
        private Label lblName;
        private Label lblRole;
        private Label lblIsActive;
        private TextBox txtBoxBarcode;
        private TextBox txtBoxName;
        private ComboBox cmbRole;
        private CheckBox checkBoxIsActive;
    }
}