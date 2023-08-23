

namespace OswalMRA
{
    public partial class currentStatusForm : Form
    {
        public currentStatusForm()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            DataGridView dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = false
            };

            // Create columns
            dataGridView1.Columns.Add("Mould", "Mould");
            dataGridView1.Columns.Add("Row", "Row");
            dataGridView1.Columns.Add("Column", "Column");
            dataGridView1.Columns.Add("Status", "Status");
            dataGridView1.Columns.Add("User", "User");
            dataGridView1.Columns.Add("Date", "Date");

            // Add DataGridView to form
            Controls.Add(dataGridView);

            // Add example data
            dataGridView1.Rows.Add("M1", 1, 2, "Active", "User1", DateTime.Now);
            dataGridView1.Rows.Add("M2", 3, 4, "Inactive", "User2", DateTime.Now.AddDays(-1));
            dataGridView1.Rows.Add("M3", 5, 6, "Active", "User3", DateTime.Now.AddDays(-2));
        }
     
    }
}
