using Ecommerce.Domain.Common;
using MediatR;
using System.Runtime.Serialization;

namespace Ecommerce.Application.Contract.Queries.User
{
    [DataContract]
    public class GetUserQueryRequest : IRequest<GenericResponse<GetUserQueryResponse>>
    {
        [DataMember]
        public String Username { get; set; }

        [DataMember]
        public String Password { get; set; }
    }
}
