using Ecommerce.Domain.Common;
using System.Runtime.Serialization;

namespace Ecommerce.Application.Contract.Customer.Queries
{
    [DataContract]
    public class GetCustomerQueryResponse //: ResponseBase
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public string FullName { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }
    }
}
