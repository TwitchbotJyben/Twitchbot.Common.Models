using System;
using FluentValidation;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Validation
{
    public partial class TwitchUpdateModelValidator
        : AbstractValidator<TwitchUpdateModel>
        {
            public TwitchUpdateModelValidator()
            {
                #region Generated Constructor
            RuleFor(p => p.Token).MaximumLength(50);
            RuleFor(p => p.ClientId).MaximumLength(50);
            RuleFor(p => p.RefreshToken).MaximumLength(50);
            #endregion
            }

        }
}