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
    public partial class frmChangePasswordPage : Form {
        public frmChangePasswordPage()
        {
            InitializeComponent();
        }


        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if(newPasswordTextBox.Text != currentPasswordTextBox.Text && newPasswordTextBox.Text == confirmPasswordTextBox.Text)
                DialogResult = DialogResult.OK; 
        }

        private void newPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text == currentPasswordTextBox.Text)
            { 
                newPasswordWarning.Text = "Password already used";
                newPasswordTextBox.Focus();
            }

        }

        private void confirmPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text != confirmPasswordTextBox.Text)
                confirmPasswordWarning.Text = "Passwords don't match";            
        }

        private void newPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (currentPasswordTextBox.Text != newPasswordTextBox.Text)
                newPasswordWarning.Text = null;
            else if (currentPasswordTextBox.Text == newPasswordTextBox.Text)
                newPasswordWarning.Text = "Password already used";
        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if(confirmPasswordTextBox.Text == newPasswordTextBox.Text)
                confirmPasswordWarning.Text = null;
        }
    }
}
