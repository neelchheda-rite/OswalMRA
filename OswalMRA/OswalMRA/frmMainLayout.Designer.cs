namespace OswalMRA {
    partial class frmMainLayout {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainLayout));
            this.topBar = new System.Windows.Forms.Panel();
            this.toggleSideBar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.headerTitle = new System.Windows.Forms.Label();
            this.sideBar = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnWorkLog = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnMould = new System.Windows.Forms.Button();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusBarTime = new System.Windows.Forms.Label();
            this.topBar.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.SystemColors.Control;
            this.topBar.Controls.Add(this.toggleSideBar);
            this.topBar.Controls.Add(this.btnClose);
            this.topBar.Controls.Add(this.headerTitle);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1920, 36);
            this.topBar.TabIndex = 0;
            // 
            // toggleSideBar
            // 
            this.toggleSideBar.FlatAppearance.BorderSize = 0;
            this.toggleSideBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleSideBar.Image = global::OswalMRA.Properties.Resources.icons8_grip_lines_20;
            this.toggleSideBar.Location = new System.Drawing.Point(0, 0);
            this.toggleSideBar.Name = "toggleSideBar";
            this.toggleSideBar.Size = new System.Drawing.Size(48, 36);
            this.toggleSideBar.TabIndex = 13;
            this.toggleSideBar.UseVisualStyleBackColor = true;
            this.toggleSideBar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(1867, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "E&xit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // headerTitle
            // 
            this.headerTitle.AutoSize = true;
            this.headerTitle.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerTitle.Location = new System.Drawing.Point(42, 6);
            this.headerTitle.Name = "headerTitle";
            this.headerTitle.Size = new System.Drawing.Size(114, 24);
            this.headerTitle.TabIndex = 2;
            this.headerTitle.Text = "Oswal MRA";
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.sideBar.Controls.Add(this.btnHome);
            this.sideBar.Controls.Add(this.btnUser);
            this.sideBar.Controls.Add(this.btnInventory);
            this.sideBar.Controls.Add(this.btnWorkLog);
            this.sideBar.Controls.Add(this.btnReset);
            this.sideBar.Controls.Add(this.btnPassword);
            this.sideBar.Controls.Add(this.btnMould);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 36);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(275, 1044);
            this.sideBar.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::OswalMRA.Properties.Resources.icons8_home_30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 150);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(275, 65);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "  &Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnUser
            // 
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::OswalMRA.Properties.Resources.icons8_admin_30;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 280);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(275, 65);
            this.btnUser.TabIndex = 9;
            this.btnUser.Text = "  &User";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = global::OswalMRA.Properties.Resources.icons8_inventory_30;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(0, 540);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(275, 65);
            this.btnInventory.TabIndex = 14;
            this.btnInventory.Text = "  &Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click_1);
            // 
            // btnWorkLog
            // 
            this.btnWorkLog.FlatAppearance.BorderSize = 0;
            this.btnWorkLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkLog.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWorkLog.ForeColor = System.Drawing.Color.White;
            this.btnWorkLog.Image = global::OswalMRA.Properties.Resources.icons8_log_30;
            this.btnWorkLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkLog.Location = new System.Drawing.Point(0, 475);
            this.btnWorkLog.Name = "btnWorkLog";
            this.btnWorkLog.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnWorkLog.Size = new System.Drawing.Size(275, 65);
            this.btnWorkLog.TabIndex = 13;
            this.btnWorkLog.Text = "  &Work Log";
            this.btnWorkLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWorkLog.UseVisualStyleBackColor = true;
            this.btnWorkLog.Click += new System.EventHandler(this.btnWorkLog_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::OswalMRA.Properties.Resources.icons8_reset_30;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(0, 410);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReset.Size = new System.Drawing.Size(275, 65);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "  &Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPassword.ForeColor = System.Drawing.Color.White;
            this.btnPassword.Image = global::OswalMRA.Properties.Resources.icons8_password_30;
            this.btnPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassword.Location = new System.Drawing.Point(0, 345);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPassword.Size = new System.Drawing.Size(275, 65);
            this.btnPassword.TabIndex = 11;
            this.btnPassword.Text = "  &Password";
            this.btnPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnMould
            // 
            this.btnMould.FlatAppearance.BorderSize = 0;
            this.btnMould.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMould.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMould.ForeColor = System.Drawing.Color.White;
            this.btnMould.Image = global::OswalMRA.Properties.Resources.icons8_machine_30;
            this.btnMould.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMould.Location = new System.Drawing.Point(0, 215);
            this.btnMould.Name = "btnMould";
            this.btnMould.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMould.Size = new System.Drawing.Size(275, 65);
            this.btnMould.TabIndex = 8;
            this.btnMould.Text = "  &Mould";
            this.btnMould.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMould.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMould.UseVisualStyleBackColor = true;
            this.btnMould.Click += new System.EventHandler(this.btnMould_Click);
            // 
            // childFormPanel
            // 
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(275, 36);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(1645, 1044);
            this.childFormPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.statusBarTime);
            this.panel1.Location = new System.Drawing.Point(0, 1056);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 25);
            this.panel1.TabIndex = 0;
            // 
            // statusBarTime
            // 
            this.statusBarTime.AutoSize = true;
            this.statusBarTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusBarTime.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusBarTime.Location = new System.Drawing.Point(1755, 2);
            this.statusBarTime.Name = "statusBarTime";
            this.statusBarTime.Size = new System.Drawing.Size(0, 19);
            this.statusBarTime.TabIndex = 0;
            // 
            // frmMainLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 1038);
            this.Name = "frmMainLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainLayout";
            this.Load += new System.EventHandler(this.frmMainLayout_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMainLayout_KeyDown);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            this.sideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel topBar;
        private PictureBox pictureBox1;
        private Label headerTitle;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button btnClose;
        private Panel sideBar;
        private Button btnReset;
        private Button btnPassword;
        private Button btnHome;
        private Button btnMould;
        private Button btnUser;
        private Panel childFormPanel;
        private Button toggleSideBar;
        private Button btnWorkLog;
        private Button btnInventory;
        private Panel panel1;
        private Label statusBarTime;
    }
}