namespace EntityFrameWorkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableSatis : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Satis",
                c => new
                    {
                        SatisID = c.Int(nullable: false, identity: true),
                        Urun_UrunID = c.Int(),
                    })
                .PrimaryKey(t => t.SatisID)
                .ForeignKey("dbo.Tablo", t => t.Urun_UrunID)
                .Index(t => t.Urun_UrunID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Satis", "Urun_UrunID", "dbo.Tablo");
            DropIndex("dbo.Satis", new[] { "Urun_UrunID" });
            DropTable("dbo.Satis");
        }
    }
}
