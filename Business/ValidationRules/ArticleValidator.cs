using Core.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.Title).NotEmpty().NotNull().WithMessage("You have to write a title.");
            RuleFor(x => x.Title).MaximumLength(250).WithMessage("Title contain max. 250 character.");

            RuleFor(x => x.Content).NotEmpty().NotNull().WithMessage("You have to write a content.");
            RuleFor(x => x.Content).MaximumLength(3000).WithMessage("Content contain max. 3000 character.");

            RuleFor(x => x.Topics).NotEmpty().NotNull().WithMessage("You have to choose at least one topic related your article.");
        }
    }
}
