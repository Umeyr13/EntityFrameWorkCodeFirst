using EntityFrameWorkCodeFirst.Etities;
using System;
using System.Data.Entity;
using System.Linq;

namespace EntityFrameWorkCodeFirst.DbContex_Model_
{
    public class Ornek_Db : DbContext
    {
        // Your context has been configured to use a 'Ornek_Db' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EntityFrameWorkCodeFirst.DbContex_Model_.Ornek_Db' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Ornek_Db' 
        // connection string in the application configuration file.
        public Ornek_Db()
            : base("name=Ornek_Db")
        {

        }

        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<Satis> Satislar { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}