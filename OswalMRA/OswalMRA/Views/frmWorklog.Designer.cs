namespace OswalMRA
{
    partial class frmWorklog
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
            components = new System.ComponentModel.Container();
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties2 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties3 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties4 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties5 = new PresentationControls.CheckBoxProperties();
            tlpHeader = new TableLayoutPanel();
            pnlHeader = new Panel();
            tlpBtn = new TableLayoutPanel();
            btnSearch = new Button();
            label3 = new Label();
            label2 = new Label();
            lblPerson = new Label();
            lbl = new Label();
            lblStatus = new Label();
            checkBoxComboBox5 = new PresentationControls.CheckBoxComboBox();
            checkBoxComboBox2 = new PresentationControls.CheckBoxComboBox();
            checkBoxComboBox3 = new PresentationControls.CheckBoxComboBox();
            checkBoxComboBox1 = new PresentationControls.CheckBoxComboBox();
            checkBoxComboBox4 = new PresentationControls.CheckBoxComboBox();
            tlpGrid = new TableLayoutPanel();
            dgvWorklog = new DataGridView();
            cmsPerson = new ContextMenuStrip(components);
            cms = new ContextMenuStrip(components);
            tlpHeader.SuspendLayout();
            tlpBtn.SuspendLayout();
            tlpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWorklog).BeginInit();
            SuspendLayout();
            // 
            // tlpHeader
            // 
            tlpHeader.ColumnCount = 1;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHeader.Controls.Add(pnlHeader, 0, 0);
            tlpHeader.Controls.Add(tlpBtn, 0, 1);
            tlpHeader.Controls.Add(tlpGrid, 0, 2);
            tlpHeader.Dock = DockStyle.Fill;
            tlpHeader.Location = new Point(0, 0);
            tlpHeader.Margin = new Padding(0);
            tlpHeader.Name = "tlpHeader";
            tlpHeader.RowCount = 3;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 81F));
            tlpHeader.Size = new Size(873, 476);
            tlpHeader.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.MaximumSize = new Size(0, 47);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(873, 33);
            pnlHeader.TabIndex = 0;
            // 
            // tlpBtn
            // 
            tlpBtn.BackColor = Color.White;
            tlpBtn.ColumnCount = 8;
            tlpBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.182909F));
            tlpBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.476792F));
            tlpBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.21323F));
            tlpBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.517705F));
            tlpBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.3698F));
            tlpBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.864676F));
            tlpBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.19198F));
            tlpBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.182908F));
            tlpBtn.Controls.Add(btnSearch, 6, 2);
            tlpBtn.Controls.Add(label3, 5, 1);
            tlpBtn.Controls.Add(label2, 3, 1);
            tlpBtn.Controls.Add(lblPerson, 3, 2);
            tlpBtn.Controls.Add(lbl, 1, 1);
            tlpBtn.Controls.Add(lblStatus, 1, 2);
            tlpBtn.Controls.Add(checkBoxComboBox5, 2, 1);
            tlpBtn.Controls.Add(checkBoxComboBox2, 4, 1);
            tlpBtn.Controls.Add(checkBoxComboBox3, 6, 1);
            tlpBtn.Controls.Add(checkBoxComboBox1, 2, 2);
            tlpBtn.Controls.Add(checkBoxComboBox4, 4, 2);
            tlpBtn.Dock = DockStyle.Fill;
            tlpBtn.Location = new Point(0, 33);
            tlpBtn.Margin = new Padding(0);
            tlpBtn.Name = "tlpBtn";
            tlpBtn.RowCount = 3;
            tlpBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 7.161804F));
            tlpBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 49.26109F));
            tlpBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 43.57711F));
            tlpBtn.Size = new Size(873, 57);
            tlpBtn.TabIndex = 1;
            tlpBtn.Paint += tableLayoutPanel2_Paint;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(41, 128, 185);
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(684, 32);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(141, 25);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(616, 4);
            label3.Margin = new Padding(0);
            label3.MaximumSize = new Size(0, 23);
            label3.MinimumSize = new Size(0, 23);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 2;
            label3.Text = "User";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(321, 4);
            label2.Margin = new Padding(0);
            label2.MaximumSize = new Size(0, 23);
            label2.MinimumSize = new Size(0, 23);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 1;
            label2.Text = "Status";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPerson
            // 
            lblPerson.AutoSize = true;
            lblPerson.Dock = DockStyle.Fill;
            lblPerson.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPerson.Location = new Point(321, 32);
            lblPerson.Margin = new Padding(0);
            lblPerson.MaximumSize = new Size(0, 23);
            lblPerson.MinimumSize = new Size(0, 23);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(65, 23);
            lblPerson.TabIndex = 15;
            lblPerson.Text = "Column";
            lblPerson.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Dock = DockStyle.Fill;
            lbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(45, 4);
            lbl.Margin = new Padding(0);
            lbl.MaximumSize = new Size(0, 23);
            lbl.MinimumSize = new Size(0, 23);
            lbl.Name = "lbl";
            lbl.Size = new Size(56, 23);
            lbl.TabIndex = 0;
            lbl.Text = "Mould";
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(45, 32);
            lblStatus.Margin = new Padding(0);
            lblStatus.MaximumSize = new Size(0, 23);
            lblStatus.MinimumSize = new Size(0, 23);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(56, 23);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Row";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxComboBox5
            // 
            checkBoxProperties1.ForeColor = SystemColors.ControlText;
            checkBoxComboBox5.CheckBoxProperties = checkBoxProperties1;
            checkBoxComboBox5.DisplayMemberSingleItem = "";
            checkBoxComboBox5.Dock = DockStyle.Fill;
            checkBoxComboBox5.FormattingEnabled = true;
            checkBoxComboBox5.Location = new Point(101, 4);
            checkBoxComboBox5.Margin = new Padding(0);
            checkBoxComboBox5.Name = "checkBoxComboBox5";
            checkBoxComboBox5.Size = new Size(220, 23);
            checkBoxComboBox5.TabIndex = 20;
            // 
            // checkBoxComboBox2
            // 
            checkBoxProperties2.ForeColor = SystemColors.ControlText;
            checkBoxComboBox2.CheckBoxProperties = checkBoxProperties2;
            checkBoxComboBox2.DisplayMemberSingleItem = "";
            checkBoxComboBox2.Dock = DockStyle.Fill;
            checkBoxComboBox2.FormattingEnabled = true;
            checkBoxComboBox2.Location = new Point(386, 4);
            checkBoxComboBox2.Margin = new Padding(0);
            checkBoxComboBox2.Name = "checkBoxComboBox2";
            checkBoxComboBox2.Size = new Size(230, 23);
            checkBoxComboBox2.TabIndex = 17;
            // 
            // checkBoxComboBox3
            // 
            checkBoxProperties3.ForeColor = SystemColors.ControlText;
            checkBoxComboBox3.CheckBoxProperties = checkBoxProperties3;
            checkBoxComboBox3.DisplayMemberSingleItem = "";
            checkBoxComboBox3.Dock = DockStyle.Fill;
            checkBoxComboBox3.FormattingEnabled = true;
            checkBoxComboBox3.Location = new Point(684, 4);
            checkBoxComboBox3.Margin = new Padding(0);
            checkBoxComboBox3.Name = "checkBoxComboBox3";
            checkBoxComboBox3.Size = new Size(141, 23);
            checkBoxComboBox3.TabIndex = 18;
            // 
            // checkBoxComboBox1
            // 
            checkBoxProperties4.ForeColor = SystemColors.ControlText;
            checkBoxComboBox1.CheckBoxProperties = checkBoxProperties4;
            checkBoxComboBox1.DisplayMemberSingleItem = "";
            checkBoxComboBox1.Dock = DockStyle.Fill;
            checkBoxComboBox1.FormattingEnabled = true;
            checkBoxComboBox1.Location = new Point(101, 32);
            checkBoxComboBox1.Margin = new Padding(0);
            checkBoxComboBox1.Name = "checkBoxComboBox1";
            checkBoxComboBox1.Size = new Size(220, 23);
            checkBoxComboBox1.TabIndex = 16;
            // 
            // checkBoxComboBox4
            // 
            checkBoxProperties5.ForeColor = SystemColors.ControlText;
            checkBoxComboBox4.CheckBoxProperties = checkBoxProperties5;
            checkBoxComboBox4.DisplayMemberSingleItem = "";
            checkBoxComboBox4.Dock = DockStyle.Fill;
            checkBoxComboBox4.FormattingEnabled = true;
            checkBoxComboBox4.Location = new Point(386, 32);
            checkBoxComboBox4.Margin = new Padding(0);
            checkBoxComboBox4.Name = "checkBoxComboBox4";
            checkBoxComboBox4.Size = new Size(230, 23);
            checkBoxComboBox4.TabIndex = 19;
            // 
            // tlpGrid
            // 
            tlpGrid.BackColor = Color.White;
            tlpGrid.ColumnCount = 1;
            tlpGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpGrid.Controls.Add(dgvWorklog, 0, 0);
            tlpGrid.Dock = DockStyle.Fill;
            tlpGrid.Location = new Point(0, 90);
            tlpGrid.Margin = new Padding(0);
            tlpGrid.Name = "tlpGrid";
            tlpGrid.RowCount = 2;
            tlpGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGrid.Size = new Size(873, 386);
            tlpGrid.TabIndex = 2;
            // 
            // dgvWorklog
            // 
            dgvWorklog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWorklog.BackgroundColor = Color.White;
            dgvWorklog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorklog.Dock = DockStyle.Fill;
            dgvWorklog.Location = new Point(0, 0);
            dgvWorklog.Margin = new Padding(0);
            dgvWorklog.Name = "dgvWorklog";
            dgvWorklog.RowTemplate.Height = 25;
            dgvWorklog.Size = new Size(873, 366);
            dgvWorklog.TabIndex = 0;
            dgvWorklog.CellContentClick += dgvWorklog_CellContentClick;
            // 
            // cmsPerson
            // 
            cmsPerson.Name = "contextMenuStrip1";
            cmsPerson.Size = new Size(61, 4);
            // 
            // cms
            // 
            cms.Name = "contextMenuStrip2";
            cms.Size = new Size(61, 4);
            // 
            // frmWorklog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 476);
            Controls.Add(tlpHeader);
            Name = "frmWorklog";
            ShowIcon = false;
            Text = "Current Status";
            Load += frmWorklog_Load;
            tlpHeader.ResumeLayout(false);
            tlpBtn.ResumeLayout(false);
            tlpBtn.PerformLayout();
            tlpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvWorklog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpHeader;
        private Panel pnlHeader;
        private TableLayoutPanel tlpGrid;
        private DataGridView dgvWorklog;
        private ContextMenuStrip cmsPerson;
        private ContextMenuStrip cms;
        private TableLayoutPanel tlpBtn;
        private Button btnSearch;
        private Label label3;
        private Label label2;
        private Label lblPerson;
        private Label lbl;
        private Label lblStatus;
        private PresentationControls.CheckBoxComboBox checkBoxComboBox5;
        private PresentationControls.CheckBoxComboBox checkBoxComboBox2;
        private PresentationControls.CheckBoxComboBox checkBoxComboBox3;
        private PresentationControls.CheckBoxComboBox checkBoxComboBox1;
        private PresentationControls.CheckBoxComboBox checkBoxComboBox4;
    }
}