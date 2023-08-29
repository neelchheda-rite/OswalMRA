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
        }

        private async void LoadUserData()
        {
            try
            {
                List<User> users = await _dapperManagement.GetUsers();
                dgvUserManagement.DataSource = users;

                foreach (DataGridViewRow row in dgvUserManagement.Rows)
                {
                    row.Cells["Edit"].Value = "Edit";
                    row.Cells["Delete"].Value = "Delete";
                }
            }
            catch (Exception ex)
            {
                // Log the exception details
                Console.WriteLine("Error loading user data: " + ex.Message);
                msgBox msgBox = new msgBox("An error occurred while loading user data.", "Error");
                msgBox.ShowDialog();
                DialogResult = DialogResult.OK;
            }
        }

        private void dgvUserManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvUserManagement.Columns["Delete"].Index)
                {
                    // ... Your existing code for handling delete action
                }
                else if (e.ColumnIndex == dgvUserManagement.Columns["Edit"].Index)
                {
                    // ... Your existing code for handling edit action
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNewUser addMouldForm = new addNewUser();
            if (addMouldForm.ShowDialog() == DialogResult.OK)
            {
                LoadUserData(); // Refresh the user data after adding a new user
            }
        }
    }
}