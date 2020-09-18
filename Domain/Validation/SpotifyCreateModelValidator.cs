using System;
using FluentValidation;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Validation
{
    public partial class SpotifyCreateModelValidator
        : AbstractValidator<SpotifyCreateModel>
    {
        public SpotifyCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Token).MaximumLength(100);
            RuleFor(p => p.RefreshToken).MaximumLength(100);
            #endregion
        }

    }
}
