using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswalMRA.COMMON.Models {
    public class workLog {
        
        public string mould { get; set; }
        public string status { get; set; }
        public string user { get; set; }
        public int column { get; set; }
        public int row { get; set; }
    }
}
