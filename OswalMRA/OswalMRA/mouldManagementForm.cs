using NLog;

namespace OswalMRA
{
    public partial class mouldManagementForm : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public mouldManagementForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            dataGridView1.ReadOnly = true;
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
            deleteButtonColumn.FillWeight = 70;
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            // Add columns to DataGridView
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
                mouldIDColumn, descriptionColumn, rowColumn, colColumn, editButtonColumn, deleteButtonColumn
            });
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold); // Make headers bold
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font.FontFamily, 12, FontStyle.Bold); // You can adjust font size

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Align text to middle

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
            dataGridView1.DataSource = moulds;
        }
   private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    if (e.ColumnIndex == dataGridView1.Columns["EditButtonColumn"].Index)
            //    {
            //        int mouldID = (int)dataGridView1.Rows[e.RowIndex].Cells["MouldID"].Value;
            //        // Perform the edit action here using the mouldID
            //        MessageBox.Show($"Edit mould with MouldID: {mouldID}");
            //    }
            //    else if (e.ColumnIndex == dataGridView1.Columns["DeleteButtonColumn"].Index)
            //    {
            //        int mouldID = (int)dataGridView1.Rows[e.RowIndex].Cells["MouldID"].Value;
            //        // Perform the delete action here using the mouldID
            //        MessageBox.Show($"Delete mould with MouldID: {mouldID}");
            //    }
            //}
        }    

        private void addBtn_Click(object sender, EventArgs e)
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
        public int Column { get; set; }
    }
}
