namespace OswalMRA {
    partial class frmHome {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.columnLabel = new System.Windows.Forms.Label();
            this.columnTxtBox = new System.Windows.Forms.TextBox();
            this.rowLabel = new System.Windows.Forms.Label();
            this.columnPanel = new System.Windows.Forms.Panel();
            this.mouldCodePanel = new System.Windows.Forms.Panel();
            this.mouldCodeTxtBox = new System.Windows.Forms.TextBox();
            this.mouldCodeLabel = new System.Windows.Forms.Label();
            this.rowPanel = new System.Windows.Forms.Panel();
            this.rowTxtBox = new System.Windows.Forms.TextBox();
            this.operatorIdLabel = new System.Windows.Forms.Label();
            this.operatorPanel = new System.Windows.Forms.Panel();
            this.operatorTxtBox = new System.Windows.Forms.TextBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.columnPanel.SuspendLayout();
            this.mouldCodePanel.SuspendLayout();
            this.rowPanel.SuspendLayout();
            this.operatorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnLabel
            // 
            this.columnLabel.AutoSize = true;
            this.columnLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.columnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.columnLabel.Location = new System.Drawing.Point(163, 107);
            this.columnLabel.Name = "columnLabel";
            this.columnLabel.Size = new System.Drawing.Size(84, 28);
            this.columnLabel.TabIndex = 0;
            this.columnLabel.Text = "Column";
            // 
            // columnTxtBox
            // 
            this.columnTxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.columnTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.columnTxtBox.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.columnTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.columnTxtBox.Location = new System.Drawing.Point(17, 15);
            this.columnTxtBox.Margin = new System.Windows.Forms.Padding(10);
            this.columnTxtBox.Name = "columnTxtBox";
            this.columnTxtBox.Size = new System.Drawing.Size(150, 54);
            this.columnTxtBox.TabIndex = 1;
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.rowLabel.Location = new System.Drawing.Point(487, 107);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(53, 28);
            this.rowLabel.TabIndex = 2;
            this.rowLabel.Text = "Row";
            // 
            // columnPanel
            // 
            this.columnPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.columnPanel.Controls.Add(this.columnTxtBox);
            this.columnPanel.Location = new System.Drawing.Point(163, 149);
            this.columnPanel.Name = "columnPanel";
            this.columnPanel.Size = new System.Drawing.Size(185, 85);
            this.columnPanel.TabIndex = 4;
            // 
            // mouldCodePanel
            // 
            this.mouldCodePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mouldCodePanel.Controls.Add(this.mouldCodeTxtBox);
            this.mouldCodePanel.Location = new System.Drawing.Point(163, 321);
            this.mouldCodePanel.Name = "mouldCodePanel";
            this.mouldCodePanel.Size = new System.Drawing.Size(509, 85);
            this.mouldCodePanel.TabIndex = 5;
            // 
            // mouldCodeTxtBox
            // 
            this.mouldCodeTxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mouldCodeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mouldCodeTxtBox.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mouldCodeTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.mouldCodeTxtBox.Location = new System.Drawing.Point(17, 15);
            this.mouldCodeTxtBox.Margin = new System.Windows.Forms.Padding(10);
            this.mouldCodeTxtBox.Name = "mouldCodeTxtBox";
            this.mouldCodeTxtBox.Size = new System.Drawing.Size(474, 54);
            this.mouldCodeTxtBox.TabIndex = 1;
            // 
            // mouldCodeLabel
            // 
            this.mouldCodeLabel.AutoSize = true;
            this.mouldCodeLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mouldCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.mouldCodeLabel.Location = new System.Drawing.Point(163, 279);
            this.mouldCodeLabel.Name = "mouldCodeLabel";
            this.mouldCodeLabel.Size = new System.Drawing.Size(126, 28);
            this.mouldCodeLabel.TabIndex = 6;
            this.mouldCodeLabel.Text = "Mould Code";
            // 
            // rowPanel
            // 
            this.rowPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rowPanel.Controls.Add(this.rowTxtBox);
            this.rowPanel.Location = new System.Drawing.Point(487, 149);
            this.rowPanel.Name = "rowPanel";
            this.rowPanel.Size = new System.Drawing.Size(185, 85);
            this.rowPanel.TabIndex = 5;
            // 
            // rowTxtBox
            // 
            this.rowTxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rowTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rowTxtBox.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rowTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.rowTxtBox.Location = new System.Drawing.Point(17, 15);
            this.rowTxtBox.Margin = new System.Windows.Forms.Padding(10);
            this.rowTxtBox.Name = "rowTxtBox";
            this.rowTxtBox.Size = new System.Drawing.Size(150, 54);
            this.rowTxtBox.TabIndex = 1;
            // 
            // operatorIdLabel
            // 
            this.operatorIdLabel.AutoSize = true;
            this.operatorIdLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.operatorIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.operatorIdLabel.Location = new System.Drawing.Point(163, 458);
            this.operatorIdLabel.Name = "operatorIdLabel";
            this.operatorIdLabel.Size = new System.Drawing.Size(124, 28);
            this.operatorIdLabel.TabIndex = 8;
            this.operatorIdLabel.Text = "Operator ID";
            // 
            // operatorPanel
            // 
            this.operatorPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.operatorPanel.Controls.Add(this.operatorTxtBox);
            this.operatorPanel.Location = new System.Drawing.Point(163, 500);
            this.operatorPanel.Name = "operatorPanel";
            this.operatorPanel.Size = new System.Drawing.Size(509, 85);
            this.operatorPanel.TabIndex = 7;
            // 
            // operatorTxtBox
            // 
            this.operatorTxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.operatorTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.operatorTxtBox.Enabled = false;
            this.operatorTxtBox.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operatorTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.operatorTxtBox.Location = new System.Drawing.Point(17, 15);
            this.operatorTxtBox.Margin = new System.Windows.Forms.Padding(10);
            this.operatorTxtBox.Name = "operatorTxtBox";
            this.operatorTxtBox.Size = new System.Drawing.Size(474, 54);
            this.operatorTxtBox.TabIndex = 1;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Location = new System.Drawing.Point(950, 150);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(150, 150);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStore.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStore.ForeColor = System.Drawing.Color.White;
            this.btnStore.Location = new System.Drawing.Point(950, 435);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(150, 150);
            this.btnStore.TabIndex = 9;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 1020);
            this.ControlBox = false;
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.operatorIdLabel);
            this.Controls.Add(this.operatorPanel);
            this.Controls.Add(this.rowPanel);
            this.Controls.Add(this.mouldCodeLabel);
            this.Controls.Add(this.columnPanel);
            this.Controls.Add(this.mouldCodePanel);
            this.Controls.Add(this.rowLabel);
            this.Controls.Add(this.columnLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1865, 1020);
            this.MinimumSize = new System.Drawing.Size(1645, 1020);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.columnPanel.ResumeLayout(false);
            this.columnPanel.PerformLayout();
            this.mouldCodePanel.ResumeLayout(false);
            this.mouldCodePanel.PerformLayout();
            this.rowPanel.ResumeLayout(false);
            this.rowPanel.PerformLayout();
            this.operatorPanel.ResumeLayout(false);
            this.operatorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label columnLabel;
        private TextBox columnTxtBox;
        private Label rowLabel;
        private Panel columnPanel;
        private Panel mouldCodePanel;
        private TextBox mouldCodeTxtBox;
        private Label mouldCodeLabel;
        private Panel rowPanel;
        private TextBox rowTxtBox;
        private Label operatorIdLabel;
        private Panel operatorPanel;
        private TextBox operatorTxtBox;
        private Button btnRestore;
        private Button btnStore;
    }
}