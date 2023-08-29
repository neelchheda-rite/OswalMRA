using OswalMRA.Test;
using OswalMRA.Views;
using Timer = System.Windows.Forms.Timer;

namespace OswalMRA.Layout {
    public partial class frmFullLayout : Form
    {

        private bool isSidebarExpanded = true;
        private Form? activeForm = null;
        private Timer timer;

        public frmFullLayout()
        {
            InitializeComponent();
            frmHomePage frmHomeTest = new();
            activeTab(btnHome);
            statusDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Screen currentScreen = Screen.FromControl(this);
            Rectangle screenBounds = currentScreen.Bounds;
            this.Width = screenBounds.Width;
            this.Height = screenBounds.Height;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = screenBounds.Location;
            openChildForm(frmHomeTest);
            Title("Home");
        }

        #region WINDOW FORM TITLE
        private void Title(string title)
        {
            headerLabel.Text =title;
        }
        #endregion

        #region CHILD FORM
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childformPanel.Controls.Add(childForm);
            childformPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion CHILD FORM

        #region TOGGLE SIDEBAR
        private void ToggleSidebar()
        {
            isSidebarExpanded = !isSidebarExpanded;
            if (isSidebarExpanded)
            {
                baseGrid.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 15); 
                baseGrid.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 85);
                sidebarShortcutLabel.Text = Properties.Resources.toggleSidebarMessage;
            }
            else
            {
                baseGrid.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 4); 
                baseGrid.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 96);
                sidebarShortcutLabel.Text = "&F1";
                sidebarShortcutLabel.Font = new Font(sidebarShortcutLabel.Font, FontStyle.Bold);

            }
        }
        #endregion TOGGLE SIDEBAR

        #region KEYBOARD SHORTCUTS
        private void frmFullLayout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                ToggleSidebar();
        }
        #endregion KEYBOARD SHORTCUTS

        #region SIDEBAR TABS
        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHomePage());
            Title("Home");
            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLoginPage = new frmLoginPage();
            DialogResult loginDialogResult = frmLoginPage.ShowDialog();
            if (loginDialogResult == DialogResult.Yes)
            {
                openChildForm(new frmUserPage());
                Title("User Management");
                activeTab(btnUser);
                frmToast frmToast = new("Log in successful", "Success");
                frmToast.ShowAtBottomCenter();
               
            }
            else if (loginDialogResult == DialogResult.No)
            {
                openChildForm(new frmHomePage());
                Title("Home");
                activeTab(btnHome);
                frmToast frmToast = new("Log in failed", "Error");
                frmToast.ShowAtBottomCenter();
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            frmChangePasswordPage frmChangePasswordPage = new frmChangePasswordPage();
            DialogResult changePasswordDialogResult = frmChangePasswordPage.ShowDialog();
            activeTab(btnPassword);
            Title("Change Password");
            if (changePasswordDialogResult == DialogResult.OK)
            {
                openChildForm(new frmHomePage());
                Title("Home");
                activeTab(btnHome);
                frmToast frmToast = new("Password changed successfully", "Success");
                frmToast.ShowAtBottomCenter();

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLoginPage = new frmLoginPage();
            DialogResult loginDialogResult = frmLoginPage.ShowDialog();
            if (loginDialogResult == DialogResult.Yes)
            {
                openChildForm(new frmResetPage());
                Title("Reset PLC");
                activeTab(btnReset);
                frmToast frmToast = new("Log in successful", "Success");
                frmToast.ShowAtBottomCenter();

            } else if (loginDialogResult == DialogResult.No)
            {
                openChildForm(new frmHomePage());
                Title("Home");
                activeTab(btnHome);
                frmToast frmToast = new("Log in failed", "Error");
                frmToast.ShowAtBottomCenter();
            }
        }

        private void btnWorkLog_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLoginPage = new frmLoginPage();
            DialogResult loginDialogResult = frmLoginPage.ShowDialog();
            if (loginDialogResult == DialogResult.Yes)
            {
                openChildForm(new frmWorklogPage());
                Title("Work Log");
                activeTab(btnWorkLog);
                frmToast frmToast = new("Log in successful", "Success");
                frmToast.ShowAtBottomCenter();

            }
            else if (loginDialogResult == DialogResult.No)
            {
                openChildForm(new frmHomePage());
                Title("Home");
                activeTab(btnHome);
                frmToast frmToast = new("Log in failed", "Error");
                frmToast.ShowAtBottomCenter();

            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLoginPage = new frmLoginPage();
            DialogResult loginDialogResult = frmLoginPage.ShowDialog();
            if (loginDialogResult == DialogResult.Yes)
            {
                openChildForm(new frmInventoryPage());
                Title("Inventory");
                activeTab(btnInventory);
                frmToast frmToast = new("Log in successful", "Success");
                frmToast.ShowAtBottomCenter();

            }
            else if (loginDialogResult == DialogResult.No)
            {
                openChildForm(new frmHomePage());
                Title("Home");
                activeTab(btnHome);
                frmToast frmToast = new("Log in failed", "Error");
                frmToast.ShowAtBottomCenter();

            }
        }

        private void btnMould_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLoginPage = new frmLoginPage();
            DialogResult loginDialogResult = frmLoginPage.ShowDialog();
            if (loginDialogResult == DialogResult.Yes)
            {
                openChildForm(new frmMouldPage());
                Title("Mould Management");
                activeTab(btnMould);
                frmToast frmToast = new("Log in successful", "Success");
                frmToast.ShowAtBottomCenter();

            }
            else if (loginDialogResult == DialogResult.No)
            {
                openChildForm(new frmHomePage());
                Title("Home");
                activeTab(btnHome);
                frmToast frmToast = new("Log in failed", "Error");
                frmToast.ShowAtBottomCenter();

            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLoginPage = new frmLoginPage();
            DialogResult loginDialogResult = frmLoginPage.ShowDialog();
            if (loginDialogResult == DialogResult.Yes)
            {
                openChildForm(new frmDashboardPage());
                Title("Dashboard");
                activeTab(btnDashboard);
                frmToast frmToast = new("Log in successful", "Success");
                frmToast.ShowAtBottomCenter();

            } else if (loginDialogResult == DialogResult.No)
            {
                openChildForm(new frmHomePage());
                Title("Home");
                activeTab(btnHome);
                frmToast frmToast = new("Log in failed", "Error");
                frmToast.ShowAtBottomCenter();

            }
        }

        #endregion SIDEBAR TABS

        #region STATUS BAR DATETIME
        private void frmFullLayout_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            statusDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        #endregion STATUS BAR DATETIME

        #region ACTIVE TAB BACK COLOR
        private void activeTab(Button button)
        {
            btnHome.BackColor = Color.FromArgb(41,128,185);
            btnUser.BackColor = Color.FromArgb(41, 128, 185);
            btnMould.BackColor = Color.FromArgb(41, 128, 185);
            btnWorkLog.BackColor = Color.FromArgb(41, 128, 185);
            btnPassword.BackColor = Color.FromArgb(41, 128, 185);
            btnInventory.BackColor = Color.FromArgb(41, 128, 185);
            btnReset.BackColor = Color.FromArgb(41, 128, 185);
            btnDashboard.BackColor = Color.FromArgb(41, 128, 185);
            button.BackColor = Color.FromArgb(49, 153, 222);
        }
        #endregion ACTIVE TAB BACK COLOR

        
    }
}
