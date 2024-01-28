using AutoMapper;
using Ecommerce.Application.Contract.Customer.Queries;
using Ecommerce.Domain.Common;
using Ecommerce.Domain.RepositoriesAsync;
using MediatR;

namespace Ecommerce.Application.Handlers.Customer
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQueryRequest, GenericResponse<List<GetCustomerQueryResponse>>>
    {
        ICustomerRepositoryAsync _customerRepositoryAsync;
        IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        public GetCustomerQueryHandler(ICustomerRepositoryAsync customerRepositoryAsync, IMapper mapper)
        {
            _customerRepositoryAsync = customerRepositoryAsync;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<GenericResponse<List<GetCustomerQueryResponse>>> Handle(GetCustomerQueryRequest request, CancellationToken cancellationToken)
        {
            var response = new GenericResponse<List<GetCustomerQueryResponse>>();

            var customers = _customerRepositoryAsync.SelectAllAsync();
            if (!customers.Result.Success)
            {
                response.Success = customers.Result.Success;
                response.ErrorMessage = customers.Result.ErrorMessage;
                return await Task.FromResult(response);
            }
            var list = _mapper.Map<List<GetCustomerQueryResponse>>(customers.Result.Value);
            response.Value = list;
            response.Success = customers.Result.Success;
            response.InfoMessage = customers.Result.InfoMessage;
            return await Task.FromResult(response);
        }
    }
}
