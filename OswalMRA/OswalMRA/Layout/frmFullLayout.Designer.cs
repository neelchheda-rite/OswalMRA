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
<<<<<<< Updated upstream
            this.outerBaseGrid = new System.Windows.Forms.TableLayoutPanel();
            this.baseGrid = new System.Windows.Forms.TableLayoutPanel();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.sidebarGrid = new System.Windows.Forms.TableLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMould = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnWorkLog = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.childformPanel = new System.Windows.Forms.Panel();
            this.statusGrid = new System.Windows.Forms.TableLayoutPanel();
            this.statusDate = new System.Windows.Forms.Label();
            this.outerBaseGrid.SuspendLayout();
            this.baseGrid.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.sidebarGrid.SuspendLayout();
            this.statusGrid.SuspendLayout();
            this.SuspendLayout();
=======
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
            btnDashboard = new Button();
            logoGrid = new TableLayoutPanel();
            logo = new PictureBox();
            sidebarShortcutGrid = new TableLayoutPanel();
            sidebarShortcutLabel = new Label();
            childFormGrid = new TableLayoutPanel();
            childformPanel = new Panel();
            headerPanel = new Panel();
            headerGrid = new TableLayoutPanel();
            headerLabel = new Label();
            statusGrid = new TableLayoutPanel();
            statusDate = new Label();
            outerBaseGrid.SuspendLayout();
            baseGrid.SuspendLayout();
            sidebarPanel.SuspendLayout();
            sidebarGrid.SuspendLayout();
            logoGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            sidebarShortcutGrid.SuspendLayout();
            childFormGrid.SuspendLayout();
            headerPanel.SuspendLayout();
            headerGrid.SuspendLayout();
            statusGrid.SuspendLayout();
            SuspendLayout();
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.baseGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseGrid.ColumnCount = 2;
            this.baseGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.baseGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.baseGrid.Controls.Add(this.sidebarPanel, 0, 0);
            this.baseGrid.Controls.Add(this.childformPanel, 1, 0);
            this.baseGrid.Location = new System.Drawing.Point(0, 0);
            this.baseGrid.Margin = new System.Windows.Forms.Padding(0);
            this.baseGrid.Name = "baseGrid";
            this.baseGrid.RowCount = 1;
            this.baseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.baseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 732F));
            this.baseGrid.Size = new System.Drawing.Size(1370, 733);
            this.baseGrid.TabIndex = 0;
