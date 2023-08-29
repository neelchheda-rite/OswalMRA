using OswalMRA.MessageBox;
using OswalMRA.DAL;
using OswalMRA.COMMON.Models;


namespace OswalMRA
{
    public partial class frmUserPage : Form
    {
        private readonly IDBRepository _dapperManagement;

        public frmUserPage()
        {
            InitializeComponent();
            dgvUserManagement.ReadOnly = true;
            dgvUserManagement.DefaultCellStyle.ForeColor = Color.Black;
            _dapperManagement = new DBRepository();
            InitializeDataGridView();
            LoadUserData();
        }

        private void InitializeDataGridView()
        {
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

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.Name = "Delete"; // Make sure this matches the actual column name
            deleteButtonColumn.FillWeight = 50;
            deleteButtonColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.DefaultCellStyle.Padding = new Padding(0);
            deleteButtonColumn.Width = 50;

            // Add the columns to the DataGridView
            dgvUserManagement.Columns.Add(editButtonColumn);
            dgvUserManagement.Columns.Add(deleteButtonColumn);
        }

        private async void LoadUserData()
        {
            try
            {
                List<UserResponse> users = await _dapperManagement.GetUsers();

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
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvUserManagement.Columns["Delete"].Index)
                {
                    // Show confirmation dialog for Delete using optionMsgBox
                    optionMsgBox confirmationBox = new optionMsgBox("Delete Confirmation", "deleteConfirmationMessage");
                    if (confirmationBox.ShowDialog() == DialogResult.Yes)
                    {
                        // Delete user logic
                        int userIDToDelete = (int)dgvUserManagement.Rows[e.RowIndex].Cells["UserID"].Value;
                        // Call delete method or logic here

                        LoadUserData();
                    }
                }
                else if (e.ColumnIndex == dgvUserManagement.Columns["Edit"].Index)
                {
                    // Edit user logic
                    int userIDToEdit = (int)dgvUserManagement.Rows[e.RowIndex].Cells["UserID"].Value;
                    // Call edit method or logic here

                    LoadUserData();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNewUser addMouldForm = new addNewUser();
            if (addMouldForm.ShowDialog() == DialogResult.OK)
            {
                LoadUserData();
            }
        }
    }
}