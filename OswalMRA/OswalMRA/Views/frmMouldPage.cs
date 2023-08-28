using OswalMRA.COMMON.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OswalMRA.Views {
    public partial class frmMouldPage : Form {
        public frmMouldPage()
        {
            InitializeComponent();
            InitializeDataGridView();
            dataTable.ReadOnly = true;
        }
        private void InitializeDataGridView()
        {
            dataTable.AutoGenerateColumns = false;
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

            DataGridViewTextBoxColumn row = new()
            {
                DataPropertyName = "row",
                Name = "row",
                HeaderText = "Row"
            };

            DataGridViewButtonColumn edit = new()
            {
                HeaderText = "Action",
                Text = "Edit",
                Name = "edit",
            };
            edit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            edit.DefaultCellStyle.Padding = new Padding(2,2,2,2);
            edit.UseColumnTextForButtonValue = true;
            edit.Width = 75;

            DataGridViewButtonColumn delete = new()
            {
                HeaderText = "Action",
                Text = "Delete",
                Name = "delete",
            };
            delete.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            delete.DefaultCellStyle.Padding = new Padding(0);
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 75;

            dataTable.Columns.AddRange(new DataGridViewColumn[]{code,name,description,column,row,edit,delete});

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
            dataTable.DataSource = moulds;
        }
    }
}
