﻿using FluentValidation;
using MVC_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasonu.Entities.Validations
{
    public class KitapHareketleriValidator:AbstractValidator<KitapHareketleri>
    {
        public KitapHareketleriValidator()
        {
            RuleFor(x=>x.YapilanIslem).MaximumLength(150).WithMessage("Yapılan işlem en fazla 150 karakter olabilir");
        }
    }
}
