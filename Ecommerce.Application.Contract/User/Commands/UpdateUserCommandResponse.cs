using System.Runtime.Serialization;

namespace Ecommerce.Application.Contract.User.Commands
{
    [DataContract]
    public class UpdateUserCommandResponse
    {
        [DataMember]
        public int? IsUpdated { get; set; }
    }
}
