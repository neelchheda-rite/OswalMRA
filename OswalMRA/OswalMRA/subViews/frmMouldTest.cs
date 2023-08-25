

using OswalMRA.COMMON;
using OswalMRA.COMMON.Models;
using OswalMRA.DAL;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OswalMRA.MessageBox;
using OswalMRA.Properties;

namespace OswalMRA
{
    public partial class frmMouldTest : Form
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly IDBRepository _dapperManagement;
        public int MouldID { get; private set; }
        public int Row { get; private set; }
        public int Column { get; private set; }
        public int Description { get; private set; }
        public frmMouldTest()
        {
            _dapperManagement = new DBRepository();
            MinimizeBox = false;
            MaximizeBox = false;
        }
    }
}
