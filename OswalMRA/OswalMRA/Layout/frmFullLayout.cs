using OswalMRA.MessageBox;
using OswalMRA.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace OswalMRA.Layout
{
    public partial class frmFullLayout : Form
    {

        private bool isSidebarExpanded = true;
        private Form? activeForm = null;
        private Timer timer;

        public frmFullLayout()
        {
            InitializeComponent();
            statusDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Screen currentScreen = Screen.FromControl(this);
            Rectangle screenBounds = currentScreen.Bounds;
            this.Width = screenBounds.Width;
            this.Height = screenBounds.Height;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = screenBounds.Location;
            openChildForm(new frmHomePage());
            this.Text = "Oswal MRA - Home";
        }

<<<<<<< Updated upstream
=======
        #region WINDOW FORM TITLE
        private void Title(string title)
        {
            headerLabel.Text = title;
        }
        #endregion
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
                baseGrid.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 15); ;
                baseGrid.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 85); ;
            }
            else
            {
                baseGrid.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 4); ;
                baseGrid.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 96); ;
=======
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

>>>>>>> Stashed changes
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
            this.Text = "Oswal MRA - Home";
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLoginPage = new frmLoginPage();
            DialogResult loginDialogResult = frmLoginPage.ShowDialog();
            if (loginDialogResult == DialogResult.OK)
            {
                openChildForm(new frmUserPage());
<<<<<<< Updated upstream
                this.Text = "Oswal MRA - User Management";
=======
                Title("User Management");
                activeTab(btnUser);
                frmToast frmToast = new("Log in successful", "Success");
                frmToast.ShowAtBottomCenter();

>>>>>>> Stashed changes
            }
            else if (loginDialogResult == DialogResult.Cancel)
            {
                openChildForm(new frmHomePage());
                this.Text = "Oswal MRA - Home";
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            frmChangePasswordPage frmChangePasswordPage = new frmChangePasswordPage();
            this.Text = "Oswal MRA - Change Password";
            DialogResult changePasswordDialogResult = frmChangePasswordPage.ShowDialog();
            if (changePasswordDialogResult == DialogResult.OK)
            {
                openChildForm(new frmHomePage());
<<<<<<< Updated upstream
                this.Text = "Oswal MRA - Home";
=======
                Title("Home");
                activeTab(btnHome);
                frmToast frmToast = new("Password changed successfully", "Success");
                frmToast.ShowAtBottomCenter();
            }
            else if (changePasswordDialogResult == DialogResult.No)
            {
                openChildForm(new frmHomePage());
                Title("Home");
                activeTab(btnHome);
>>>>>>> Stashed changes
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

<<<<<<< Updated upstream
=======
            }
            else if (loginDialogResult == DialogResult.No)
            {
                openChildForm(new frmHomePage());
                Title("Home");
                activeTab(btnHome);
                frmToast frmToast = new("Log in failed", "Error");
                frmToast.ShowAtBottomCenter();
            }
>>>>>>> Stashed changes
        }

        private void btnWorkLog_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLoginPage = new frmLoginPage();
            DialogResult loginDialogResult = frmLoginPage.ShowDialog();
            if (loginDialogResult == DialogResult.OK)
            {
                openChildForm(new frmWorklog());
                this.Text = "Oswal MRA - Work Log";
            }
            else if (loginDialogResult == DialogResult.Cancel)
            {
                openChildForm(new frmHomePage());
                this.Text = "Oswal MRA - Home";
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLoginPage = new frmLoginPage();
            DialogResult loginDialogResult = frmLoginPage.ShowDialog();
            if (loginDialogResult == DialogResult.OK)
            {
                openChildForm(new frmInventory());
                this.Text = "Oswal MRA - Inventory";
            }
            else if (loginDialogResult == DialogResult.Cancel)
            {
                openChildForm(new frmHomePage());
                this.Text = "Oswal MRA - Home";
            }
        }

        private void btnMould_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLoginPage = new frmLoginPage();
            DialogResult loginDialogResult = frmLoginPage.ShowDialog();
            if (loginDialogResult == DialogResult.OK)
            {
                openChildForm(new frmMouldPage());
                this.Text = "Oswal MRA - Mould Management";
            }
            else if (loginDialogResult == DialogResult.Cancel)
            {
                openChildForm(new frmHomePage());
<<<<<<< Updated upstream
                this.Text = "Oswal MRA - Home";
=======
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

            }
            else if (loginDialogResult == DialogResult.No)
            {
                openChildForm(new frmHomePage());
                Title("Home");
                activeTab(btnHome);
                frmToast frmToast = new("Log in failed", "Error");
                frmToast.ShowAtBottomCenter();

>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
=======
        #region ACTIVE TAB BACK COLOR
        private void activeTab(Button button)
        {
            btnHome.BackColor = Color.FromArgb(41, 128, 185);
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


>>>>>>> Stashed changes
    }
}
