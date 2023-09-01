using FluentValidation;
using MVC_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasonu.Entities.Validations
{
   public class DuyurlarValidator:AbstractValidator<Duyurular>
    {
        public DuyurlarValidator()
        {
            RuleFor(x => x.Baslik).NotEmpty().WithMessage("Başlık alanı boş geçilmez.");
            RuleFor(x => x.Duyuru).NotEmpty().WithMessage("Başlık alanı boş geçilmez.");
            RuleFor(x => x.Baslik).Length(5, 150).WithMessage("Başlık alanı 5-150 karakter arasında olmalıdır");
            RuleFor(x => x.Duyuru).MaximumLength(500).WithMessage("duyuru alanı en fazla 500 karakter arasında olmalıdır");
        }
    }
}
