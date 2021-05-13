using System;
using FluentValidation;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Validation
{
    public partial class TokensCreateModelValidator
        : AbstractValidator<TokensCreateModel>
    {
        public TokensCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Token).NotEmpty();
            RuleFor(p => p.Token).MaximumLength(100);
            RuleFor(p => p.CreatedByIp).NotEmpty();
            RuleFor(p => p.CreatedByIp).MaximumLength(30);
            RuleFor(p => p.ReplacedByToken).MaximumLength(100);
            #endregion
        }

    }
}
