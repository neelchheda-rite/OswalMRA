using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OswalMRA.MessageBox
{
    public partial class optionMsgBox : Form
    {
        public optionMsgBox(string Title, string ResourceMessageKey)
        {
            InitializeComponent();
            this.Text = Title;
            string message = Properties.Resources.ResourceManager.GetString(ResourceMessageKey);
            messageLabel.Text = message;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.No;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Yes;
        }
    }
}
