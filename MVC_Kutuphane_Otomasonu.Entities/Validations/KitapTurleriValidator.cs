using FluentValidation;
using MVC_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasonu.Entities.Validations
{
    public class KitapTurleriValidator:AbstractValidator<KitapTurleri>
    {
        public KitapTurleriValidator()
        {
            RuleFor(x => x.KitapTuru).NotEmpty().WithMessage("Kitap Türü alanı boş geçilmez");
            RuleFor(x => x.KitapTuru).MinimumLength(4).WithMessage("Kitap Türü alanı 4 karakterden az olmamalıdır");
            RuleFor(x => x.KitapTuru).MaximumLength(150).WithMessage("Kitap Türü alanı en fazla 150 karakter olabilir");

        }
    }
}
