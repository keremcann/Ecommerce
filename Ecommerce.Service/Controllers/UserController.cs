using Ecommerce.Application.Contract.User.Commands;
using Ecommerce.Domain.Common;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IMediator _mediator;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mediator"></param>
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("createUser")]
        public async Task<IActionResult> CreateUser([FromQuery] CreateUserCommandRequest request)
        {
            GenericResponse<CreateUserCommandResponse> response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("updateUser")]
        public async Task<IActionResult> UpdateUser([FromQuery] UpdateUserCommandRequest request)
        {
            GenericResponse<UpdateUserCommandResponse> response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("deleteUser")]
        public async Task<IActionResult> DeleteUser([FromQuery] DeleteUserCommandRequest request)
        {
            GenericResponse<DeleteUserCommandResponse> response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
