using System;
using System.Data.Entity;
using System.Linq;
using PBL3.DTO;

namespace PBL3
{
    public class PBL3Entities : DbContext
    {
        // Your context has been configured to use a 'PBL3Entities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PBL3.PBL3Entities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PBL3Entities' 
        // connection string in the application configuration file.
        public PBL3Entities()
            : base("name=PBL3Entities1")
        {
            Database.SetInitializer<PBL3Entities>(new CreateDatabase());
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Vaccine> Vaccines { get; set; }


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