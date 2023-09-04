<<<<<<< Updated upstream
﻿namespace OswalMRA
=======
﻿namespace OswalMRA.subViews
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
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
=======
            tableLayoutPanel1 = new TableLayoutPanel();
            titlePanel = new Panel();
            titleGrid = new TableLayoutPanel();
            titleLabel = new Label();
            closeLabel = new Label();
            buttonGrid = new TableLayoutPanel();
            btnAdd = new Button();
            btnCancel = new Button();
            baseGrid = new TableLayoutPanel();
            firstGrid = new TableLayoutPanel();
            nameLabel = new Label();
            textBox1 = new TextBox();
            secondGrid = new TableLayoutPanel();
            externalLabel = new Label();
            textBox2 = new TextBox();
            thirdGrid = new TableLayoutPanel();
            roleLabel = new Label();
            comboBox1 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            titlePanel.SuspendLayout();
            titleGrid.SuspendLayout();
            buttonGrid.SuspendLayout();
            baseGrid.SuspendLayout();
            firstGrid.SuspendLayout();
            secondGrid.SuspendLayout();
            thirdGrid.SuspendLayout();
>>>>>>> Stashed changes
            SuspendLayout();
            // 
            // tlpButton
            // 
<<<<<<< Updated upstream
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
=======
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(titlePanel, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonGrid, 0, 2);
            tableLayoutPanel1.Controls.Add(baseGrid, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel1.Size = new Size(442, 292);
            tableLayoutPanel1.TabIndex = 0;
>>>>>>> Stashed changes
            // 
            // tlpFooterRow
            // 
<<<<<<< Updated upstream
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
=======
            titlePanel.BackColor = Color.FromArgb(41, 128, 185);
            titlePanel.Controls.Add(titleGrid);
            titlePanel.Dock = DockStyle.Fill;
            titlePanel.Location = new Point(0, 0);
            titlePanel.Margin = new Padding(0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(442, 32);
            titlePanel.TabIndex = 1;
>>>>>>> Stashed changes
            // 
            // btnClear
            // 
<<<<<<< Updated upstream
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
=======
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
            titleGrid.Size = new Size(442, 32);
            titleGrid.TabIndex = 0;
>>>>>>> Stashed changes
            // 
            // btnSave
            // 
<<<<<<< Updated upstream
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
=======
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Left;
            titleLabel.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Margin = new Padding(0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(117, 32);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "   Add New User";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
>>>>>>> Stashed changes
            // 
            // tlpHeader
            // 
<<<<<<< Updated upstream
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
=======
            closeLabel.AutoSize = true;
            closeLabel.Dock = DockStyle.Fill;
            closeLabel.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point);
            closeLabel.ForeColor = Color.White;
            closeLabel.Location = new Point(411, 0);
            closeLabel.Margin = new Padding(0);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new Size(31, 32);
            closeLabel.TabIndex = 0;
            closeLabel.Text = "X";
            closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            closeLabel.Click += closeLabel_Click;
            closeLabel.MouseEnter += closeLabel_MouseEnter;
            closeLabel.MouseLeave += closeLabel_MouseLeave;
>>>>>>> Stashed changes
            // 
            // tlpHeaderRow
            // 
<<<<<<< Updated upstream
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
=======
            buttonGrid.ColumnCount = 5;
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            buttonGrid.Controls.Add(btnAdd, 1, 0);
            buttonGrid.Controls.Add(btnCancel, 3, 0);
            buttonGrid.Dock = DockStyle.Fill;
            buttonGrid.Location = new Point(0, 236);
            buttonGrid.Margin = new Padding(0);
            buttonGrid.Name = "buttonGrid";
            buttonGrid.RowCount = 1;
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            buttonGrid.Size = new Size(442, 37);
            buttonGrid.TabIndex = 2;
>>>>>>> Stashed changes
            // 
            // tlpLabel
            // 
<<<<<<< Updated upstream
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
=======
            btnAdd.BackColor = Color.FromArgb(41, 128, 185);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(44, 0);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 37);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
>>>>>>> Stashed changes
            // 
            // tlpFooter
            // 
<<<<<<< Updated upstream
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
=======
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(250, 0);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 37);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
>>>>>>> Stashed changes
            // 
            // lblBarcode
            // 
<<<<<<< Updated upstream
            lblBarcode.AutoSize = true;
            lblBarcode.Dock = DockStyle.Fill;
            lblBarcode.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBarcode.Location = new Point(3, 26);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(61, 56);
            lblBarcode.TabIndex = 0;
            lblBarcode.Text = "Barcode";
