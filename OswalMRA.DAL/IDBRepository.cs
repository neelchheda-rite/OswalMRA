using OswalMRA.COMMON.Models;

namespace OswalMRA.DAL {
    public interface IDBRepository
    {
        public Task<List<LoginResponse>> Login(string userName, string password);
        public Task<List<UpdatePasswordResponse>> UpdatePassword(int UserID, string currentPassword, string newPassword);
        public Task<List<VerifyCurrentPasswordResponse>> VerifyCurrentPassword(string UserName, string Password);
    }

}
