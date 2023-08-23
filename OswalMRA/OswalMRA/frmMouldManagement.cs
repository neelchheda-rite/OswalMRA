//using NLog;
using OswalMRA.DAL;
using NLog;
using OswalMRA.MessageBox;
using OswalMRA.COMMON.Models;

namespace OswalMRA
{
    public partial class frmMouldManagement : Form
    {
        //private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly IDBRepository _dapperManagement;
        private List<mouldDetails> mouldDetails;  // Declare the list at the class level

        public frmMouldManagement()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeMoulds();  // Call the method to populate the moulds list
        }

        // ... other methods ...

        private void InitializeMoulds()
        {
            // Initialize and populate the moulds list
            mouldDetails = new List<mouldDetails>
            {
                new mouldDetails { mouldId = 1, mouldCode = "M00001", mouldName = "Mould 1", description = "Mould Desc 1", row = 1, col = 1 },
                new mouldDetails { mouldId = 2, mouldCode = "M00002", mouldName = "Mould 2", description = "Mould Desc 2", row = 2, col = 2 },
                new mouldDetails { mouldId = 3, mouldCode = "M00003", mouldName = "Mould 3", description = "Mould Desc 3", row = 3, col = 3 }
            };

            // Bind the data to the DataGridView
            dataGridView1.DataSource = mouldDetails;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            // Create columns
            DataGridViewTextBoxColumn mouldIDColumn = new DataGridViewTextBoxColumn();
            mouldIDColumn.DataPropertyName = "MouldID";
            mouldIDColumn.HeaderText = "MouldID";

            DataGridViewTextBoxColumn mouldCodeColumn = new DataGridViewTextBoxColumn();
            mouldCodeColumn.DataPropertyName = "MouldCode";
            mouldCodeColumn.HeaderText = "MouldCode";

            DataGridViewTextBoxColumn mouldNameColumn = new DataGridViewTextBoxColumn();
            mouldNameColumn.DataPropertyName = "MouldName";
            mouldNameColumn.HeaderText = "MouldName";

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.DataPropertyName = "Description";
            descriptionColumn.HeaderText = "Description";

            DataGridViewTextBoxColumn rowColumn = new DataGridViewTextBoxColumn();
            rowColumn.DataPropertyName = "Row";
            rowColumn.HeaderText = "Row";

            DataGridViewTextBoxColumn colColumn = new DataGridViewTextBoxColumn();
            colColumn.DataPropertyName = "Col";
            colColumn.HeaderText = "Col";

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            // Add columns to DataGridView
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
                mouldIDColumn, mouldCodeColumn, mouldNameColumn, descriptionColumn, rowColumn, colColumn, editButtonColumn, deleteButtonColumn
            });

            // Subscribe to the CellClick event of the DataGridView
            dataGridView1.CellClick += dataGridView1_CellContentClickAsync;
        }
        private async void dataGridView1_CellContentClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
                {
                    int mouldID = (int)dataGridView1.Rows[e.RowIndex].Cells["MouldID"].Value;
                    // Perform the edit action here using the mouldID
                    //MessageBox.Show($"Edit mould with MouldID: {mouldID}");
                    msgBox msgBox = new("", "");
                    msgBox.Show();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
                {
                    /* Neel's code
                    int mouldID = (int)dataGridView1.Rows[e.RowIndex].Cells["MouldID"].Value;
                    // Perform the delete action here using the mouldID
                    //MessageBox.Show($"Delete mould with MouldID: {mouldID}");
                    msgBox msgBox = new("", "");
                    msgBox.Show();*/
                    int mouldID = (int)dataGridView1.Rows[e.RowIndex].Cells["MouldID"].Value;

                    await deleteMouldsAync(mouldID);

                }
            }
        }
        private void addMouldBtn_Click_1(object sender, EventArgs e)
        {
            frmNewMould addMouldForm = new frmNewMould();
            if (addMouldForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private async Task deleteMouldsAync(int mouldID)
        {
            using (var optionBox = new optionMsgBox("Confirmation", "Are you sure?"))
            {
                var result1 = optionBox.ShowDialog();

                if (result1 == DialogResult.Yes)
                {
                    var deleteResult1 = await _dapperManagement.DeleteMould(mouldID);
                    Console.WriteLine(deleteResult1);
                }
                else
                {
                    Console.WriteLine("Operation cancelled.");
                }
            }
        }
    }
}
