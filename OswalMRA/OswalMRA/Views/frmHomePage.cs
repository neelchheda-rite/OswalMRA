namespace OswalMRA.Test {
    public partial class frmHomePage : Form {
            
        public frmHomePage()
        {
            InitializeComponent();
            descriptionLabel.Text = "Established in 1970, Oswal Engineering Corporation offers manufacturing systems and technical guidance for cable industries  all over the world.The Company regularly exports plants to Asian, African and Middle East countries.";
            emailLabel.Text = "Email: info@oswalengineering.com";
            phoneLabel.Text = "Phone: +912240114568";
            addressLabel.Text = "Address: 9, Ark Industrial Estate, Makwana Rd Marol, Andheri East, Mumbai - 400059, Maharashtra, India.";
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
