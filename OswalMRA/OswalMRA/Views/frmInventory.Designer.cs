namespace OswalMRA
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            pnlHeader = new Panel();
            tlpHeader = new TableLayoutPanel();
            lblFrom = new Label();
            lblTo = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            toolstripMoulId = new ToolStrip();
            tspDropDownBtn = new ToolStripDropDownButton();
            lblPerson = new Label();
            cmbTo = new ComboBox();
            btnSearch = new Button();
            checkBoxComboBox5 = new PresentationControls.CheckBoxComboBox();
            dgvInventory = new DataGridView();
            tlpBtn = new TableLayoutPanel();
            tlpHeader.SuspendLayout();
            toolstripMoulId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            tlpBtn.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.MaximumSize = new Size(0, 35);
            pnlHeader.MinimumSize = new Size(0, 35);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1370, 35);
            pnlHeader.TabIndex = 0;
            // 
            // tlpHeader
            // 
            tlpHeader.BackColor = Color.White;
            tlpHeader.ColumnCount = 8;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.666667F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.30864F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.185185F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.18005F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.24817F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.777778F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.80247F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.81481F));
            tlpHeader.Controls.Add(lblFrom, 0, 0);
            tlpHeader.Controls.Add(lblTo, 2, 0);
            tlpHeader.Controls.Add(dtpFrom, 1, 0);
            tlpHeader.Controls.Add(dtpTo, 3, 0);
            tlpHeader.Controls.Add(toolstripMoulId, 4, 0);
            tlpHeader.Controls.Add(lblPerson, 5, 0);
            tlpHeader.Controls.Add(cmbTo, 6, 0);
            tlpHeader.Controls.Add(btnSearch, 7, 0);
            tlpHeader.Controls.Add(checkBoxComboBox5, 4, 0);
            tlpHeader.Dock = DockStyle.Top;
            tlpHeader.Location = new Point(0, 35);
            tlpHeader.Margin = new Padding(1);
            tlpHeader.Name = "tlpHeader";
            tlpHeader.RowCount = 1;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeader.Size = new Size(1370, 28);
            tlpHeader.TabIndex = 1;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Dock = DockStyle.Fill;
            lblFrom.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFrom.ForeColor = Color.Black;
            lblFrom.Location = new Point(0, 0);
            lblFrom.Margin = new Padding(0);
            lblFrom.MaximumSize = new Size(0, 23);
            lblFrom.MinimumSize = new Size(0, 23);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(91, 23);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "From";
            lblFrom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Dock = DockStyle.Fill;
            lblTo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTo.ForeColor = Color.Black;
            lblTo.Location = new Point(300, 0);
            lblTo.Margin = new Padding(0);
            lblTo.MaximumSize = new Size(0, 23);
            lblTo.MinimumSize = new Size(0, 23);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(71, 23);
            lblTo.TabIndex = 1;
            lblTo.Text = "To";
            lblTo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpFrom
            // 
            dtpFrom.Dock = DockStyle.Fill;
            dtpFrom.Location = new Point(91, 0);
            dtpFrom.Margin = new Padding(0);
            dtpFrom.MaximumSize = new Size(100, 23);
            dtpFrom.MinimumSize = new Size(120, 23);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(120, 23);
            dtpFrom.TabIndex = 5;
            // 
            // dtpTo
            // 
            dtpTo.Dock = DockStyle.Fill;
            dtpTo.Location = new Point(371, 0);
            dtpTo.Margin = new Padding(0);
            dtpTo.MaximumSize = new Size(120, 23);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(120, 23);
            dtpTo.TabIndex = 6;
            // 
            // toolstripMoulId
            // 
            toolstripMoulId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolstripMoulId.Items.AddRange(new ToolStripItem[] { tspDropDownBtn });
            toolstripMoulId.Location = new Point(392, 0);
            toolstripMoulId.Name = "toolstripMoulId";
            toolstripMoulId.Size = new Size(152, 25);
            toolstripMoulId.TabIndex = 9;
            toolstripMoulId.Text = "Mould Id";
            toolstripMoulId.Visible = false;
            // 
            // tspDropDownBtn
            // 
            tspDropDownBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tspDropDownBtn.Image = (Image)resources.GetObject("tspDropDownBtn.Image");
            tspDropDownBtn.ImageTransparentColor = Color.Magenta;
            tspDropDownBtn.Name = "tspDropDownBtn";
            tspDropDownBtn.Size = new Size(29, 22);
            tspDropDownBtn.Text = "Mould Id";
            // 
            // lblPerson
            // 
            lblPerson.AutoSize = true;
            lblPerson.Dock = DockStyle.Fill;
            lblPerson.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPerson.ForeColor = Color.Black;
            lblPerson.Location = new Point(842, 0);
            lblPerson.Margin = new Padding(0);
            lblPerson.MaximumSize = new Size(0, 23);
            lblPerson.MinimumSize = new Size(0, 23);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(106, 23);
            lblPerson.TabIndex = 2;
            lblPerson.Text = "Person";
            lblPerson.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbTo
            // 
            cmbTo.Dock = DockStyle.Fill;
            cmbTo.FormattingEnabled = true;
            cmbTo.Location = new Point(948, 0);
            cmbTo.Margin = new Padding(0);
            cmbTo.Name = "cmbTo";
            cmbTo.Size = new Size(216, 23);
            cmbTo.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(41, 128, 185);
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(1164, 0);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(206, 28);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // checkBoxComboBox5
            // 
            checkBoxProperties1.ForeColor = SystemColors.ControlText;
            checkBoxComboBox5.CheckBoxProperties = checkBoxProperties1;
            checkBoxComboBox5.DisplayMemberSingleItem = "";
            checkBoxComboBox5.Dock = DockStyle.Fill;
            checkBoxComboBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxComboBox5.FormattingEnabled = true;
            checkBoxComboBox5.Location = new Point(592, 0);
            checkBoxComboBox5.Margin = new Padding(0);
            checkBoxComboBox5.Name = "checkBoxComboBox5";
            checkBoxComboBox5.Size = new Size(250, 25);
            checkBoxComboBox5.TabIndex = 21;
            checkBoxComboBox5.Text = "Mould ID";
            // 
            // dgvInventory
            // 
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.Location = new Point(0, 0);
            dgvInventory.Margin = new Padding(0);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowTemplate.Height = 25;
            dgvInventory.Size = new Size(1370, 686);
            dgvInventory.TabIndex = 0;
            dgvInventory.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tlpBtn
            // 
            tlpBtn.ColumnCount = 1;
            tlpBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBtn.Controls.Add(dgvInventory, 0, 0);
            tlpBtn.Dock = DockStyle.Fill;
            tlpBtn.Location = new Point(0, 63);
            tlpBtn.Name = "tlpBtn";
            tlpBtn.RowCount = 1;
            tlpBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBtn.Size = new Size(1370, 686);
            tlpBtn.TabIndex = 2;
            tlpBtn.Paint += tableLayoutPanel2_Paint;
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(tlpBtn);
            Controls.Add(tlpHeader);
            Controls.Add(pnlHeader);
            ForeColor = Color.White;
            MinimumSize = new Size(903, 487);
            Name = "frmInventory";
            ShowIcon = false;
            Text = "Mould Details";
            Load += frmInventory_Load;
            tlpHeader.ResumeLayout(false);
            tlpHeader.PerformLayout();
            toolstripMoulId.ResumeLayout(false);
            toolstripMoulId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            tlpBtn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private TableLayoutPanel tlpHeader;
        private Label lblFrom;
        private Label lblTo;
        private Label lblPerson;
        private Button btnSearch;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private ComboBox cmbTo;
        private DataGridView dgvInventory;
        private TableLayoutPanel tlpBtn;
        private ToolStrip toolstripMoulId;
        private ToolStripDropDownButton tspDropDownBtn;
        private PresentationControls.CheckBoxComboBox checkBoxComboBox5;
    }
}