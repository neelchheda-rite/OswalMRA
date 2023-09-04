<<<<<<< Updated upstream
﻿using OswalMRA.MessageBox;
using OswalMRA.DAL;
using OswalMRA.COMMON.Models;


namespace OswalMRA
{
    public partial class frmUserPage : Form
    {
        private readonly IDBRepository _dapperManagement;

=======
﻿using OswalMRA.COMMON.Models;
using OswalMRA.DAL;
using OswalMRA.subViews;
using System.Windows.Forms;

namespace OswalMRA.Views
{
    public partial class frmUserPage : Form {
        private readonly IDBRepository _dapperManagement;
>>>>>>> Stashed changes
        public frmUserPage()
        {
            InitializeComponent();
            dgvUserManagement.ReadOnly = true;
            dgvUserManagement.DefaultCellStyle.ForeColor = Color.Black;
            _dapperManagement = new DBRepository();
            InitializeDataGridView();
<<<<<<< Updated upstream
=======
            dataTableUser.ReadOnly = true;
            _dapperManagement = new DBRepository();
>>>>>>> Stashed changes
            LoadUserData();
        }

        private void InitializeDataGridView()
        {
<<<<<<< Updated upstream
            // ... Your existing code for adding columns

            // Add Edit and Delete columns
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.FillWeight = 50;
            editButtonColumn.Name = "Edit"; // Make sure this matches the actual column name
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            editButtonColumn.DefaultCellStyle.Padding = new Padding(0);
            editButtonColumn.Width = 50;
=======
            dataTableUser.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn id = new()
            {
                DataPropertyName = "UserID",
                Name = "UserID",
                HeaderText = "ID"
            };
            id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewTextBoxColumn ExternalID = new()
            {
                DataPropertyName = "ExternalID",
                Name = "ExternalID",
                HeaderText = "External ID"
            };
            ExternalID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewTextBoxColumn name = new()
            {
                DataPropertyName = "UserName",
                Name = "name",
                HeaderText = "Name"
            };
>>>>>>> Stashed changes

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.Name = "Delete"; // Make sure this matches the actual column name
            deleteButtonColumn.FillWeight = 50;
            deleteButtonColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.DefaultCellStyle.Padding = new Padding(0);
            deleteButtonColumn.Width = 50;

<<<<<<< Updated upstream
            // Add the columns to the DataGridView
            dgvUserManagement.Columns.Add(editButtonColumn);
            dgvUserManagement.Columns.Add(deleteButtonColumn);
        }

=======
            

            DataGridViewButtonColumn edit = new()
            {
                HeaderText = "Action",
                Text = "Edit",
                Name = "Edit",
                DataPropertyName = "Edit"
            };
            edit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            edit.DefaultCellStyle.Padding = new Padding(2, 2, 2, 2);
            edit.UseColumnTextForButtonValue = true;
            edit.Width = 75;
            edit.FlatStyle = FlatStyle.Flat;
            edit.CellTemplate.Style.ForeColor = Color.FromArgb(105, 190, 40);
            edit.CellTemplate.Style.SelectionForeColor = Color.FromArgb(105, 190, 40);
            edit.CellTemplate.Style.SelectionBackColor = edit.CellTemplate.Style.BackColor;
            edit.ToolTipText = "";

            DataGridViewButtonColumn delete = new()
            {
                HeaderText = "Action",
                Text = "Delete",
                Name = "Delete",
                DataPropertyName = "Delete"
            };
            delete.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            delete.DefaultCellStyle.Padding = new Padding(0);
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 75;
            delete.FlatStyle = FlatStyle.Flat;
            delete.CellTemplate.Style.ForeColor = Color.FromArgb(229, 79, 63);
            delete.CellTemplate.Style.SelectionForeColor = Color.FromArgb(229, 79, 63);
            delete.CellTemplate.Style.SelectionBackColor = delete.CellTemplate.Style.BackColor;
            delete.ToolTipText = "";

