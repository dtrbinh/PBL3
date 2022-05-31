using PBL3.DTO;
using System;
using System.Data.Entity;
using System.Linq;

namespace PBL3
{
    public class PBL3Entities : DbContext
    {
        // connection string in the application configuration file.
        public PBL3Entities()
            : base("name=PBL3Entities")
        {
            Database.SetInitializer<PBL3Entities>(new CreateDB());
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Vaccine> Vaccines { get; set; }
        //public virtual DbSet<Citizen> Citizen { get; set; }
    }
}