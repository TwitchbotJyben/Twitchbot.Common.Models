using System;
using FluentValidation;
using Twitchbot.Common.Models.Domain.Models;

namespace Twitchbot.Common.Models.Domain.Validation
{
    public partial class UsersCreateModelValidator
        : AbstractValidator<UsersCreateModel>
        {
            public UsersCreateModelValidator()
            {
                #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(100);
            #endregion
            }

        }
}