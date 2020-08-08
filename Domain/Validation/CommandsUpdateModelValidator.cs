using System;
using FluentValidation;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Validation
{
    public partial class CommandsUpdateModelValidator
        : AbstractValidator<CommandsUpdateModel>
    {
        public CommandsUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
