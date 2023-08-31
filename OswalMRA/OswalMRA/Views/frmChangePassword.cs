using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OswalMRA.Views {
    public partial class frmChangePassword : Form {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.Red;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void changePasswordTest_Shown(object sender, EventArgs e)
        {
            currentPasswordTextBox.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            if (DialogResult == DialogResult.Yes)
            {
                frmToast frmToast = new("Password chang ed successfully", "Success");
                frmToast.ShowAtBottomCenter();
            }
        }

        private void frmChangePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode==Keys.Enter)
            {
                btnChangePassword.PerformClick();
            }
        }
    }
}
