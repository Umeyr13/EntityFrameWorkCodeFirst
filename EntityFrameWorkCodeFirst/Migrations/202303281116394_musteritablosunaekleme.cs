namespace EntityFrameWorkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class musteritablosunaekleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteri", "MusteriAdi", c => c.String());
            AddColumn("dbo.Musteri", "MusteriAdres", c => c.String());
            AddColumn("dbo.Musteri", "Telefon", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musteri", "Telefon");
            DropColumn("dbo.Musteri", "MusteriAdres");
            DropColumn("dbo.Musteri", "MusteriAdi");
        }
    }
}
