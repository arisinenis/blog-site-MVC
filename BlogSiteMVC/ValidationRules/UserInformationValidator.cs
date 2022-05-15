using Core.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.ValidationRules
{
    public class UserInformationValidator : AbstractValidator<UserInformation>
    {
        public UserInformationValidator()
        {
            RuleFor(x => x.FirstName).NotNull().NotEmpty().MaximumLength(200).WithMessage("Firstname section must be fill.");
            RuleFor(x => x.LastName).NotNull().NotEmpty().MaximumLength(200).WithMessage("LastName section must be fill.");
            RuleFor(x => x.Description).NotNull().NotEmpty().MaximumLength(500).WithMessage("Description section must be fill.");

        }
    }
}
