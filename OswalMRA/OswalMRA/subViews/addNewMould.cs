using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OswalMRA.subViews {
    public partial class addNewMould : Form {
        public addNewMould()
        {
            InitializeComponent();
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.Red;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(41,128,185);
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmToast frmToast = new("Mould added successfully", "Success");
            frmToast.ShowAtBottomCenter();
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void addMouldTest_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.No;
                this.Close();
            }
            else if (e.KeyCode==Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }
    }
}
