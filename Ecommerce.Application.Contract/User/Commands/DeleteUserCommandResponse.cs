using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Contract.User.Commands
{
    [DataContract]
    public class DeleteUserCommandResponse
    {
        [DataMember]
        public int? IsDeleted { get; set; }
    }
}
