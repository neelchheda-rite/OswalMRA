

namespace OswalMRA
{
    public partial class Worklog : Form
    {
        public Worklog()
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
            // Set the header style to bold and larger
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Font = new Font(dataGridView1.Font.FontFamily, 12, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;
            dataGridView1.AllowUserToAddRows = false;

            // Add example data           
            dataGridView1.Rows.Add( 1, 1, 2, "Active", "User1", DateTime.Now);
            dataGridView1.Rows.Add( 2, 3, 4, "Inactive", "User2", DateTime.Now.AddDays(-1));
            dataGridView1.Rows.Add( 3, 5, 6, "Active", "User3", DateTime.Now.AddDays(-2));
        }


        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
