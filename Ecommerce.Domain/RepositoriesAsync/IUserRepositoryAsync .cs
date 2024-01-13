using Ecommerce.Domain.Common;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Domain.RepositoriesAsync
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserRepositoryAsync : IRepositoryAsync<User>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<GenericResponse<User>> SelectUserInfoByUserIdAsync(Int32 userId);
    }
}
