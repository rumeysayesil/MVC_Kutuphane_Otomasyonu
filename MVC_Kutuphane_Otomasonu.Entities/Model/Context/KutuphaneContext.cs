using MVC_Kutuphane_Otomasyonu.Entities.Mapping;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;



namespace MVC_Kutuphane_Otomasyonu.Entities.Model.Context
{
    public class KutuphaneContext : DbContext
    {
        public KutuphaneContext() : base("Kutuphane")
        {

        }
        public DbSet<Duyurular> Duyurular { get; set; }
        public DbSet<EmanetKitaplar> EmanetKitaplar { get; set; }
        public DbSet<Hakkimizda> Hakkimizda { get; set; }
        public DbSet<Iletisim> Iletisimr { get; set; }
        public DbSet<KitapKayitHareketleri> KitapKayitHareketleri { get; set; }
        public DbSet<Kitaplar> Kitaplar { get; set; }
        public DbSet<KitapTurleri> KitapTurleri { get; set; }
        public DbSet<KullaniciHareketleri> KullaniciHareketleri { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<Roller> Roller { get; set; }
        public DbSet<Uyeler> Uyeler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DuyurularMap());
            modelBuilder.Configurations.Add(new EmanetKitaplarMap());
            modelBuilder.Configurations.Add(new HakkimizdaMap());
            modelBuilder.Configurations.Add(new IletisimMap());
            modelBuilder.Configurations.Add(new KitapHareketleriMap());
            modelBuilder.Configurations.Add(new KitapKayitHareketleriMap());
            modelBuilder.Configurations.Add(new KitaplarMap());
            modelBuilder.Configurations.Add(new KitapTurleriMap());
            modelBuilder.Configurations.Add(new KullaniciHareketleriMap());
            modelBuilder.Configurations.Add(new KullaniciRolleriMap());
            modelBuilder.Configurations.Add(new RollerMap());
            modelBuilder.Configurations.Add(new UyelerMap());
        }


    }

    
    
}
