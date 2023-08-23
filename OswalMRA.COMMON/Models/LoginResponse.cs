using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswalMRA.COMMON.Models {
    public class LoginResponse {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public string ValidationStatus { get; set; }
    }
}
