namespace OswalMRA
{
    partial class frmUserManagementPage
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
            dgvUserManagement = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAdd = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            uploadBtn = new Button();
            clearBtn = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserManagement).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvUserManagement, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel1.Size = new Size(762, 478);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvUserManagement
            // 
            dgvUserManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUserManagement.BackgroundColor = Color.White;
            dgvUserManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserManagement.Dock = DockStyle.Fill;
            dgvUserManagement.Location = new Point(0, 66);
            dgvUserManagement.Margin = new Padding(0);
            dgvUserManagement.Name = "dgvUserManagement";
            dgvUserManagement.RowTemplate.Height = 25;
            dgvUserManagement.Size = new Size(762, 377);
            dgvUserManagement.TabIndex = 1;
            dgvUserManagement.CellContentClick += dgvUserManagement_CellContentClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.Controls.Add(btnAdd, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 33);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(762, 33);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(41, 128, 185);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(647, 0);
            btnAdd.Margin = new Padding(0);
            btnAdd.MaximumSize = new Size(0, 33);
            btnAdd.MinimumSize = new Size(0, 33);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 33);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.Controls.Add(uploadBtn, 1, 0);
            tableLayoutPanel3.Controls.Add(clearBtn, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 443);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(762, 35);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // uploadBtn
            // 
            uploadBtn.BackColor = Color.FromArgb(41, 128, 185);
            uploadBtn.Dock = DockStyle.Fill;
            uploadBtn.ForeColor = Color.White;
            uploadBtn.Location = new Point(533, 0);
            uploadBtn.Margin = new Padding(0);
            uploadBtn.MaximumSize = new Size(0, 33);
            uploadBtn.MinimumSize = new Size(0, 33);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(114, 33);
            uploadBtn.TabIndex = 0;
            uploadBtn.Text = "Upload";
            uploadBtn.UseVisualStyleBackColor = false;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(41, 128, 185);
            clearBtn.Dock = DockStyle.Fill;
            clearBtn.ForeColor = Color.White;
            clearBtn.Location = new Point(647, 0);
            clearBtn.Margin = new Padding(0);
            clearBtn.MaximumSize = new Size(0, 33);
            clearBtn.MinimumSize = new Size(0, 33);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(115, 33);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.FromArgb(41, 128, 185);
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.MaximumSize = new Size(0, 47);
            tableLayoutPanel4.MinimumSize = new Size(0, 47);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(762, 47);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 478);
            Controls.Add(tableLayoutPanel1);
            Name = "UserManagement";
            ShowIcon = false;
            Text = "User Management";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserManagement).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvUserManagement;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanel3;
        private Button uploadBtn;
        private Button clearBtn;
        private TableLayoutPanel tableLayoutPanel4;
    }
}