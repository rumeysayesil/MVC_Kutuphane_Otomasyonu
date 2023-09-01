using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using FluentValidation.Attributes;
using MVC_Kutuphane_Otomasonu.Entities.Validations;

namespace MVC_Kutuphane_Otomasyonu.Entities.Model
{
    [Validator(typeof(KitaplarValidator))]
    public class Kitaplar
    {
        public int Id { get; set; }
        public string BarkodNo { get; set; }
        public int KitapTuruId { get; set; }
        public string KitapAdi { get; set; }
        public string Yazari { get; set; }
        public string YayinEvi { get; set; }
        public int StokAdedi { get; set; }
        public int SayfaSayisi  { get; set; }
        public  string Aciklama { get; set; }
        public DateTime EklenmeTarihi { get; set; }= DateTime.Now;  
        public DateTime GüncellenmeTarihi { get; set; }=DateTime.Now;   
        public bool SilindiMi { get; set; }=false;

        public KitapTurleri  KitapTurleri { get; set; }//tekil adlandrma yani bir kitap ancak bir kitap türü kategorisine ait olabilir
        public List<EmanetKitaplar> EmanetKitaplar{ get; set; }
        public List<KitapHareketleri> KitapHareketleri { get; set; }
        public List<KitapKayitHareketleri> KitapKayitHareketleri { get; set; }

    }
} 
