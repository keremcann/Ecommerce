using System;

namespace Ecommerce.Domain.Common
{
    public class GenericResponse<T> : ResponseBase
    {
        public T Value { get; set; }
    }
}
