namespace OswalMRA
{
    partial class frmNewMould
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtMouldCode = new TextBox();
            txtMouldName = new TextBox();
            txtMouldDesc = new TextBox();
            codeWarning = new Label();
            nameWarning = new Label();
            descWarning = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            ddlRow = new ComboBox();
            ddlCol = new ComboBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            btnAddNew = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.15842F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.33663F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.75248F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.75248F));
            tableLayoutPanel1.Size = new Size(435, 310);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.MaximumSize = new Size(1920, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 45);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11111F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.22222F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.22222F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11111F));
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 2, 0);
            tableLayoutPanel2.Controls.Add(label5, 3, 0);
            tableLayoutPanel2.Controls.Add(txtMouldCode, 1, 1);
            tableLayoutPanel2.Controls.Add(txtMouldName, 2, 1);
            tableLayoutPanel2.Controls.Add(txtMouldDesc, 3, 1);
            tableLayoutPanel2.Controls.Add(codeWarning, 1, 2);
            tableLayoutPanel2.Controls.Add(nameWarning, 2, 2);
            tableLayoutPanel2.Controls.Add(descWarning, 3, 2);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 80);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(429, 72);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(50, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 26);
            label1.TabIndex = 0;
            label1.Text = "Mould Code";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(145, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 26);
            label2.TabIndex = 1;
            label2.Text = "Mould Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(240, 0);
            label5.Name = "label5";
            label5.Size = new Size(137, 26);
            label5.TabIndex = 2;
            label5.Text = "Mould Description";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMouldCode
            // 
            txtMouldCode.Dock = DockStyle.Fill;
            txtMouldCode.Location = new Point(50, 29);
            txtMouldCode.MaxLength = 25;
            txtMouldCode.Name = "txtMouldCode";
            txtMouldCode.Size = new Size(89, 23);
            txtMouldCode.TabIndex = 0;
            // 
            // txtMouldName
            // 
            txtMouldName.Dock = DockStyle.Fill;
            txtMouldName.Location = new Point(145, 29);
            txtMouldName.MaxLength = 75;
            txtMouldName.Name = "txtMouldName";
            txtMouldName.Size = new Size(89, 23);
            txtMouldName.TabIndex = 1;
            // 
            // txtMouldDesc
            // 
            txtMouldDesc.Dock = DockStyle.Fill;
            txtMouldDesc.Location = new Point(240, 29);
            txtMouldDesc.MaxLength = 500;
            txtMouldDesc.Name = "txtMouldDesc";
            txtMouldDesc.Size = new Size(137, 23);
            txtMouldDesc.TabIndex = 2;
            // 
            // codeWarning
            // 
            codeWarning.AutoSize = true;
            codeWarning.ForeColor = Color.Red;
            codeWarning.Location = new Point(50, 52);
            codeWarning.Name = "codeWarning";
            codeWarning.Size = new Size(0, 15);
            codeWarning.TabIndex = 3;
            // 
            // nameWarning
            // 
            nameWarning.AutoSize = true;
            nameWarning.ForeColor = Color.Red;
            nameWarning.Location = new Point(145, 52);
            nameWarning.Name = "nameWarning";
            nameWarning.Size = new Size(0, 15);
            nameWarning.TabIndex = 4;
            // 
            // descWarning
            // 
            descWarning.AutoSize = true;
            descWarning.ForeColor = Color.Red;
            descWarning.Location = new Point(240, 52);
            descWarning.Name = "descWarning";
            descWarning.Size = new Size(0, 15);
            descWarning.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.57795F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.89098F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.53107F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(3, 158);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(429, 70);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label3, 0, 0);
            tableLayoutPanel6.Controls.Add(label4, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(86, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(255, 29);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 29);
            label3.TabIndex = 0;
            label3.Text = "Row";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(130, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 29);
            label4.TabIndex = 1;
            label4.Text = "Column";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(ddlRow, 0, 0);
            tableLayoutPanel7.Controls.Add(ddlCol, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(86, 38);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(255, 29);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // ddlRow
            // 
            ddlRow.Dock = DockStyle.Fill;
            ddlRow.FormattingEnabled = true;
            ddlRow.Location = new Point(3, 3);
            ddlRow.Name = "ddlRow";
            ddlRow.Size = new Size(121, 23);
            ddlRow.TabIndex = 2;
            // 
            // ddlCol
            // 
            ddlCol.Dock = DockStyle.Fill;
            ddlCol.FormattingEnabled = true;
            ddlCol.Location = new Point(130, 3);
            ddlCol.Name = "ddlCol";
            ddlCol.Size = new Size(122, 23);
            ddlCol.TabIndex = 3;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 4;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.Controls.Add(btnAddNew, 1, 0);
            tableLayoutPanel8.Controls.Add(button2, 2, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 234);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(429, 73);
            tableLayoutPanel8.TabIndex = 3;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.FromArgb(41, 128, 185);
            btnAddNew.Dock = DockStyle.Fill;
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.ForeColor = Color.White;
            btnAddNew.Location = new Point(110, 3);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(101, 30);
            btnAddNew.TabIndex = 0;
            btnAddNew.Text = "Save";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 128, 185);
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(217, 3);
            button2.Name = "button2";
            button2.Size = new Size(101, 30);
            button2.TabIndex = 1;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += clear_Click;
            // 
            // frmNewMould
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 310);
            Controls.Add(tableLayoutPanel1);
            Name = "frmNewMould";
            ShowIcon = false;
            Text = "Add New Mould";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private Button btnAddNew;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox txtMouldCode;
        private TextBox txtMouldName;
        private TextBox txtMouldDesc;
        private ComboBox ddlRow;
        private ComboBox ddlCol;
        private Label codeWarning;
        private Label nameWarning;
        private Label descWarning;
    }
}