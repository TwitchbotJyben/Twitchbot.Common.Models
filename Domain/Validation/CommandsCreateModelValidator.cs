using System;
using FluentValidation;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Validation
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