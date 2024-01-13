using Ecommerce.Domain.Common;

namespace Ecommerce.Domain.Common
{
    public interface IRepository<T>
    {
        #region Not Async Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        GenericResponse<List<T>> SelectAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        GenericResponse<T> Select(Object id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        GenericResponse<T> Insert(T entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        GenericResponse<T> Update(T entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        GenericResponse<T> Remove(Object id);

        #endregion
    }
}
