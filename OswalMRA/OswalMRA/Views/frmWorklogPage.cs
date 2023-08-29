using OswalMRA.COMMON.Models;
using PresentationControls;
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
    public partial class frmWorklogPage : Form {
        private StatusList _StatusList;

        private ListSelectionWrapper<Status> StatusSelections;
        public frmWorklogPage()
        {
            InitializeComponent();
            InitializeDataGridView();
            dataTableWorkLog.ReadOnly = true;
        }

        private void InitializeDataGridView()
        {
            dataTableWorkLog.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn mould = new()
            {
                DataPropertyName = "mould",
                Name = "mould",
                HeaderText = "Mould"
            };

            DataGridViewTextBoxColumn status = new()
            {
                DataPropertyName = "status",
                Name = "status",
                HeaderText = "Status"
            };

            DataGridViewTextBoxColumn user = new()
            {
                DataPropertyName = "user",
                Name = "user",
                HeaderText = "User"
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

            

            dataTableWorkLog.Columns.AddRange(new DataGridViewColumn[] { mould,status,user,column,row});
            dataTableWorkLog.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            PopulateMouldData();
        }
        private void PopulateMouldData()
        {
            var moulds = new List<workLog>
            {
                new workLog { mould = "M00001", status = "xyz", user = "User 1", row = 1, column = 1 },
                new workLog { mould = "M00002", status = "abc", user = "User 2", row = 2, column = 2 },
                new workLog { mould = "M00003", status = "pqr", user = "User 3", row = 3, column = 3 },
                new workLog { mould = "M00001", status = "xyz", user = "User 1", row = 1, column = 1 },
                new workLog { mould = "M00002", status = "abc", user = "User 2", row = 2, column = 2 },
                new workLog { mould = "M00003", status = "pqr", user = "User 3", row = 3, column = 3 },
                new workLog { mould = "M00001", status = "xyz", user = "User 1", row = 1, column = 1 },
                new workLog { mould = "M00002", status = "abc", user = "User 2", row = 2, column = 2 },
                new workLog { mould = "M00003", status = "pqr", user = "User 3", row = 3, column = 3 },
                new workLog { mould = "M00001", status = "xyz", user = "User 1", row = 1, column = 1 },
                new workLog { mould = "M00002", status = "abc", user = "User 2", row = 2, column = 2 },
                new workLog { mould = "M00003", status = "pqr", user = "User 3", row = 3, column = 3 },
                new workLog { mould = "M00001", status = "xyz", user = "User 1", row = 1, column = 1 },
                new workLog { mould = "M00002", status = "abc", user = "User 2", row = 2, column = 2 },
                new workLog { mould = "M00003", status = "pqr", user = "User 3", row = 3, column = 3 },
                new workLog { mould = "M00001", status = "xyz", user = "User 1", row = 1, column = 1 },
                new workLog { mould = "M00002", status = "abc", user = "User 2", row = 2, column = 2 },
                new workLog { mould = "M00003", status = "pqr", user = "User 3", row = 3, column = 3 },
                new workLog { mould = "M00001", status = "xyz", user = "User 1", row = 1, column = 1 },
                new workLog { mould = "M00002", status = "abc", user = "User 2", row = 2, column = 2 },
                new workLog { mould = "M00003", status = "pqr", user = "User 3", row = 3, column = 3 },
                new workLog { mould = "M00001", status = "xyz", user = "User 1", row = 1, column = 1 },
                new workLog { mould = "M00002", status = "abc", user = "User 2", row = 2, column = 2 },
                new workLog { mould = "M00003", status = "pqr", user = "User 3", row = 3, column = 3 },
                new workLog { mould = "M00001", status = "xyz", user = "User 1", row = 1, column = 1 },
                new workLog { mould = "M00002", status = "abc", user = "User 2", row = 2, column = 2 },
                new workLog { mould = "M00003", status = "pqr", user = "User 3", row = 3, column = 3 },
                new workLog { mould = "M00001", status = "xyz", user = "User 1", row = 1, column = 1 },
                new workLog { mould = "M00002", status = "abc", user = "User 2", row = 2, column = 2 },
                new workLog { mould = "M00003", status = "pqr", user = "User 3", row = 3, column = 3 },
                new workLog { mould = "M00001", status = "xyz", user = "User 1", row = 1, column = 1 },
                new workLog { mould = "M00002", status = "abc", user = "User 2", row = 2, column = 2 },
                new workLog { mould = "M00003", status = "pqr", user = "User 3", row = 3, column = 3 },
            };
            dataTableWorkLog.DataSource = moulds;
        }

        private void worklogTest_Load(object sender, EventArgs e)
        {
            _StatusList = new StatusList();
            _StatusList.Add(new Status(1, "New"));
            _StatusList.Add(new Status(2, "Loaded"));
            _StatusList.Add(new Status(3, "Inserted"));
            Status UpdatedStatus = new Status(4, "Updated");
            _StatusList.Add(UpdatedStatus);
            _StatusList.Add(new Status(5, "Deleted"));
            StatusSelections = new ListSelectionWrapper<Status>(_StatusList, "Name");

            mouldSearch.DataSource = StatusSelections;
            mouldSearch.DisplayMemberSingleItem = "Name";
            mouldSearch.DisplayMember = "NameConcatenated";
            mouldSearch.ValueMember = "Selected";
            mouldSearch.CheckBoxItems[3].DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            mouldSearch.DataBindings.DefaultDataSourceUpdateMode= DataSourceUpdateMode.OnPropertyChanged;

            statusSearch.DataSource = StatusSelections;
            statusSearch.DisplayMemberSingleItem = "Name";
            statusSearch.DisplayMember = "NameConcatenated";
            statusSearch.ValueMember = "Selected";
            statusSearch.CheckBoxItems[3].DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            statusSearch.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            userSearch.DataSource = StatusSelections;
            userSearch.DisplayMemberSingleItem = "Name";
            userSearch.DisplayMember = "NameConcatenated";
            userSearch.ValueMember = "Selected";
            userSearch.CheckBoxItems[3].DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            userSearch.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            columnSearch.DataSource = StatusSelections;
            columnSearch.DisplayMemberSingleItem = "Name";
            columnSearch.DisplayMember = "NameConcatenated";
            columnSearch.ValueMember = "Selected";
            columnSearch.CheckBoxItems[3].DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            columnSearch.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            rowSearch.DataSource = StatusSelections;
            rowSearch.DisplayMemberSingleItem = "Name";
            rowSearch.DisplayMember = "NameConcatenated";
            rowSearch.ValueMember = "Selected";
            rowSearch.CheckBoxItems[3].DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            rowSearch.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmToast frmToast = new("Table updated", "Success");
            frmToast.ShowAtBottomCenter();
        }
    }
}
