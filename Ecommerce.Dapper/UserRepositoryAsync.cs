using Ecommerce.Domain.Common;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.RepositoriesAsync;
using Ecommerce.Core.Connection;
using System.Data;
using Dapper;

namespace Ecommerce.Dapper
{
    /// <summary>
    /// 
    /// </summary>
    public class UserRepositoryAsync : DbConnection, IUserRepositoryAsync
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GenericResponse<User>> InsertAsync(User request)
        {
            var data = new GenericResponse<User>();
            data.Value = new User();
            if (!connection.Success)
            {
                data.Success = false;
                data.ErrorMessage = connection.ErrorMessage;
                return await Task.FromResult(data);
            }
            try
            {
                var parameters = new DynamicParameters(new
                {
                    request.FullName,
                    request.Password,
                    request.Username,
                    request.Email,
                    request.PhoneNumber
                });
                int value = await connection.db.ExecuteAsync("ins_User", parameters, null , 5, CommandType.StoredProcedure).ConfigureAwait(false);
                data.Value.UserId = value;
                data.Success = true;
                connection.db.Close();
                return await Task.FromResult(data);
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.ErrorMessage = ex.Message;
                connection.db.Close();
                return await Task.FromResult(data);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GenericResponse<User>> RemoveAsync(User request)
        {
            var data = new GenericResponse<User>();
            data.Value = new User();
            if (!connection.Success)
            {
                data.Success = false;
                data.ErrorMessage = connection.ErrorMessage;
                return await Task.FromResult(data);
            }
            try
            {
                data.Value = (User)connection.db.QueryAsync<User>("del_User", CommandType.StoredProcedure).Result;
                data.Success = true;
                connection.db.Close();
                return await Task.FromResult(data);
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.ErrorMessage = ex.Message;
                connection.db.Close();
                return await Task.FromResult(data);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<GenericResponse<List<User>>> SelectAllAsync()
        {
            var data = new GenericResponse<List<User>>();
            data.Value = new List<User>();
            if (!connection.Success)
            {
                data.Success = false;
                data.ErrorMessage = connection.ErrorMessage;
                return await Task.FromResult(data);
            }
            try
            {
                data.Value = connection.db.QueryAsync<User>("sel_AllCustomer", CommandType.StoredProcedure).Result.ToList();
                data.Success = true;
                connection.db.Close();
                return await Task.FromResult(data);
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.ErrorMessage = ex.Message;
                connection.db.Close();
                return await Task.FromResult(data);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<GenericResponse<User>> SelectAsync(User request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<GenericResponse<User>> SelectUserInfoByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GenericResponse<User>> UpdateAsync(User request)
        {
            var data = new GenericResponse<User>();
            data.Value = new User();
            if (!connection.Success)
            {
                data.Success = false;
                data.ErrorMessage = connection.ErrorMessage;
                return await Task.FromResult(data);
            }
            try
            {
                data.Value = (User)connection.db.QueryAsync<User>("upd_User", CommandType.StoredProcedure).Result;
                data.Success = true;
                connection.db.Close();
                return await Task.FromResult(data);
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.ErrorMessage = ex.Message;
                connection.db.Close();
                return await Task.FromResult(data);
            }
        }
    }
}
