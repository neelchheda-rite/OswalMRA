using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswalMRA.COMMON.Models {
    public class mouldDataSource {
        public int mouldId { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int column { get; set; }
        public int row { get; set; }
    }
}
