

using OswalMRA.COMMON;
using OswalMRA.DAL;
using NLog;
using OswalMRA.MessageBox;

namespace OswalMRA
{
    public partial class frmNewMould : Form
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly IDBRepository _dapperManagement;
        public int MouldID { get; private set; }
        public int Row { get; private set; }
        public int Column { get; private set; }
        public int Description { get; private set; }
        public frmNewMould()
        {
            _dapperManagement = new DBRepository();
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            PopulateRowComboBoxAsync();
            PopulateColComboBoxAsync();
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

        private async Task PopulateColComboBoxAsync()
        {
            // Clear any existing items in the ComboBox
            ddlCol.Items.Clear();

            // Retrieve the value of 'numberofrows' from the settings table
            int numberOfCols = await _dapperManagement.GetNumberOfColsFromSettings();

            // Populate the ComboBox with numbers from 1 to numberOfRows
            for (int col = 1; col <= numberOfCols; col++)
            {
                ddlCol.Items.Add(col);
            }
        }

        private async void btnAddNew_Click(object sender, EventArgs e)
        {
            List<string> errorMessages = new List<string>();

            if (!ValidateFields(errorMessages))
            {
                string errorMessage = "Please correct the following errors:\n";
                foreach (string error in errorMessages)
                {
                    errorMessage += "- " + error + "\n";
                }
                msgBox fieldValError = new("Error", errorMessage);
                fieldValError.Show();
            }
            else
            {
                int selectedRow = (int)ddlRow.SelectedItem;
                int selectedCol = (int)ddlCol.SelectedItem;
                int createdBy = 1;

                try
                {
                    _logger.Trace("frmNewMould===>InsertMould(): Request Received to create a new mould.");
                    var insertResult = await _dapperManagement.InsertMould(txtMouldCode.Text.ToSafeString(), txtMouldName.Text.ToSafeString(), txtMouldDesc.Text.ToSafeString(), selectedRow, selectedCol, createdBy, 0);

                    int validateCode = insertResult.validateCode;
                    int validationFlag = insertResult.validationFlag;

                    msgBox insertSuccessBox = new("Confirmation Message", "mouldInsertSuccess");

                    if (validateCode == 1)
                    {
                        msgBox dupeCodeMsg = new("Duplicate Mould Code", "mouldDuplicateCode");
                        dupeCodeMsg.Show();
                    }

                    if (validationFlag == 1 && validateCode == 0)
                    {
                        using (var optionBox = new optionMsgBox("Confirmation for inserting in the same grid", $"mouldSameRowColConfirmation"))
                        {
                            var result1 = optionBox.ShowDialog();

                            if (result1 == DialogResult.Yes)
                            {
                                var insertResult1 = await _dapperManagement.InsertMould(txtMouldCode.Text, txtMouldName.Text, txtMouldDesc.Text, selectedRow, selectedCol, createdBy, 1);

                                insertSuccessBox.Show();
                            }
                            else
                            {
                                Console.WriteLine("Operation cancelled.");
                            }
                        }

                    }
                    else if (validateCode == 0)
                    {
                        insertSuccessBox.Show();
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions here
                }
            }
        }

        private bool ValidateFields(List<string> errorMessages)
        {
            bool isValid = true;

            // Perform your validation logic here
            // Add error messages to the errorMessages list for fields that fail validation

            if (string.IsNullOrEmpty(txtMouldCode.Text))
            {
                errorMessages.Add("Mould Code is required.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtMouldName.Text))
            {
                errorMessages.Add("Mould Name is required.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtMouldDesc.Text))
            {
                errorMessages.Add("Mould Description is required.");
                isValid = false;
            }

            if (ddlRow.SelectedIndex == -1)
            {
                errorMessages.Add("Please select a row value.");
                isValid = false;
            }

            if (ddlCol.SelectedIndex == -1)
            {
                errorMessages.Add("Please select a column value.");
                isValid = false;
            }

            // Add more validation rules and error messages as needed

            return isValid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMouldCode.Clear();
            txtMouldName.Clear();
            txtMouldDesc.Clear();
            ddlRow.Items.Clear();
            ddlCol.Items.Clear();
        }
    }
}
