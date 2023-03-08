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
            RuleFor(x => x.Description).NotEmpty().WithMessage("açıklama alanı boş geçilemez");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("resim alanı boş geçilemez");
            RuleFor(x => x.Description).MinimumLength(5).WithMessage("açıklama alanı için en az 5 karakter gerekli");

        }
    }
}
