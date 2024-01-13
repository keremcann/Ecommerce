using Ecommerce.Domain.Common;
using MediatR;
using System.Runtime.Serialization;

namespace Ecommerce.Application.Contract.Commands.User
{
    [DataContract]
    public class CreateUserCommandRequest : IRequest<GenericResponse<CreateUserCommandResponse>>
    {
        [DataMember]
        public String FullName { get; set; }

        [DataMember]
        public String UserName { get; set; }
        
        [DataMember]
        public String Password { get; set; }

        [DataMember]
        public String Email { get; set; }
    }
}
