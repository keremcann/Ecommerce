using Ecommerce.Domain.Common;
using MediatR;
using System.Runtime.Serialization;

namespace Ecommerce.Application.Contract.Customer.Queries.Customer
{
    [DataContract]
    public class GetCustomerQueryRequest : IRequest<GenericResponse<List<GetCustomerQueryResponse>>>
    {
        
    }
}
