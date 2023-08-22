namespace MVC_Kutuphane_Otomasonu.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Duyurular", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Duyurular", "MyProperty", c => c.Int(nullable: false));
        }
    }
}
