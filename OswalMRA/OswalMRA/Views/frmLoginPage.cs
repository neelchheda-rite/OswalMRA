using OswalMRA.COMMON.Models;
using OswalMRA.DAL;
using OswalMRA.MessageBox;

namespace OswalMRA.Views
{
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
                    byte userRoleID = loginResp[0].UserRoleID;
                    if (userRoleID == 1 || userRoleID == 2)
                    {
                        msgBox msgBox = new("successfully logged in", "");
                        DialogResult dialogResult = msgBox.ShowDialog();

                        if (msgBox.DialogResult == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        msgBox msgBox = new msgBox("Invalid User Role", "");
                        msgBox.ShowDialog();
                        DialogResult = DialogResult.Cancel;
                    }
                }
                else
                {
                    msgBox msgBox = new msgBox("Login Failed", "");
                    msgBox.ShowDialog();
                    DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
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
