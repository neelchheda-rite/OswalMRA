namespace OswalMRA {
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
            this.currentPasswordLabel = new System.Windows.Forms.Label();
            this.currentPasswordPanel = new System.Windows.Forms.Panel();
            this.currentPasswordtxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newPasswordtxtBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.confirmPasswordtxtBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.passwordWarningLabel = new System.Windows.Forms.Label();
            this.currentPasswordPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentPasswordLabel
            // 
            this.currentPasswordLabel.AutoSize = true;
            this.currentPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.currentPasswordLabel.Location = new System.Drawing.Point(53, 106);
            this.currentPasswordLabel.Name = "currentPasswordLabel";
            this.currentPasswordLabel.Size = new System.Drawing.Size(178, 28);
            this.currentPasswordLabel.TabIndex = 0;
            this.currentPasswordLabel.Text = "Current Password";
            // 
            // currentPasswordPanel
            // 
            this.currentPasswordPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.currentPasswordPanel.Controls.Add(this.currentPasswordtxtBox);
            this.currentPasswordPanel.Location = new System.Drawing.Point(258, 95);
            this.currentPasswordPanel.Name = "currentPasswordPanel";
            this.currentPasswordPanel.Size = new System.Drawing.Size(400, 50);
            this.currentPasswordPanel.TabIndex = 0;
            // 
            // currentPasswordtxtBox
            // 
            this.currentPasswordtxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.currentPasswordtxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentPasswordtxtBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentPasswordtxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.currentPasswordtxtBox.Location = new System.Drawing.Point(20, 10);
            this.currentPasswordtxtBox.Name = "currentPasswordtxtBox";
            this.currentPasswordtxtBox.PasswordChar = '•';
            this.currentPasswordtxtBox.Size = new System.Drawing.Size(362, 27);
            this.currentPasswordtxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(67, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(51, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Confirm Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.newPasswordtxtBox);
            this.panel1.Location = new System.Drawing.Point(258, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 50);
            this.panel1.TabIndex = 1;
            // 
            // newPasswordtxtBox
            // 
            this.newPasswordtxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newPasswordtxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPasswordtxtBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newPasswordtxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.newPasswordtxtBox.Location = new System.Drawing.Point(20, 10);
            this.newPasswordtxtBox.Name = "newPasswordtxtBox";
            this.newPasswordtxtBox.PasswordChar = '•';
            this.newPasswordtxtBox.Size = new System.Drawing.Size(362, 27);
            this.newPasswordtxtBox.TabIndex = 0;
            this.newPasswordtxtBox.TextChanged += new System.EventHandler(this.newPasswordtxtBox_TextChanged);
            this.newPasswordtxtBox.Leave += new System.EventHandler(this.newPasswordtxtBox_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.confirmPasswordtxtBox);
            this.panel2.Location = new System.Drawing.Point(258, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 50);
            this.panel2.TabIndex = 2;
            // 
            // confirmPasswordtxtBox
            // 
            this.confirmPasswordtxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.confirmPasswordtxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordtxtBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmPasswordtxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.confirmPasswordtxtBox.Location = new System.Drawing.Point(20, 10);
            this.confirmPasswordtxtBox.Name = "confirmPasswordtxtBox";
            this.confirmPasswordtxtBox.PasswordChar = '•';
            this.confirmPasswordtxtBox.Size = new System.Drawing.Size(362, 27);
            this.confirmPasswordtxtBox.TabIndex = 0;
            this.confirmPasswordtxtBox.Leave += new System.EventHandler(this.confirmPasswordtxtBox_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 501);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 60);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(367, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(367, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(367, 60);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.passwordWarningLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 405);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(734, 96);
            this.panel4.TabIndex = 4;
            // 
            // passwordWarningLabel
            // 
            this.passwordWarningLabel.AutoSize = true;
            this.passwordWarningLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordWarningLabel.Location = new System.Drawing.Point(261, 4);
            this.passwordWarningLabel.Name = "passwordWarningLabel";
            this.passwordWarningLabel.Size = new System.Drawing.Size(0, 21);
            this.passwordWarningLabel.TabIndex = 0;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currentPasswordPanel);
            this.Controls.Add(this.currentPasswordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "frmChangePassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.currentPasswordPanel.ResumeLayout(false);
            this.currentPasswordPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label currentPasswordLabel;
        private Panel currentPasswordPanel;
        private TextBox currentPasswordtxtBox;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox newPasswordtxtBox;
        private Panel panel2;
        private TextBox confirmPasswordtxtBox;
        private Panel panel3;
        private Button button2;
        private Button btnUpdate;
        private Panel panel4;
        private Label passwordWarningLabel;
    }
}