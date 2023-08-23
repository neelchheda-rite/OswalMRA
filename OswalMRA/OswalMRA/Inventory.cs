
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OswalMRA
{
    public partial class Inventory : Form
    {
        public Inventory()
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
            
            dataTable.Rows.Add( DateTime.Now, "Mould A", "Slot 1", "Person 1");
            dataTable.Rows.Add( DateTime.Now.AddDays(1), "Mould B", "Slot 2", "Person 2");
            dataTable.Rows.Add( DateTime.Now.AddDays(2), "Mould C", "Slot 3", "Person 3");

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;
            dataGridView1.AllowUserToAddRows = false;

            // Add Edit and Delete buttons as columns
            var editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "EditButtonColumn",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                FillWeight = 50

            };
            dataGridView1.Columns.Add(editButtonColumn);

            var deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "DeleteButtonColumn",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                FillWeight = 50
  };
            dataGridView1.Columns.Add(deleteButtonColumn);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font.FontFamily, 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public class CheckedListBoxDropDown : ToolStripDropDown
        {
            private CheckedListBox checkedListBox;

            public CheckedListBoxDropDown()
            {
                checkedListBox = new CheckedListBox();
                checkedListBox.Items.AddRange(new string[] { "Option 1", "Option 2", "Option 3", "Option 4", "Option 5", "Option 6" });

                ToolStripControlHost host = new ToolStripControlHost(checkedListBox);
                host.Margin = Padding.Empty;
                host.Padding = Padding.Empty;

                this.Padding = Padding.Empty;
                this.Items.Add(host);
            }
            
        }
      
    }
}
