using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Kutuphane_Otomasyonu.Entities.Model
{

    public class KitapTurleri
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string KitapTuru{ get; set; }
        public string Aciklama { get; set; }
    }
}
