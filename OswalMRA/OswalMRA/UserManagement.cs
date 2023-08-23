

namespace OswalMRA
{
    
    public partial class UserManagement : Form
    {

        
        public UserManagement()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

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
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center-align button
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.DefaultCellStyle.Padding = new Padding(0); // Reset padding
            editButtonColumn.Width = 50; // Set button width           

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.FillWeight = 50;
            deleteButtonColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center-align button
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.DefaultCellStyle.Padding = new Padding(0); // Reset padding
            deleteButtonColumn.Width = 50; // Set button width  

            // Add columns to DataGridView
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
                userIDColumn, userNameColumn, roleColumn, editButtonColumn, deleteButtonColumn
            });
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold); // Make headers bold
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font.FontFamily, 12, FontStyle.Bold); // You can adjust font size

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Align text to middle

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
            dataGridView1.DataSource = users; 
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == dataGridView1.Columns["EditButtonColumn"].Index)
                    {
                        int userID = (int)dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value;
                        // Perform the edit action here using the userID
                        //MessageBox.Show($"Edit user with UserID: {userID}");
                    }
                    else if (e.ColumnIndex == dataGridView1.Columns["DeleteButtonColumn"].Index)
                    {
                        int userID = (int)dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value;
                        // Perform the delete action here using the userID
                        //MessageBox.Show($"Delete user with kUserID: {userID}");
                    }
                }
            }

        }
             

        private void addBtn_Click(object sender, EventArgs e)
        {

            addNewUser addMouldForm = new addNewUser();
            if (addMouldForm.ShowDialog() == DialogResult.OK)
            {

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
