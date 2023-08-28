namespace OswalMRA {
    partial class frmToast {
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
            this.components = new System.ComponentModel.Container();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.successImage = new System.Windows.Forms.PictureBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.errorImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.successImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // timerClose
            // 
            this.timerClose.Interval = 1000;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // successImage
            // 
            this.successImage.Image = global::OswalMRA.Properties.Resources.icons8_success_30;
            this.successImage.Location = new System.Drawing.Point(10, 15);
            this.successImage.Margin = new System.Windows.Forms.Padding(0);
            this.successImage.Name = "successImage";
            this.successImage.Size = new System.Drawing.Size(30, 30);
            this.successImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.successImage.TabIndex = 0;
            this.successImage.TabStop = false;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messageLabel.ForeColor = System.Drawing.Color.White;
            this.messageLabel.Location = new System.Drawing.Point(50, 18);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(110, 21);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "Test Message";
            // 
            // errorImage
            // 
            this.errorImage.Image = global::OswalMRA.Properties.Resources.icons8_error_30;
            this.errorImage.Location = new System.Drawing.Point(10, 15);
            this.errorImage.Margin = new System.Windows.Forms.Padding(0);
            this.errorImage.Name = "errorImage";
            this.errorImage.Size = new System.Drawing.Size(30, 30);
            this.errorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.errorImage.TabIndex = 2;
            this.errorImage.TabStop = false;
            // 
            // frmToast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(325, 60);
            this.ControlBox = false;
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.successImage);
            this.Controls.Add(this.errorImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmToast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmToast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.successImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerClose;
        private PictureBox successImage;
        private Label messageLabel;
        private PictureBox errorImage;
    }
}