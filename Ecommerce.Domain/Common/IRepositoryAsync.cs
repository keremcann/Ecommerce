using Ecommerce.Domain.Common;

namespace Ecommerce.Domain.Common
{
    public interface IRepositoryAsync<T>
    {
        #region Async Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<GenericResponse<List<T>>> SelectAllAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GenericResponse<T>> SelectAsync(T request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GenericResponse<T>> InsertAsync(T request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GenericResponse<T>> UpdateAsync(T request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GenericResponse<T>> RemoveAsync(T request);

        #endregion
    }
}
