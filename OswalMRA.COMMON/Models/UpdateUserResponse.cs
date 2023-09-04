namespace OswalMRA.COMMON.Models
{
    public class UpdateUserResponse
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int RoleID { get; set; }
        public string Role { get; set; }
        public bool Active { get; set; }
        public string Error { get; set; }
        public string UpdateStatus { get; set; }
    }
}
