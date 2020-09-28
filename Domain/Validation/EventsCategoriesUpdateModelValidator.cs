using System;
using FluentValidation;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Validation
{
    public partial class EventsCategoriesUpdateModelValidator
        : AbstractValidator<EventsCategoriesUpdateModel>
        {
            public EventsCategoriesUpdateModelValidator()
            {
                #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(100);
            #endregion
            }

        }
}