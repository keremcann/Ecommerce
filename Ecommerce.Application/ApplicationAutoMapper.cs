using AutoMapper;
using Ecommerce.Application.Contract.Commands.User;
using Ecommerce.Application.Contract.Customer.Queries.Customer;
using Ecommerce.Application.Contract.Queries.User;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationAutoMapper : Profile 
    {
        /// <summary>
        /// 
        /// </summary>
        public ApplicationAutoMapper() 
        {
            #region User
            CreateMap<User, GetUserQueryResponse>().ReverseMap();
            #endregion

            #region Customer
            CreateMap<Customer, GetCustomerQueryResponse>().ReverseMap();
            #endregion
        }
    }
}
