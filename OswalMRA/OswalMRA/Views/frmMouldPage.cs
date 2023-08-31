using OswalMRA.COMMON.Models;
using OswalMRA.subViews;

namespace OswalMRA.Views {
    public partial class frmMouldPage : Form {
        public frmMouldPage()
        {
            InitializeComponent();
            InitializeDataGridView();
            dataTableMould.ReadOnly = true;

        }
        private void InitializeDataGridView()
        {
            dataTableMould.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn code = new()
            {
                DataPropertyName = "code",
                Name = "code",
                HeaderText = "Code"
            };

            DataGridViewTextBoxColumn name = new()
            {
                DataPropertyName = "name",
                Name = "name",
                HeaderText = "Name"
            };

            DataGridViewTextBoxColumn description = new()
            {
                DataPropertyName = "description",
                Name = "description",
                HeaderText = "Description"
            };

            DataGridViewTextBoxColumn column = new()
            {
                DataPropertyName = "column",
                Name = "column",
                HeaderText = "Column"
            };
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            

            DataGridViewTextBoxColumn row = new()
            {
                DataPropertyName = "row",
                Name = "row",
                HeaderText = "Row"
            };
            row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewButtonColumn edit = new()
            {
                HeaderText = "Action",
                Text = "Edit",
                Name = "edit",
                DataPropertyName="Edit"
            };
            edit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            edit.DefaultCellStyle.Padding = new Padding(2,2,2,2);
            edit.UseColumnTextForButtonValue = true;
            edit.Width = 75;
            edit.FlatStyle = FlatStyle.Flat;
            edit.CellTemplate.Style.ForeColor = Color.FromArgb(105, 190, 40);
            edit.CellTemplate.Style.SelectionForeColor = Color.FromArgb(105, 190, 40);
            edit.CellTemplate.Style.SelectionBackColor = edit.CellTemplate.Style.BackColor;
            edit.ToolTipText = "";
            
            DataGridViewButtonColumn delete = new()
            {
                HeaderText = "Action",
                Text = "Delete",
                Name = "delete",
                DataPropertyName = "Delete"
            };
            delete.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            delete.DefaultCellStyle.Padding = new Padding(0);
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 75;
            delete.FlatStyle = FlatStyle.Flat;
            delete.CellTemplate.Style.ForeColor = Color.FromArgb(229,79,63);
            delete.CellTemplate.Style.SelectionForeColor = Color.FromArgb(229, 79, 63);
            delete.CellTemplate.Style.SelectionBackColor = delete.CellTemplate.Style.BackColor;
            delete.ToolTipText = "";

            dataTableMould.Columns.AddRange(new DataGridViewColumn[]{code,name,description,column,row,edit,delete});
            dataTableMould.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            PopulateMouldData();
        }
        private void PopulateMouldData()
        {
            var moulds = new List<mouldDataSource>
            {
                new mouldDataSource { code = "M00001", name = "Mould 1", description = "Desc Mould 1", row = 1, column = 1 },
                new mouldDataSource { code = "M00002", name = "Mould 2", description = "Desc Mould 2", row = 2, column = 2 },
                new mouldDataSource { code = "M00003", name = "Mould 3", description = "Desc Mould 3", row = 3, column = 3 },
                 new mouldDataSource { code = "M00001", name = "Mould 1", description = "Desc Mould 1", row = 1, column = 1 },
                new mouldDataSource { code = "M00002", name = "Mould 2", description = "Desc Mould 2", row = 2, column = 2 },
                new mouldDataSource { code = "M00003", name = "Mould 3", description = "Desc Mould 3", row = 3, column = 3 },
                 new mouldDataSource { code = "M00001", name = "Mould 1", description = "Desc Mould 1", row = 1, column = 1 },
                new mouldDataSource { code = "M00002", name = "Mould 2", description = "Desc Mould 2", row = 2, column = 2 },
                new mouldDataSource { code = "M00003", name = "Mould 3", description = "Desc Mould 3", row = 3, column = 3 },
                 new mouldDataSource { code = "M00001", name = "Mould 1", description = "Desc Mould 1", row = 1, column = 1 },
                new mouldDataSource { code = "M00002", name = "Mould 2", description = "Desc Mould 2", row = 2, column = 2 },
                new mouldDataSource { code = "M00003", name = "Mould 3", description = "Desc Mould 3", row = 3, column = 3 },
                 new mouldDataSource { code = "M00001", name = "Mould 1", description = "Desc Mould 1", row = 1, column = 1 },
                new mouldDataSource { code = "M00002", name = "Mould 2", description = "Desc Mould 2", row = 2, column = 2 },
                new mouldDataSource { code = "M00003", name = "Mould 3", description = "Desc Mould 3", row = 3, column = 3 },
                 new mouldDataSource { code = "M00001", name = "Mould 1", description = "Desc Mould 1", row = 1, column = 1 },
                new mouldDataSource { code = "M00002", name = "Mould 2", description = "Desc Mould 2", row = 2, column = 2 },
                new mouldDataSource { code = "M00003", name = "Mould 3", description = "Desc Mould 3", row = 3, column = 3 },
                 new mouldDataSource { code = "M00001", name = "Mould 1", description = "Desc Mould 1", row = 1, column = 1 },
                new mouldDataSource { code = "M00002", name = "Mould 2", description = "Desc Mould 2", row = 2, column = 2 },
                new mouldDataSource { code = "M00003", name = "Mould 3", description = "Desc Mould 3", row = 3, column = 3 },
                 new mouldDataSource { code = "M00001", name = "Mould 1", description = "Desc Mould 1", row = 1, column = 1 },
                new mouldDataSource { code = "M00002", name = "Mould 2", description = "Desc Mould 2", row = 2, column = 2 },
                new mouldDataSource { code = "M00003", name = "Mould 3", description = "Desc Mould 3", row = 3, column = 3 },
                 new mouldDataSource { code = "M00001", name = "Mould 1", description = "Desc Mould 1", row = 1, column = 1 },
                new mouldDataSource { code = "M00002", name = "Mould 2", description = "Desc Mould 2", row = 2, column = 2 },
                new mouldDataSource { code = "M00003", name = "Mould 3", description = "Desc Mould 3", row = 3, column = 3 },
                 new mouldDataSource { code = "M00001", name = "Mould 1", description = "Desc Mould 1", row = 1, column = 1 },
                new mouldDataSource { code = "M00002", name = "Mould 2", description = "Desc Mould 2", row = 2, column = 2 },
                new mouldDataSource { code = "M00003", name = "Mould 3", description = "Desc Mould 3", row = 3, column = 3 },
                 new mouldDataSource { code = "M00001", name = "Mould 1", description = "Desc Mould 1", row = 1, column = 1 },
                new mouldDataSource { code = "M00002", name = "Mould 2", description = "Desc Mould 2", row = 2, column = 2 },
                new mouldDataSource { code = "M00003", name = "Mould 3", description = "Desc Mould 3", row = 3, column = 3 }
            };
            dataTableMould.DataSource = moulds;
        }

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataTableMould.Columns["Delete"].Index)
                {

                    frmToast frmToast = new("Deleted successfully", "Error");
                    frmToast.ShowAtBottomCenter();
                }
                else if (e.ColumnIndex == dataTableMould.Columns["Edit"].Index)
                {

                    frmToast frmToast = new("Edited successfully", "Success");
                    frmToast.ShowAtBottomCenter();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNewMould addMouldTest = new();
            DialogResult mouldDIalogResult = addMouldTest.ShowDialog();
            if (mouldDIalogResult == DialogResult.Yes)
            {
                frmToast frmToast = new("Mould added successfully", "Success");
                frmToast.ShowAtBottomCenter();
            }
        }
    }
}
