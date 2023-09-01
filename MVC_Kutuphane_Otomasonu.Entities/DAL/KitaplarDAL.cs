using MVC_Kutuphane_Otomasyonu.Entities.Model.Context;
using MVC_Kutuphane_Otomasyonu.Entities.Repository;
using System;
using MVC_Kutuphane_Otomasyonu.Entities.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasonu.Entities.DAL
{
    public class KitaplarDAL:GenericRepository<KutuphaneContext,Kitaplar>
    {
    }
}
