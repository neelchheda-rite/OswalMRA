

using OswalMRA.COMMON;
using OswalMRA.COMMON.Models;
using OswalMRA.DAL;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OswalMRA.MessageBox;
using OswalMRA.Properties;

namespace OswalMRA
{
    public partial class frmMould : Form
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly IDBRepository _dapperManagement;
        public string MouldCode { get; private set; }
        public string MouldName { get; private set; }
        public string Description { get; private set; }
        public int Row { get; private set; }
        public int Column { get; private set; }

        public frmMould()
        {
            _dapperManagement = new DBRepository();
            InitializeComponent();
            PopulateRowComboBoxAsync();
            PopulateColumnComboBoxAsync();
            btnAction.Click += btnAddNew_Click;
            btnOption2.Text = "Clear";
            btnOption2.Click += btnClear_Click;
        }

        public frmMould(string MouldCode, string MouldName, string Description, int currentRow, int currentColumn)
        {
            _dapperManagement = new DBRepository();
            InitializeComponent();
            Text = "Edit Mould";
            txtMouldCode.Text = MouldCode;
            txtMouldCode.Enabled = false;
            txtMouldName.Text = MouldName;
            txtMouldDesc.Text = Description;
            PopulateRowComboBoxAsync(currentRow);
            PopulateColumnComboBoxAsync(currentColumn);
            btnAction.Click += btnEdit_Click;
            btnOption2.Text = "Cancel";
            btnOption2.Click += btnCancel_Click;
        }

        private async Task PopulateRowComboBoxAsync()
        {
            // Clear any existing items in the ComboBox
            ddlRow.Items.Clear();

            // Retrieve the value of 'numberofrows' from the settings table
            int numberOfRows = await _dapperManagement.GetNumberOfRowsFromSettings();

            // Populate the ComboBox with numbers from 1 to numberOfRows
            for (int row = 1; row <= numberOfRows; row++)
            {
                ddlRow.Items.Add(row);
            }
        }

        private async Task PopulateRowComboBoxAsync(int currentRow)
        {
            // Clear any existing items in the ComboBox
            ddlRow.Items.Clear();
            ddlRow.Items.Add(currentRow);

            // Retrieve the value of 'numberofrows' from the settings table
            int numberOfRows = await _dapperManagement.GetNumberOfRowsFromSettings();

            // Populate the ComboBox with numbers from 1 to numberOfRows
            for (int row = 1; row <= numberOfRows; row++)
            {
                if (row != currentRow)
                {
                    ddlRow.Items.Add(row);
                }
            }

            ddlRow.SelectedIndex = 0;
        }

        private async Task PopulateColumnComboBoxAsync()
        {
            // Clear any existing items in the ComboBox
            ddlColumn.Items.Clear();

            // Retrieve the value of 'numberofrows' from the settings table
            int numberOfCols = await _dapperManagement.GetNumberOfColumnsFromSettings();

            // Populate the ComboBox with numbers from 1 to numberOfRows
            for (int col = 1; col <= numberOfCols; col++)
            {
                ddlColumn.Items.Add(col);
            }
        }

        private async Task PopulateColumnComboBoxAsync(int currentColumn)
        {
            // Clear any existing items in the ComboBox
            ddlColumn.Items.Clear();
            ddlColumn.Items.Add(currentColumn);

            // Retrieve the value of 'numberofrows' from the settings table
            int numberOfCols = await _dapperManagement.GetNumberOfColumnsFromSettings();

            // Populate the ComboBox with numbers from 1 to numberOfRows
            for (int column = 1; column <= numberOfCols; column++)
            {
                if (column != currentColumn)
                {
                    ddlColumn.Items.Add(column);
                }
            }
            ddlColumn.SelectedIndex = 0;
        }

        private async void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = (int)ddlRow.SelectedItem;
                int selectedCol = (int)ddlColumn.SelectedItem;
                int createdBy = 1;

                _logger.Trace("frmNewMould===>InsertMould(): Request Received to create a new mould.");
                var insertResult = await _dapperManagement.InsertMould(txtMouldCode.Text.ToSafeString(), txtMouldName.Text.ToSafeString(), txtMouldDesc.Text.ToSafeString(), selectedRow, selectedCol, createdBy, 0);

                int insertValidateCode = insertResult.validateCode;
                int insertValidationFlag = insertResult.validationFlag;

                msgBox insertSuccessBox = new("Confirmation Message", "mouldInsertSuccess");

                if (insertValidateCode == 1)
                {
                    msgBox dupeCodeMsg = new("Duplicate Mould Code", "mouldDuplicateCode");
                    dupeCodeMsg.ShowDialog();

                }

                if (insertValidationFlag == 1 && insertValidateCode == 0)
                {
                    using (var optionBox = new optionMsgBox("Confirmation for inserting in the same grid", $"mouldSameRowColConfirmation"))
                    {
                        var result1 = optionBox.ShowDialog();

                        if (result1 == DialogResult.Yes)
                        {
                            var insertResult1 = await _dapperManagement.InsertMould(txtMouldCode.Text.ToSafeString(), txtMouldName.Text.ToSafeString(), txtMouldDesc.Text.ToSafeString(), selectedRow, selectedCol, createdBy, 1);

                            insertSuccessBox.ShowDialog();
                            if(insertSuccessBox.DialogResult == DialogResult.OK)
                            {
                                this.DialogResult = DialogResult.OK;
                            }
                        }
                    }

                }
                else if (insertValidateCode == 0)
                {
                    insertSuccessBox.ShowDialog();
                    if (insertSuccessBox.DialogResult == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = (int)ddlRow.SelectedItem;
                int selectedCol = (int)ddlColumn.SelectedItem;
                int modifyBy = 1;

                _logger.Trace($"frmNewMould===>EditMould(): Request Received to Edit Mould with Code: {txtMouldCode.Text.ToSafeString()}.");
                var editResult = await _dapperManagement.EditMould(txtMouldCode.Text.ToSafeString(), txtMouldName.Text.ToSafeString(), txtMouldDesc.Text.ToSafeString(), selectedRow, selectedCol, modifyBy, 0);

                msgBox editSuccessBox = new("Confirmation Message", "mouldEditSuccess");

                if (editResult == 1)
                {
                    using (var samegridConfirm = new optionMsgBox("Confirmation for inserting in the same grid", $"mouldSameRowColConfirmation"))
                    {
                        var result1 = samegridConfirm.ShowDialog();

                        if (result1 == DialogResult.Yes)
                        {
                            var editResultConfirm = await _dapperManagement.EditMould(txtMouldCode.Text.ToSafeString(), txtMouldName.Text.ToSafeString(), txtMouldDesc.Text.ToSafeString(), selectedRow, selectedCol, modifyBy, 1);

                            editSuccessBox.ShowDialog();
                            this.DialogResult = DialogResult.OK;

                        }
                    }
                }
                else
                {
                    editSuccessBox.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMouldCode.Clear();
            txtMouldName.Clear();
            txtMouldDesc.Clear();
            ddlRow.Items.Clear();
            ddlColumn.Items.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _logger.Trace($"frmMouldPage===>Edit: Request Cancelled to edit mould with MouldCode: {txtMouldCode.ToSafeString()}.");
            this.Close();
        }
    }
}
