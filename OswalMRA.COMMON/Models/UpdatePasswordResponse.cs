using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswalMRA.COMMON.Models
{
    public class UpdatePasswordResponse
    {   
        public int UserID { get; set; }
        public string currentPassword { get; set; }
        public string newPassword { get; set; }
        public bool Active { get; set; }
        public string UpdatePasswordStatus { get; set; }
    }
}
