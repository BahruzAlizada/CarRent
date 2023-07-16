using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    internal class SocialMediaValidator : AbstractValidator<SocialMedia>
    {
        public SocialMediaValidator()
        {
            RuleFor(x => x.InstgramLink).NotEmpty().WithMessage("Link can not be null");
            RuleFor(x => x.FacebookLink).NotEmpty().WithMessage("Link can not be null");
            RuleFor(x => x.YoutbeLink).NotEmpty().WithMessage("Link can not be null");
            RuleFor(x => x.TvitterLink).NotEmpty().WithMessage("Link can not be null");
        }
    }
}
