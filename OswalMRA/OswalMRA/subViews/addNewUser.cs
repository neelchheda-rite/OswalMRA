using OswalMRA.MessageBox;
using OswalMRA.DAL;
using System.Data;
using OswalMRA.COMMON.Models;


namespace OswalMRA
{
    public partial class addNewUser : Form
    {
        private bool isActive;

        private byte roleID = 3;

        private readonly IDBRepository _dapperManagement;
        public addNewUser()
        {
            _dapperManagement = new DBRepository();
            InitializeComponent();
            cmbRole.Items.AddRange(new string[] { "Worker", "Supervisor" });
            cmbRole.SelectedIndex = 0;
        }



        private void txtBoxBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxIsActive_CheckedChanged(object sender, EventArgs e)
        {
            isActive = checkBoxIsActive.Checked;
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem != null)
            {
                string selectedRole = cmbRole.SelectedItem.ToString();

                if (selectedRole == "Worker")
                {
                    roleID = 3;
                }
                else if (selectedRole == "Supervisor")
                {
                    roleID = 1;
                }
            }
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtBoxName.Text;
                int selectedRoleIndex = cmbRole.SelectedIndex;
                byte roleID = (byte)(selectedRoleIndex == 0 ? 3 : 1);
                bool isActive = checkBoxIsActive.Checked;

                // Call the InsertUser method
                await _dapperManagement.InsertUser(userName, roleID, isActive);

                msgBox msgBox = new msgBox("User has been created successfully.", "Success");
                msgBox.ShowDialog();

                if (msgBox.DialogResult == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxName.Clear();
            cmbRole.SelectedIndex = 0;
            checkBoxIsActive.Checked = false;

        }
    }
}
