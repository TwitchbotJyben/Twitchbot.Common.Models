using System;
using FluentValidation;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Validation
{
    public partial class EventsUpdateModelValidator
        : AbstractValidator<EventsUpdateModel>
        {
            public EventsUpdateModelValidator()
            {
                #region Generated Constructor
            RuleFor(p => p.UserName).NotEmpty();
            RuleFor(p => p.UserName).MaximumLength(100);
            RuleFor(p => p.Object).NotEmpty();
            RuleFor(p => p.Object).MaximumLength(100);
            #endregion
            }

        }
}