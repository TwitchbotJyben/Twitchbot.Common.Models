using System;
using FluentValidation;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Validation
{
    public partial class CommandsCreateModelValidator
        : AbstractValidator<CommandsCreateModel>
    {
        public CommandsCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).MaximumLength(50);
            #endregion
        }

    }
}
