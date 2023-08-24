namespace OswalMRA.Layout
{
    partial class frmFullLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFullLayout));
            outerBaseGrid = new TableLayoutPanel();
            baseGrid = new TableLayoutPanel();
            sidebarPanel = new Panel();
            sidebarGrid = new TableLayoutPanel();
            btnHome = new Button();
            btnMould = new Button();
            btnUser = new Button();
            btnPassword = new Button();
            btnReset = new Button();
            btnWorkLog = new Button();
            btnInventory = new Button();
            childformPanel = new Panel();
            statusGrid = new TableLayoutPanel();
            statusDate = new Label();
            outerBaseGrid.SuspendLayout();
            baseGrid.SuspendLayout();
            sidebarPanel.SuspendLayout();
            sidebarGrid.SuspendLayout();
            statusGrid.SuspendLayout();
            SuspendLayout();
            // 
            // outerBaseGrid
            // 
            outerBaseGrid.ColumnCount = 1;
            outerBaseGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            outerBaseGrid.Controls.Add(baseGrid, 0, 0);
            outerBaseGrid.Controls.Add(statusGrid, 0, 1);
            outerBaseGrid.Dock = DockStyle.Fill;
            outerBaseGrid.Location = new Point(0, 0);
            outerBaseGrid.Margin = new Padding(0);
            outerBaseGrid.Name = "outerBaseGrid";
            outerBaseGrid.RowCount = 2;
            outerBaseGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 97.93814F));
            outerBaseGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 2.061856F));
            outerBaseGrid.Size = new Size(1199, 591);
            outerBaseGrid.TabIndex = 0;
            // 
            // baseGrid
            // 
            baseGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            baseGrid.ColumnCount = 2;
            baseGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            baseGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            baseGrid.Controls.Add(sidebarPanel, 0, 0);
            baseGrid.Controls.Add(childformPanel, 1, 0);
            baseGrid.Location = new Point(0, 0);
            baseGrid.Margin = new Padding(0);
            baseGrid.Name = "baseGrid";
            baseGrid.RowCount = 1;
            baseGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            baseGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 579F));
            baseGrid.Size = new Size(1199, 578);
            baseGrid.TabIndex = 0;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(41, 128, 185);
            sidebarPanel.Controls.Add(sidebarGrid);
            sidebarPanel.Dock = DockStyle.Fill;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(179, 578);
            sidebarPanel.TabIndex = 0;
            // 
            // sidebarGrid
            // 
            sidebarGrid.ColumnCount = 1;
            sidebarGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sidebarGrid.Controls.Add(btnHome, 0, 1);
            sidebarGrid.Controls.Add(btnMould, 0, 2);
            sidebarGrid.Controls.Add(btnUser, 0, 3);
            sidebarGrid.Controls.Add(btnPassword, 0, 4);
            sidebarGrid.Controls.Add(btnReset, 0, 5);
            sidebarGrid.Controls.Add(btnWorkLog, 0, 6);
            sidebarGrid.Controls.Add(btnInventory, 0, 7);
            sidebarGrid.Dock = DockStyle.Fill;
            sidebarGrid.Location = new Point(0, 0);
            sidebarGrid.Margin = new Padding(3, 2, 3, 2);
            sidebarGrid.Name = "sidebarGrid";
            sidebarGrid.RowCount = 9;
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            sidebarGrid.Size = new Size(179, 578);
            sidebarGrid.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Fill;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = Properties.Resources.icons8_home_30;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(5, 132);
            btnHome.Margin = new Padding(5);
            btnHome.MaximumSize = new Size(239, 56);
            btnHome.MinimumSize = new Size(166, 39);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(13, 0, 0, 0);
            btnHome.Size = new Size(169, 39);
            btnHome.TabIndex = 0;
            btnHome.Text = "   &Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnMould
            // 
            btnMould.Dock = DockStyle.Fill;
            btnMould.FlatAppearance.BorderSize = 0;
            btnMould.FlatStyle = FlatStyle.Flat;
            btnMould.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnMould.ForeColor = Color.White;
            btnMould.Image = Properties.Resources.icons8_machine_30;
            btnMould.ImageAlign = ContentAlignment.MiddleLeft;
            btnMould.Location = new Point(5, 178);
            btnMould.Margin = new Padding(5);
            btnMould.MaximumSize = new Size(239, 56);
            btnMould.MinimumSize = new Size(166, 39);
            btnMould.Name = "btnMould";
            btnMould.Padding = new Padding(13, 0, 0, 0);
            btnMould.Size = new Size(169, 39);
            btnMould.TabIndex = 1;
            btnMould.Text = "   &Mould";
            btnMould.TextAlign = ContentAlignment.MiddleLeft;
            btnMould.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMould.UseVisualStyleBackColor = false;
            btnMould.Click += btnMould_Click;
            // 
            // btnUser
            // 
            btnUser.Dock = DockStyle.Fill;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.ForeColor = Color.White;
            btnUser.Image = Properties.Resources.icons8_admin_30;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(5, 224);
            btnUser.Margin = new Padding(5);
            btnUser.MaximumSize = new Size(239, 56);
            btnUser.MinimumSize = new Size(166, 39);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(13, 0, 0, 0);
            btnUser.Size = new Size(169, 39);
            btnUser.TabIndex = 2;
            btnUser.Text = "   &User";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // btnPassword
            // 
            btnPassword.Dock = DockStyle.Fill;
            btnPassword.FlatAppearance.BorderSize = 0;
            btnPassword.FlatStyle = FlatStyle.Flat;
            btnPassword.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnPassword.ForeColor = Color.White;
            btnPassword.Image = Properties.Resources.icons8_password_30;
            btnPassword.ImageAlign = ContentAlignment.MiddleLeft;
            btnPassword.Location = new Point(5, 270);
            btnPassword.Margin = new Padding(5);
            btnPassword.MaximumSize = new Size(239, 56);
            btnPassword.MinimumSize = new Size(166, 39);
            btnPassword.Name = "btnPassword";
            btnPassword.Padding = new Padding(13, 0, 0, 0);
            btnPassword.Size = new Size(169, 39);
            btnPassword.TabIndex = 3;
            btnPassword.Text = "   &Password";
            btnPassword.TextAlign = ContentAlignment.MiddleLeft;
            btnPassword.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPassword.UseVisualStyleBackColor = false;
            btnPassword.Click += btnPassword_Click;
            // 
            // btnReset
            // 
            btnReset.Dock = DockStyle.Fill;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Image = Properties.Resources.icons8_reset_30;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(5, 316);
            btnReset.Margin = new Padding(5);
            btnReset.MaximumSize = new Size(239, 56);
            btnReset.MinimumSize = new Size(166, 39);
            btnReset.Name = "btnReset";
            btnReset.Padding = new Padding(13, 0, 0, 0);
            btnReset.Size = new Size(169, 39);
            btnReset.TabIndex = 4;
            btnReset.Text = "   &Reset ";
            btnReset.TextAlign = ContentAlignment.MiddleLeft;
            btnReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnWorkLog
            // 
            btnWorkLog.Dock = DockStyle.Fill;
            btnWorkLog.FlatAppearance.BorderSize = 0;
            btnWorkLog.FlatStyle = FlatStyle.Flat;
            btnWorkLog.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnWorkLog.ForeColor = Color.White;
            btnWorkLog.Image = Properties.Resources.icons8_log_30;
            btnWorkLog.ImageAlign = ContentAlignment.MiddleLeft;
            btnWorkLog.Location = new Point(5, 362);
            btnWorkLog.Margin = new Padding(5);
            btnWorkLog.MaximumSize = new Size(239, 56);
            btnWorkLog.MinimumSize = new Size(166, 39);
            btnWorkLog.Name = "btnWorkLog";
            btnWorkLog.Padding = new Padding(13, 0, 0, 0);
            btnWorkLog.Size = new Size(169, 39);
            btnWorkLog.TabIndex = 5;
            btnWorkLog.Text = "   &Work Log";
            btnWorkLog.TextAlign = ContentAlignment.MiddleLeft;
            btnWorkLog.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnWorkLog.UseVisualStyleBackColor = false;
            btnWorkLog.Click += btnWorkLog_Click;
            // 
            // btnInventory
            // 
            btnInventory.Dock = DockStyle.Fill;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnInventory.ForeColor = Color.White;
            btnInventory.Image = Properties.Resources.icons8_inventory_30;
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(5, 408);
            btnInventory.Margin = new Padding(5);
            btnInventory.MaximumSize = new Size(239, 56);
            btnInventory.MinimumSize = new Size(166, 39);
            btnInventory.Name = "btnInventory";
            btnInventory.Padding = new Padding(13, 0, 0, 0);
            btnInventory.Size = new Size(169, 39);
            btnInventory.TabIndex = 6;
            btnInventory.Text = "   &Inventory";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // childformPanel
            // 
            childformPanel.BackColor = Color.White;
            childformPanel.Dock = DockStyle.Fill;
            childformPanel.Location = new Point(179, 0);
            childformPanel.Margin = new Padding(0);
            childformPanel.Name = "childformPanel";
            childformPanel.Size = new Size(1020, 578);
            childformPanel.TabIndex = 0;
            // 
            // statusGrid
            // 
            statusGrid.ColumnCount = 2;
            statusGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            statusGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            statusGrid.Controls.Add(statusDate, 1, 0);
            statusGrid.Dock = DockStyle.Fill;
            statusGrid.Location = new Point(3, 580);
            statusGrid.Margin = new Padding(3, 2, 3, 2);
            statusGrid.Name = "statusGrid";
            statusGrid.RowCount = 1;
            statusGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            statusGrid.Size = new Size(1193, 9);
            statusGrid.TabIndex = 1;
            // 
            // statusDate
            // 
            statusDate.AutoSize = true;
            statusDate.Dock = DockStyle.Fill;
            statusDate.Location = new Point(957, 0);
            statusDate.Name = "statusDate";
            statusDate.Size = new Size(233, 9);
            statusDate.TabIndex = 0;
            statusDate.Text = "Indian Standard Time";
            statusDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmFullLayout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 591);
            Controls.Add(outerBaseGrid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1682, 861);
            MinimumSize = new Size(282, 387);
            Name = "frmFullLayout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Oswal MRA";
            Load += frmFullLayout_Load;
            KeyDown += frmFullLayout_KeyDown;
            outerBaseGrid.ResumeLayout(false);
            baseGrid.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            sidebarGrid.ResumeLayout(false);
            statusGrid.ResumeLayout(false);
            statusGrid.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel outerBaseGrid;
        private TableLayoutPanel baseGrid;
        private Panel sidebarPanel;
        private TableLayoutPanel sidebarGrid;
        private Button btnHome;
        private Button btnMould;
        private Button btnUser;
        private Button btnPassword;
        private Button btnReset;
        private Button btnWorkLog;
        private Button btnInventory;
        private Panel childformPanel;
        private TableLayoutPanel statusGrid;
        private Label statusDate;
    }
}