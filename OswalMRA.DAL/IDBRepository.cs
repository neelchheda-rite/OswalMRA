using OswalMRA.COMMON.Models;

namespace OswalMRA.DAL {
    public interface IDBRepository
    {
        public Task<List<LoginResponse>> Login(string userName, string password);
        public Task<List<UpdatePasswordResponse>> UpdatePassword(int UserID, string currentPassword, string newPassword);
        public Task<List<VerifyCurrentPasswordResponse>> VerifyCurrentPassword(string UserName, string Password);
        public Task<(int validateCode, int validationFlag)> InsertMould(string mouldCode, string mouldName, string mouldDesc, int mouldRow, int mouldCol, int mouldCreatedBy, int valOverride);
        public Task<List<mouldDetails>> FetchMouldMaster();
        public Task<int> DeleteMould(string mouldCode);
        public Task<int> GetNumberOfRowsFromSettings();
        public Task<int> GetNumberOfColsFromSettings();
    }

}
