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

namespace OswalMRA {
    public partial class frmHome : Form {
        public frmHome()
        {
            InitializeComponent();
            operatorTxtBox.Text = "Please scan your ID";
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            optionMsgBox optionMsgBox = new("Restore Mould", "Restore Button Test");
            optionMsgBox.Show();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            optionMsgBox optionMsgBox = new("Store Mould", "Store Button Test");
            optionMsgBox.Show();
        }
    }
}
