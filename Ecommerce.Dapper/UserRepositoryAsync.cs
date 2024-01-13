using Ecommerce.Domain.Common;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.RepositoriesAsync;
using Ecommerce.Core.Connection;
using System.Data;
using Dapper;

namespace Ecommerce.Dapper
{
    public class UserRepositoryAsync : DbConnection, IUserRepositoryAsync
    {
        public Task<GenericResponse<User>> InsertAsync(User request)
        {
            throw new NotImplementedException();
        }

        public Task<GenericResponse<User>> RemoveAsync(User request)
        {
            throw new NotImplementedException();
        }

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

        public Task<GenericResponse<User>> SelectAsync(User request)
        {
            throw new NotImplementedException();
        }

        public Task<GenericResponse<User>> SelectUserInfoByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<GenericResponse<User>> UpdateAsync(User request)
        {
            throw new NotImplementedException();
        }
    }
}
