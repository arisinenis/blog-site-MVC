using BlogSiteMVC.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.ValidationRules
{
    public class UserVMValidator : AbstractValidator<UserVM>
    {
        public UserVMValidator()
        {
            RuleFor(x => x.UserRegister.Email).EmailAddress().WithMessage("Invalid mail address. Please try again.");
            //RuleFor(x => x.UserRegister.Email).Matches(@"/^((?!\.)[\w-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$/gim;").WithMessage("Please enter a valid email address.");
            RuleFor(x => x.UserRegister.Email).NotNull().WithMessage("You can not register without email.").NotEmpty().WithMessage("You can not register without email.");
            RuleFor(x => x.UserRegister.Password).Matches(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[^\w\d\s:])([^\s]){8,16}$").WithMessage("Must contain 1 number(0 - 9), 1 uppercase letter, 1 lowercase letter, 1 non - alpha numeric number, 8 - 16 characters with no space");
            RuleFor(x => x.UserRegister.UserName).NotNull().WithMessage("You can not register without User Name.").NotEmpty().WithMessage("You can not register without User Name.");
            RuleFor(x => x.UserInformation.FirstName).NotNull().WithMessage("Firstname section must be fill.").NotEmpty().MaximumLength(200).WithMessage("Firstname section must be fill.");
            RuleFor(x => x.UserInformation.LastName).NotNull().WithMessage("LastName section must be fill.").NotEmpty().MaximumLength(200).WithMessage("LastName section must be fill.");
            //RuleFor(x => x.UserInformation.Description).NotNull().WithMessage("Description section must be fill.").NotEmpty().MaximumLength(500).WithMessage("Description section must be fill.");
            RuleFor(x => x.UserInformation.Photo).NotNull().WithMessage("Please choose a photo.").NotEmpty().WithMessage("Please choose a photo.");
        }
    }
}
