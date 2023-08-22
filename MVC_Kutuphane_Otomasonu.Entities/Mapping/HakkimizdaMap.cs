﻿using MVC_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasyonu.Entities.Mapping
{
    public class HakkimizdaMap:EntityTypeConfiguration<Hakkimizda> 
    {
        public HakkimizdaMap()
        {
            this.ToTable("Hakkimizda");
            this.HasKey(x => x.Id);//Primary Key
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik artan sayı
            this.Property(x => x.Icerik).IsRequired().HasMaxLength(500);
            this.Property(x => x.Aciklama).HasMaxLength(5000);//İlgili alana kısıtlama getiriyor
        }
    }
}
