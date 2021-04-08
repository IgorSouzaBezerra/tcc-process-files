using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProcessFile.API.Domain.Entities;

namespace ProcessFile.API.Infra.Mappings
{
    public class ProcessMap : IEntityTypeConfiguration<Process>
    {
        public void Configure(EntityTypeBuilder<Process> builder)
        {
            builder.ToTable("Process");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn().HasColumnType("BIGINT");

            builder.Property(x => x.Title).HasColumnName("Title").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.StartDate).HasColumnName("StartDate").HasColumnType("DATETIME2").IsRequired();
        }
    }
}
