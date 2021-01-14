using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sdt.Domain.Entities;

namespace Sdt.Data.EntityTypeConfiguration
{
    class AutorEntityConf : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.ToTable("Autoren");

            builder.HasKey(c => c.AutorId);
            builder.Property(c => c.AutorId)
                .IsRequired()
                .ValueGeneratedOnAdd();

            //Name
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(50);

            //Beschreibung
            builder.Property(c => c.Beschreibung).IsRequired();
            builder.Property(c => c.Beschreibung).HasMaxLength(255);

            //Geburtsdatum
            builder.Property(c => c.Geburtsdatum).IsRequired(false);
            //builder.Property(c => c.Geburtsdatum).HasColumnType("datetime2");

            //Photo
            builder.Property(c => c.Photo).IsRequired(false);
            builder.Property(c => c.PhotoMimeType).IsRequired(false);

            //Relation
            builder.HasMany(c => c.Sprueche).WithOne(c => c.Autor);
        }
    }
}
