using AutoMapper;
using Ecommerce.Application.Contract.Customer.Queries;
using Ecommerce.Application.Contract.User.Commands;
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
            CreateMap<User, CreateUserCommandRequest>().ReverseMap();
            CreateMap<User, CreateUserCommandResponse>().ReverseMap();
            CreateMap<User, UpdateUserCommandRequest>().ReverseMap();
            CreateMap<User, UpdateUserCommandResponse>().ReverseMap();
            CreateMap<User, DeleteUserCommandRequest>().ReverseMap();
            CreateMap<User, DeleteUserCommandResponse>().ReverseMap();
            #endregion

            #region Customer
            CreateMap<Customer, GetCustomerQueryResponse>().ReverseMap();
            #endregion
        }
    }
}
