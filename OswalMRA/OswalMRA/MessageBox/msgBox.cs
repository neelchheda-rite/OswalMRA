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
    public partial class msgBox : Form
    {
        public msgBox(string Title, string ResourceMessageKey)
        {
            InitializeComponent();
            this.Text = Title;
            string message = Properties.Resources.ResourceManager.GetString(ResourceMessageKey);
            messageLabel.Text = message;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
