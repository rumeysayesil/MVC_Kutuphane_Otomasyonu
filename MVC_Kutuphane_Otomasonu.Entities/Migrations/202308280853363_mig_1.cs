namespace MVC_Kutuphane_Otomasonu.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Duyurular",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Baslik2 = c.String(nullable: false, maxLength: 150, unicode: false),
                        Duyuru = c.String(nullable: false, maxLength: 500),
                        Aciklama = c.String(),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kitaplar", t => t.KitapId, cascadeDelete: true)
                .ForeignKey("dbo.Uyeler", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.UyeId)
                .Index(t => t.KitapId);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KitapTurleri", t => t.KitapTuruId, cascadeDelete: true)
                .Index(t => t.KitapTuruId);
            
            CreateTable(
                "dbo.KitapHareketleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        UyeId = c.Int(nullable: false),
                        KitapId = c.Int(nullable: false),
                        YapilanIslem = c.String(nullable: false, maxLength: 150),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kitaplar", t => t.KitapId, cascadeDelete: true)
                .Index(t => t.KitapId);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kitaplar", t => t.KitapId, cascadeDelete: true)
                .Index(t => t.KitapId);
            
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
                "dbo.KullaniciHareketleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        Aciklama = c.String(nullable: false),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanicilars", t => t.KullaniciId, cascadeDelete: true)
                .Index(t => t.KullaniciId);
            
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
                "dbo.KullaniciRolleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        RolId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanicilars", t => t.KullaniciId, cascadeDelete: true)
                .ForeignKey("dbo.Roller", t => t.RolId, cascadeDelete: true)
                .Index(t => t.KullaniciId)
                .Index(t => t.RolId);
            
            CreateTable(
                "dbo.Roller",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rol = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KullaniciHareketleri", "KullaniciId", "dbo.Kullanicilars");
            DropForeignKey("dbo.KullaniciRolleri", "RolId", "dbo.Roller");
            DropForeignKey("dbo.KullaniciRolleri", "KullaniciId", "dbo.Kullanicilars");
            DropForeignKey("dbo.EmanetKitaplar", "UyeId", "dbo.Uyeler");
            DropForeignKey("dbo.EmanetKitaplar", "KitapId", "dbo.Kitaplar");
            DropForeignKey("dbo.Kitaplar", "KitapTuruId", "dbo.KitapTurleri");
            DropForeignKey("dbo.KitapKayitHareketleri", "KitapId", "dbo.Kitaplar");
            DropForeignKey("dbo.KitapHareketleri", "KitapId", "dbo.Kitaplar");
            DropIndex("dbo.KullaniciRolleri", new[] { "RolId" });
            DropIndex("dbo.KullaniciRolleri", new[] { "KullaniciId" });
            DropIndex("dbo.KullaniciHareketleri", new[] { "KullaniciId" });
            DropIndex("dbo.KitapKayitHareketleri", new[] { "KitapId" });
            DropIndex("dbo.KitapHareketleri", new[] { "KitapId" });
            DropIndex("dbo.Kitaplar", new[] { "KitapTuruId" });
            DropIndex("dbo.EmanetKitaplar", new[] { "KitapId" });
            DropIndex("dbo.EmanetKitaplar", new[] { "UyeId" });
            DropTable("dbo.Roller");
            DropTable("dbo.KullaniciRolleri");
            DropTable("dbo.Kullanicilars");
            DropTable("dbo.KullaniciHareketleri");
            DropTable("dbo.Iletisim");
            DropTable("dbo.Hakkimizda");
            DropTable("dbo.Uyeler");
            DropTable("dbo.KitapTurleri");
            DropTable("dbo.KitapKayitHareketleri");
            DropTable("dbo.KitapHareketleri");
            DropTable("dbo.Kitaplar");
            DropTable("dbo.EmanetKitaplar");
            DropTable("dbo.Duyurular");
        }
    }
}
