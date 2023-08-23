//using NLog;

using OswalMRA.MessageBox;

namespace OswalMRA
{
    public partial class mouldManagementForm : Form
    {
        //private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public mouldManagementForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            dataGridView1.ReadOnly = true;
            //logger.Info("Main form initialized.");
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

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
                mouldIDColumn, descriptionColumn, rowColumn, colColumn, editButtonColumn, deleteButtonColumn
            });

            // Populate DataGridView with dummy data
            PopulateMouldData();
        }
        private void PopulateMouldData()
        {
            // Dummy data
            var moulds = new List<Mould>
            {
                new Mould { MouldID = 1, Description = "Mould 1", Row = 1, Col = 1 },
                new Mould { MouldID = 2, Description = "Mould 2", Row = 2, Col = 2 },
                new Mould { MouldID = 3, Description = "Mould 3", Row = 3, Col = 3 }
            };

            // Bind the data to the DataGridView
            dataGridView1.DataSource = moulds;
        }
   private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["EditButtonColumn"].Index)
                {
                    int mouldID = (int)dataGridView1.Rows[e.RowIndex].Cells["MouldID"].Value;
                    // Perform the edit action here using the mouldID
                    //MessageBox.Show($"Edit mould with MouldID: {mouldID}");
                    msgBox msgBox = new("","");
                    msgBox.Show();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["DeleteButtonColumn"].Index)
                {
                    int mouldID = (int)dataGridView1.Rows[e.RowIndex].Cells["MouldID"].Value;
                    // Perform the delete action here using the mouldID
                    //MessageBox.Show($"Delete mould with MouldID: {mouldID}");
                    msgBox msgBox = new("", "");
                    msgBox.Show();
                }
            }
        }
        private void addMouldBtn_Click_1(object sender, EventArgs e)
        {
            addNewMould addMouldForm = new addNewMould();
            if (addMouldForm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
    public class Mould
    {
        public int MouldID { get; set; }
        public string Description { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
    }
}
