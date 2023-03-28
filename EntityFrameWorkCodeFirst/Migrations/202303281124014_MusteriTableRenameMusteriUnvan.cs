namespace EntityFrameWorkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MusteriTableRenameMusteriUnvan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteri", "MusteriÜnvanı", c => c.String());
            AddColumn("dbo.Musteri", "yeni", c => c.String());
            Sql("UPDATE Musteri SET MusteriÜnvanı = MusteriAdi");
            DropColumn("dbo.Musteri", "MusteriAdi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musteri", "MusteriAdi", c => c.String());
            DropColumn("dbo.Musteri", "yeni");
            Sql("UPDATE Musteri SET MusteriAdi = MusteriÜnvanı");
            DropColumn("dbo.Musteri", "MusteriÜnvanı");
        }
    }
}
