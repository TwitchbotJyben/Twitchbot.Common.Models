using System;
using FluentValidation;
using Twitchbot.Models.Domain.Models;

namespace Twitchbot.Models.Domain.Validation
{
    public partial class UsersUpdateModelValidator
        : AbstractValidator<UsersUpdateModel>
    {
        public UsersUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(100);
            #endregion
        }

    }
}
