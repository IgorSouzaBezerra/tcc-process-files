using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProcessFile.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessFile.API.Infra.Mappings
{
    public class ColumnControlMap : IEntityTypeConfiguration<ColumnControl>
    {
        public void Configure(EntityTypeBuilder<ColumnControl> builder)
        {
            builder.ToTable("ColumnControls");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn().HasColumnType("BIGINT");

            builder.Property(x => x.ColumnPosition).HasColumnName("ColumnPosition").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.Start).HasColumnName("Start").HasColumnType("INT").IsRequired();
            builder.Property(x => x.End).HasColumnName("End").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Size).HasColumnName("Size").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Field).HasColumnName("Field").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.FieldCode).HasColumnName("FieldCode").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.Typing).HasColumnName("Typing").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.Company).HasColumnName("Company").HasColumnType("VARCHAR(255)").IsRequired();
        }
    }
}
