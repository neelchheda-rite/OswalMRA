using NLog;
using OswalMRA.COMMON.Models;
using OswalMRA.DAL;
using OswalMRA.MessageBox;

namespace OswalMRA.Views
{
    public partial class frmChangePasswordPage : Form {
        private readonly IDBRepository _dapperManagement;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public frmChangePasswordPage()
        {
            InitializeComponent();
            _dapperManagement = new DBRepository();
            currentPasswordTextBox.Focus();
            newPasswordTextBox.Focus();
        }


        private async void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text == currentPasswordTextBox.Text)
            {
                newPasswordWarning.Text = Properties.Resources.passwordAlreadyUsedMessage;
                newPasswordTextBox.Focus();
                return;
            }

            if (newPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                confirmPasswordWarning.Text = Properties.Resources.passwordsDoNotMatchMessage;
                return;
            }

            try
            {
                List<UpdatePasswordResponse> updatePasswordResp = await _dapperManagement.UpdatePassword(
                    UserID: 2,
                    currentPasswordTextBox.Text, newPasswordTextBox.Text);

                if (updatePasswordResp[0].UpdatePasswordStatus == "Password updated successfully.")
                {
                    logger.Info("Password changed successfully.");
                    msgBox msgBox = new msgBox("Password Change Successfull", "passwordConfirmationMessage");
                    msgBox.ShowDialog();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    logger.Error("Password change error.");
                    msgBox msgBox = new msgBox("Password Change Error", "errorConfirmationMessage");
                    msgBox.ShowDialog();
                    DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "An error occurred while changing the password.");
                // Handle the exception appropriately, e.g., display an error message
                msgBox msgBox = new msgBox("Password Change Error", "errorConfirmationMessage.");
                msgBox.ShowDialog();
                DialogResult = DialogResult.Cancel;
            }
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
