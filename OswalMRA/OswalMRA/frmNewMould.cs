

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

namespace OswalMRA
{
    public partial class frmNewMould : Form
    {
        private readonly ILogger _logger;
        private readonly IDBRepository _dapperManagement;
        public int MouldID { get; private set; }
        public int Row { get; private set; }
        public int Column { get; private set; }
        public int Description { get; private set; }
        public frmNewMould()
        {
            InitializeComponent();
            _dapperManagement = new DBRepository();
        }

        private void addNewMouldBtn_Click(object sender, EventArgs e)
        {

        }

        private async void btnAddNew_Click(object sender, EventArgs e)
        {

            int createdBy = 1;
            DateTime createTime = DateTime.Now;

            try
            {
                //_logger.Trace("frmNewMould===>InsertMould(): Request Received to create a new mould.");
                var insertResult = await _dapperManagement.InsertMould(txtMouldCode.Text, txtMouldName.Text, txtMouldDesc.Text, txtMouldRow.Text, txtMouldCol.Text, createdBy, createTime, 0);
                List<MouldResponse> insertResp = insertResult; // Extract the response list from the result

                // Display the contents of the insertResp list
                foreach (var response in insertResp)
                {
                    if (response.insertValidationStatus == "Invalid")
                    {
                        using (var optionBox = new optionMsgBox("Confirmation", "A mould already exists here. Do you still want to proceed?"))
                        {
                            var result1 = optionBox.ShowDialog();

                            if (result1 == DialogResult.Yes)
                            {
                                var insertResult1 = await _dapperManagement.InsertMould(txtMouldCode.Text, txtMouldName.Text, txtMouldDesc.Text, txtMouldRow.Text, txtMouldCol.Text, createdBy, createTime, 1);

                                Console.WriteLine(insertResult1);
                            }
                            else
                            {
                                Console.WriteLine("Operation cancelled.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
            }

        }
    }
}
