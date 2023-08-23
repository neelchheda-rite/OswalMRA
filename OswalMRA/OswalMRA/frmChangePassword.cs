using OswalMRA.DAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OswalMRA {
    public partial class frmChangePassword : Form {
        private readonly DBRepository _dapperManagement;
        private readonly string _loggedUserName;
        public frmChangePassword(DBRepository dapperManagement)
        {
            InitializeComponent();
            _dapperManagement = dapperManagement;
            //_loggedUserName = loggedUserName;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    bool isPasswordValid = await _dapperManagement.VerifyPassword(_loggedUserName, currentPasswordtxtBox.Text);

            //    if (!isPasswordValid)
            //    {
            //        msgBox msgBox = new("current password is incorrect", "");
            //        msgBox.Show();
            //    }

            //    if (newPasswordtxtBox.Text != confirmPasswordtxtBox.Text)
            //    {
            //        msgBox msgBox = new("passwords don't match", "");
            //        msgBox.Show();
            //    }

            //    // Update the password in the database
            //    bool success = await _dapperManagement.UpdatePassword(_loggedUserName, newPasswordtxtBox.Text);
            //    if (success)
            //    {
            //        msgBox msgBox = new("password changed successfully", "");
            //        msgBox.Show();
            //        this.Close();
            //    }
            //    else
            //    {
            //        msgBox msgBox = new("password updatefailed", "");
            //        msgBox.Show();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // Handle exceptions
            //    msgBox msgBox = new("An error occured", "");
            //    msgBox.Show();
            //}
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
