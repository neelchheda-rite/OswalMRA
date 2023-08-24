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
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.toolstripMoulId = new System.Windows.Forms.ToolStrip();
            this.tspDropDownBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.CmbPerson = new System.Windows.Forms.ComboBox();
            this.lblPerson = new System.Windows.Forms.Label();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.tlpBtn = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tlpHeader.SuspendLayout();
            this.toolstripMoulId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.tlpBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpHeader
            // 
            this.tlpHeader.BackColor = System.Drawing.Color.White;
            this.tlpHeader.ColumnCount = 8;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.30864F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.185185F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.18005F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.24817F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.777778F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.80247F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.81481F));
            this.tlpHeader.Controls.Add(this.lblFrom, 0, 0);
            this.tlpHeader.Controls.Add(this.lblTo, 2, 0);
            this.tlpHeader.Controls.Add(this.dtpFrom, 1, 0);
            this.tlpHeader.Controls.Add(this.dtpTo, 3, 0);
            this.tlpHeader.Controls.Add(this.toolstripMoulId, 4, 0);
            this.tlpHeader.Controls.Add(this.CmbPerson, 4, 0);
            this.tlpHeader.Controls.Add(this.lblPerson, 5, 0);
            this.tlpHeader.Controls.Add(this.cmbTo, 6, 0);
            this.tlpHeader.Controls.Add(this.btnSearch, 7, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeader.Location = new System.Drawing.Point(0, 44);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(1);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(998, 35);
            this.tlpHeader.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFrom.ForeColor = System.Drawing.Color.Black;
            this.lblFrom.Location = new System.Drawing.Point(0, 0);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(0);
            this.lblFrom.MaximumSize = new System.Drawing.Size(0, 29);
            this.lblFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(66, 29);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTo.ForeColor = System.Drawing.Color.Black;
            this.lblTo.Location = new System.Drawing.Point(218, 0);
            this.lblTo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTo.MaximumSize = new System.Drawing.Size(0, 29);
            this.lblTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(51, 29);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "To";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFrom.Location = new System.Drawing.Point(66, 0);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(0);
            this.dtpFrom.MaximumSize = new System.Drawing.Size(114, 23);
            this.dtpFrom.MinimumSize = new System.Drawing.Size(137, 23);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(137, 23);
            this.dtpFrom.TabIndex = 5;
            // 
            // dtpTo
            // 
            this.dtpTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTo.Location = new System.Drawing.Point(269, 0);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(0);
            this.dtpTo.MaximumSize = new System.Drawing.Size(137, 23);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(137, 23);
            this.dtpTo.TabIndex = 6;
            // 
            // toolstripMoulId
            // 
            this.toolstripMoulId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolstripMoulId.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspDropDownBtn});
            this.toolstripMoulId.Location = new System.Drawing.Point(448, 0);
            this.toolstripMoulId.Name = "toolstripMoulId";
            this.toolstripMoulId.Size = new System.Drawing.Size(174, 32);
            this.toolstripMoulId.TabIndex = 9;
            this.toolstripMoulId.Text = "Mould Id";
            this.toolstripMoulId.Visible = false;
            // 
            // tspDropDownBtn
            // 
            this.tspDropDownBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspDropDownBtn.Image = ((System.Drawing.Image)(resources.GetObject("tspDropDownBtn.Image")));
            this.tspDropDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspDropDownBtn.Name = "tspDropDownBtn";
            this.tspDropDownBtn.Size = new System.Drawing.Size(29, 29);
            this.tspDropDownBtn.Text = "Mould Id";
            // 
            // CmbPerson
            // 
            this.CmbPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbPerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CmbPerson.FormattingEnabled = true;
            this.CmbPerson.Location = new System.Drawing.Point(433, 4);
            this.CmbPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbPerson.Name = "CmbPerson";
            this.CmbPerson.Size = new System.Drawing.Size(176, 25);
            this.CmbPerson.TabIndex = 10;
            this.CmbPerson.Text = "Mould ID";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPerson.ForeColor = System.Drawing.Color.Black;
            this.lblPerson.Location = new System.Drawing.Point(612, 0);
            this.lblPerson.Margin = new System.Windows.Forms.Padding(0);
            this.lblPerson.MaximumSize = new System.Drawing.Size(0, 29);
            this.lblPerson.MinimumSize = new System.Drawing.Size(0, 29);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(77, 29);
            this.lblPerson.TabIndex = 2;
            this.lblPerson.Text = "Person";
            this.lblPerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTo
            // 
            this.cmbTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(689, 0);
            this.cmbTo.Margin = new System.Windows.Forms.Padding(0);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(157, 27);
            this.cmbTo.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(846, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.Location = new System.Drawing.Point(0, 0);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(0);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowTemplate.Height = 25;
            this.dgvInventory.Size = new System.Drawing.Size(998, 524);
            this.dgvInventory.TabIndex = 0;
            // 
            // tlpBtn
            // 
            this.tlpBtn.ColumnCount = 1;
            this.tlpBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBtn.Controls.Add(this.dgvInventory, 0, 0);
            this.tlpBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBtn.Location = new System.Drawing.Point(0, 79);
            this.tlpBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpBtn.Name = "tlpBtn";
            this.tlpBtn.RowCount = 1;
            this.tlpBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBtn.Size = new System.Drawing.Size(998, 524);
            this.tlpBtn.TabIndex = 2;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.MaximumSize = new System.Drawing.Size(0, 44);
            this.pnlHeader.MinimumSize = new System.Drawing.Size(0, 44);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(998, 44);
            this.pnlHeader.TabIndex = 0;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 603);
            this.Controls.Add(this.tlpBtn);
            this.Controls.Add(this.tlpHeader);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInventory";
            this.ShowIcon = false;
            this.Text = "Mould Details";
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.toolstripMoulId.ResumeLayout(false);
            this.toolstripMoulId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.tlpBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private ComboBox CmbPerson;
        private Panel pnlHeader;
    }
}