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
        public msgBox(string Title, string Message)
        {
            InitializeComponent();
            this.Text = Title;
            messageLabel.Text = Message;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
