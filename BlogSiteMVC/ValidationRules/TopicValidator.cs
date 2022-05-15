using Core.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.ValidationRules
{
    public class TopicValidator : AbstractValidator<Topic>
    {
        public TopicValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().MaximumLength(100).WithMessage("Topic name must be fill.");
        }
    }
}
