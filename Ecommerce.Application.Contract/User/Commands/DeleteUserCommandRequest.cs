using Ecommerce.Domain.Common;
using MediatR;
using System.Runtime.Serialization;

namespace Ecommerce.Application.Contract.User.Commands
{
    [DataContract]
    public class DeleteUserCommandRequest : IRequest<GenericResponse<DeleteUserCommandResponse>>
    {
    }
}
