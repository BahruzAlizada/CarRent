using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Title Can not be null");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Minimum 50 Character");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description can not be null");
        }
    }
}
