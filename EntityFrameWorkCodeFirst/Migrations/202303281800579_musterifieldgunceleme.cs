namespace EntityFrameWorkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class musterifieldgunceleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteri", "Degistirdim", c => c.String());
            Sql("UPDATE Musteri SET Degistirdim=yeni ");//yeni deki kullanıcı verilerini kaybetmemek için silinmeden önce içindekilerini set ile başka değişkene aldık
            DropColumn("dbo.Musteri", "yeni");//silinmeden önce yaptık. Artık yeni diye bir column yok
        }//ÇALIŞTI...
        
        public override void Down()
        {
            AddColumn("dbo.Musteri", "yeni", c => c.String());
            Sql("UPDATE Musteri SET yeni = Degistirdim");//geri almak istersek de veri kaybetmeyelim.
            DropColumn("dbo.Musteri", "Degistirdim");
        }
    }
}