            dataTableUser.Columns.AddRange(new DataGridViewColumn[] {id, ExternalID,name, role, edit, delete });
            dataTableUser.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            //PopulateMouldData();
        }
>>>>>>> Stashed changes
        private async void LoadUserData()
        {
            try
            {
                List<UserResponse> users = await _dapperManagement.GetUsers();
<<<<<<< Updated upstream

                // Map RoleID to corresponding role names
                foreach (var user in users)
                {
                    if (user.RoleID == 1)
                    {
                        user.Role = "Supervisor";
                    }
                    else if (user.RoleID == 3)
                    {
                        user.Role = "Worker";
                    }
                }

                dgvUserManagement.DataSource = users;

                // Adjust column properties and add Edit and Delete buttons
                foreach (DataGridViewRow row in dgvUserManagement.Rows)
                {
                    row.Cells["Edit"].Value = "Edit";
                    row.Cells["Delete"].Value = "Delete";
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                msgBox msgBox = new msgBox("An error occurred while loading user data.", "Error");
                msgBox.ShowDialog();
                DialogResult = DialogResult.OK;
            }
        }

        private async void dgvUserManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
=======

                // Map RoleID to corresponding role names
                foreach (var user in users)
                {
                    if (user.RoleID == 2)
                    {
                        user.Role = "Supervisor";
                    }
                    else if (user.RoleID == 3)
                    {
                        user.Role = "Worker";
                    }
                }

                dataTableUser.DataSource = users;

                // Adjust column properties and add Edit and Delete buttons
                foreach (DataGridViewRow row in dataTableUser.Rows)
                {
                    row.Cells["Edit"].Value = "Edit";
                    row.Cells["Delete"].Value = "Delete";
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                singleMsgBox msgBox = new singleMsgBox("An error occurred while loading user data.", "Error");
                msgBox.ShowDialog();
                DialogResult = DialogResult.OK;
            }
        }
        //private void PopulateMouldData()
        //{
        //    var users = new List<User>
        //    {
        //        new User { ID = 1,ExternalID=1, Name= "user1", Role = "Admin" },
        //        new User { ID = 2,ExternalID=1, Name = "user2", Role = "Supervisor" },
        //        new User { ID = 3,ExternalID=1, Name = "user3", Role = "Worker" },
        //        new User { ID = 1,ExternalID=1, Name = "user1", Role = "Admin" },
        //        new User { ID = 2,ExternalID=1, Name = "user2", Role = "Supervisor" },
        //        new User { ID = 3,ExternalID=1, Name = "user3", Role = "Worker" },
        //        new User { ID = 1,ExternalID=1, Name = "user1", Role = "Admin" },
        //        new User { ID = 2,ExternalID=1, Name = "user2", Role = "Supervisor" },
        //        new User { ID = 1,ExternalID=1, Name = "user1", Role = "Admin" },
        //        new User { ID = 2,ExternalID=1, Name = "user2", Role = "Supervisor" },
        //        new User { ID = 1,ExternalID=1, Name = "user1", Role = "Admin" },
        //        new User { ID = 2,ExternalID=1, Name = "user2", Role = "Supervisor" },
        //        new User { ID = 3,ExternalID=1, Name = "user3", Role = "Worker" },
        //        new User { ID = 1,ExternalID=1, Name = "user1", Role = "Admin" },
        //        new User { ID = 2,ExternalID=1, Name = "user2", Role = "Supervisor" },
        //        new User { ID = 3,ExternalID=1, Name = "user3", Role = "Worker" },
        //        new User { ID = 1,ExternalID=1, Name = "user1", Role = "Admin" },
        //        new User { ID = 2,ExternalID=1, Name = "user2", Role = "Supervisor" },
        //        new User { ID = 3,ExternalID=1, Name = "user3", Role = "Worker" },
        //        new User { ID = 1,ExternalID=1, Name = "user1", Role = "Admin" },
        //        new User { ID = 2,ExternalID=1, Name = "user2", Role = "Supervisor" },
        //        new User { ID = 3,ExternalID=1, Name = "user3", Role = "Worker" },
        //        new User { ID = 1,ExternalID=1, Name = "user1", Role = "Admin" },
        //        new User { ID = 2,ExternalID=1, Name = "user2", Role = "Supervisor" },
        //        new User { ID = 3,ExternalID=1, Name = "user3", Role = "Worker" },
        //        new User { ID = 1,ExternalID=1, Name = "user1", Role = "Admin" },
        //        new User { ID = 2,ExternalID=1, Name = "user2", Role = "Supervisor" },
        //        new User { ID = 3,ExternalID=1, Name = "user3", Role = "Worker" },
        //        new User { ID = 1,ExternalID=1, Name = "user1", Role = "Admin" },
        //        new User { ID = 2,ExternalID=1, Name = "user2", Role = "Supervisor" },
        //        new User { ID = 3,ExternalID=1, Name = "user3", Role = "Worker" },
        //        new User { ID = 1,ExternalID=1, Name = "user1", Role = "Admin" },
        //        new User { ID = 2,ExternalID=1, Name = "user2", Role = "Supervisor" },
        //        new User { ID = 3,ExternalID=1, Name = "user3", Role = "Worker" },
        //        new User { ID = 1,ExternalID=1, Name = "user1", Role = "Admin" },
        //        new User { ID = 2,ExternalID=1, Name = "user2", Role = "Supervisor" },
        //        new User { ID = 3,ExternalID=1, Name = "user3", Role = "Worker" },
        //        new User { ID = 3,ExternalID=1, Name = "user3", Role = "Worker" },
        //        new User { ID = 3,ExternalID=1, Name = "user3", Role = "Worker" },
        //    };
        //    dataTableUser.DataSource = users;
        //}

