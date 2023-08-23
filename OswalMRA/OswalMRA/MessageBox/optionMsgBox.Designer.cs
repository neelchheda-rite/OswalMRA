namespace OswalMRA.MessageBox
{
    partial class optionMsgBox
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
            btnYes = new Button();
            btnNo = new Button();
            messageLabel = new Label();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.FromArgb(41, 128, 185);
            btnYes.FlatAppearance.BorderSize = 0;
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnYes.ForeColor = Color.White;
            btnYes.Location = new Point(0, 174);
            btnYes.Margin = new Padding(3, 2, 3, 2);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(201, 32);
            btnYes.TabIndex = 0;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = SystemColors.ControlLight;
            btnNo.FlatAppearance.BorderSize = 0;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnNo.ForeColor = SystemColors.ControlDarkDark;
            btnNo.Location = new Point(201, 174);
            btnNo.Margin = new Padding(3, 2, 3, 2);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(201, 32);
            btnNo.TabIndex = 1;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += button2_Click;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            messageLabel.Location = new Point(12, 9);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(0, 25);
            messageLabel.TabIndex = 2;
            // 
            // optionMsgBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 206);
            Controls.Add(messageLabel);
            Controls.Add(btnYes);
            Controls.Add(btnNo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "optionMsgBox";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYes;
        private Button btnNo;
        private Label messageLabel;
    }
}