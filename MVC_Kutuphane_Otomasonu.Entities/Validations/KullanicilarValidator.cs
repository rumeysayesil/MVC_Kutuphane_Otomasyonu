using FluentValidation;
using MVC_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasonu.Entities.Validations
{
    public class KullanicilarValidator:AbstractValidator<Kullanicilar>
    {
        public KullanicilarValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilmez");
            RuleFor(x => x.Email).MaximumLength(150).WithMessage("Email alanı en fazla 150 karakter olabilir.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen bir Email formatı giriniz");

            RuleFor(x => x.AdiSoyadi).NotEmpty().WithMessage("Adı Soyadı alanı boş geçilmez");
            RuleFor(x => x.AdiSoyadi).MaximumLength(100).WithMessage("Adı Soyadı alanı en fazla 100 karakter olabilir.");
            RuleFor(x => x.KullaniciAdi).NotEmpty().WithMessage("Adı Soyadı alanı boş geçilmez");
            RuleFor(x => x.KullaniciAdi).MaximumLength(30).WithMessage("Adı Soyadı alanı en fazla 30 karakter olabilir.");

            RuleFor(x => x.Sifre).NotEmpty().WithMessage("Şifre alanı boş geçilmez");
            RuleFor(x => x.Sifre).MaximumLength(15).WithMessage("Şifre alanı en fazla 15 karakter olabilir.");


            RuleFor(x => x.Adres).NotEmpty().WithMessage("Adres alanı boş geçilmez");
            RuleFor(x => x.Adres).MaximumLength(500).WithMessage("Adres alanı en fazla 500 karakter olabilir.");
        }
    }
}
