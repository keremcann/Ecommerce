using System.Runtime.Serialization;

namespace Ecommerce.Application.Contract.User.Commands
{
    [DataContract]
    public class CreateUserCommandResponse
    {
        [DataMember]
        public int? IsCreated { get; set; }
    }
}
