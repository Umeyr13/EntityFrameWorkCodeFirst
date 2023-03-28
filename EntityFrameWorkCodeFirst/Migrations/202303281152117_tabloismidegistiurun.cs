namespace EntityFrameWorkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tabloismidegistiurun : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Tablo", newName: "Urun");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Urun", newName: "Tablo");
        }
    }
}
