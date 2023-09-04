<<<<<<< Updated upstream
﻿using OswalMRA.MessageBox;
using OswalMRA.DAL;
=======
﻿using OswalMRA.COMMON.Models;
using OswalMRA.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
>>>>>>> Stashed changes
using System.Data;
using OswalMRA.COMMON.Models;


namespace OswalMRA
{
    public partial class addNewUser : Form
    {
        private bool isActive;
        private byte roleID = 3;
        private readonly IDBRepository _dapperManagement;

<<<<<<< Updated upstream
        public addNewUser()
=======
namespace OswalMRA.subViews
{
    public partial class addNewUser : Form
    {
        private UserResponse _userData;
        private bool Active;
        private byte RoleID = 3;
        private readonly IDBRepository _dapperManagement;
        public addNewUser(UserResponse userData) // Accept userData as a parameter
>>>>>>> Stashed changes
        {
            _dapperManagement = new DBRepository();
            InitializeComponent();
<<<<<<< Updated upstream
            cmbRole.Items.AddRange(new string[] { "Worker", "Supervisor" });
            cmbRole.SelectedIndex = 0;
        }
        public void SetUserData(UserResponse userData)
        {
            txtBoxName.Text = userData.UserName;
            // Set other form controls based on userData
            roleID = (byte)userData.RoleID; // Explicit cast to byte
            checkBoxIsActive.Checked = userData.IsActive;
        }

        private void checkBoxIsActive_CheckedChanged(object sender, EventArgs e)
=======
            _dapperManagement = new DBRepository();
            _userData = userData;

            comboBox1.Items.AddRange(new string[] { "Worker", "Supervisor" });
            comboBox1.SelectedIndex = 0;
            textBox1.Focus();
            textBox2.Focus();
            comboBox1.Focus();

            if (_userData != null)
            {
                SetUserData(_userData);
            }
        }

        public void SetUserData(UserResponse userData)
        {
            // Populate the form fields with the provided user data
            textBox1.Text = userData.UserName;
            textBox2.Text = userData.ExternalID;
            comboBox1.SelectedIndex = userData.RoleID == 3 ? 0 : 1; // Assuming roles are "Worker" and "Admin"


            // Set other properties or fields as needed
        }


        private void closeLabel_MouseEnter(object sender, EventArgs e)
>>>>>>> Stashed changes
        {
            isActive = checkBoxIsActive.Checked;
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
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
=======
            closeLabel.BackColor = Color.FromArgb(41, 128, 185);
>>>>>>> Stashed changes
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string UserName = txtBoxName.Text;
                int selectedRoleIndex = cmbRole.SelectedIndex;
                byte RoleID = (byte)(selectedRoleIndex == 0 ? 3 : 1);
                bool IsActive = checkBoxIsActive.Checked;

                // Call the InsertUser method
                await _dapperManagement.InsertUser(UserName, RoleID, IsActive);

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
                msgBox msgBox = new msgBox("An error occurred while creating the user.", "Error");
                msgBox.ShowDialog();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxName.Clear();
            cmbRole.SelectedIndex = 0;
            checkBoxIsActive.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedRole = comboBox1.SelectedItem.ToString();

                if (selectedRole == "Worker")
                {
                    RoleID = 3;
                }
                else if (selectedRole == "Supervisor")
                {
                    RoleID = 2;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string UserName = textBox1.Text;
                    string ExternalID = textBox2.Text;
                    byte roleId = this.RoleID;

                    if (_userData == null)
                    {
                        // Adding a new user
                        await _dapperManagement.InsertUser(UserName, roleId, ExternalID);
                        singleMsgBox msgBox = new singleMsgBox("User has been created successfully.", "Success");
                        msgBox.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        await _dapperManagement.UpdateUser(UserName, roleId, ExternalID);
                        singleMsgBox msgBox = new singleMsgBox("User has been updated successfully.", "Success");
                        msgBox.ShowDialog();
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    singleMsgBox msgBox = new singleMsgBox("An error occurred while creating the user.", "Error");
                    msgBox.ShowDialog();
                }

            }
        }
    }
}
