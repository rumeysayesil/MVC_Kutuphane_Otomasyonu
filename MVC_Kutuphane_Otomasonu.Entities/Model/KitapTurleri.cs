using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using FluentValidation.Attributes;
using MVC_Kutuphane_Otomasonu.Entities.Validations;

namespace MVC_Kutuphane_Otomasyonu.Entities.Model
{
    [Validator(typeof(KitapTurleriValidator))]

    public class KitapTurleri
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string KitapTuru{ get; set; }
        public string Aciklama { get; set; }

        public ICollection<Kitaplar> Kitaplar { get; set; }//Çoğul adlandırma bir kitap tüü kategoisinde birden fazla kitap olabilir
    }
}
