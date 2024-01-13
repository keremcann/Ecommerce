using Ecommerce.Domain.Common;
using System.Data;

namespace Ecommerce.Core.Connection
{
    public class DbConnectionResponse : ResponseBase
    {
        public IDbConnection db { get; set; }
    }
}
