using MVC_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVC_Kutuphane_Otomasyonu.Entities.Mapping
{
    public class DuyurularMap:EntityTypeConfiguration<Duyurular>
    {
        public DuyurularMap()
        {

            this.ToTable("Duyurular");
            this.HasKey(x => x.Id);//Primary Key
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik artan sayı
            this.Property(x => x.Baslik).HasColumnType("varchar");//Kolon türü
            this.Property(x => x.Baslik).IsRequired().HasMaxLength(150);//Max karakter sayısı
            this.Property(x => x.Duyuru).IsRequired().HasMaxLength(500);
            this.Property(x => x.Aciklama).HasMaxLength(5000);

            this.Property(x => x.Id).HasColumnName("Id"); //Kolon Adlandıma
            this.Property(x => x.Baslik).HasColumnName("Baslik2");
            this.Property(x => x.Aciklama).HasColumnName("Aciklama");
            this.Property(x => x.Duyuru).HasColumnName("Duyuru");
            this.Property(x => x.Tarih).HasColumnName("Tarih");

        }
    }
}
