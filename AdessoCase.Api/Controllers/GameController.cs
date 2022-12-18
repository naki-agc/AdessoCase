using AdessoCase.Application.Queries.Game;
using AdessoCase.Core.Controller;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AdessoCase.Api.Controllers
{
    public class GameController : BaseController
    {
        public GameController(IMediator mediatr) : base(mediatr)
        {
        }

        [HttpGet("begin-game")]
        public IActionResult BeginGame([FromQuery] GameQueryModel queryModel)
        {
            return Ok(_mediatr.Send(queryModel));
        }
    }
}
