﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OswalMRA.COMMON.Models {
    public class User {
        public int ID { get; set; }
        public int ExternalID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
