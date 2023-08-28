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
    public partial class singleMsgBox : Form {
        public singleMsgBox(string Title, string MessageKey)
        {
            InitializeComponent();
            titleLabel.Text = Title;
        }

        private void singleMsgBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.Yes;
                this.Close();
                
            }
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.Red;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.No;
            this.Close();
        }
    }
}
