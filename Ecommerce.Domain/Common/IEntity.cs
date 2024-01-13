using System;

namespace Ecommerce.Domain.Common
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEntity
    {
        Int32 CreateUser { get; set; }
        DateTime CreateDate { get; set; }
        Int32? UpdateUser { get; set; }
        DateTime? UpdateDate { get; set; }
        Int32? DeleteUser { get; set; }
        DateTime? DeleteDate { get; set; }
    }
}
