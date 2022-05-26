using BlogSiteMVC.Models;
using Core.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class ArticleCreateVMValidator : AbstractValidator<ArticleCreateVM>
    {
        public ArticleCreateVMValidator()
        {
            //RuleFor(x => x.Title).NotEmpty().WithMessage("You have to write a title.");
            //RuleFor(x => x.Title).MaximumLength(250).WithMessage("Title contain max. 250 character.");

            //RuleFor(x => x.Content).NotEmpty().WithMessage("You have to write a content.");
            //RuleFor(x => x.Content).MaximumLength(3000).WithMessage("Content contain max. 3000 character.");

            //RuleFor(x => x.Topics).NotEmpty().WithMessage("You have to choose at least one topic related your article.");

            //RuleFor(x => x.TotalReadingTime).NotEmpty().WithMessage("You have to choose total reading time.");
        }
    }
}
