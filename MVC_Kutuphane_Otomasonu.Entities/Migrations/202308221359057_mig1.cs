namespace MVC_Kutuphane_Otomasonu.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Duyurular",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Baslik = c.String(nullable: false, maxLength: 150, unicode: false),
                        Duyuru = c.String(nullable: false, maxLength: 500),
                        Aciklama = c.String(),
                        Tarih = c.DateTime(nullable: false),
                        MyProperty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.EmanetKitaplar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UyeId = c.Int(nullable: false),
                        KitapId = c.Int(nullable: false),
                        KitapSayisi = c.Int(nullable: false),
                        KitapAldigiTarih = c.DateTime(nullable: false),
                        KitapIadeTarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hakkimizda",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Icerik = c.String(nullable: false, maxLength: 500),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Iletisim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdiSoyadi = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 150),
                        Baslik = c.String(nullable: false, maxLength: 200),
                        Mesaj = c.String(nullable: false, maxLength: 500),
                        Aciklama = c.String(nullable: false),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KitapKayitHareketleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        KitapId = c.Int(nullable: false),
                        YapilanIslem = c.String(nullable: false, maxLength: 150),
                        Aciklama = c.String(),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kitaplar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BarkodNo = c.String(nullable: false, maxLength: 30),
                        KitapTuruId = c.Int(nullable: false),
                        KitapAdi = c.String(nullable: false, maxLength: 100),
                        Yazari = c.String(nullable: false, maxLength: 100),
                        YayinEvi = c.String(nullable: false, maxLength: 150),
                        StokAdedi = c.Int(nullable: false),
                        SayfaSayisi = c.Int(nullable: false),
                        Aciklama = c.String(nullable: false),
                        EklenmeTarihi = c.DateTime(nullable: false),
                        GüncellenmeTarihi = c.DateTime(nullable: false),
                        SilindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KitapTurleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KitapTuru = c.String(nullable: false, maxLength: 150),
                        Aciklama = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KullaniciHareketleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        Aciklama = c.String(nullable: false),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kullanicilars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                        AdiSoyadi = c.String(),
                        Telefon = c.String(),
                        Adres = c.String(),
                        Email = c.String(),
                        KayitTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roller",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rol = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Uyeler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdiSoyadi = c.String(nullable: false, maxLength: 100),
                        Telefon = c.String(nullable: false, maxLength: 10),
                        Adres = c.String(nullable: false, maxLength: 500),
                        Email = c.String(nullable: false, maxLength: 150),
                        Resim = c.String(),
                        OkunanKitapSayisi = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KitapHaeketleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        UyeId = c.Int(nullable: false),
                        KitapId = c.Int(nullable: false),
                        YapilanIslem = c.String(nullable: false, maxLength: 150),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KullaniciRolleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        RolId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KullaniciRolleri");
            DropTable("dbo.KitapHaeketleri");
            DropTable("dbo.Uyeler");
            DropTable("dbo.Roller");
            DropTable("dbo.Kullanicilars");
            DropTable("dbo.KullaniciHareketleri");
            DropTable("dbo.KitapTurleri");
            DropTable("dbo.Kitaplar");
            DropTable("dbo.KitapKayitHareketleri");
            DropTable("dbo.Iletisim");
            DropTable("dbo.Hakkimizda");
            DropTable("dbo.EmanetKitaplar");
            DropTable("dbo.Duyurular");
        }
    }
}
