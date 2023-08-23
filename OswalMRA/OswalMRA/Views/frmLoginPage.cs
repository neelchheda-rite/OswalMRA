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
    public partial class frmLoginPage : Form {
        public frmLoginPage()
        {
            InitializeComponent();
            usernameTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void frmLoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
