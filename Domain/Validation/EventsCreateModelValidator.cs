using System;
using FluentValidation;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Validation
{
    public partial class EventsCreateModelValidator
        : AbstractValidator<EventsCreateModel>
    {
        public EventsCreateModelValidator()
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
