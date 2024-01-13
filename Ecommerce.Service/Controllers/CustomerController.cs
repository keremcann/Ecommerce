using Ecommerce.Application.Contract.Customer.Queries.Customer;
using Ecommerce.Domain.Common;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        IMediator _mediator;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mediator"></param>
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("getAllCustomer")]
        public async Task<IActionResult> GetAllCustomer([FromQuery] GetCustomerQueryRequest request)
        {
            GenericResponse<List<GetCustomerQueryResponse>> response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
