using InfoPill.Application.UseCases.Pill.GetAll;
using InfoPill.Application.UseCases.Pill.GetPillByIdUseCase;
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

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllPillJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllPillsUseCase();
            var response = useCase.Execute();
            
            if (response.Pills.Any())
            {
                return Ok(response);
            }
            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponsePillJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult Get([FromRoute] int id)
        {
            var useCase = new GetPillByIdUseCase();
            var response = useCase.Execute(id);

            return Ok(response);
        }
    }
}
