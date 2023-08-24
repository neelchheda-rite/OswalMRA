using NLog;
using OswalMRA.MessageBox;
using OswalMRA.COMMON;
using OswalMRA.Properties;
using OswalMRA.COMMON.Models;

namespace OswalMRA
{
    public partial class frmMouldPage : Form
    {
        //private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public frmMouldPage()
        {
            InitializeComponent();
            InitializeDataGridView();
            dvgMouldManagement.ReadOnly = true;
        }

        private void InitializeDataGridView()
        {
            dvgMouldManagement.AutoGenerateColumns = false;

            // Create columns
            DataGridViewTextBoxColumn mouldCodeColumn = new DataGridViewTextBoxColumn();
            mouldCodeColumn.DataPropertyName = "mouldCode";
            mouldCodeColumn.Name = "mouldCode";
            mouldCodeColumn.HeaderText = "Mould Code";
            mouldCodeColumn.Name = "mouldCode";

            DataGridViewTextBoxColumn mouldNameColumn = new DataGridViewTextBoxColumn();
            mouldNameColumn.DataPropertyName = "mouldName";
            mouldNameColumn.Name = "mouldName";
            mouldNameColumn.HeaderText = "Mould Name";

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.DataPropertyName = "Description";
            descriptionColumn.Name = "description";
            descriptionColumn.HeaderText = "Description";

            DataGridViewTextBoxColumn rowColumn = new DataGridViewTextBoxColumn();
            rowColumn.DataPropertyName = "row";
            rowColumn.Name = "row";
            rowColumn.HeaderText = "Row";

            DataGridViewTextBoxColumn colColumn = new DataGridViewTextBoxColumn();
            colColumn.DataPropertyName = "col";
            colColumn.Name = "column";
            colColumn.HeaderText = "Coloumn";

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.Name = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            // Add columns to DataGridView
            dvgMouldManagement.Columns.AddRange(new DataGridViewColumn[] {
                mouldCodeColumn, mouldNameColumn, descriptionColumn, rowColumn, colColumn, editButtonColumn, deleteButtonColumn
            });

            // Populate DataGridView with dummy data
            PopulateMouldData();
        }
        private void PopulateMouldData()
        {
            // Dummy data
            var moulds = new List<mouldDetails>
            {
                new mouldDetails { mouldCode = "M00001", mouldName = "Mould 1", description = "Desc Mould 1", row = 1, col = 1 },
                new mouldDetails { mouldCode = "M00002", mouldName = "Mould 2", description = "Desc Mould 2", row = 2, col = 2 },
                new mouldDetails { mouldCode = "M00003", mouldName = "Mould 3", description = "Desc Mould 3", row = 3, col = 3 }
            };

            // Bind the data to the DataGridView
            dvgMouldManagement.DataSource = moulds;
        }
        private void addMouldBtn_Click_1(object sender, EventArgs e)
        {
            frmNewMould frmNewMould = new();

            frmNewMould.StartPosition = FormStartPosition.CenterParent;
            if (frmNewMould.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void dvgMouldManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dvgMouldManagement.Columns["Edit"].Index)
                {
                    string mouldCode = (string)dvgMouldManagement.Rows[e.RowIndex].Cells["mouldCode"].Value;
                    msgBox msgBox = new("", "");
                    msgBox.Show();
                }
                else if (e.ColumnIndex == dvgMouldManagement.Columns["Delete"].Index)
                {
                    string mouldCode = (string)dvgMouldManagement.Rows[e.RowIndex].Cells["mouldCode"].Value;

                    optionMsgBox confirmationBox = new optionMsgBox("Delete Confirmation", "mouldDeleteConfirmation");
                    confirmationBox.Show();
                }
            }
        }
    }

}
