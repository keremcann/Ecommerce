using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Common
{
    public abstract class ResponseBase
    {
        [NotMapped]
        public Boolean Success { get; set; }
        [NotMapped]
        public String InfoMessage { get; set; }
        [NotMapped]
        public String ErrorMessage { get; set; }
    }
}
