using Business.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Photo;

namespace API.Controllers
{

    public class PhotoController : BaseController
    {
        private readonly IMediator _mediator;

        public PhotoController(IMediator mediator)
        {
            _mediator=mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePhotoModel model)
        {
            await _mediator.Send(new CreatePhotoCommand(model));
            return Ok();
            //return CreatedAtAction("Get", id);
        }
    }
}
