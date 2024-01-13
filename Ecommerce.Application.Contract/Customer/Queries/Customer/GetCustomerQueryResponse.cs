using Ecommerce.Domain.Common;
using System.Runtime.Serialization;

namespace Ecommerce.Application.Contract.Customer.Queries.Customer
{
    [DataContract]
    public class GetCustomerQueryResponse //: ResponseBase
    {
        [DataMember]
        public Int32 CustomerId { get; set; }

        [DataMember]
        public String FullName { get; set; }

        [DataMember]
        public String Email { get; set; }

        [DataMember]
        public String PhoneNumber { get; set; }
    }
}
