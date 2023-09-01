﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using FluentValidation.Attributes;
using MVC_Kutuphane_Otomasonu.Entities.Validations;

namespace MVC_Kutuphane_Otomasyonu.Entities.Model
{
    [Validator(typeof(KullanicilarValidator))]
    public class Kullanicilar
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string AdiSoyadi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Email{ get; set; }
        public DateTime KayitTarihi  { get; set; }
        public List <KullaniciHareketleri> KullaniciHareketleri { get; set; }
        public List <KullaniciRolleri> KullaniciRolleri { get; set; }

    }
}
