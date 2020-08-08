using System;
using FluentValidation;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Validation
{
    public partial class ExtensionCreateModelValidator
        : AbstractValidator<ExtensionCreateModel>
    {
        public ExtensionCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(250);
            RuleFor(p => p.Text).MaximumLength(250);
            #endregion
        }

    }
}
