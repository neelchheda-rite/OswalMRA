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
        public string MouldRow { get; set; }
        public string MouldCol { get; set; }
        public int createdBy { get; set; }
        public DateTime createdTime { get; set; }
        public int modifyBy { get; set; }
        public DateTime modifyTime { get; set; }
        public int valOverride { get; set; }
        public string insertValidationStatus { get; set; }
    }
}
