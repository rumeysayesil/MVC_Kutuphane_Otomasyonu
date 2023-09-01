using FluentValidation;
using MVC_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasonu.Entities.Validations
{
    public class KitaplarValidator:AbstractValidator<Kitaplar>
    {
        public KitaplarValidator()
        {
            RuleFor(x => x.BarkodNo).NotEmpty().WithMessage("BarkodNo alanı boş geçilmez");
            RuleFor(x => x.BarkodNo).MaximumLength(30).WithMessage("BarkodNo alanı en fazla 30 karakter olabilir");

            RuleFor(x => x.KitapAdi).NotEmpty().WithMessage("Kitap Adı alanı boş geçilmez");
            RuleFor(x => x.KitapAdi).MaximumLength(100).WithMessage("Kitap Adı alanı en fazla 100 karakter olabilir");

            RuleFor(x => x.Yazari).NotEmpty().WithMessage("Yazarı alanı boş geçilmez");
            RuleFor(x => x.Yazari).MaximumLength(100).WithMessage("Yazarı alanı en fazla 100 karakter olabilir");

            RuleFor(x => x.YayinEvi).NotEmpty().WithMessage("Yayın Evi alanı boş geçilmez");
            RuleFor(x => x.YayinEvi).MaximumLength(150).WithMessage("Yayın Evi alanı en fazla 150 karakter olabilir");
            RuleFor(x => x.KitapTuruId).NotEmpty().WithMessage("Kitap Türü alanı boş geçilmez");
        }
    }
}
