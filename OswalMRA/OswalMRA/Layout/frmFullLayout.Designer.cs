namespace OswalMRA.Layout {
    partial class frmFullLayout {
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
            // 
            // outerBaseGrid
            // 
            this.outerBaseGrid.ColumnCount = 1;
            this.outerBaseGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outerBaseGrid.Controls.Add(this.baseGrid, 0, 0);
            this.outerBaseGrid.Controls.Add(this.statusGrid, 0, 1);
            this.outerBaseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outerBaseGrid.Location = new System.Drawing.Point(0, 0);
            this.outerBaseGrid.Margin = new System.Windows.Forms.Padding(0);
            this.outerBaseGrid.Name = "outerBaseGrid";
            this.outerBaseGrid.RowCount = 2;
            this.outerBaseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.93814F));
            this.outerBaseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.061856F));
            this.outerBaseGrid.Size = new System.Drawing.Size(1904, 1001);
            this.outerBaseGrid.TabIndex = 0;
            // 
            // baseGrid
            // 
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
            this.baseGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.baseGrid.Size = new System.Drawing.Size(1904, 980);
            this.baseGrid.TabIndex = 0;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.sidebarPanel.Controls.Add(this.sidebarGrid);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(285, 980);
            this.sidebarPanel.TabIndex = 0;
            // 
            // sidebarGrid
            // 
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
            this.sidebarGrid.Size = new System.Drawing.Size(285, 980);
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
            this.btnHome.Location = new System.Drawing.Point(6, 221);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6);
            this.btnHome.MaximumSize = new System.Drawing.Size(273, 71);
            this.btnHome.MinimumSize = new System.Drawing.Size(190, 50);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(273, 66);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "   &Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMould
            // 
            this.btnMould.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMould.FlatAppearance.BorderSize = 0;
            this.btnMould.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMould.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMould.ForeColor = System.Drawing.Color.White;
            this.btnMould.Image = global::OswalMRA.Properties.Resources.icons8_machine_30;
            this.btnMould.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMould.Location = new System.Drawing.Point(6, 299);
            this.btnMould.Margin = new System.Windows.Forms.Padding(6);
            this.btnMould.MaximumSize = new System.Drawing.Size(273, 71);
            this.btnMould.MinimumSize = new System.Drawing.Size(190, 50);
            this.btnMould.Name = "btnMould";
            this.btnMould.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMould.Size = new System.Drawing.Size(273, 66);
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
            this.btnUser.Location = new System.Drawing.Point(6, 377);
            this.btnUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnUser.MaximumSize = new System.Drawing.Size(273, 71);
            this.btnUser.MinimumSize = new System.Drawing.Size(190, 50);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(273, 66);
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
            this.btnPassword.Location = new System.Drawing.Point(6, 455);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(6);
            this.btnPassword.MaximumSize = new System.Drawing.Size(273, 71);
            this.btnPassword.MinimumSize = new System.Drawing.Size(190, 50);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPassword.Size = new System.Drawing.Size(273, 66);
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
            this.btnReset.Location = new System.Drawing.Point(6, 533);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset.MaximumSize = new System.Drawing.Size(273, 71);
            this.btnReset.MinimumSize = new System.Drawing.Size(190, 50);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReset.Size = new System.Drawing.Size(273, 66);
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
            this.btnWorkLog.Location = new System.Drawing.Point(6, 611);
            this.btnWorkLog.Margin = new System.Windows.Forms.Padding(6);
            this.btnWorkLog.MaximumSize = new System.Drawing.Size(273, 71);
            this.btnWorkLog.MinimumSize = new System.Drawing.Size(190, 50);
            this.btnWorkLog.Name = "btnWorkLog";
            this.btnWorkLog.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnWorkLog.Size = new System.Drawing.Size(273, 66);
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
            this.btnInventory.Location = new System.Drawing.Point(6, 689);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(6);
            this.btnInventory.MaximumSize = new System.Drawing.Size(273, 71);
            this.btnInventory.MinimumSize = new System.Drawing.Size(190, 50);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(273, 66);
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
            this.childformPanel.Location = new System.Drawing.Point(285, 0);
            this.childformPanel.Margin = new System.Windows.Forms.Padding(0);
            this.childformPanel.Name = "childformPanel";
            this.childformPanel.Size = new System.Drawing.Size(1619, 980);
            this.childformPanel.TabIndex = 0;
            // 
            // statusGrid
            // 
            this.statusGrid.ColumnCount = 2;
            this.statusGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.statusGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.statusGrid.Controls.Add(this.statusDate, 1, 0);
            this.statusGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusGrid.Location = new System.Drawing.Point(3, 983);
            this.statusGrid.Name = "statusGrid";
            this.statusGrid.RowCount = 1;
            this.statusGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.statusGrid.Size = new System.Drawing.Size(1898, 15);
            this.statusGrid.TabIndex = 1;
            // 
            // statusDate
            // 
            this.statusDate.AutoSize = true;
            this.statusDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusDate.Location = new System.Drawing.Point(1521, 0);
            this.statusDate.Name = "statusDate";
            this.statusDate.Size = new System.Drawing.Size(374, 15);
            this.statusDate.TabIndex = 0;
            this.statusDate.Text = "Indian Standard Time";
            this.statusDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmFullLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1001);
            this.Controls.Add(this.outerBaseGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(320, 480);
            this.Name = "frmFullLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oswal MRA";
            this.Load += new System.EventHandler(this.frmFullLayout_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFullLayout_KeyDown);
            this.outerBaseGrid.ResumeLayout(false);
            this.baseGrid.ResumeLayout(false);
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarGrid.ResumeLayout(false);
            this.statusGrid.ResumeLayout(false);
            this.statusGrid.PerformLayout();
            this.ResumeLayout(false);

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