using OswalMRA.COMMON.Models;

namespace OswalMRA.DAL {
    public interface IDBRepository
    {
        public Task<List<LoginResponse>> Login(string userName, string password);
        public Task<List<MouldResponse>> InsertMould(string mouldCode, string mouldName, string mouldDesc, string mouldRow, string mouldCol, int mouldCreatedBy, DateTime mouldCreateTime, int valOverride);
        public Task<int> DeleteMould(int mouldID);


    }

}
