using System.Collections.Generic;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using OswalMRA.COMMON.Models;

namespace OswalMRA.DAL
{
    public class DBRepository : IDBRepository
    {
        private readonly string _connectionString;
        readonly DBContext _context;

        public DBRepository()
        {
            _context = new DBContext();
        }
        #region Validation
        //login validation
        public async Task<List<LoginResponse>> Login(string userName, string password)
        {
            List<LoginResponse> loginResp;
            try
            {
                var query = "usp_ValidateLogin";
                var parameters = new DynamicParameters();
                parameters.Add("@UserName", userName, DbType.String);
                parameters.Add("@Password", password, DbType.String);
                parameters.Add("@ValidationStatus", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                parameters.Add("@UserRoleID", dbType: DbType.Byte, direction: ParameterDirection.Output, size: 100);

                using (var connection = _context.CreateConnection())
                {
                    await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure);

                    // Retrieve the output values
                    string validationStatus = parameters.Get<string>("@ValidationStatus");
                    byte userRoleID = parameters.Get<byte>("@UserRoleID");

                    loginResp = new List<LoginResponse>
            {
                new LoginResponse { ValidationStatus = validationStatus, UserRoleID = userRoleID }
            };
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                throw;
            }
            return loginResp;
        }
        //Update password
        public async Task<List<UpdatePasswordResponse>> UpdatePassword(int UserID, string currentPassword, string newPassword)
        {
            List<UpdatePasswordResponse> updatePasswordResp;
            try
            {
                var query = "usp_UpdatePassword";
                var parameters = new DynamicParameters();
                parameters.Add("@UserID", UserID, DbType.Int32);
                parameters.Add("@CurrentPassword", currentPassword, DbType.String);
                parameters.Add("@NewPassword", newPassword, DbType.String);
                parameters.Add("@UpdateStatus", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                using (var connection = _context.CreateConnection())
                {

                    await connection.ExecuteAsync(query, parameters, null, null, CommandType.StoredProcedure);

                    string updatePasswordStatus = parameters.Get<string>("@UpdateStatus");

                    updatePasswordResp = new List<UpdatePasswordResponse>
                    {
                        new UpdatePasswordResponse { UpdatePasswordStatus = updatePasswordStatus }
                    };

                    return updatePasswordResp;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //verify current password
        public async Task<List<VerifyCurrentPasswordResponse>> VerifyCurrentPassword(string UserName, string Password)
        {
            List<VerifyCurrentPasswordResponse> VerifyCurrentPasswordResp;
            try
            {
                using (var connection = _context.CreateConnection())
                {
                    var query = "usp_VerifyCurrentPassword";
                    var parameters = new DynamicParameters();
                    parameters.Add("@UserName", UserName, DbType.String);
                    parameters.Add("@CurrentPassword", Password, DbType.String);
                    parameters.Add("@ValidationStatus", dbType: DbType.String, direction: ParameterDirection.Output);

                    await connection.ExecuteAsync(query, parameters, null, null, CommandType.StoredProcedure);

                    string validationStatus = parameters.Get<string>("@ValidationStatus");
                    VerifyCurrentPasswordResp = new List<VerifyCurrentPasswordResponse>
                    {
                        new VerifyCurrentPasswordResponse { validationStatus = validationStatus }
                    };
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return VerifyCurrentPasswordResp;
        }

        public async Task<(string validationStatus, byte userRoleID)> ValidateLogin(string userName, string password)
        {
            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@UserName", userName);
                parameters.Add("@Password", password);
                parameters.Add("@ValidationStatus", dbType: DbType.String, size: 100, direction: ParameterDirection.Output);
                parameters.Add("@UserRoleID", dbType: DbType.Byte, direction: ParameterDirection.Output);

                await connection.ExecuteAsync("usp_ValidateLogin", parameters, null, null, CommandType.StoredProcedure);

                string validationStatus = parameters.Get<string>("@ValidationStatus");
                byte userRoleID = parameters.Get<byte>("@UserRoleID");

                return (validationStatus, userRoleID);
            }
        }
        #endregion

        #region Mould
        public async Task<(int validateCode, int validationFlag)> InsertMould(string mouldCode, string mouldName, string mouldDesc, int mouldRow, int mouldCol, int mouldCreatedBy, int valOverride)//get details based on usernaem then compare//validations        {
        {
            int validateCode = 0 ;
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
                parameters.Add("@valOverride", valOverride);
                parameters.Add("@validateCode", dbType: DbType.Int32, direction: ParameterDirection.Output);
                parameters.Add("@ValidationFlag", dbType: DbType.Int32, direction: ParameterDirection.Output);

                using (var connection = _context.CreateConnection())
                {
                    var reader = await connection.ExecuteAsync(query, parameters, null, null, CommandType.StoredProcedure);

                    validationFlag = parameters.Get<int>("@ValidationFlag");
                    validateCode = parameters.Get<int>("@validateCode");

                }

                // Other parts of your code
            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw;
            }

            return (validateCode, validationFlag);
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

        #region User
        public async Task InsertUser(string UserName, int RoleID, bool IsActive)
        {
            try
            {
                var query = "usp_InsertUser";
                var parameters = new DynamicParameters();
                parameters.Add("@UserName", UserName);
                parameters.Add("@RoleID", RoleID);
                parameters.Add("@IsActive", IsActive);
                parameters.Add("@UserID", dbType: DbType.Int64, direction: ParameterDirection.Output);

                using (var connection = _context.CreateConnection())
                {
                    await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw;
            }
        }

        public async Task<List<User>> GetUsers()
        {
            try
            {
                var query = "SELECT UserID, UserName, Role FROM Users";
                using (var connection = _context.CreateConnection())
                {
                    List<User> users = (await connection.QueryAsync<User>(query)).AsList();
                    return users;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw;
            }
        }
        #endregion
        #region Role
        public async Task<List<Role>> GetRoles()
        {
            try
            {
                var query = "usp_GetRoles"; 

                using (var connection = _context.CreateConnection())
                {
                    IEnumerable<Role> roles = await connection.QueryAsync<Role>(query, commandType: CommandType.StoredProcedure);
                    return roles.ToList(); 
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Settings
        public async Task<int> GetNumberOfRowsFromSettings()
        {
            {

                int maxRows = 0;

                try
                {
                    var query = "usp_GetNumberOfRows";
                    var parameters = new DynamicParameters();
                    parameters.Add("@NumberOfRows", dbType: DbType.Int32, direction: ParameterDirection.Output);

                    using (var connection = _context.CreateConnection())
                    {
                        await connection.ExecuteAsync(query, parameters, null, null, CommandType.StoredProcedure);
                        maxRows = parameters.Get<int>("@NumberOfRows");
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    throw;
                }

                return maxRows;
            }

        }
        public async Task<int> GetNumberOfColsFromSettings()
        {
            {

                int maxCols = 0;

                try
                {
                    var query = "usp_GetNumberOfCols";
                    var parameters = new DynamicParameters();
                    parameters.Add("@NumberOfCols", dbType: DbType.Int32, direction: ParameterDirection.Output);

                    using (var connection = _context.CreateConnection())
                    {
                        await connection.ExecuteAsync(query, parameters, null, null, CommandType.StoredProcedure);
                        maxCols = parameters.Get<int>("@NumberOfCols");

                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    throw;
                }

                return maxCols;
            }
        }

        #endregion
        
    }
}
