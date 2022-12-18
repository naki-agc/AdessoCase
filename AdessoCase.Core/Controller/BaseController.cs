using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoCase.Core.Controller
{
    [Route("api/[controller]"), ApiController]
    public class BaseController : ControllerBase
    {
        protected readonly IMediator _mediatr;
        public BaseController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }
    }
}
