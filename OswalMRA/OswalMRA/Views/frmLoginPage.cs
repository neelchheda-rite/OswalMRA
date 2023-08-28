using OswalMRA.COMMON.Models;
using OswalMRA.DAL;
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
    public partial class frmLoginPage : Form {
        private readonly IDBRepository _dapperManagement;

        public frmLoginPage()
        {
            InitializeComponent();
            _dapperManagement = new DBRepository();
            usernameTextBox.Focus();
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.Red;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(41,128,185);
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLoginPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();

            } else if (e.KeyCode == Keys.Enter)
            {
                this.Close();   
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            List<LoginResponse> loginResp = await _dapperManagement.Login(usernameTextBox.Text, passwordTextBox.Text);
            if (loginResp[0].ValidationStatus == "Validation successful.")
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            } else
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
