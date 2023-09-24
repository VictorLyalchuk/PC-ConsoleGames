using FluentValidation;
using PC_ConsoleGames.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_ConsoleGames.Core.Validations
{
    public class GameValidation : AbstractValidator<CreateGameDTO>
    {
        public GameValidation()
        {
            RuleFor(game => game.Name)
               .NotNull()
               .NotEmpty()
               .MinimumLength(2)
               .MaximumLength(200)
               .WithMessage("Value {PropertyValue} is incorrect. {PropertyName} is required and must be len greater 2... ");

            RuleFor(game => game.ReleaseDate)
                .LessThan(DateTime.Now)
                .WithMessage("Value {PropertyValue} of property {PropertyName} is incorrect.");

            RuleFor(game => game.Description)
                .NotNull()
                .WithMessage("{PropertyName} is required");

            RuleFor(game => game.Publisher)
                .NotNull()
                .WithMessage("{PropertyName} is required");
        }
    }
}
