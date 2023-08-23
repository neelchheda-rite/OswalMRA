using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswalMRA.COMMON.Models
{
    public class VerifyCurrentPasswordResponse
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public string validationStatus { get; set; }
    }
}