        private async void dataTableUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
>>>>>>> Stashed changes
        {
            //if (e.ColumnIndex == dataTableUser.Columns["Edit"].Index)
            //{
            //    int userIDToEdit = (int)dataTableUser.Rows[e.RowIndex].Cells["UserID"].Value;

            //    // Retrieve user data by ID
            //    UserResponse userData = await _dapperManagement.GetUserByID(userIDToEdit);

            //    // Open the addNewUser form for editing
            //    addNewUser editForm = new addNewUser(userData); // Pass user data to the form
            //    DialogResult result = editForm.ShowDialog();

            //    // Refresh user data in the DataGridView after editing
            //    if (result == DialogResult.OK)
            //    {
            //        LoadUserData();
            //    }
            //}
            if (e.RowIndex >= 0)
            {
<<<<<<< Updated upstream
                if (e.ColumnIndex == dgvUserManagement.Columns["Edit"].Index)
                {
                    int userIDToEdit = (int)dgvUserManagement.Rows[e.RowIndex].Cells["UserID"].Value;

                    // Retrieve user data by ID
                    UserResponse userData = await _dapperManagement.GetUserByID(userIDToEdit);

                    // Open the addNewUser form for editing
                    addNewUser editForm = new addNewUser();
                    editForm.SetUserData(userData); // Set user data in the form
                    editForm.ShowDialog();

                    // Refresh user data in the DataGridView after editing
                    if (editForm.DialogResult == DialogResult.OK)
                    {
                        LoadUserData();
=======
                if (e.ColumnIndex == dataTableUser.Columns["Edit"].Index)
                {
                    int userIDToEdit = (int)dataTableUser.Rows[e.RowIndex].Cells["UserID"].Value;

                    // Retrieve user data by ID
                    UserResponse userData = await _dapperManagement.GetUserByID(userIDToEdit);

                    // Open the addNewUser form for editing
                    addNewUser editForm = new addNewUser(userData);
                    /* editForm.SetUserData(userData);*/ // Set user data in the form
                    editForm.ShowDialog();

                    // Refresh user data in the DataGridView after editing
                    if (editForm.DialogResult == DialogResult.OK)
                    {
                        LoadUserData();
                    }
                }
                if (e.ColumnIndex == dataTableUser.Columns["Delete"].Index)
                {
                    // Retrieve the UserID from the selected row
                    int userIDToDelete = (int)dataTableUser.Rows[e.RowIndex].Cells["UserID"].Value;

                    // Call the DeleteUser method
                    List<DeleteUserResponse> deleteUserResponseList = await _dapperManagement.DeleteUser(userIDToDelete);

                    // Check the delete status from the response
                    if (deleteUserResponseList.Count > 0)
                    {
                        string deleteStatus = deleteUserResponseList[0].DeleteStatus;

                        if (deleteStatus == "Success")
                        {
                            // Successful deletion, you can handle this as needed
                            singleMsgBox msgBox = new singleMsgBox("User deleted successfully.", "deleted");
                            msgBox.ShowDialog();
                            DialogResult = DialogResult.OK;
                            // Refresh the user data in the DataGridView
                            LoadUserData();
                        }
                        else
                        {
                            // Handle delete failure
                            singleMsgBox msgBox = new singleMsgBox("Failed to delete user.", "");
                        }
>>>>>>> Stashed changes
                    }
                }
                // ...
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            addNewUser addMouldForm = new addNewUser();
            if (addMouldForm.ShowDialog() == DialogResult.OK)
=======
            UserResponse newUser = new UserResponse
            {
                UserName = "NewUser", 
                ExternalID = "NewExternalID", 
                RoleID = 3 
            };

            addNewUser addNewUserForm = new addNewUser(newUser); // Pass the newUser data
            DialogResult dialogResult = addNewUserForm.ShowDialog();
            if (dialogResult == DialogResult.Yes)
>>>>>>> Stashed changes
            {
                LoadUserData();
            }
        }
    }
}