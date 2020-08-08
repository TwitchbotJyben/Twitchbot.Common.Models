using System;
using FluentValidation;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Validation
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
