using Core.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class UserRegisterValidator : AbstractValidator<UserRegister>
    {
        public UserRegisterValidator()
        {
            RuleFor(x => x.Email).EmailAddress().WithMessage("Invalid mail address. Please try again.");
            RuleFor(x => x.Email).NotNull().NotEmpty().WithMessage("You can not register without email.");
        }
    }
}
