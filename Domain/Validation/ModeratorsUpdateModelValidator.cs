using System;
using FluentValidation;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Validation
{
    public partial class ModeratorsUpdateModelValidator
        : AbstractValidator<ModeratorsUpdateModel>
    {
        public ModeratorsUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).MaximumLength(100);
            #endregion
        }

    }
}
