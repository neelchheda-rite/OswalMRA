using OswalMRA.COMMON.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OswalMRA {
    public partial class frmLogin : Form {
               
        private readonly IDBRepository _dapperManagement;
        public frmLogin()
        {
            InitializeComponent();
            _dapperManagement = new DBRepository();
            usernametxtbox.Focus();
            passwordtxtbox.Focus();
        }
        private async void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<LoginResponse> loginResp = await _dapperManagement.Login(usernametxtbox.Text, passwordtxtbox.Text);
                if (loginResp[0].ValidationStatus == "Validation successful.")
                {
                    msgBox msgBox = new("successfully logged in", "");
                    msgBox.Show();
                }
                else
                {
                    msgBox msgBox = new("error occured", "");
                    msgBox.Show();
                }
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                // Clear input fields
                usernametxtbox.Text = string.Empty;
                passwordtxtbox.Text = string.Empty;
            }
        }
        
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            usernametxtbox.Text = null;
            passwordtxtbox.Text = null;
            DialogResult= DialogResult.Abort;
        }
        

        private void panel2_Enter(object sender, EventArgs e)
        {
            
            usernametxtbox.Focus();
        }
        private void panel2_Leave(object sender, EventArgs e)
        {
            
            usernametxtbox.Focus();
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            usernametxtbox.Focus();
        }

        private void forgotbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
