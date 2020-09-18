using System;
using FluentValidation;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Validation
{
    public partial class EventsCategoriesCreateModelValidator
        : AbstractValidator<EventsCategoriesCreateModel>
    {
        public EventsCategoriesCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(100);
            #endregion
        }

    }
}
