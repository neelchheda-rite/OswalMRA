
using OswalMRA.MessageBox;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OswalMRA
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
            // Set the form to maximize
            WindowState = FormWindowState.Maximized;
            // Create and populate DataGridView with dummy data

            PopulateDummyData();
            dgvInventory.ReadOnly = true;
            dgvInventory.DefaultCellStyle.ForeColor = Color.Black;

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
            dgvInventory.DataSource = dataTable;
            dgvInventory.AllowUserToAddRows = false;

            // Add Edit and Delete buttons as columns
            var editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "EditButtonColumn",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                FillWeight = 50

            };
            dgvInventory.Columns.Add(editButtonColumn);

            var deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "DeleteButtonColumn",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                FillWeight = 50
            };
            dgvInventory.Columns.Add(deleteButtonColumn);
            dgvInventory.ColumnHeadersDefaultCellStyle.Font = new Font(dgvInventory .Font, FontStyle.Bold);
            dgvInventory.ColumnHeadersDefaultCellStyle.Font = new Font(dgvInventory.Font.FontFamily, 12, FontStyle.Bold);
            dgvInventory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == dgvInventory.Columns["DeleteButtonColumn"].Index)
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
    }
}
