using OswalMRA.COMMON.Models;
using OswalMRA.MessageBox;
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
            dgvMould.ReadOnly = true;
        }
        private void InitializeDataGridView()
        {
            dgvMould.AutoGenerateColumns = false;

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
            editButtonColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center-align button
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.DefaultCellStyle.Padding = new Padding(0); // Reset padding
            editButtonColumn.Width = 50; // Set button width 

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.FillWeight = 50;
            deleteButtonColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center-align button
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.DefaultCellStyle.Padding = new Padding(0); // Reset padding
            deleteButtonColumn.Width = 50; // Set button width  

            // Add columns to DataGridView
            dgvMould.Columns.AddRange(new DataGridViewColumn[] {
                mouldCodeColumn, mouldNameColumn, descriptionColumn,rowColumn,colColumn, editButtonColumn, deleteButtonColumn
            });
            dgvMould.ColumnHeadersDefaultCellStyle.Font = new Font(dgvMould.Font, FontStyle.Bold); // Make headers bold
            dgvMould.ColumnHeadersDefaultCellStyle.Font = new Font(dgvMould.Font.FontFamily, 12, FontStyle.Bold); // You can adjust font size

            foreach (DataGridViewColumn column in dgvMould.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            dgvMould.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Align text to middle
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
            dgvMould.DataSource = moulds;
        }
        private void btnAddMould_Click(object sender, EventArgs e)
        {
            frmNewMould frmNewMould = new();

            frmNewMould.StartPosition = FormStartPosition.CenterParent;
            if (frmNewMould.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void dgvMould_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvMould.Columns["Edit"].Index)
                {
                    string mouldCode = (string)dgvMould.Rows[e.RowIndex].Cells["mouldCode"].Value;
                    msgBox msgBox = new("", "");
                    msgBox.Show();
                } else if (e.ColumnIndex == dgvMould.Columns["Delete"].Index)
                {
                    string mouldCode = (string)dgvMould.Rows[e.RowIndex].Cells["mouldCode"].Value;

                    optionMsgBox confirmationBox = new optionMsgBox("Delete Confirmation", "mouldDeleteConfirmation");
                    confirmationBox.Show();
                }
            }
        }
    }
}
