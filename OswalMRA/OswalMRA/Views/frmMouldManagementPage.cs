using NLog;
using OswalMRA.MessageBox;

namespace OswalMRA
{
    public partial class frmMouldManagementPage : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public frmMouldManagementPage()
        {
            InitializeComponent();
            InitializeDataGridView();
            dgvMouldManagement.ReadOnly = true;
        }

        private void InitializeDataGridView()
        {
            dgvMouldManagement.AutoGenerateColumns = false;

            // Create columns
            DataGridViewTextBoxColumn mouldIDColumn = new DataGridViewTextBoxColumn();
            mouldIDColumn.DataPropertyName = "MouldID";
            mouldIDColumn.HeaderText = "MouldID";

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.DataPropertyName = "Description";
            descriptionColumn.HeaderText = "Description";

            DataGridViewTextBoxColumn rowColumn = new DataGridViewTextBoxColumn();
            rowColumn.DataPropertyName = "Row";
            rowColumn.HeaderText = "Row";

            DataGridViewTextBoxColumn colColumn = new DataGridViewTextBoxColumn();
            colColumn.DataPropertyName = "Column";
            colColumn.HeaderText = "Column";

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.FillWeight = 70;
            editButtonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.FillWeight = 70;
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            // Add columns to DataGridView
            dgvMouldManagement.Columns.AddRange(new DataGridViewColumn[] {
                mouldIDColumn, descriptionColumn, rowColumn, colColumn, editButtonColumn, deleteButtonColumn
            });
            dgvMouldManagement.ColumnHeadersDefaultCellStyle.Font = new Font(dgvMouldManagement.Font, FontStyle.Bold); // Make headers bold
            dgvMouldManagement.ColumnHeadersDefaultCellStyle.Font = new Font(dgvMouldManagement.Font.FontFamily, 12, FontStyle.Bold); // You can adjust font size

            foreach (DataGridViewColumn column in dgvMouldManagement.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            dgvMouldManagement.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Align text to middle

            // Populate DataGridView with dummy data
            PopulateMouldData();
        }
        private void PopulateMouldData()
        {
            // Dummy data
            var moulds = new List<Mould>
            {
                new Mould { MouldID = 1, Description = "Mould 1", Row = 1, Column = 1 },
                new Mould { MouldID = 2, Description = "Mould 2", Row = 2, Column = 2 },
                new Mould { MouldID = 3, Description = "Mould 3", Row = 3, Column = 3 }
            };

            // Bind the data to the DataGridView
            dgvMouldManagement.DataSource = moulds;
        }
        

        private void addBtn_Click(object sender, EventArgs e)
        {
            addNewMould addMouldForm = new addNewMould();
            if (addMouldForm.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Retrieve the clear confirmation message from the resource file
            string clearConfirmationMessage = Properties.Resources.ResourceManager.GetString("ClearMessageConfirmation");

            // Show confirmation dialog for Clear using optionMsgBox
            optionMsgBox confirmationBox = new optionMsgBox("Clear Confirmation", "clearConfirmationMessage");
            if (confirmationBox.ShowDialog() == DialogResult.Yes)
            {
                // Perform the clear action
                // Your code to clear data goes here
            }
        }

        private void dgvMouldManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvMouldManagement.Columns["Delete"].Index)
                {
                    // Show confirmation dialog for Delete using optionMsgBox
                    optionMsgBox confirmationBox = new optionMsgBox("Delete Confirmation", "deleteConfirmationMessage");
                    if (confirmationBox.ShowDialog() == DialogResult.Yes)
                    {
                        // Perform the delete action
                    }
                }
            }
        }
    }
    public class Mould
    {
        public int MouldID { get; set; }
        public string Description { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
    }
}
