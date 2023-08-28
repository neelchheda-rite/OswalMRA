namespace OswalMRA {
    partial class singleMsgBox {
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
            this.closeLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.buttonGrid = new System.Windows.Forms.TableLayoutPanel();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.outerBaseGrid.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.titleGrid.SuspendLayout();
            this.buttonGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // outerBaseGrid
            // 
            this.outerBaseGrid.BackColor = System.Drawing.Color.White;
            this.outerBaseGrid.ColumnCount = 1;
            this.outerBaseGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outerBaseGrid.Controls.Add(this.titlePanel, 0, 0);
            this.outerBaseGrid.Controls.Add(this.buttonGrid, 0, 2);
            this.outerBaseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outerBaseGrid.Location = new System.Drawing.Point(0, 0);
            this.outerBaseGrid.Margin = new System.Windows.Forms.Padding(0);
            this.outerBaseGrid.Name = "outerBaseGrid";
            this.outerBaseGrid.RowCount = 4;
            this.outerBaseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.outerBaseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.outerBaseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.outerBaseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.outerBaseGrid.Size = new System.Drawing.Size(500, 350);
            this.outerBaseGrid.TabIndex = 0;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.titlePanel.Controls.Add(this.titleGrid);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlePanel.ForeColor = System.Drawing.Color.White;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(500, 38);
            this.titlePanel.TabIndex = 0;
            // 
            // titleGrid
            // 
            this.titleGrid.ColumnCount = 2;
            this.titleGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.titleGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.titleGrid.Controls.Add(this.closeLabel, 1, 0);
            this.titleGrid.Controls.Add(this.titleLabel, 0, 0);
            this.titleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleGrid.Location = new System.Drawing.Point(0, 0);
            this.titleGrid.Margin = new System.Windows.Forms.Padding(0);
            this.titleGrid.Name = "titleGrid";
            this.titleGrid.RowCount = 1;
            this.titleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.titleGrid.Size = new System.Drawing.Size(500, 38);
            this.titleGrid.TabIndex = 0;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeLabel.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeLabel.Location = new System.Drawing.Point(465, 0);
            this.closeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(35, 38);
            this.closeLabel.TabIndex = 0;
            this.closeLabel.Text = "X";
            this.closeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            this.closeLabel.MouseEnter += new System.EventHandler(this.closeLabel_MouseEnter);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(459, 38);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonGrid
            // 
            this.buttonGrid.ColumnCount = 5;
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.buttonGrid.Controls.Add(this.btnYes, 1, 0);
            this.buttonGrid.Controls.Add(this.btnNo, 3, 0);
            this.buttonGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGrid.Location = new System.Drawing.Point(0, 283);
            this.buttonGrid.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGrid.Name = "buttonGrid";
            this.buttonGrid.RowCount = 1;
            this.buttonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonGrid.Size = new System.Drawing.Size(500, 45);
            this.buttonGrid.TabIndex = 1;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(50, 0);
            this.btnYes.Margin = new System.Windows.Forms.Padding(0);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(165, 45);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNo.Location = new System.Drawing.Point(285, 0);
            this.btnNo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(165, 45);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // singleMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.ControlBox = false;
            this.Controls.Add(this.outerBaseGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "singleMsgBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.singleMsgBox_KeyDown);
            this.MouseEnter += new System.EventHandler(this.closeLabel_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            this.outerBaseGrid.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titleGrid.ResumeLayout(false);
            this.titleGrid.PerformLayout();
            this.buttonGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel outerBaseGrid;
        private Panel titlePanel;
        private TableLayoutPanel titleGrid;
        private Label closeLabel;
        private Label titleLabel;
        private TableLayoutPanel buttonGrid;
        private Button btnYes;
        private Button btnNo;
    }
}