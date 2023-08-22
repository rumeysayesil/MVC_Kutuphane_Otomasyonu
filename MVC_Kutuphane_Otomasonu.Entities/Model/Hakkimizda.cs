using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Kutuphane_Otomasyonu.Entities.Model
{
    public class Hakkimizda
    {
        public int Id  { get; set; }

        public string Icerik { get; set; }

        public string Aciklama { get; set; }
    }
}
