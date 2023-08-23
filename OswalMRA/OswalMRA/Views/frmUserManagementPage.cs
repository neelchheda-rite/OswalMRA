using OswalMRA.MessageBox;
using OswalMRA.Properties;
using System.Data.Common;
using System.Numerics;
using System.Text.RegularExpressions;
using System;
using System.Windows.Forms;


namespace OswalMRA
{

    public partial class frmUserManagementPage : Form
    {


        public frmUserManagementPage()
        {
            InitializeComponent();
            dgvUserManagement.ReadOnly = true;
            dgvUserManagement.DefaultCellStyle.ForeColor = Color.Black;
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            dgvUserManagement.AutoGenerateColumns = false;

            // Create columns
            DataGridViewTextBoxColumn userIDColumn = new DataGridViewTextBoxColumn();
            userIDColumn.DataPropertyName = "UserID";
            userIDColumn.HeaderText = "UserID";

            DataGridViewTextBoxColumn userNameColumn = new DataGridViewTextBoxColumn();
            userNameColumn.DataPropertyName = "UserName";
            userNameColumn.HeaderText = "Username";

            DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
            roleColumn.DataPropertyName = "Role";
            roleColumn.HeaderText = "Role";

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.FillWeight = 50;
            editButtonColumn.Name = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center-align button
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.DefaultCellStyle.Padding = new Padding(0); // Reset padding
            editButtonColumn.Width = 50; // Set button width           

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.FillWeight = 50;
            deleteButtonColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center-align button
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.DefaultCellStyle.Padding = new Padding(0); // Reset padding
            deleteButtonColumn.Width = 50; // Set button width  

            // Add columns to DataGridView
            dgvUserManagement.Columns.AddRange(new DataGridViewColumn[] {
                userIDColumn, userNameColumn, roleColumn, editButtonColumn, deleteButtonColumn
            });
            dgvUserManagement.ColumnHeadersDefaultCellStyle.Font = new Font(dgvUserManagement.Font, FontStyle.Bold); // Make headers bold
            dgvUserManagement.ColumnHeadersDefaultCellStyle.Font = new Font(dgvUserManagement.Font.FontFamily, 12, FontStyle.Bold); // You can adjust font size

            foreach (DataGridViewColumn column in dgvUserManagement.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            dgvUserManagement.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Align text to middle

            // Populate DataGridView with dummy data
            PopulateUserData();
        }
        private void PopulateUserData()
        {
            // Dummy data
            var users = new List<User>
         {
        new User { UserID = 1, UserName = "user1", Role = "Admin" },
        new User { UserID = 2, UserName = "user2", Role = "Supervisor" },
        new User { UserID = 3, UserName = "user3", Role = "Worker" }
          };

            // Bind the data to the DataGridView
            dgvUserManagement.DataSource = users;
        }


        private void dgvUserManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvUserManagement.Columns["Delete"].Index)
                {
                    // Show confirmation dialog for Delete using optionMsgBox
                    optionMsgBox confirmationBox = new optionMsgBox("Delete Confirmation", "DeleteConfirmationMessage");
                    if (confirmationBox.ShowDialog() == DialogResult.Yes)
                    {
                        // Perform the delete action
                    }
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            addNewUser addMouldForm = new addNewUser();
            if (addMouldForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Retrieve the clear confirmation message from the resource file
            string clearConfirmationMessage = Properties.Resources.ResourceManager.GetString("ClearMessageConfirmation");

            // Show confirmation dialog for Clear using optionMsgBox
            optionMsgBox confirmationBox = new optionMsgBox("Clear Confirmation", "ClearConfirmationMessage");
            if (confirmationBox.ShowDialog() == DialogResult.Yes)
            {
                // Perform the clear action
                // Your code to clear data goes here
            }
        }
    }
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
    }
}
