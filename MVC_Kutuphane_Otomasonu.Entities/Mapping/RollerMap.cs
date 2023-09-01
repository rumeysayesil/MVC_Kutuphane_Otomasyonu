using MVC_Kutuphane_Otomasyonu.Entities.Model;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasyonu.Entities.Mapping
{
    public class RollerMap:EntityTypeConfiguration<Roller>
    {
        public RollerMap()
        {

            this.ToTable("Roller");
            this.HasKey(x => x.Id);//Primary Key
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik artan sayı
            this.Property(x => x.Rol).IsRequired().HasMaxLength(50);
           
        }
    }
}
