using OswalMRA.MessageBox;
using OswalMRA.Test;
using OswalMRA.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            frmHome frmHomeTest = new();
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
            openChildForm(new frmHome());
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
                frmToast frmToast = new("Log in successfull", "Success");
                frmToast.ShowAtBottomCenter();
               
            }
            else if (loginDialogResult == DialogResult.No)
            {
                openChildForm(new frmHome());
                Title("Home");
                frmToast frmToast = new("Log in failed", "Error");
                frmToast.ShowAtBottomCenter();
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            frmChangePasswordPage frmChangePasswordPage = new frmChangePasswordPage();
            DialogResult changePasswordDialogResult = frmChangePasswordPage.ShowDialog();
            if (changePasswordDialogResult == DialogResult.OK)
            {
                openChildForm(new frmHome());
                Title("Home");
                frmToast frmToast = new("Log in failed", "Error");
                frmToast.ShowAtBottomCenter();

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnWorkLog_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLoginPage = new frmLoginPage();
            DialogResult loginDialogResult = frmLoginPage.ShowDialog();
            if (loginDialogResult == DialogResult.Yes)
            {
                openChildForm(new frmWorklog());
                Title("Work Log");
                frmToast frmToast = new("Log in successfull", "Success");
                frmToast.ShowAtBottomCenter();

            }
            else if (loginDialogResult == DialogResult.No)
            {
                openChildForm(new frmHome());
                Title("Home");
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
                openChildForm(new frmInventory());
                Title("Inventory");
                frmToast frmToast = new("Log in successfull", "Success");
                frmToast.ShowAtBottomCenter();

            }
            else if (loginDialogResult == DialogResult.No)
            {
                openChildForm(new frmHome());
                Title("Home");
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
                frmToast frmToast = new("Log in successfull", "Success");
                frmToast.ShowAtBottomCenter();

            }
            else if (loginDialogResult == DialogResult.No)
            {
                openChildForm(new frmHome());
                Title("Home");
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

    }
}
