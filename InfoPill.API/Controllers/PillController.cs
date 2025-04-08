using InfoPill.Application.UseCases.Pill.Register;
using InfoPill.Application.UseCases.Pill.Update;
using InfoPill.Communication.Requests;
using InfoPill.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace InfoPill.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PillController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterPillJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestPillJson request)
        {
            var useCase = new RegisterPillUseCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update([FromRoute] int id, RequestPillJson request )
        {
            var useCase = new UpdatePillUseCase();
            useCase.Execute(id, request);

            return NoContent();
        }
    }
}
