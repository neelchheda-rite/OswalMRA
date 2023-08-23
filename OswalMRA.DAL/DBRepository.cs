using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using OswalMRA.COMMON.Models; // Import your model namespace
using System.Collections.Generic;
using Microsoft.VisualBasic.ApplicationServices;

namespace OswalMRA.DAL
{
    public class DBRepository : IDBRepository
    {
        readonly DBContext _context;

        public DBRepository()
        {
            _context = new DBContext();
        }

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

                using (var connection = _context.CreateConnection())
                {
                    await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure);

                    // Retrieve the output value
                    string validationStatus = parameters.Get<string>("@ValidationStatus");

                    loginResp = new List<LoginResponse>
            {
                new LoginResponse { ValidationStatus = validationStatus }
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
    }
}
