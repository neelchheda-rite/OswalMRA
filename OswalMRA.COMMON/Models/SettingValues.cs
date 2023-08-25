using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswalMRA.COMMON.Models
{
    public class SettingValues
    {
        private string emergencyContactNumber { get; set; }
        private string macUDDI { get; set; }
        private int numberOfRow { get; set; }
        private int numberOfColumn { get; set; }

        public string EmergencyContactNumber
        {
            get { return emergencyContactNumber; }
            set { emergencyContactNumber = value; }
        }

        public string MacUDDI
        {
            get { return macUDDI; }
            set { macUDDI = value; }
        }

        public int NumberOfRow
        {
            get { return numberOfRow; }
            set { numberOfRow = value; }
        }

        public int NumberOfColumn
        {
            get { return numberOfColumn; }
            set { numberOfColumn = value; }
        }
    }
}

