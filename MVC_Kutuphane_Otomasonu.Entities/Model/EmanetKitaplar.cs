using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Kutuphane_Otomasyonu.Entities.Model
{
    public class EmanetKitaplar
    {
        public int Id { get; set; }

        public int UyeId { get; set; }
        public int KitapId { get; set; }
        public int KitapSayisi { get; set; }

        public DateTime KitapAldigiTarih { get; set; }
        public DateTime KitapIadeTarih { get; set; }
       
    }
}
