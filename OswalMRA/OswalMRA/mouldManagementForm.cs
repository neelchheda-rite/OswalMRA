//using NLog;
using OswalMRA.DAL;
using NLog;
using OswalMRA.MessageBox;

namespace OswalMRA
{
    public partial class mouldManagementForm : Form
    {
        //private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly IDBRepository _dapperManagement;
        private List<Mould> moulds;  // Declare the list at the class level

        public mouldManagementForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeMoulds();  // Call the method to populate the moulds list
        }

        // ... other methods ...

        private void InitializeMoulds()
        {
            // Initialize and populate the moulds list
            moulds = new List<Mould>
            {
                new Mould { MouldID = 1, MouldCode = "M00001", MouldName = "Mould 1", Description = "Mould Desc 1", Row = 1, Col = 1 },
                new Mould { MouldID = 2, MouldCode = "M00002", MouldName = "Mould 2", Description = "Mould Desc 2", Row = 2, Col = 2 },
                new Mould { MouldID = 3, MouldCode = "M00003", MouldName = "Mould 3", Description = "Mould Desc 3", Row = 3, Col = 3 }
            };

            // Bind the data to the DataGridView
            dataGridView1.DataSource = moulds;
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
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["editButtonColumn"].Index)
                {
                    int mouldID = (int)dataGridView1.Rows[e.RowIndex].Cells["MouldID"].Value;
                    // Perform the edit action here using the mouldID
                    //MessageBox.Show($"Edit mould with MouldID: {mouldID}");
                    msgBox msgBox = new("", "");
                    msgBox.Show();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["deleteButtonColumn"].Index)
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
    public class Mould
    {
        public int MouldID { get; set; }
        public string MouldCode { get; set; }
        public string MouldName { get; set; }
        public string Description { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
    }
}
