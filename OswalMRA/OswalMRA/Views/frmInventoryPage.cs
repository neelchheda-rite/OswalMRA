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
    public partial class frmInventoryPage : Form {
        private StatusList _StatusList;

        private ListSelectionWrapper<Status> StatusSelections;
        public frmInventoryPage()
        {
            InitializeComponent();
            InitializeDataGridView();
            dataTableInventory.ReadOnly = true;
        }

        private void InitializeDataGridView()
        {
            dataTableInventory.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn date = new()
            {
                DataPropertyName = "date",
                Name = "date",
                HeaderText = "Date"
            };

            DataGridViewTextBoxColumn mould = new()
            {
                DataPropertyName = "mould",
                Name = "mould",
                HeaderText = "Mould"
            };

            DataGridViewTextBoxColumn slot = new()
            {
                DataPropertyName = "slot",
                Name = "slot",
                HeaderText = "Slot"
            };

            DataGridViewTextBoxColumn user = new()
            {
                DataPropertyName = "user",
                Name = "user",
                HeaderText = "User"
            };
            

            

            DataGridViewButtonColumn edit = new()
            {
                HeaderText = "Action",
                Text = "Edit",
                Name = "edit",
                DataPropertyName = "Edit"
            };
            edit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            edit.DefaultCellStyle.Padding = new Padding(2, 2, 2, 2);
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
            delete.CellTemplate.Style.ForeColor = Color.FromArgb(229, 79, 63);
            delete.CellTemplate.Style.SelectionForeColor = Color.FromArgb(229, 79, 63);
            delete.CellTemplate.Style.SelectionBackColor = delete.CellTemplate.Style.BackColor;
            delete.ToolTipText = "";

            dataTableInventory.Columns.AddRange(new DataGridViewColumn[] { date,mould,slot,user,edit,delete });
            dataTableInventory.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            PopulateMouldData();
        }
        private void PopulateMouldData()
        {
            var inventory = new List<Inventory>
            {
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 1", slot = "Slot 1" ,user = "User 1" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 2", slot = "Slot 2" ,user = "User 2" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 3", slot = "Slot 3" ,user = "User 3" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 1", slot = "Slot 1" ,user = "User 1" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 2", slot = "Slot 2" ,user = "User 2" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 3", slot = "Slot 3" ,user = "User 3" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 1", slot = "Slot 1" ,user = "User 1" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 2", slot = "Slot 2" ,user = "User 2" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 3", slot = "Slot 3" ,user = "User 3" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 1", slot = "Slot 1" ,user = "User 1" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 2", slot = "Slot 2" ,user = "User 2" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 3", slot = "Slot 3" ,user = "User 3" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 1", slot = "Slot 1" ,user = "User 1" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 2", slot = "Slot 2" ,user = "User 2" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 3", slot = "Slot 3" ,user = "User 3" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 1", slot = "Slot 1" ,user = "User 1" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 2", slot = "Slot 2" ,user = "User 2" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 3", slot = "Slot 3" ,user = "User 3" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 1", slot = "Slot 1" ,user = "User 1" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 2", slot = "Slot 2" ,user = "User 2" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 3", slot = "Slot 3" ,user = "User 3" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 1", slot = "Slot 1" ,user = "User 1" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 2", slot = "Slot 2" ,user = "User 2" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 3", slot = "Slot 3" ,user = "User 3" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 1", slot = "Slot 1" ,user = "User 1" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 2", slot = "Slot 2" ,user = "User 2" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 3", slot = "Slot 3" ,user = "User 3" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 1", slot = "Slot 1" ,user = "User 1" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 2", slot = "Slot 2" ,user = "User 2" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 3", slot = "Slot 3" ,user = "User 3" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 1", slot = "Slot 1" ,user = "User 1" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 2", slot = "Slot 2" ,user = "User 2" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 3", slot = "Slot 3" ,user = "User 3" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 1", slot = "Slot 1" ,user = "User 1" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 2", slot = "Slot 2" ,user = "User 2" },
                new Inventory { date = "29/08/2023 17:00:00", mould="Mould 3", slot = "Slot 3" ,user = "User 3" }

            };
            dataTableInventory.DataSource = inventory;
        }

        private void inventoryTest_Load(object sender, EventArgs e)
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
            mouldSearch.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            userSearch.DataSource = StatusSelections;
            userSearch.DisplayMemberSingleItem = "Name";
            userSearch.DisplayMember = "NameConcatenated";
            userSearch.ValueMember = "Selected";
            userSearch.CheckBoxItems[3].DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            userSearch.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
        }
    }
}
