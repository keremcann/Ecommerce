using Ecommerce.Domain.Common;
using MediatR;
using System.Runtime.Serialization;

namespace Ecommerce.Application.Contract.User.Commands
{
    [DataContract]
    public class CreateUserCommandRequest : IRequest<GenericResponse<CreateUserCommandResponse>>
    {
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public DateTime? ExpireDate { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
    }
}
