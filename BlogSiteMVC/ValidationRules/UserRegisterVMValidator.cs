using BlogSiteMVC.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.ValidationRules
{
    public class UserRegisterVMValidator : AbstractValidator<UserRegisterVM>
    {
        public UserRegisterVMValidator()
        {
            //RuleFor(x => x.UserRegister.Email).EmailAddress().WithMessage("Invalid mail address. Please try again.");
            RuleFor(x => x.UserRegister.Password).Matches(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[^\w\d\s:])([^\s]){8,16}$").WithMessage("Must contain 1 number(0 - 9), 1 uppercase letter, 1 lowercase letter, 1 non - alpha numeric number, 8 - 16 characters with no space");
        }
    }
}
