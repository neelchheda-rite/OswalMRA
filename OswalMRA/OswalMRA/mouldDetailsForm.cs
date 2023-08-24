using OswalMRA.Properties; 
namespace OswalMRA
{
    public partial class mouldDetailsfORM : Form
    {
        public mouldDetailsfORM()
        {
            InitializeComponent();
            // Set the form to maximize
            WindowState = FormWindowState.Maximized;
           // Create and populate DataGridView with dummy data
            PopulateDummyData();
            dataGridView1.ReadOnly = true;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }
        private void PopulateDummyData()
        {
            // Create a DataTable to hold the data
            var dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("Date", typeof(DateTime));
            dataTable.Columns.Add("Mould", typeof(string));
            dataTable.Columns.Add("Slot", typeof(string));
            dataTable.Columns.Add("Person", typeof(string));

            // Add some dummy data
            dataTable.Rows.Add(DateTime.Now, "Mould A", "Slot 1", "Person 1");
            dataTable.Rows.Add(DateTime.Now.AddDays(1), "Mould B", "Slot 2", "Person 2");
            dataTable.Rows.Add(DateTime.Now.AddDays(2), "Mould C", "Slot 3", "Person 3");

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;

            // Add Edit and Delete buttons as columns
            var editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "EditButtonColumn",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(editButtonColumn);

            var deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "DeleteButtonColumn",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(deleteButtonColumn);
        }

    }
}
