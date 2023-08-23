using OswalMRA.MessageBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OswalMRA {
    public partial class frmChangePassword : Form {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(currentPasswordtxtBox.Text!=null && newPasswordtxtBox.Text==confirmPasswordtxtBox.Text && passwordWarningLabel.Text == "")
            {
                msgBox msgBox = new("Password Changed","");
                msgBox.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void newPasswordtxtBox_Leave(object sender, EventArgs e)
        {
            if (newPasswordtxtBox.Text == currentPasswordtxtBox.Text)
            {
                passwordWarningLabel.Text = "Current and new passwords cannot be same.";
                confirmPasswordtxtBox.Enabled = false;
                newPasswordtxtBox.Focus();
            } else
            {
                confirmPasswordtxtBox.Enabled = true;
                confirmPasswordtxtBox.Focus();
                passwordWarningLabel.Text = null;
            }
                
        }

        private void newPasswordtxtBox_TextChanged(object sender, EventArgs e)
        {
            if (currentPasswordtxtBox.Text != newPasswordtxtBox.Text)
                passwordWarningLabel.Text = null;
        }

        private void confirmPasswordtxtBox_Leave(object sender, EventArgs e)
        {
            if (newPasswordtxtBox.Text != confirmPasswordtxtBox.Text)
            {
                passwordWarningLabel.Text = "Passwords don't match.";
                confirmPasswordtxtBox.Focus();
            } 
            else
            {
                passwordWarningLabel.Text = null;
            }
                           
        }
    }
}
