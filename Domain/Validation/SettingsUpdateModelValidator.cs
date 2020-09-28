using System;
using FluentValidation;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Validation
{
    public partial class SettingsUpdateModelValidator
        : AbstractValidator<SettingsUpdateModel>
        {
            public SettingsUpdateModelValidator()
            {
                #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(100);
            #endregion
            }

        }
}