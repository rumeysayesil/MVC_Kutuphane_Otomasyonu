using FluentValidation;
using MVC_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasonu.Entities.Validations
{
    public class HakkimizdaValidator:AbstractValidator<Hakkimizda>
    {
        public HakkimizdaValidator()
        {
            RuleFor(x => x.Icerik).NotEmpty().WithMessage("İçerik alanı bş geçilmez");
            RuleFor(x => x.Icerik).MaximumLength(500).WithMessage("İçerik alanı en fazla 500 karakter olabilir.");

        }
    }

}
