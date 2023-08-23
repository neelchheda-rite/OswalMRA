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

namespace OswalMRA.Layout {
    public partial class frmFullLayout : Form {

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
                baseGrid.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 15); ;
                baseGrid.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 85); ;
            } else
            {
                baseGrid.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 4); ;
                baseGrid.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 96); ;
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
                openChildForm(new UserManagement());
                this.Text = "Oswal MRA - User Management";
            } else if (loginDialogResult == DialogResult.Cancel)
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
                this.Text = "Oswal MRA - Home";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnWorkLog_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLoginPage = new frmLoginPage();
            DialogResult loginDialogResult = frmLoginPage.ShowDialog();
            if (loginDialogResult == DialogResult.OK)
            {
                openChildForm(new frmWorkLogPage());
                this.Text = "Oswal MRA - Work Log";
            } else if (loginDialogResult == DialogResult.Cancel)
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
                openChildForm(new frmInventoryPage());
                this.Text = "Oswal MRA - Inventory";
            } else if (loginDialogResult == DialogResult.Cancel)
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
            } else if (loginDialogResult == DialogResult.Cancel)
            { 
                openChildForm(new frmHomePage());
                this.Text = "Oswal MRA - Home";
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
