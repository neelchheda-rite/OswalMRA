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
    public partial class frmToast : Form {
        private int targetTop;

        public frmToast(String message, String colorKey)
        {
            InitializeComponent();
            messageLabel.Text = message;    
            if(colorKey == "Success")
            {
                BackColor = Color.FromArgb(25, 135, 84);
                errorImage.Hide();
            }
            else if (colorKey == "Error")
            {
                BackColor = Color.FromArgb(229, 79, 63);
                successImage.Hide();
            }
        }

        private void frmToast_Load(object sender, EventArgs e)
        {
            timerClose.Start();
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            Close();
        }
        public void ShowAtBottomCenter()
        {

            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formHeight = Height;
            int positionAboveBottom = screenHeight - formHeight - 40;
           Top = positionAboveBottom;
            Left = (Screen.PrimaryScreen.WorkingArea.Width - Width) / 2;
            Show();
        }
    }
}
