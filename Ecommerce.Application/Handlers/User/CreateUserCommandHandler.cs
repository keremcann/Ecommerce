using AutoMapper;
using Ecommerce.Application.Contract.User.Commands;
using Ecommerce.Domain.Common;
using Ecommerce.Domain.RepositoriesAsync;
using MediatR;

namespace Ecommerce.Application.Handlers.User
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, GenericResponse<CreateUserCommandResponse>>
    {
        IUserRepositoryAsync _userRepositoryAsync;
        IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userRepositoryAsync"></param>
        /// <param name="mapper"></param>
        public CreateUserCommandHandler(IUserRepositoryAsync userRepositoryAsync, IMapper mapper)
        {
            _userRepositoryAsync = userRepositoryAsync;
            _mapper = mapper;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<GenericResponse<CreateUserCommandResponse>> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var response = new GenericResponse<CreateUserCommandResponse>();
            var req = _mapper.Map<Domain.Entities.User>(request);
            var result = _userRepositoryAsync.InsertAsync(req);
            if (!result.Result.Success)
            {
                response.Success = result.Result.Success;
                response.ErrorMessage = result.Result.ErrorMessage;
                return await Task.FromResult(response);
            }
            var isCreated = _mapper.Map<CreateUserCommandResponse>(result.Result.Value);
            response.Value = isCreated;
            response.Success = result.Result.Success;
            response.InfoMessage = result.Result.InfoMessage;
            return await Task.FromResult(response);
        }
    }
}
