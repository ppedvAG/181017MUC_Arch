using ppedv.GoldCricket.Domain;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ppedv.GoldCricket.Data.EF
{
    public class EFContext : DbContext
    {
        //public EFContext() : base("Server=.;Database=GoldCricket;Trusted_Connection=true") { }
        public EFContext() : base("Server=(localdb)\\mssqllocaldb;Database=GoldCricket;Trusted_Connection=true;AttachDbFilename=C:\\temp\\meineDB.mdf") { }

        public DbSet<Application> Application { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Domain.Database> AppDatabase { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Konfiguration für das EF
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Person>().Property(x => x.Kontostand)
                                         .HasColumnName("Ka_ching")
                                         .IsRequired();
        }

    }
}
