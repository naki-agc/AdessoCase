using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoCase.Application.Queries.Game
{
    public class GameQueryModel : IRequest<GameResponseModel>
    {
        public int PeopleCount { get; set; }
    }
}
