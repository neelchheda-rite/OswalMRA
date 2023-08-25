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
            this.components = new System.ComponentModel.Container();
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties2 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties3 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties4 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties5 = new PresentationControls.CheckBoxProperties();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tlpBtn = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.checkBoxComboBox5 = new PresentationControls.CheckBoxComboBox();
            this.checkBoxComboBox2 = new PresentationControls.CheckBoxComboBox();
            this.checkBoxComboBox3 = new PresentationControls.CheckBoxComboBox();
            this.checkBoxComboBox1 = new PresentationControls.CheckBoxComboBox();
            this.checkBoxComboBox4 = new PresentationControls.CheckBoxComboBox();
            this.tlpGrid = new System.Windows.Forms.TableLayoutPanel();
            this.dgvWorklog = new System.Windows.Forms.DataGridView();
            this.cmsPerson = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlpHeader.SuspendLayout();
            this.tlpBtn.SuspendLayout();
            this.tlpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorklog)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 1;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpHeader.Controls.Add(this.tlpBtn, 0, 1);
            this.tlpHeader.Controls.Add(this.tlpGrid, 0, 2);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 3;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81F));
            this.tlpHeader.Size = new System.Drawing.Size(998, 603);
            this.tlpHeader.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.MaximumSize = new System.Drawing.Size(0, 60);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(998, 42);
            this.pnlHeader.TabIndex = 0;
            // 
            // tlpBtn
            // 
            this.tlpBtn.BackColor = System.Drawing.Color.White;
            this.tlpBtn.ColumnCount = 8;
            this.tlpBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.182909F));
            this.tlpBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.476792F));
            this.tlpBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.21323F));
            this.tlpBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.517705F));
            this.tlpBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.3698F));
            this.tlpBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.864676F));
            this.tlpBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.19198F));
            this.tlpBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.182908F));
            this.tlpBtn.Controls.Add(this.btnSearch, 6, 2);
            this.tlpBtn.Controls.Add(this.label3, 5, 1);
            this.tlpBtn.Controls.Add(this.label2, 3, 1);
            this.tlpBtn.Controls.Add(this.lblPerson, 3, 2);
            this.tlpBtn.Controls.Add(this.lbl, 1, 1);
            this.tlpBtn.Controls.Add(this.lblStatus, 1, 2);
            this.tlpBtn.Controls.Add(this.checkBoxComboBox5, 2, 1);
            this.tlpBtn.Controls.Add(this.checkBoxComboBox2, 4, 1);
            this.tlpBtn.Controls.Add(this.checkBoxComboBox3, 6, 1);
            this.tlpBtn.Controls.Add(this.checkBoxComboBox1, 2, 2);
            this.tlpBtn.Controls.Add(this.checkBoxComboBox4, 4, 2);
            this.tlpBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBtn.Location = new System.Drawing.Point(0, 42);
            this.tlpBtn.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBtn.Name = "tlpBtn";
            this.tlpBtn.RowCount = 3;
            this.tlpBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.161804F));
            this.tlpBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.26109F));
            this.tlpBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.57711F));
            this.tlpBtn.Size = new System.Drawing.Size(998, 72);
            this.tlpBtn.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(782, 40);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(161, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(704, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MaximumSize = new System.Drawing.Size(0, 29);
            this.label3.MinimumSize = new System.Drawing.Size(0, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "User";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(366, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.MaximumSize = new System.Drawing.Size(0, 29);
            this.label2.MinimumSize = new System.Drawing.Size(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPerson.Location = new System.Drawing.Point(366, 40);
            this.lblPerson.Margin = new System.Windows.Forms.Padding(0);
            this.lblPerson.MaximumSize = new System.Drawing.Size(0, 29);
            this.lblPerson.MinimumSize = new System.Drawing.Size(0, 29);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(75, 29);
            this.lblPerson.TabIndex = 15;
            this.lblPerson.Text = "Column";
            this.lblPerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(51, 5);
            this.lbl.Margin = new System.Windows.Forms.Padding(0);
            this.lbl.MaximumSize = new System.Drawing.Size(0, 29);
            this.lbl.MinimumSize = new System.Drawing.Size(0, 29);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(64, 29);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Mould";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(51, 40);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatus.MaximumSize = new System.Drawing.Size(0, 29);
            this.lblStatus.MinimumSize = new System.Drawing.Size(0, 29);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 29);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Row";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxComboBox5
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxComboBox5.CheckBoxProperties = checkBoxProperties1;
            this.checkBoxComboBox5.DisplayMemberSingleItem = "";
            this.checkBoxComboBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxComboBox5.FormattingEnabled = true;
            this.checkBoxComboBox5.Location = new System.Drawing.Point(115, 5);
            this.checkBoxComboBox5.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxComboBox5.Name = "checkBoxComboBox5";
            this.checkBoxComboBox5.Size = new System.Drawing.Size(251, 27);
            this.checkBoxComboBox5.TabIndex = 20;
            // 
            // checkBoxComboBox2
            // 
            checkBoxProperties2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxComboBox2.CheckBoxProperties = checkBoxProperties2;
            this.checkBoxComboBox2.DisplayMemberSingleItem = "";
            this.checkBoxComboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxComboBox2.FormattingEnabled = true;
            this.checkBoxComboBox2.Location = new System.Drawing.Point(441, 5);
            this.checkBoxComboBox2.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxComboBox2.Name = "checkBoxComboBox2";
            this.checkBoxComboBox2.Size = new System.Drawing.Size(263, 27);
            this.checkBoxComboBox2.TabIndex = 17;
            // 
            // checkBoxComboBox3
            // 
            checkBoxProperties3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxComboBox3.CheckBoxProperties = checkBoxProperties3;
            this.checkBoxComboBox3.DisplayMemberSingleItem = "";
            this.checkBoxComboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxComboBox3.FormattingEnabled = true;
            this.checkBoxComboBox3.Location = new System.Drawing.Point(782, 5);
            this.checkBoxComboBox3.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxComboBox3.Name = "checkBoxComboBox3";
            this.checkBoxComboBox3.Size = new System.Drawing.Size(161, 27);
            this.checkBoxComboBox3.TabIndex = 18;
            // 
            // checkBoxComboBox1
            // 
            checkBoxProperties4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxComboBox1.CheckBoxProperties = checkBoxProperties4;
            this.checkBoxComboBox1.DisplayMemberSingleItem = "";
            this.checkBoxComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxComboBox1.FormattingEnabled = true;
            this.checkBoxComboBox1.Location = new System.Drawing.Point(115, 40);
            this.checkBoxComboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxComboBox1.Name = "checkBoxComboBox1";
            this.checkBoxComboBox1.Size = new System.Drawing.Size(251, 27);
            this.checkBoxComboBox1.TabIndex = 16;
            // 
            // checkBoxComboBox4
            // 
            checkBoxProperties5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxComboBox4.CheckBoxProperties = checkBoxProperties5;
            this.checkBoxComboBox4.DisplayMemberSingleItem = "";
            this.checkBoxComboBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxComboBox4.FormattingEnabled = true;
            this.checkBoxComboBox4.Location = new System.Drawing.Point(441, 40);
            this.checkBoxComboBox4.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxComboBox4.Name = "checkBoxComboBox4";
            this.checkBoxComboBox4.Size = new System.Drawing.Size(263, 27);
            this.checkBoxComboBox4.TabIndex = 19;
            // 
            // tlpGrid
            // 
            this.tlpGrid.BackColor = System.Drawing.Color.White;
            this.tlpGrid.ColumnCount = 1;
            this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGrid.Controls.Add(this.dgvWorklog, 0, 0);
            this.tlpGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGrid.Location = new System.Drawing.Point(0, 114);
            this.tlpGrid.Margin = new System.Windows.Forms.Padding(0);
            this.tlpGrid.Name = "tlpGrid";
            this.tlpGrid.RowCount = 2;
            this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpGrid.Size = new System.Drawing.Size(998, 489);
            this.tlpGrid.TabIndex = 2;
            // 
            // dgvWorklog
            // 
            this.dgvWorklog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorklog.BackgroundColor = System.Drawing.Color.White;
            this.dgvWorklog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorklog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorklog.Location = new System.Drawing.Point(0, 0);
            this.dgvWorklog.Margin = new System.Windows.Forms.Padding(0);
            this.dgvWorklog.Name = "dgvWorklog";
            this.dgvWorklog.RowHeadersVisible = false;
            this.dgvWorklog.RowTemplate.Height = 25;
            this.dgvWorklog.Size = new System.Drawing.Size(998, 464);
            this.dgvWorklog.TabIndex = 0;
            // 
            // cmsPerson
            // 
            this.cmsPerson.Name = "contextMenuStrip1";
            this.cmsPerson.Size = new System.Drawing.Size(61, 4);
            // 
            // cms
            // 
            this.cms.Name = "contextMenuStrip2";
            this.cms.Size = new System.Drawing.Size(61, 4);
            // 
            // frmWorklog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 603);
            this.Controls.Add(this.tlpHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmWorklog";
            this.ShowIcon = false;
            this.Text = "Current Status";
            this.tlpHeader.ResumeLayout(false);
            this.tlpBtn.ResumeLayout(false);
            this.tlpBtn.PerformLayout();
            this.tlpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorklog)).EndInit();
            this.ResumeLayout(false);

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