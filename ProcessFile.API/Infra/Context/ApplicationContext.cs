using Microsoft.EntityFrameworkCore;
using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Domain.Enum;

namespace ProcessFile.API.Infra.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() {}

        public ApplicationContext(DbContextOptions options) : base(options) {}

        public virtual DbSet<ColumnControl> ColumnControls { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Process> Process { get; set; }
        public virtual DbSet<Sulamerica> Sulamericas { get; set; }
        public virtual DbSet<Unimed> Unimed { get; set; }
        public virtual DbSet<JobEvent> JobEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Administrador",
                    Email = "adm@adm.com",
                    Password = "B09C600FDDC573F117449B3723F23D64",
                    Avatar = null,
                    UserStatus = UserStatus.Active
                }
            );
            builder.Entity<ColumnControl>().HasData(
                new ColumnControl
                {
                    Id = 1,
                    ColumnPosition = 0,
                    Start = 0,
                    End = 1,
                    Size = 2,
                    Field = "Sequência",
                    FieldCode = "sequencia",
                    Typing = "Texto",
                    Company = "Sulamerica"
                },
                new ColumnControl
                {
                    Id = 2,
                    ColumnPosition = 1,
                    Start = 2,
                    End = 17,
                    Size = 16,
                    Field = "Carteirinha",
                    FieldCode = "carteirinha",
                    Typing = "Texto",
                    Company = "Sulamerica"
                },
                new ColumnControl
                {
                    Id = 3,
                    ColumnPosition = 2,
                    Start = 18,
                    End = 56,
                    Size = 38,
                    Field = "Nome",
                    FieldCode = "nome",
                    Typing = "Texto",
                    Company = "Sulamerica"
                },
                new ColumnControl
                {
                    Id = 4,
                    ColumnPosition = 3,
                    Start = 57,
                    End = 67,
                    Size = 11,
                    Field = "CPF",
                    FieldCode = "cpf",
                    Typing = "Texto",
                    Company = "Sulamerica"
                },
                new ColumnControl
                {
                    Id = 5,
                    ColumnPosition = 4,
                    Start = 68,
                    End = 74,
                    Size = 7,
                    Field = "Data do Registro",
                    FieldCode = "dataRegistro",
                    Typing = "Texto",
                    Company = "Sulamerica"
                },
                new ColumnControl
                {
                    Id = 6,
                    ColumnPosition = 5,
                    Start = 75,
                    End = 75,
                    Size = 1,
                    Field = "Mais",
                    FieldCode = "mais",
                    Typing = "Texto",
                    Company = "Sulamerica"
                },
                new ColumnControl
                {
                    Id = 7,
                    ColumnPosition = 6,
                    Start = 76,
                    End = 90,
                    Size = 15,
                    Field = "Valor",
                    FieldCode = "valor",
                    Typing = "Decimal",
                    Company = "Sulamerica"
                },
                new ColumnControl
                {
                    Id = 8,
                    ColumnPosition = 7,
                    Start = 91,
                    End = 95,
                    Size = 5,
                    Field = "Codigo Aleatorio",
                    FieldCode = "codigoAleatorio",
                    Typing = "Decimal",
                    Company = "Sulamerica"
                },
                new ColumnControl
                {
                    Id = 9,
                    ColumnPosition = 8,
                    Start = 96,
                    End = 105,
                    Size = 10,
                    Field = "Nascimento",
                    FieldCode = "nascimento",
                    Typing = "Data",
                    Company = "Sulamerica"
                },
                new ColumnControl
                {
                    Id = 10,
                    ColumnPosition = 9,
                    Start = 106,
                    End = 120,
                    Size = 15,
                    Field = "CNPJ",
                    FieldCode = "cnpj",
                    Typing = "Texto",
                    Company = "Sulamerica"
                },
                new ColumnControl
                {
                    Id = 11,
                    ColumnPosition = 10,
                    Start = 121,
                    End = 152,
                    Size = 32,
                    Field = "Nome do Colaborador",
                    FieldCode = "nomeColaborador",
                    Typing = "Texto",
                    Company = "Sulamerica"
                },
                new ColumnControl
                {
                    Id = 12,
                    ColumnPosition = 11,
                    Start = 153,
                    End = 161,
                    Size = 9,
                    Field = "NE",
                    FieldCode = "ne",
                    Typing = "Texto",
                    Company = "Sulamerica"
                }
            );

            builder.Entity<ColumnControl>().HasData(
                new ColumnControl
                {
                    Id = 13,
                    ColumnPosition = 1,
                    Start = 0,
                    End = 1,
                    Size = 2,
                    Field = "Tipo de Serviço",
                    FieldCode = "tipoServico",
                    Typing = "Texto",
                    Company = "Unimed"
                },
                new ColumnControl
                {
                    Id = 14,
                    ColumnPosition = 2,
                    Start = 2,
                    End = 9,
                    Size = 8,
                    Field = "Data do Consumo",
                    FieldCode = "dataConsumo",
                    Typing = "Data",
                    Company = "Unimed"
                },
                new ColumnControl
                {
                    Id = 15,
                    ColumnPosition = 3,
                    Start = 10,
                    End = 15,
                    Size = 6,
                    Field = "NE",
                    FieldCode = "ne",
                    Typing = "Texto",
                    Company = "Unimed"
                },
                new ColumnControl
                {
                    Id = 16,
                    ColumnPosition = 4,
                    Start = 16,
                    End = 17,
                    Size = 2,
                    Field = "Código do Dependente no Sistema",
                    FieldCode = "codigoDependenteSistema",
                    Typing = "Texto",
                    Company = "Unimed"
                },
                new ColumnControl
                {
                    Id = 17,
                    ColumnPosition = 5,
                    Start = 18,
                    End = 47,
                    Size = 30,
                    Field = "Nome",
                    FieldCode = "nome",
                    Typing = "Texto",
                    Company = "Unimed"
                },
                new ColumnControl
                {
                    Id = 18,
                    ColumnPosition = 6,
                    Start = 48,
                    End = 55,
                    Size = 8,
                    Field = "CRM",
                    FieldCode = "crm",
                    Typing = "Texto",
                    Company = "Unimed"
                },
                new ColumnControl
                {
                    Id = 19,
                    ColumnPosition = 7,
                    Start = 56,
                    End = 67,
                    Size = 12,
                    Field = "Valor da Despesa",
                    FieldCode = "valorDespesa",
                    Typing = "Decimal",
                    Company = "Unimed"
                },
                new ColumnControl
                {
                    Id = 20,
                    ColumnPosition = 8,
                    Start = 68,
                    End = 75,
                    Size = 8,
                    Field = "AMB",
                    FieldCode = "amb",
                    Typing = "Texto",
                    Company = "Unimed"
                },
                new ColumnControl
                {
                    Id = 21,
                    ColumnPosition = 9,
                    Start = 76,
                    End = 83,
                    Size = 8,
                    Field = "Controle Unimed Lotação",
                    FieldCode = "controleUnimedLotacao",
                    Typing = "Texto",
                    Company = "Unimed"
                },
                new ColumnControl
                {
                    Id = 22,
                    ColumnPosition = 10,
                    Start = 84,
                    End = 84,
                    Size = 8,
                    Field = "Controle Unimed Acomodação",
                    FieldCode = "controleUnimedAcomodacao",
                    Typing = "Texto",
                    Company = "Unimed"
                },
                new ColumnControl
                {
                    Id = 23,
                    ColumnPosition = 11,
                    Start = 85,
                    End = 85,
                    Size = 1,
                    Field = "Pago ou Não Pago",
                    FieldCode = "pago",
                    Typing = "Texto",
                    Company = "Unimed"
                }
            );
        }
    }
}
