using System;

namespace Ecommerce.Domain.Common
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEntity
    {
        String CreateUser { get; set; }
        DateTime CreateDate { get; set; }
        String UpdateUser { get; set; }
        DateTime? UpdateDate { get; set; }
        String DeleteUser { get; set; }
        DateTime? DeleteDate { get; set; }
        Boolean IsActive { get; set; }
    }
}
