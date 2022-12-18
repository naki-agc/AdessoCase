using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdessoCase.Application.Queries.Game
{
    public class GameValidation : AbstractValidator<GameQueryModel>
    {
        public GameValidation()
        {
            RuleFor(x=> x.PeopleCount).NotEmpty();
            RuleFor(x => x).Must(x => x.PeopleCount < 100);
        }
    }
}
