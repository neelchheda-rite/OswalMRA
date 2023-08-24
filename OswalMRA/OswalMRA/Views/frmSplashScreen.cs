using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;
using System.Windows.Forms;

namespace OswalMRA {
    public partial class frmSplashScreen : Form {
        private Timer timerDelay;
        public frmSplashScreen()
        {
            InitializeComponent();
            timerDelay = new Timer();
            timerDelay.Interval = 3000; 
            timerDelay.Tick += TimerDelay_Tick;
            timerDelay.Start();
        }
        private void TimerDelay_Tick(object sender, EventArgs e)
        {            
            this.Close();
        }

    }
}
