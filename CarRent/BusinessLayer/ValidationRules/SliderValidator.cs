using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SliderValidator : AbstractValidator<Slider>
    {
        public SliderValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Title can not be null");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Minimum 5 Character");
        }
    }
}
