using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sdt.Data.EntityTypeConfiguration;
using Sdt.Domain.Entities;

namespace Sdt.Data.Context
{
    public class SdtDataContext : DbContext
    {
        public DbSet<Autor> Autoren { get; set; }
        public DbSet<Spruch> Sprueche { get; set; }

        public SdtDataContext(DbContextOptions<SdtDataContext> options) : base(options)
        {
            //Database.EnsureCreated();

            //Reverse Engineering
            //Scaffold-DbContext "Server=(localdb)\mssqllocaldb;Database=CsaeSdt;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Modeltest
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Autor>().ToTable("Autoren");
            //modelBuilder.ApplyConfiguration(new AutorEntityConf());

            modelBuilder.Seed();
        }
    }
}
