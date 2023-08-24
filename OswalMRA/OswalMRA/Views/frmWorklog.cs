

using OswalMRA.COMMON.Models;
using OswalMRA.MessageBox;
using PresentationControls;

namespace OswalMRA
{
    public partial class frmWorklog : Form
    {
        private StatusList _StatusList;

        private ListSelectionWrapper<Status> StatusSelections;
        public frmWorklog()
        {
            InitializeComponent();
            dgvWorklog.ReadOnly = true;
            dgvWorklog.DefaultCellStyle.ForeColor = Color.Black;
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

            dgvWorklog.Columns.Add("Mould", "Mould");
            dgvWorklog.Columns.Add("Row", "Row");
            dgvWorklog.Columns.Add("Column", "Column");
            dgvWorklog.Columns.Add("Status", "Status");
            dgvWorklog.Columns.Add("User", "User");
            dgvWorklog.Columns.Add("Date", "Date");

            // Add DataGridView to form
            // Set the header style to bold and larger
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Font = new Font(dgvWorklog.Font.FontFamily, 12, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvWorklog.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvWorklog.AllowUserToAddRows = false;

            // Add example data           
            dgvWorklog.Rows.Add(1, 1, 2, "Active", "User1", DateTime.Now);
            dgvWorklog.Rows.Add(2, 3, 4, "Inactive", "User2", DateTime.Now.AddDays(-1));
            dgvWorklog.Rows.Add(3, 5, 6, "Active", "User3", DateTime.Now.AddDays(-2));
        }


        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvWorklog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == dgvWorklog.Columns["DeleteButtonColumn"].Index)
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

        private void frmWorklog_Load(object sender, EventArgs e)
        {
            
                _StatusList = new StatusList();

                _StatusList.Add(new Status(1, "New"));
                _StatusList.Add(new Status(2, "Loaded"));
                _StatusList.Add(new Status(3, "Inserted"));
                Status UpdatedStatus = new Status(4, "Updated");
                _StatusList.Add(UpdatedStatus);
                _StatusList.Add(new Status(5, "Deleted"));

                StatusSelections = new ListSelectionWrapper<Status>(_StatusList, "Name");

                checkBoxComboBox5.DataSource = StatusSelections;
            checkBoxComboBox5.DisplayMemberSingleItem = "Name";
            checkBoxComboBox5.DisplayMember = "NameConcatenated";
            checkBoxComboBox5.ValueMember = "Selected";

            checkBoxComboBox5.CheckBoxItems[3].DataBindings.DefaultDataSourceUpdateMode
                    = DataSourceUpdateMode.OnPropertyChanged;
            checkBoxComboBox5.DataBindings.DefaultDataSourceUpdateMode
                    = DataSourceUpdateMode.OnPropertyChanged;
            
        }
    }
    
}
