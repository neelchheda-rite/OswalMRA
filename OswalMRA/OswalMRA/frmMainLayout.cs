using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;
using System.Windows.Forms;

namespace OswalMRA {
    public partial class frmMainLayout : Form {
        private Timer transitionTimer;
        private bool isExpanding;
        frmLogin frmLogin = new();
        
        private Timer timer;
        public frmMainLayout()
        {
            InitializeComponent();
            this.KeyPreview = true;
            transitionTimer = new Timer();
            transitionTimer.Interval = 15;
            transitionTimer.Tick += TransitionTimer_Tick;
            isExpanding = false;
            openChildForm(new frmHome());

        }
        private void TransitionTimer_Tick(object sender, EventArgs e)
        {
            int targetWidth = isExpanding ? 275 : 55;
            int stepSize = (targetWidth - sideBar.Width) / 12;
            sideBar.Width += stepSize;
            if (Math.Abs(targetWidth - sideBar.Width) <= Math.Abs(stepSize))
            {
                sideBar.Width = targetWidth;
                btnHome.Width = sideBar.Width;
                btnMould.Width = sideBar.Width;
                btnUser.Width = sideBar.Width;
                btnPassword.Width = sideBar.Width;
                btnReset.Width = sideBar.Width;
                transitionTimer.Stop();
            }

        }
        private Form? activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = SystemColors.Control;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
            openChildForm(new frmHome());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isExpanding = !isExpanding;
            if (transitionTimer.Enabled)
                transitionTimer.Stop();
            transitionTimer.Start();
        }

        private void btnMould_Click(object sender, EventArgs e)
        {
            DialogResult result = frmLogin.ShowDialog();
            if (result == DialogResult.OK)
            {

                openChildForm(new frmMouldPage());


            }
            else
            {
                //MessageBox.Show("Access Denied");
                openChildForm(new frmHome());
            }
            
        }

        private void frmMainLayout_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.F1)
            {
                toggleSideBar.PerformClick();
            } 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = frmLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                openChildForm(new frmReset());
            } else if (result == DialogResult.Cancel)
            {
                //MessageBox.Show("Access Denied");
                openChildForm(new frmHome());
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            DialogResult result = frmLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                openChildForm(new frmUserPage());
            } else if (result == DialogResult.Cancel)
            {
                //MessageBox.Show("Access Denied");
                openChildForm(new frmHome());
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            //frmChangePassword frmChangePassword = new();
            //DialogResult result = frmChangePassword.ShowDialog();
            //if (result == DialogResult.OK || result == DialogResult.Cancel)
            //{
            //    openChildForm(new frmHome());
            //}
        }

        private void btnWorkLog_Click(object sender, EventArgs e)
        {
            DialogResult result = frmLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                openChildForm(new mouldDetailsfORM());
            } else if (result == DialogResult.Cancel)
            {
                //MessageBox.Show("Access Denied");
                openChildForm(new frmHome());
            }
        }
        private void btnInventory_Click_1(object sender, EventArgs e)
        {
            DialogResult result = frmLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                openChildForm(new currentStatusForm());
            } else if (result == DialogResult.Cancel)
            {
                //MessageBox.Show("Access Denied");
                openChildForm(new frmHome());
            } else if (result == DialogResult.Abort)
            {

            }
        }

        private void frmMainLayout_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the date and time in the status strip label.
            statusBarTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

    }
}
