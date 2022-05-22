using BlogSiteMVC.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.ValidationRules
{
    public class UserInformationVMValidator : AbstractValidator<UserInformationVM>
    {
        public UserInformationVMValidator()
        {
            RuleFor(x => x.UserInformation.FirstName).NotNull().NotEmpty().MaximumLength(200).WithMessage("Firstname section must be fill.");
            RuleFor(x => x.UserInformation.LastName).NotNull().NotEmpty().MaximumLength(200).WithMessage("LastName section must be fill.");
            RuleFor(x => x.UserInformation.Description).NotNull().NotEmpty().MaximumLength(500).WithMessage("Description section must be fill.");

        }
    }
}
