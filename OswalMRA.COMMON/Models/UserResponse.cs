﻿

namespace OswalMRA.COMMON.Models
{
    public class UserResponse
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int RoleID { get; set; }
        public string Role { get; set; }
<<<<<<< Updated upstream
        public bool IsActive { get; set; }
        public string Error { get; set; }
=======
        public bool Active { get; set; }
        public string Error { get; set; }
        public string ExternalID { get; set; }
>>>>>>> Stashed changes
    }

}
