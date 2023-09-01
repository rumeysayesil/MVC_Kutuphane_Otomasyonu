 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Attributes;
using MVC_Kutuphane_Otomasonu.Entities.Validations;

namespace MVC_Kutuphane_Otomasyonu.Entities.Model
{
    [Validator(typeof(DuyurlarValidator))]
    
    public class Duyurular
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Duyuru { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
    }
}
