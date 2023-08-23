using Dapper;
using OswalMRA.COMMON.Models;
using System.Data;
using static OswalMRA.DAL.IDBRepository;

namespace OswalMRA.DAL {
    public class DBRepository : IDBRepository
    {
        readonly DBContext _context;

        public DBRepository()
        {
            _context = new DBContext();            
        }

        #region Login
        public async Task<List<LoginResponse>> Login(string userName, string password)//get details based on usernaem then compare//validations
        {
            List<LoginResponse> loginResp;
            try
            {

                var query = "usp_ValidateLogin";
                var parameters = new DynamicParameters();
                parameters.Add("@UserName", userName, DbType.String);

                using (var connection = _context.CreateConnection())
                {
                    var reader = await connection.QueryMultipleAsync(query, parameters, null, null, CommandType.StoredProcedure);

                    loginResp = reader.Read<LoginResponse>().ToList();
                    if (loginResp.Count > 0)
                    {
                        string decryptedPass = string.Empty;
                        Encryption.DecryptText(loginResp[0].Password, ref decryptedPass);
                        if (loginResp[0].Password != password)
                        {
                            loginResp[0].ValidationStatus = "Incorrect password.";
                        } else
                        {
                            loginResp[0].ValidationStatus = "Validation successfull.";

                        }
                    } else
                    {
                        loginResp.Add(new LoginResponse { ValidationStatus = "User not found." });
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return loginResp;
        }
        #endregion

        #region Mould
        public async Task<List<MouldResponse>> InsertMould(string mouldCode, string mouldName, string mouldDesc, string mouldRow, string mouldCol, int mouldCreatedBy, DateTime mouldCreateTime, int valOverride)//get details based on usernaem then compare//validations        {
        {
            List<MouldResponse> mouldResponses = new List<MouldResponse>();
            int validationFlag = 0;

            try
            {
                var query = "usp_InsertMould";
                var parameters = new DynamicParameters();
                parameters.Add("@MouldCode", mouldCode);
                parameters.Add("@MouldName", mouldName);
                parameters.Add("@MouldDesc", mouldDesc);
                parameters.Add("@MouldRow", mouldRow);
                parameters.Add("@MouldCol", mouldCol);
                parameters.Add("@MouldCreatedBy", mouldCreatedBy);
                parameters.Add("@DateCreated", mouldCreateTime);
                parameters.Add("@valOverride", valOverride);
                parameters.Add("@ValidationFlag", dbType: DbType.Int32, direction: ParameterDirection.Output);

                if (int.TryParse(mouldRow, out int rowValue) && int.TryParse(mouldCol, out int colValue))
                {
                    parameters.Add("@MouldRow", rowValue);
                    parameters.Add("@MouldCol", colValue);
                }

                using (var connection = _context.CreateConnection())
                {
                    var reader = await connection.ExecuteAsync(query, parameters, null, null, CommandType.StoredProcedure);

                    validationFlag = parameters.Get<int>("@ValidationFlag");

                    if (validationFlag == 0)
                    {
                        // Construct the MouldResponse object based on inserted data
                        MouldResponse mouldResponse = new MouldResponse
                        {
                            MouldCode = mouldCode,
                            MouldName = mouldName,
                            MouldDescription = mouldDesc,
                            MouldRow = mouldRow,
                            MouldCol = mouldCol,
                            createdBy = mouldCreatedBy,
                            createdTime = mouldCreateTime,
                            // Set other properties as needed
                            insertValidationStatus = "Valid" // Or any other status
                        };

                        // Add the constructed response to the list
                        mouldResponses.Add(mouldResponse);
                    }
                    else
                    {
                        MouldResponse mouldResponse = new MouldResponse
                        {
                            MouldCode = mouldCode,
                            MouldName = mouldName,
                            MouldDescription = mouldDesc,
                            MouldRow = mouldRow,
                            MouldCol = mouldCol,
                            createdBy = mouldCreatedBy,
                            createdTime = mouldCreateTime,
                            // Set other properties as needed
                            insertValidationStatus = "Invalid" // Or any other status
                        };
                        // Add the constructed response to the list
                        mouldResponses.Add(mouldResponse);
                    }

                }

                // Other parts of your code
            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw;
            }

            return mouldResponses;
        }

        public async Task<int> DeleteMould(int mouldID)//get details based on usernaem then compare//validations        {
        {
            
            int affectedRows = 0;

            try
            {
                var query = "usp_DeleteMould";
                var parameters = new DynamicParameters();
                parameters.Add("@MouldID", mouldID);

                using (var connection = _context.CreateConnection())
                {
                    affectedRows = await connection.ExecuteAsync(query, parameters, null, null, CommandType.StoredProcedure);

                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw;
            }

            return affectedRows;
        }
        #endregion
    }
}
