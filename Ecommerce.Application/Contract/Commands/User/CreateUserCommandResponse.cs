using Ecommerce.Domain.Common;
using System.Runtime.Serialization;

namespace Ecommerce.Application.Contract.Commands.User
{
    [DataContract]
    public class CreateUserCommandResponse : ResponseBase
    {
        [DataMember]
        public Int32 UserId { get; set; }

        [DataMember]
        public Int32 RoleId { get; set; }
    }
}
