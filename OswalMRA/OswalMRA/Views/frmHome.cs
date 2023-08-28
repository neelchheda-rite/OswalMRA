﻿namespace OswalMRA.Test {
    public partial class frmHome : Form {
            
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            singleMsgBox singleMsgBox = new singleMsgBox("Confirm Restore","");
            DialogResult dialogResult = singleMsgBox.ShowDialog();
            if(dialogResult == DialogResult.Yes)
            {
                frmToast frmToast = new("Restored successfully","Success");
                clearData();
                frmToast.ShowAtBottomCenter();
            }
            
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            singleMsgBox singleMsgBox = new singleMsgBox("Confirm Store", "");
            DialogResult dialogResult = singleMsgBox.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                frmToast frmToast = new("Stored successfully", "Error");
                clearData();
                frmToast.ShowAtBottomCenter();
            }

        }

        private void frmHome_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
             {
                btnRestore.PerformClick();
             } 
        }

        private void clearData()
        {
            columnTextBox.Text = "";
            rowTextBox.Text = "";
            mouldCodeTextbox.Text = "";
            operatorIdTextBox.Text = "";
        }
    }
}
