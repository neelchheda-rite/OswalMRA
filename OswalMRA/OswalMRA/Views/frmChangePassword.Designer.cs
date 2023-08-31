namespace OswalMRA.Views {
    partial class frmChangePassword {
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
            this.outerBaseGrid = new System.Windows.Forms.TableLayoutPanel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleGrid = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.buttonGrid = new System.Windows.Forms.TableLayoutPanel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.baseGrid = new System.Windows.Forms.TableLayoutPanel();
            this.currentPasswordGrid = new System.Windows.Forms.TableLayoutPanel();
            this.currentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.currentPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordGrid = new System.Windows.Forms.TableLayoutPanel();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordGRid = new System.Windows.Forms.TableLayoutPanel();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outerBaseGrid.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.titleGrid.SuspendLayout();
            this.buttonGrid.SuspendLayout();
            this.baseGrid.SuspendLayout();
            this.currentPasswordGrid.SuspendLayout();
            this.newPasswordGrid.SuspendLayout();
            this.confirmPasswordGRid.SuspendLayout();
            this.SuspendLayout();
            // 
            // outerBaseGrid
            // 
            this.outerBaseGrid.ColumnCount = 1;
            this.outerBaseGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outerBaseGrid.Controls.Add(this.titlePanel, 0, 0);
            this.outerBaseGrid.Controls.Add(this.buttonGrid, 0, 2);
            this.outerBaseGrid.Controls.Add(this.baseGrid, 0, 1);
            this.outerBaseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outerBaseGrid.Location = new System.Drawing.Point(0, 0);
            this.outerBaseGrid.Margin = new System.Windows.Forms.Padding(0);
            this.outerBaseGrid.Name = "outerBaseGrid";
            this.outerBaseGrid.RowCount = 4;
            this.outerBaseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.outerBaseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.outerBaseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.outerBaseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.outerBaseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.outerBaseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.outerBaseGrid.Size = new System.Drawing.Size(596, 396);
            this.outerBaseGrid.TabIndex = 0;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.titlePanel.Controls.Add(this.titleGrid);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(596, 43);
            this.titlePanel.TabIndex = 1;
            // 
            // titleGrid
            // 
            this.titleGrid.ColumnCount = 2;
            this.titleGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.titleGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.titleGrid.Controls.Add(this.titleLabel, 0, 0);
            this.titleGrid.Controls.Add(this.closeLabel, 1, 0);
            this.titleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleGrid.Location = new System.Drawing.Point(0, 0);
            this.titleGrid.Margin = new System.Windows.Forms.Padding(0);
            this.titleGrid.Name = "titleGrid";
            this.titleGrid.RowCount = 1;
            this.titleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.titleGrid.Size = new System.Drawing.Size(596, 43);
            this.titleGrid.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(139, 43);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "   Change Password";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeLabel.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeLabel.ForeColor = System.Drawing.Color.White;
            this.closeLabel.Location = new System.Drawing.Point(554, 0);
            this.closeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(42, 43);
            this.closeLabel.TabIndex = 0;
            this.closeLabel.Text = "X";
            this.closeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            this.closeLabel.MouseEnter += new System.EventHandler(this.closeLabel_MouseEnter);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            // 
            // buttonGrid
            // 
            this.buttonGrid.ColumnCount = 5;
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.buttonGrid.Controls.Add(this.btnChangePassword, 1, 0);
            this.buttonGrid.Controls.Add(this.btnCancel, 3, 0);
            this.buttonGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGrid.Location = new System.Drawing.Point(0, 320);
            this.buttonGrid.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGrid.Name = "buttonGrid";
            this.buttonGrid.RowCount = 1;
            this.buttonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonGrid.Size = new System.Drawing.Size(596, 51);
            this.buttonGrid.TabIndex = 2;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(59, 0);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(196, 51);
            this.btnChangePassword.TabIndex = 0;
            this.btnChangePassword.Text = "Save";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(338, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(196, 51);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // baseGrid
            // 
            this.baseGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseGrid.ColumnCount = 1;
            this.baseGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.baseGrid.Controls.Add(this.currentPasswordGrid, 0, 0);
            this.baseGrid.Controls.Add(this.newPasswordGrid, 0, 1);
            this.baseGrid.Controls.Add(this.confirmPasswordGRid, 0, 2);
            this.baseGrid.Location = new System.Drawing.Point(0, 43);
            this.baseGrid.Margin = new System.Windows.Forms.Padding(0);
            this.baseGrid.Name = "baseGrid";
            this.baseGrid.RowCount = 4;
            this.baseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.baseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.baseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.baseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.baseGrid.Size = new System.Drawing.Size(596, 277);
            this.baseGrid.TabIndex = 3;
            // 
            // currentPasswordGrid
            // 
            this.currentPasswordGrid.ColumnCount = 5;
            this.currentPasswordGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.currentPasswordGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.currentPasswordGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.currentPasswordGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.currentPasswordGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.currentPasswordGrid.Controls.Add(this.currentPasswordTextBox, 3, 1);
            this.currentPasswordGrid.Controls.Add(this.currentPasswordLabel, 1, 1);
            this.currentPasswordGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentPasswordGrid.Location = new System.Drawing.Point(0, 0);
            this.currentPasswordGrid.Margin = new System.Windows.Forms.Padding(0);
            this.currentPasswordGrid.Name = "currentPasswordGrid";
            this.currentPasswordGrid.RowCount = 3;
            this.currentPasswordGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.currentPasswordGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.currentPasswordGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.currentPasswordGrid.Size = new System.Drawing.Size(596, 83);
            this.currentPasswordGrid.TabIndex = 1;
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.currentPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.currentPasswordTextBox.Location = new System.Drawing.Point(242, 29);
            this.currentPasswordTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.PasswordChar = '●';
            this.currentPasswordTextBox.Size = new System.Drawing.Size(321, 29);
            this.currentPasswordTextBox.TabIndex = 0;
            // 
            // currentPasswordLabel
            // 
            this.currentPasswordLabel.AutoSize = true;
            this.currentPasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentPasswordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.currentPasswordLabel.Location = new System.Drawing.Point(32, 29);
            this.currentPasswordLabel.Name = "currentPasswordLabel";
            this.currentPasswordLabel.Size = new System.Drawing.Size(184, 24);
            this.currentPasswordLabel.TabIndex = 1;
            this.currentPasswordLabel.Text = "Current password";
            this.currentPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newPasswordGrid
            // 
            this.newPasswordGrid.ColumnCount = 5;
            this.newPasswordGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.newPasswordGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.newPasswordGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.newPasswordGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.newPasswordGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.newPasswordGrid.Controls.Add(this.newPasswordTextBox, 3, 1);
            this.newPasswordGrid.Controls.Add(this.newPasswordLabel, 1, 1);
            this.newPasswordGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newPasswordGrid.Location = new System.Drawing.Point(0, 83);
            this.newPasswordGrid.Margin = new System.Windows.Forms.Padding(0);
            this.newPasswordGrid.Name = "newPasswordGrid";
            this.newPasswordGrid.RowCount = 3;
            this.newPasswordGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.newPasswordGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.newPasswordGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.newPasswordGrid.Size = new System.Drawing.Size(596, 83);
            this.newPasswordGrid.TabIndex = 2;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.newPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.newPasswordTextBox.Location = new System.Drawing.Point(242, 29);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '●';
            this.newPasswordTextBox.Size = new System.Drawing.Size(321, 29);
            this.newPasswordTextBox.TabIndex = 0;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newPasswordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.newPasswordLabel.Location = new System.Drawing.Point(32, 29);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(184, 24);
            this.newPasswordLabel.TabIndex = 1;
            this.newPasswordLabel.Text = "New password";
            this.newPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // confirmPasswordGRid
            // 
            this.confirmPasswordGRid.ColumnCount = 5;
            this.confirmPasswordGRid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.confirmPasswordGRid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.confirmPasswordGRid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.confirmPasswordGRid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.confirmPasswordGRid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.confirmPasswordGRid.Controls.Add(this.confirmPasswordTextBox, 3, 1);
            this.confirmPasswordGRid.Controls.Add(this.confirmPasswordLabel, 1, 1);
            this.confirmPasswordGRid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmPasswordGRid.Location = new System.Drawing.Point(0, 166);
            this.confirmPasswordGRid.Margin = new System.Windows.Forms.Padding(0);
            this.confirmPasswordGRid.Name = "confirmPasswordGRid";
            this.confirmPasswordGRid.RowCount = 3;
            this.confirmPasswordGRid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.confirmPasswordGRid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.confirmPasswordGRid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.confirmPasswordGRid.Size = new System.Drawing.Size(596, 83);
            this.confirmPasswordGRid.TabIndex = 3;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.confirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(242, 29);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '●';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(321, 29);
            this.confirmPasswordTextBox.TabIndex = 0;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmPasswordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(32, 29);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(184, 24);
            this.confirmPasswordLabel.TabIndex = 1;
            this.confirmPasswordLabel.Text = "Confirm password";
            this.confirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 125);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 396);
            this.ControlBox = false;
            this.Controls.Add(this.outerBaseGrid);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.changePasswordTest_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmChangePassword_KeyDown);
            this.outerBaseGrid.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titleGrid.ResumeLayout(false);
            this.titleGrid.PerformLayout();
            this.buttonGrid.ResumeLayout(false);
            this.baseGrid.ResumeLayout(false);
            this.currentPasswordGrid.ResumeLayout(false);
            this.currentPasswordGrid.PerformLayout();
            this.newPasswordGrid.ResumeLayout(false);
            this.newPasswordGrid.PerformLayout();
            this.confirmPasswordGRid.ResumeLayout(false);
            this.confirmPasswordGRid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel outerBaseGrid;
        private Panel titlePanel;
        private TableLayoutPanel titleGrid;
        private Label titleLabel;
        private Label closeLabel;
        private TableLayoutPanel buttonGrid;
        private Button btnChangePassword;
        private Button btnCancel;
        private TableLayoutPanel baseGrid;
        private TableLayoutPanel currentPasswordGrid;
        private TextBox currentPasswordTextBox;
        private Label currentPasswordLabel;
        private TableLayoutPanel newPasswordGrid;
        private TextBox newPasswordTextBox;
        private Label newPasswordLabel;
        private Label label1;
        private TableLayoutPanel confirmPasswordGRid;
        private TextBox confirmPasswordTextBox;
        private Label confirmPasswordLabel;
    }
}