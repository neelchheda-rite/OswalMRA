namespace OswalMRA.Views {
    partial class frmChangePasswordPage {
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
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.currentPasswordLabel = new System.Windows.Forms.Label();
            this.currentPasswordPanel = new System.Windows.Forms.Panel();
            this.currentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordPanel = new System.Windows.Forms.Panel();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordPanel = new System.Windows.Forms.Panel();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.currentPasswordWarning = new System.Windows.Forms.Label();
            this.newPasswordWarning = new System.Windows.Forms.Label();
            this.confirmPasswordWarning = new System.Windows.Forms.Label();
            this.currentPasswordPanel.SuspendLayout();
            this.newPasswordPanel.SuspendLayout();
            this.confirmPasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(121, 253);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(3);
            this.btnChangePassword.Size = new System.Drawing.Size(173, 40);
            this.btnChangePassword.TabIndex = 8;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // currentPasswordLabel
            // 
            this.currentPasswordLabel.AutoSize = true;
            this.currentPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.currentPasswordLabel.Location = new System.Drawing.Point(19, 33);
            this.currentPasswordLabel.Name = "currentPasswordLabel";
            this.currentPasswordLabel.Size = new System.Drawing.Size(143, 21);
            this.currentPasswordLabel.TabIndex = 5;
            this.currentPasswordLabel.Text = "Current Password";
            // 
            // currentPasswordPanel
            // 
            this.currentPasswordPanel.BackColor = System.Drawing.SystemColors.Control;
            this.currentPasswordPanel.Controls.Add(this.currentPasswordTextBox);
            this.currentPasswordPanel.Location = new System.Drawing.Point(185, 25);
            this.currentPasswordPanel.Name = "currentPasswordPanel";
            this.currentPasswordPanel.Size = new System.Drawing.Size(200, 38);
            this.currentPasswordPanel.TabIndex = 6;
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.currentPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.currentPasswordTextBox.Location = new System.Drawing.Point(7, 7);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.PasswordChar = '●';
            this.currentPasswordTextBox.Size = new System.Drawing.Size(185, 24);
            this.currentPasswordTextBox.TabIndex = 0;
            // 
            // newPasswordPanel
            // 
            this.newPasswordPanel.BackColor = System.Drawing.SystemColors.Control;
            this.newPasswordPanel.Controls.Add(this.newPasswordTextBox);
            this.newPasswordPanel.Location = new System.Drawing.Point(185, 100);
            this.newPasswordPanel.Name = "newPasswordPanel";
            this.newPasswordPanel.Size = new System.Drawing.Size(200, 38);
            this.newPasswordPanel.TabIndex = 6;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.newPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.newPasswordTextBox.Location = new System.Drawing.Point(7, 7);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '●';
            this.newPasswordTextBox.Size = new System.Drawing.Size(185, 24);
            this.newPasswordTextBox.TabIndex = 0;
            this.newPasswordTextBox.TextChanged += new System.EventHandler(this.newPasswordTextBox_TextChanged);
            this.newPasswordTextBox.Leave += new System.EventHandler(this.newPasswordTextBox_Leave);
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.newPasswordLabel.Location = new System.Drawing.Point(19, 108);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(121, 21);
            this.newPasswordLabel.TabIndex = 5;
            this.newPasswordLabel.Text = "New Password";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(19, 183);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(148, 21);
            this.confirmPasswordLabel.TabIndex = 5;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // confirmPasswordPanel
            // 
            this.confirmPasswordPanel.BackColor = System.Drawing.SystemColors.Control;
            this.confirmPasswordPanel.Controls.Add(this.confirmPasswordTextBox);
            this.confirmPasswordPanel.Location = new System.Drawing.Point(185, 175);
            this.confirmPasswordPanel.Name = "confirmPasswordPanel";
            this.confirmPasswordPanel.Size = new System.Drawing.Size(200, 38);
            this.confirmPasswordPanel.TabIndex = 6;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.confirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(7, 7);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '●';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(185, 24);
            this.confirmPasswordTextBox.TabIndex = 0;
            this.confirmPasswordTextBox.TextChanged += new System.EventHandler(this.confirmPasswordTextBox_TextChanged);
            this.confirmPasswordTextBox.Leave += new System.EventHandler(this.confirmPasswordTextBox_Leave);
            // 
            // currentPasswordWarning
            // 
            this.currentPasswordWarning.AutoSize = true;
            this.currentPasswordWarning.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentPasswordWarning.ForeColor = System.Drawing.Color.Red;
            this.currentPasswordWarning.Location = new System.Drawing.Point(185, 66);
            this.currentPasswordWarning.Name = "currentPasswordWarning";
            this.currentPasswordWarning.Size = new System.Drawing.Size(0, 19);
            this.currentPasswordWarning.TabIndex = 9;
            // 
            // newPasswordWarning
            // 
            this.newPasswordWarning.AutoSize = true;
            this.newPasswordWarning.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPasswordWarning.ForeColor = System.Drawing.Color.Red;
            this.newPasswordWarning.Location = new System.Drawing.Point(185, 141);
            this.newPasswordWarning.Name = "newPasswordWarning";
            this.newPasswordWarning.Size = new System.Drawing.Size(0, 19);
            this.newPasswordWarning.TabIndex = 9;
            // 
            // confirmPasswordWarning
            // 
            this.confirmPasswordWarning.AutoSize = true;
            this.confirmPasswordWarning.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPasswordWarning.ForeColor = System.Drawing.Color.Red;
            this.confirmPasswordWarning.Location = new System.Drawing.Point(185, 216);
            this.confirmPasswordWarning.Name = "confirmPasswordWarning";
            this.confirmPasswordWarning.Size = new System.Drawing.Size(0, 19);
            this.confirmPasswordWarning.TabIndex = 9;
            // 
            // frmChangePasswordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.confirmPasswordWarning);
            this.Controls.Add(this.newPasswordWarning);
            this.Controls.Add(this.currentPasswordWarning);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.currentPasswordLabel);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.currentPasswordPanel);
            this.Controls.Add(this.newPasswordPanel);
            this.Controls.Add(this.confirmPasswordPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "frmChangePasswordPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.currentPasswordPanel.ResumeLayout(false);
            this.currentPasswordPanel.PerformLayout();
            this.newPasswordPanel.ResumeLayout(false);
            this.newPasswordPanel.PerformLayout();
            this.confirmPasswordPanel.ResumeLayout(false);
            this.confirmPasswordPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnChangePassword;
        private Label currentPasswordLabel;
        private Panel currentPasswordPanel;
        private TextBox currentPasswordTextBox;
        private Panel newPasswordPanel;
        private TextBox newPasswordTextBox;
        private Label newPasswordLabel;
        private Label confirmPasswordLabel;
        private Panel confirmPasswordPanel;
        private TextBox confirmPasswordTextBox;
        private Label currentPasswordWarning;
        private Label newPasswordWarning;
        private Label confirmPasswordWarning;
    }
}