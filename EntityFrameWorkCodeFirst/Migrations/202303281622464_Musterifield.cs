namespace EntityFrameWorkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Musterifield : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteri", "MusteriAdı", c => c.String());
            AddColumn("dbo.Musteri", "MusteriAdres", c => c.String());
            AddColumn("dbo.Musteri", "Telefon", c => c.String());
            AddColumn("dbo.Musteri", "yeni", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musteri", "yeni");
            DropColumn("dbo.Musteri", "Telefon");
            DropColumn("dbo.Musteri", "MusteriAdres");
            DropColumn("dbo.Musteri", "MusteriAdı");
        }
    }
}
