using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswalMRA.COMMON.Models
{
    public class Mould
    {
        public int mouldId { get; set; }
        public string mouldCode { get; set; }
        public string mouldName { get; set; }
        public string description { get; set; }
        public int row { get; set; }
        public int column { get; set; }
    }

}
