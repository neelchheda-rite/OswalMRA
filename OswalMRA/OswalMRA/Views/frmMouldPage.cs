using NLog;
using OswalMRA.COMMON.Models;
using OswalMRA.DAL;
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

namespace OswalMRA.Views
{
    public partial class frmMouldPage : Form
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly IDBRepository _dapperManagement;
        public frmMouldPage()
        {
            _dapperManagement = new DBRepository();
            InitializeComponent();
            InitializeDataGridView();
            dgvMould.ReadOnly = true;
        }
        private void InitializeDataGridView()
        {
            dgvMould.AutoGenerateColumns = false;

            // Create columns
            DataGridViewTextBoxColumn srNumberColumn = new DataGridViewTextBoxColumn();
            srNumberColumn.DataPropertyName = "srNumber";
            srNumberColumn.Name = "srNumber";
            srNumberColumn.HeaderText = "Sr Number";

            DataGridViewTextBoxColumn mouldCodeColumn = new DataGridViewTextBoxColumn();
            mouldCodeColumn.DataPropertyName = "mouldCode";
            mouldCodeColumn.Name = "mouldCode";
            mouldCodeColumn.HeaderText = "Mould Code";

            DataGridViewTextBoxColumn mouldNameColumn = new DataGridViewTextBoxColumn();
            mouldNameColumn.DataPropertyName = "mouldName";
            mouldNameColumn.Name = "mouldName";
            mouldNameColumn.HeaderText = "Mould Name";

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.DataPropertyName = "mouldDescription";
            descriptionColumn.Name = "mouldDescription";
            descriptionColumn.HeaderText = "Mould Description";

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
                srNumberColumn, mouldCodeColumn, mouldNameColumn, descriptionColumn,rowColumn,colColumn, editButtonColumn, deleteButtonColumn
            });
            dgvMould.ColumnHeadersDefaultCellStyle.Font = new Font(dgvMould.Font, FontStyle.Bold); // Make headers bold
            dgvMould.ColumnHeadersDefaultCellStyle.Font = new Font(dgvMould.Font.FontFamily, 12, FontStyle.Bold); // You can adjust font size

            foreach (DataGridViewColumn column in dgvMould.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            dgvMould.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Align text to middle
            // Populate DataGridView with dummy data
            //PopulateMouldData();
        }
        //private async void PopulateMouldData()
        //{
        //    _logger.Trace("frmMouldPage===>FetchMouldMaster(): Request Received to list all moulds.");
        //    List<mouldDetails> mouldList = await _dapperManagement.FetchMouldMaster();
        //    List<mouldDetails> moulds = new List<mouldDetails>();

        //    int srNumber = 0;

        //    foreach (var mould in mouldList)
        //    {
        //        srNumber++;
        //        // Check conditions and add to the moulds list
        //        if (mould.row >= 1 && mould.col >= 1)
        //        {
        //            moulds.Add(new mouldDetails
        //            {
        //                srNumber = srNumber,
        //                mouldCode = mould.mouldCode,
        //                mouldName = mould.mouldName,
        //                mouldDescription = mould.mouldDescription,
        //                row = mould.row,
        //                col = mould.col
        //            });
        //        }
        //    }

        //    // Bind the data to the DataGridView
        //    dgvMould.DataSource = moulds;
        //}
        //private void btnAddMould_Click(object sender, EventArgs e)
        //{
        //    frmMould frmMould = new();

        //    if (frmMould.ShowDialog() == DialogResult.OK)
        //    {
        //        PopulateMouldData();
        //    }
        //}

        //private async void dgvMould_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //    {
        //        if (e.ColumnIndex == dgvMould.Columns["Edit"].Index)
        //        {
        //            string mouldCode = (string)dgvMould.Rows[e.RowIndex].Cells["mouldCode"].Value;
        //            string mouldName = (string)dgvMould.Rows[e.RowIndex].Cells["mouldName"].Value;
        //            string mouldDescription = (string)dgvMould.Rows[e.RowIndex].Cells["mouldDescription"].Value;
        //            int row = (int)dgvMould.Rows[e.RowIndex].Cells["row"].Value;
        //            int column = (int)dgvMould.Rows[e.RowIndex].Cells["column"].Value;

        //            frmMould frmEditMould = new(mouldCode, mouldName, mouldDescription, row, column);

        //            frmEditMould.ShowDialog();

        //            if (frmEditMould.DialogResult == DialogResult.OK)
        //            {
        //                PopulateMouldData();
        //            }


        //        }
        //        else if (e.ColumnIndex == dgvMould.Columns["Delete"].Index)
        //        {
        //            string mouldCode = (string)dgvMould.Rows[e.RowIndex].Cells["mouldCode"].Value;

        //            using (var optionBox = new optionMsgBox("Confirmation for delete", "mouldDeleteConfirmation"))
        //            {
        //                var result1 = optionBox.ShowDialog();

        //                if (result1 == DialogResult.Yes)
        //                {
        //                    _logger.Trace($"frmMouldPage===>DeleteMould(): Request Received to delete mould with MouldCode: {mouldCode}.");
        //                    var deleteResult1 = await _dapperManagement.DeleteMould(mouldCode);

        //                    msgBox deleteSuccessBox = new("Confirmation Message", "moulddeleteSuccess");
        //                    deleteSuccessBox.ShowDialog();
        //                    if (deleteSuccessBox.DialogResult == DialogResult.OK)
        //                    {
        //                        PopulateMouldData();
        //                    }
        //                }
        //                else
        //                {
        //                    _logger.Trace($"frmMouldPage===>Delete: Request Cancelled to delete mould with MouldCode: {mouldCode}.");
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