=======
            baseGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            baseGrid.ColumnCount = 2;
            baseGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            baseGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            baseGrid.Controls.Add(sidebarPanel, 0, 0);
            baseGrid.Controls.Add(childFormGrid, 1, 0);
            baseGrid.Location = new Point(0, 0);
            baseGrid.Margin = new Padding(0);
            baseGrid.Name = "baseGrid";
            baseGrid.RowCount = 1;
            baseGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            baseGrid.Size = new Size(1199, 578);
            baseGrid.TabIndex = 0;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.sidebarGrid.ColumnCount = 1;
            this.sidebarGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sidebarGrid.Controls.Add(this.btnHome, 0, 1);
            this.sidebarGrid.Controls.Add(this.btnMould, 0, 2);
            this.sidebarGrid.Controls.Add(this.btnUser, 0, 3);
            this.sidebarGrid.Controls.Add(this.btnPassword, 0, 4);
            this.sidebarGrid.Controls.Add(this.btnReset, 0, 5);
            this.sidebarGrid.Controls.Add(this.btnWorkLog, 0, 6);
            this.sidebarGrid.Controls.Add(this.btnInventory, 0, 7);
            this.sidebarGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebarGrid.Location = new System.Drawing.Point(0, 0);
            this.sidebarGrid.Name = "sidebarGrid";
            this.sidebarGrid.RowCount = 9;
            this.sidebarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.sidebarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.sidebarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.sidebarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.sidebarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.sidebarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.sidebarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.sidebarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.sidebarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.sidebarGrid.Size = new System.Drawing.Size(205, 733);
            this.sidebarGrid.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::OswalMRA.Properties.Resources.icons8_home_30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(6, 167);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6);
            this.btnHome.MaximumSize = new System.Drawing.Size(273, 71);
            this.btnHome.MinimumSize = new System.Drawing.Size(190, 49);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(193, 49);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "   &Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnMould
            // 
            this.btnMould.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMould.FlatAppearance.BorderSize = 0;
            this.btnMould.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMould.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMould.ForeColor = System.Drawing.Color.White;
            this.btnMould.Image = global::OswalMRA.Properties.Resources.icons8_machine_30;
            this.btnMould.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMould.Location = new System.Drawing.Point(6, 225);
            this.btnMould.Margin = new System.Windows.Forms.Padding(6);
            this.btnMould.MaximumSize = new System.Drawing.Size(273, 71);
            this.btnMould.MinimumSize = new System.Drawing.Size(190, 49);
            this.btnMould.Name = "btnMould";
            this.btnMould.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMould.Size = new System.Drawing.Size(193, 49);
            this.btnMould.TabIndex = 1;
            this.btnMould.Text = "   &Mould";
            this.btnMould.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMould.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMould.UseVisualStyleBackColor = false;
            this.btnMould.Click += new System.EventHandler(this.btnMould_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::OswalMRA.Properties.Resources.icons8_admin_30;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(6, 283);
            this.btnUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnUser.MaximumSize = new System.Drawing.Size(273, 71);
            this.btnUser.MinimumSize = new System.Drawing.Size(190, 49);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(193, 49);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "   &User";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPassword.ForeColor = System.Drawing.Color.White;
            this.btnPassword.Image = global::OswalMRA.Properties.Resources.icons8_password_30;
            this.btnPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassword.Location = new System.Drawing.Point(6, 341);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(6);
            this.btnPassword.MaximumSize = new System.Drawing.Size(273, 71);
            this.btnPassword.MinimumSize = new System.Drawing.Size(190, 49);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPassword.Size = new System.Drawing.Size(193, 49);
            this.btnPassword.TabIndex = 3;
            this.btnPassword.Text = "   &Password";
            this.btnPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::OswalMRA.Properties.Resources.icons8_reset_30;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(6, 399);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset.MaximumSize = new System.Drawing.Size(273, 71);
            this.btnReset.MinimumSize = new System.Drawing.Size(190, 49);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReset.Size = new System.Drawing.Size(193, 49);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "   &Reset ";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnWorkLog
            // 
            this.btnWorkLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWorkLog.FlatAppearance.BorderSize = 0;
            this.btnWorkLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkLog.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWorkLog.ForeColor = System.Drawing.Color.White;
            this.btnWorkLog.Image = global::OswalMRA.Properties.Resources.icons8_log_30;
            this.btnWorkLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkLog.Location = new System.Drawing.Point(6, 457);
            this.btnWorkLog.Margin = new System.Windows.Forms.Padding(6);
            this.btnWorkLog.MaximumSize = new System.Drawing.Size(273, 71);
            this.btnWorkLog.MinimumSize = new System.Drawing.Size(190, 49);
            this.btnWorkLog.Name = "btnWorkLog";
            this.btnWorkLog.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnWorkLog.Size = new System.Drawing.Size(193, 49);
            this.btnWorkLog.TabIndex = 5;
            this.btnWorkLog.Text = "   &Work Log";
            this.btnWorkLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWorkLog.UseVisualStyleBackColor = false;
            this.btnWorkLog.Click += new System.EventHandler(this.btnWorkLog_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = global::OswalMRA.Properties.Resources.icons8_inventory_30;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(6, 515);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(6);
            this.btnInventory.MaximumSize = new System.Drawing.Size(273, 71);
            this.btnInventory.MinimumSize = new System.Drawing.Size(190, 49);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(193, 49);
            this.btnInventory.TabIndex = 6;
            this.btnInventory.Text = "   &Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // childformPanel
            // 
            this.childformPanel.BackColor = System.Drawing.Color.White;
            this.childformPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childformPanel.Location = new System.Drawing.Point(205, 0);
            this.childformPanel.Margin = new System.Windows.Forms.Padding(0);
            this.childformPanel.Name = "childformPanel";
            this.childformPanel.Size = new System.Drawing.Size(1165, 733);
            this.childformPanel.TabIndex = 0;
            // 
            // statusGrid
            // 
            this.statusGrid.ColumnCount = 2;
            this.statusGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.statusGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.statusGrid.Controls.Add(this.statusDate, 1, 0);
            this.statusGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusGrid.Location = new System.Drawing.Point(3, 736);
            this.statusGrid.Name = "statusGrid";
            this.statusGrid.RowCount = 1;
            this.statusGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.statusGrid.Size = new System.Drawing.Size(1364, 10);
            this.statusGrid.TabIndex = 1;
            // 
            // statusDate
            // 
            this.statusDate.AutoSize = true;
            this.statusDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusDate.Location = new System.Drawing.Point(1094, 0);
            this.statusDate.Name = "statusDate";
            this.statusDate.Size = new System.Drawing.Size(267, 10);
            this.statusDate.TabIndex = 0;
            this.statusDate.Text = "Indian Standard Time";
            this.statusDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmFullLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.outerBaseGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(320, 480);
            this.Name = "frmFullLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oswal MRA";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFullLayout_KeyDown);
            this.outerBaseGrid.ResumeLayout(false);
            this.baseGrid.ResumeLayout(false);
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarGrid.ResumeLayout(false);
            this.statusGrid.ResumeLayout(false);
            this.statusGrid.PerformLayout();
            this.ResumeLayout(false);

=======
            sidebarGrid.ColumnCount = 1;
            sidebarGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sidebarGrid.Controls.Add(btnHome, 0, 1);
            sidebarGrid.Controls.Add(btnMould, 0, 2);
            sidebarGrid.Controls.Add(btnUser, 0, 3);
            sidebarGrid.Controls.Add(btnPassword, 0, 4);
            sidebarGrid.Controls.Add(btnReset, 0, 5);
            sidebarGrid.Controls.Add(btnWorkLog, 0, 6);
            sidebarGrid.Controls.Add(btnInventory, 0, 7);
            sidebarGrid.Controls.Add(btnDashboard, 0, 8);
            sidebarGrid.Controls.Add(logoGrid, 0, 0);
            sidebarGrid.Controls.Add(sidebarShortcutGrid, 0, 9);
            sidebarGrid.Dock = DockStyle.Fill;
            sidebarGrid.Location = new Point(0, 0);
            sidebarGrid.Margin = new Padding(3, 2, 3, 2);
            sidebarGrid.Name = "sidebarGrid";
            sidebarGrid.RowCount = 10;
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            sidebarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            sidebarGrid.Size = new Size(179, 578);
            sidebarGrid.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(41, 128, 185);
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
            btnHome.TabIndex = 1;
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
            btnMould.TabIndex = 2;
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
            btnUser.TabIndex = 3;
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
            btnPassword.TabIndex = 4;
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
            btnReset.TabIndex = 5;
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
            btnWorkLog.TabIndex = 6;
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
            btnInventory.TabIndex = 7;
            btnInventory.Text = "   &Inventory";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.icons8_control_panel_30;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(5, 454);
            btnDashboard.Margin = new Padding(5);
            btnDashboard.MaximumSize = new Size(239, 56);
            btnDashboard.MinimumSize = new Size(166, 39);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(13, 0, 0, 0);
            btnDashboard.Size = new Size(169, 39);
            btnDashboard.TabIndex = 8;
            btnDashboard.Text = "   &Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // logoGrid
            // 
            logoGrid.AutoSize = true;
            logoGrid.ColumnCount = 3;
            logoGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            logoGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76F));
            logoGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            logoGrid.Controls.Add(logo, 1, 1);
            logoGrid.Dock = DockStyle.Fill;
            logoGrid.Location = new Point(0, 0);
            logoGrid.Margin = new Padding(0);
            logoGrid.Name = "logoGrid";
            logoGrid.RowCount = 3;
            logoGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            logoGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            logoGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            logoGrid.Size = new Size(179, 127);
            logoGrid.TabIndex = 8;
            // 
            // logo
            // 
            logo.Dock = DockStyle.Fill;
            logo.Image = Properties.Resources.oswal_transparent;
            logo.Location = new Point(21, 12);
            logo.Margin = new Padding(0);
            logo.Name = "logo";
            logo.Size = new Size(136, 101);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // sidebarShortcutGrid
            // 
            sidebarShortcutGrid.ColumnCount = 1;
            sidebarShortcutGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sidebarShortcutGrid.Controls.Add(sidebarShortcutLabel, 0, 1);
            sidebarShortcutGrid.Dock = DockStyle.Fill;
            sidebarShortcutGrid.Location = new Point(0, 495);
            sidebarShortcutGrid.Margin = new Padding(0);
            sidebarShortcutGrid.Name = "sidebarShortcutGrid";
            sidebarShortcutGrid.RowCount = 2;
            sidebarShortcutGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            sidebarShortcutGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            sidebarShortcutGrid.Size = new Size(179, 83);
            sidebarShortcutGrid.TabIndex = 9;
            // 
            // sidebarShortcutLabel
            // 
            sidebarShortcutLabel.AutoSize = true;
            sidebarShortcutLabel.Dock = DockStyle.Fill;
            sidebarShortcutLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            sidebarShortcutLabel.ForeColor = Color.White;
            sidebarShortcutLabel.Location = new Point(0, 66);
            sidebarShortcutLabel.Margin = new Padding(0);
            sidebarShortcutLabel.Name = "sidebarShortcutLabel";
            sidebarShortcutLabel.Size = new Size(179, 17);
            sidebarShortcutLabel.TabIndex = 0;
            sidebarShortcutLabel.Text = "Press F1 to Toggle Sidebar";
            sidebarShortcutLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // childFormGrid
            // 
            childFormGrid.BackColor = Color.White;
            childFormGrid.ColumnCount = 1;
            childFormGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            childFormGrid.Controls.Add(childformPanel, 0, 1);
            childFormGrid.Controls.Add(headerPanel, 0, 0);
            childFormGrid.Dock = DockStyle.Fill;
            childFormGrid.Location = new Point(179, 0);
            childFormGrid.Margin = new Padding(0);
            childFormGrid.Name = "childFormGrid";
            childFormGrid.RowCount = 2;
            childFormGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            childFormGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 93F));
            childFormGrid.Size = new Size(1020, 578);
            childFormGrid.TabIndex = 1;
            // 
            // childformPanel
            // 
            childformPanel.Dock = DockStyle.Fill;
            childformPanel.Location = new Point(0, 40);
            childformPanel.Margin = new Padding(0);
            childformPanel.Name = "childformPanel";
            childformPanel.Size = new Size(1020, 538);
            childformPanel.TabIndex = 1;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(41, 128, 185);
            headerPanel.Controls.Add(headerGrid);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1020, 40);
            headerPanel.TabIndex = 1;
            // 
            // headerGrid
            // 
            headerGrid.ColumnCount = 2;
            headerGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            headerGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            headerGrid.Controls.Add(headerLabel, 0, 0);
            headerGrid.Dock = DockStyle.Fill;
            headerGrid.Location = new Point(0, 0);
            headerGrid.Margin = new Padding(0);
            headerGrid.Name = "headerGrid";
            headerGrid.RowCount = 1;
            headerGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            headerGrid.Size = new Size(1020, 40);
            headerGrid.TabIndex = 0;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Dock = DockStyle.Fill;
            headerLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(0, 0);
            headerLabel.Margin = new Padding(0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(357, 40);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Oswal MRA";
            headerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusGrid
            // 
            statusGrid.ColumnCount = 2;
            statusGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            statusGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            statusGrid.Controls.Add(statusDate, 1, 0);
            statusGrid.Dock = DockStyle.Fill;
            statusGrid.Location = new Point(0, 578);
            statusGrid.Margin = new Padding(0);
            statusGrid.Name = "statusGrid";
            statusGrid.RowCount = 1;
            statusGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            statusGrid.Size = new Size(1199, 13);
            statusGrid.TabIndex = 1;
            // 
            // statusDate
            // 
            statusDate.AutoSize = true;
            statusDate.Dock = DockStyle.Fill;
            statusDate.Location = new Point(959, 0);
            statusDate.Margin = new Padding(0);
            statusDate.Name = "statusDate";
            statusDate.Size = new Size(240, 13);
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
            WindowState = FormWindowState.Maximized;
            Load += frmFullLayout_Load;
            KeyDown += frmFullLayout_KeyDown;
            outerBaseGrid.ResumeLayout(false);
            baseGrid.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            sidebarGrid.ResumeLayout(false);
            sidebarGrid.PerformLayout();
            logoGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            sidebarShortcutGrid.ResumeLayout(false);
            sidebarShortcutGrid.PerformLayout();
            childFormGrid.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerGrid.ResumeLayout(false);
            headerGrid.PerformLayout();
            statusGrid.ResumeLayout(false);
            statusGrid.PerformLayout();
            ResumeLayout(false);
>>>>>>> Stashed changes
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