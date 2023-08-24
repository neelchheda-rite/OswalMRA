using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswalMRA.COMMON.Models {
    public class MouldResponse
    {
        public long MouldID { get; set; }
        public string MouldCode { get; set; }
        public string MouldName { get; set; }
        public string MouldDescription { get; set; }
        public int MouldRow { get; set; }
        public int MouldCol { get; set; }
        public int createdBy { get; set; }
        public DateTime createdTime { get; set; }
        public int modifyBy { get; set; }
        public DateTime modifyTime { get; set; }
        public int validateCode { get; set; }
        public int validationFlag { get; set; }
    }
}
