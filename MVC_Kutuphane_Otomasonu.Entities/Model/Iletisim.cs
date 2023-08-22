using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Kutuphane_Otomasyonu.Entities.Model
{
    public class Iletisim
    {
        public int Id { get; set; }
        public string AdiSoyadi { get; set; }

        public string Email { get; set; }

        public string Baslik { get; set; }
        public string Mesaj { get; set; }

        public string Aciklama { get; set; }

        public DateTime Tarih { get; set; }
    }
}
