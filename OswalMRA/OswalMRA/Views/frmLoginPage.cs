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

namespace OswalMRA.Views {
    public partial class frmLoginPage : Form {
        private readonly IDBRepository _dapperManagement;
        public frmLoginPage()
        {
            InitializeComponent();
            _dapperManagement = new DBRepository();
            usernameTextBox.Focus();
            passwordTextBox.Focus();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<LoginResponse> loginResp = await _dapperManagement.Login(usernameTextBox.Text, passwordTextBox.Text);
                if (loginResp[0].ValidationStatus == "Validation successful.")
                {
                    //msgBox msgBox = new("successfully logged in", "");
                    //DialogResult dialogResult = msgBox.ShowDialog();

                    //if(msgBox.DialogResult == DialogResult.OK)
                    //{
                       
                    //}
                    this.DialogResult = DialogResult.OK;
                    this.Close();
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
                usernameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
            }
            
        }

        private void frmLoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