=======
            baseGrid.ColumnCount = 1;
            baseGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            baseGrid.Controls.Add(firstGrid, 0, 0);
            baseGrid.Controls.Add(secondGrid, 0, 1);
            baseGrid.Controls.Add(thirdGrid, 0, 2);
            baseGrid.Dock = DockStyle.Fill;
            baseGrid.Location = new Point(0, 32);
            baseGrid.Margin = new Padding(0);
            baseGrid.Name = "baseGrid";
            baseGrid.RowCount = 4;
            baseGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            baseGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            baseGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            baseGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            baseGrid.Size = new Size(442, 204);
            baseGrid.TabIndex = 3;
>>>>>>> Stashed changes
            // 
            // lblName
            // 
<<<<<<< Updated upstream
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
=======
            firstGrid.ColumnCount = 3;
            firstGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            firstGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            firstGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            firstGrid.Controls.Add(nameLabel, 1, 0);
            firstGrid.Controls.Add(textBox1, 1, 2);
            firstGrid.Dock = DockStyle.Fill;
            firstGrid.Location = new Point(0, 0);
            firstGrid.Margin = new Padding(0);
            firstGrid.Name = "firstGrid";
            firstGrid.RowCount = 3;
            firstGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            firstGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            firstGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            firstGrid.Size = new Size(442, 61);
            firstGrid.TabIndex = 0;
>>>>>>> Stashed changes
            // 
            // txtBoxBarcode
            // 
<<<<<<< Updated upstream
            txtBoxBarcode.Dock = DockStyle.Fill;
            txtBoxBarcode.Location = new Point(67, 26);
            txtBoxBarcode.Margin = new Padding(0);
            txtBoxBarcode.Name = "txtBoxBarcode";
            txtBoxBarcode.Size = new Size(149, 25);
            txtBoxBarcode.TabIndex = 4;
            // 
            // txtBoxName
            // 
            txtBoxName.Dock = DockStyle.Fill;
            txtBoxName.Location = new Point(284, 26);
            txtBoxName.Margin = new Padding(0);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(166, 25);
            txtBoxName.TabIndex = 5;
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
=======
            nameLabel.AutoSize = true;
            nameLabel.Dock = DockStyle.Fill;
            nameLabel.FlatStyle = FlatStyle.Flat;
            nameLabel.Location = new Point(44, 0);
            nameLabel.Margin = new Padding(0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(353, 27);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.BottomLeft;
>>>>>>> Stashed changes
            // 
            // checkBoxIsActive
            // 
<<<<<<< Updated upstream
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
=======
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(41, 128, 185);
            textBox1.Location = new Point(44, 33);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 29);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // secondGrid
            // 
            secondGrid.ColumnCount = 3;
            secondGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            secondGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            secondGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            secondGrid.Controls.Add(externalLabel, 1, 0);
            secondGrid.Controls.Add(textBox2, 1, 2);
            secondGrid.Dock = DockStyle.Fill;
            secondGrid.Location = new Point(0, 61);
            secondGrid.Margin = new Padding(0);
            secondGrid.Name = "secondGrid";
            secondGrid.RowCount = 3;
            secondGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            secondGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            secondGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            secondGrid.Size = new Size(442, 61);
            secondGrid.TabIndex = 1;
            // 
            // externalLabel
            // 
            externalLabel.AutoSize = true;
            externalLabel.Dock = DockStyle.Fill;
            externalLabel.FlatStyle = FlatStyle.Flat;
            externalLabel.Location = new Point(44, 0);
            externalLabel.Margin = new Padding(0);
            externalLabel.Name = "externalLabel";
            externalLabel.Size = new Size(353, 27);
            externalLabel.TabIndex = 0;
            externalLabel.Text = "External ID";
            externalLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(41, 128, 185);
            textBox2.Location = new Point(44, 33);
            textBox2.Margin = new Padding(0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(353, 29);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // thirdGrid
            // 
            thirdGrid.ColumnCount = 3;
            thirdGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            thirdGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            thirdGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            thirdGrid.Controls.Add(roleLabel, 1, 0);
            thirdGrid.Controls.Add(comboBox1, 1, 2);
            thirdGrid.Dock = DockStyle.Fill;
            thirdGrid.Location = new Point(0, 122);
            thirdGrid.Margin = new Padding(0);
            thirdGrid.Name = "thirdGrid";
            thirdGrid.RowCount = 3;
            thirdGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            thirdGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            thirdGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            thirdGrid.Size = new Size(442, 61);
            thirdGrid.TabIndex = 2;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Dock = DockStyle.Fill;
            roleLabel.FlatStyle = FlatStyle.Flat;
            roleLabel.Location = new Point(44, 0);
            roleLabel.Margin = new Padding(0);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(353, 27);
            roleLabel.TabIndex = 0;
            roleLabel.Text = "Role";
            roleLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Control;
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.FromArgb(41, 128, 185);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(44, 33);
            comboBox1.Margin = new Padding(0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(353, 38);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // addNewUser
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(442, 292);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(41, 128, 185);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "addNewUser";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
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
>>>>>>> Stashed changes
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