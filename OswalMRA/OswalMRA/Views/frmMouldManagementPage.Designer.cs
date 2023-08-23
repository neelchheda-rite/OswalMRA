using System.Windows.Forms;

namespace OswalMRA
{
    partial class frmMouldManagementPage
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
            dgvMouldManagement = new DataGridView();
            tlpHeader = new TableLayoutPanel();
            tlpBtn = new TableLayoutPanel();
            addBtn = new Button();
            tlpGrid = new TableLayoutPanel();
            uploadBtn = new Button();
            clearBtn = new Button();
            tlpFooter = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvMouldManagement).BeginInit();
            tlpHeader.SuspendLayout();
            tlpBtn.SuspendLayout();
            tlpGrid.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMouldManagement
            // 
            dgvMouldManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMouldManagement.BackgroundColor = Color.White;
            dgvMouldManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMouldManagement.Dock = DockStyle.Fill;
            dgvMouldManagement.Location = new Point(0, 70);
            dgvMouldManagement.Margin = new Padding(0);
            dgvMouldManagement.Name = "dgvMouldManagement";
            dgvMouldManagement.RowTemplate.Height = 25;
            dgvMouldManagement.Size = new Size(800, 402);
            dgvMouldManagement.TabIndex = 1;
            dgvMouldManagement.CellContentClick += dgvMouldManagement_CellContentClick;
            // 
            // tableLayoutPanel1
            // 
            tlpHeader.ColumnCount = 1;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHeader.Controls.Add(dgvMouldManagement, 0, 2);
            tlpHeader.Controls.Add(tlpBtn, 0, 1);
            tlpHeader.Controls.Add(tlpGrid, 0, 3);
            tlpHeader.Controls.Add(tlpFooter, 0, 0);
            tlpHeader.Dock = DockStyle.Fill;
            tlpHeader.Location = new Point(0, 0);
            tlpHeader.Margin = new Padding(0);
            tlpHeader.Name = "tableLayoutPanel1";
            tlpHeader.RowCount = 4;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 79F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tlpHeader.Size = new Size(800, 510);
            tlpHeader.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tlpBtn.BackColor = Color.White;
            tlpBtn.ColumnCount = 2;
            tlpBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tlpBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpBtn.Controls.Add(addBtn, 1, 0);
            tlpBtn.Dock = DockStyle.Fill;
            tlpBtn.Location = new Point(0, 35);
            tlpBtn.Margin = new Padding(0);
            tlpBtn.Name = "tableLayoutPanel2";
            tlpBtn.RowCount = 1;
            tlpBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBtn.Size = new Size(800, 35);
            tlpBtn.TabIndex = 2;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(41, 128, 185);
            addBtn.Dock = DockStyle.Fill;
            addBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(680, 0);
            addBtn.Margin = new Padding(0);
            addBtn.MaximumSize = new Size(0, 33);
            addBtn.MinimumSize = new Size(0, 33);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(120, 33);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // tableLayoutPanel3
            // 
            tlpGrid.BackColor = Color.White;
            tlpGrid.ColumnCount = 3;
            tlpGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpGrid.Controls.Add(uploadBtn, 1, 0);
            tlpGrid.Controls.Add(clearBtn, 2, 0);
            tlpGrid.Dock = DockStyle.Fill;
            tlpGrid.Location = new Point(0, 472);
            tlpGrid.Margin = new Padding(0);
            tlpGrid.Name = "tableLayoutPanel3";
            tlpGrid.RowCount = 1;
            tlpGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpGrid.Size = new Size(800, 38);
            tlpGrid.TabIndex = 3;
            // 
            // uploadBtn
            // 
            uploadBtn.BackColor = Color.FromArgb(41, 128, 185);
            uploadBtn.Dock = DockStyle.Fill;
            uploadBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            uploadBtn.ForeColor = Color.White;
            uploadBtn.Location = new Point(560, 0);
            uploadBtn.Margin = new Padding(0);
            uploadBtn.MaximumSize = new Size(0, 33);
            uploadBtn.MinimumSize = new Size(0, 33);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(120, 33);
            uploadBtn.TabIndex = 0;
            uploadBtn.Text = "Upload";
            uploadBtn.UseVisualStyleBackColor = false;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(41, 128, 185);
            clearBtn.Dock = DockStyle.Fill;
            clearBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.ForeColor = Color.White;
            clearBtn.Location = new Point(680, 0);
            clearBtn.Margin = new Padding(0);
            clearBtn.MaximumSize = new Size(0, 33);
            clearBtn.MinimumSize = new Size(0, 33);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(120, 33);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // tableLayoutPanel4
            // 
            tlpFooter.BackColor = Color.FromArgb(41, 128, 185);
            tlpFooter.ColumnCount = 1;
            tlpFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFooter.Dock = DockStyle.Fill;
            tlpFooter.Location = new Point(0, 0);
            tlpFooter.Margin = new Padding(0);
            tlpFooter.MaximumSize = new Size(0, 47);
            tlpFooter.MinimumSize = new Size(0, 47);
            tlpFooter.Name = "tableLayoutPanel4";
            tlpFooter.RowCount = 1;
            tlpFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFooter.Size = new Size(800, 47);
            tlpFooter.TabIndex = 4;
            // 
            // frmMouldManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(tlpHeader);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmMouldManagementForm";
            ShowIcon = false;
            Text = "Mould Management";
            ((System.ComponentModel.ISupportInitialize)dgvMouldManagement).EndInit();
            tlpHeader.ResumeLayout(false);
            tlpBtn.ResumeLayout(false);
            tlpGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMouldManagement;
        private TableLayoutPanel tlpHeader;
        private TableLayoutPanel tlpBtn;
        private Button addBtn;
        private TableLayoutPanel tlpGrid;
        private Button uploadBtn;
        private Button clearBtn;
        private TableLayoutPanel tlpFooter;
    }
}