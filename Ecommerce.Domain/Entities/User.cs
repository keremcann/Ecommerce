using Ecommerce.Domain.Common;

namespace Ecommerce.Domain.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class User : IEntity
    {
        public Int32 UserId { get; set; }
        public String FullName { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public DateTime? ExpireDate { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
        public Int32 CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Int32? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
