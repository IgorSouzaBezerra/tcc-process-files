using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProcessFile.API.Domain.Entities;

namespace ProcessFile.API.Infra.Mappings
{
    public class SulamericaMap : IEntityTypeConfiguration<Sulamerica>
    {
        public void Configure(EntityTypeBuilder<Sulamerica> builder)
        {
            builder.ToTable("Sulamerica");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn().HasColumnType("BIGINT");

            builder.Property(x => x.Sequencia).HasColumnName("Sequencia").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.Carteirinha).HasColumnName("Carteirinha").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.Nome).HasColumnName("Nome").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.CPF).HasColumnName("CPF").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.DataRegistro).HasColumnName("DataRegistro").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.Mais).HasColumnName("Mais").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.Valor).HasColumnName("Valor").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.CodigoAleatorio).HasColumnName("CodigoAleatorio").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.Nascimento).HasColumnName("Nascimento").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.CNPJ).HasColumnName("CNPJ").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.NomeColaborador).HasColumnName("NomeColaborador").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.NE).HasColumnName("NE").HasColumnType("VARCHAR(255)").IsRequired();

            //builder.Property(x => x.IdProcess).HasColumnName("ProcessId").IsRequired();
            //builder.HasOne(x => x.Process).WithMany().HasForeignKey(x => x.IdProcess);
        }
    }
}
