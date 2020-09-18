using System;
using FluentValidation;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Validation
{
    public partial class CommandsTypeCreateModelValidator
        : AbstractValidator<CommandsTypeCreateModel>
    {
        public CommandsTypeCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(100);
            #endregion
        }

    }
}
