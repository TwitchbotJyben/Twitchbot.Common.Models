using System;
using FluentValidation;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Validation
{
    public partial class ExtensionUpdateModelValidator
        : AbstractValidator<ExtensionUpdateModel>
    {
        public ExtensionUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(250);
            RuleFor(p => p.Text).MaximumLength(250);
            #endregion
        }

    }
}
