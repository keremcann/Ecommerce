using Dapper;
using Ecommerce.Core.Connection;
using Ecommerce.Domain.Common;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.RepositoriesAsync;
using Ecommerce.Domain.Shared.Constants;
using System.Data;

namespace Ecommerce.Dapper
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerRepositoryAsync : DbConnection, ICustomerRepositoryAsync
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<GenericResponse<Customer>> InsertAsync(Customer request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<GenericResponse<Customer>> RemoveAsync(Customer request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<GenericResponse<List<Customer>>> SelectAllAsync()
        {
            var data = new GenericResponse<List<Customer>>();
            data.Value = new List<Customer>();
            if (!connection.Success)
            {
                data.Success = false;
                data.ErrorMessage = connection.ErrorMessage;
                return await Task.FromResult(data);
            }
            try
            {
                data.Value = connection.db.QueryAsync<Customer>("sel_AllCustomer", CommandType.StoredProcedure).Result.ToList();
                data.Success = true;
                data.InfoMessage = Messages.InfoMessage;
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
        public Task<GenericResponse<Customer>> SelectAsync(Customer request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<GenericResponse<Customer>> UpdateAsync(Customer request)
        {
            throw new NotImplementedException();
        }
    }
}
