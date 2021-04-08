﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProcessFile.API.Infra.Context;

namespace ProcessFile.API.Infra.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210324011630_AddColumnJobEvent")]
    partial class AddColumnJobEvent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProcessFile.API.Domain.Entities.ColumnControl", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColumnPosition")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("End")
                        .HasColumnType("int");

                    b.Property<string>("Field")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FieldCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<int>("Start")
                        .HasColumnType("int");

                    b.Property<string>("Typing")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ColumnControls");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ColumnPosition = 0,
                            Company = "Sulamerica",
                            End = 1,
                            Field = "Sequência",
                            FieldCode = "sequencia",
                            Size = 2,
                            Start = 0,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 2L,
                            ColumnPosition = 1,
                            Company = "Sulamerica",
                            End = 17,
                            Field = "Carteirinha",
                            FieldCode = "carteirinha",
                            Size = 16,
                            Start = 2,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 3L,
                            ColumnPosition = 2,
                            Company = "Sulamerica",
                            End = 56,
                            Field = "Nome",
                            FieldCode = "nome",
                            Size = 38,
                            Start = 18,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 4L,
                            ColumnPosition = 3,
                            Company = "Sulamerica",
                            End = 67,
                            Field = "CPF",
                            FieldCode = "cpf",
                            Size = 11,
                            Start = 57,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 5L,
                            ColumnPosition = 4,
                            Company = "Sulamerica",
                            End = 74,
                            Field = "Data do Registro",
                            FieldCode = "dataRegistro",
                            Size = 7,
                            Start = 68,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 6L,
                            ColumnPosition = 5,
                            Company = "Sulamerica",
                            End = 75,
                            Field = "Mais",
                            FieldCode = "mais",
                            Size = 1,
                            Start = 75,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 7L,
                            ColumnPosition = 6,
                            Company = "Sulamerica",
                            End = 90,
                            Field = "Valor",
                            FieldCode = "valor",
                            Size = 15,
                            Start = 76,
                            Typing = "Decimal"
                        },
                        new
                        {
                            Id = 8L,
                            ColumnPosition = 7,
                            Company = "Sulamerica",
                            End = 95,
                            Field = "Codigo Aleatorio",
                            FieldCode = "codigoAleatorio",
                            Size = 5,
                            Start = 91,
                            Typing = "Decimal"
                        },
                        new
                        {
                            Id = 9L,
                            ColumnPosition = 8,
                            Company = "Sulamerica",
                            End = 105,
                            Field = "Nascimento",
                            FieldCode = "nascimento",
                            Size = 10,
                            Start = 96,
                            Typing = "Data"
                        },
                        new
                        {
                            Id = 10L,
                            ColumnPosition = 9,
                            Company = "Sulamerica",
                            End = 120,
                            Field = "CNPJ",
                            FieldCode = "cnpj",
                            Size = 15,
                            Start = 106,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 11L,
                            ColumnPosition = 10,
                            Company = "Sulamerica",
                            End = 152,
                            Field = "Nome do Colaborador",
                            FieldCode = "nomeColaborador",
                            Size = 32,
                            Start = 121,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 12L,
                            ColumnPosition = 11,
                            Company = "Sulamerica",
                            End = 161,
                            Field = "NE",
                            FieldCode = "ne",
                            Size = 9,
                            Start = 153,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 13L,
                            ColumnPosition = 1,
                            Company = "Unimed",
                            End = 1,
                            Field = "Tipo de Serviço",
                            FieldCode = "tipoServico",
                            Size = 2,
                            Start = 0,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 14L,
                            ColumnPosition = 2,
                            Company = "Unimed",
                            End = 9,
                            Field = "Data do Consumo",
                            FieldCode = "dataConsumo",
                            Size = 8,
                            Start = 2,
                            Typing = "Data"
                        },
                        new
                        {
                            Id = 15L,
                            ColumnPosition = 3,
                            Company = "Unimed",
                            End = 15,
                            Field = "NE",
                            FieldCode = "ne",
                            Size = 6,
                            Start = 10,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 16L,
                            ColumnPosition = 4,
                            Company = "Unimed",
                            End = 17,
                            Field = "Código do Dependente no Sistema",
                            FieldCode = "codigoDependenteSistema",
                            Size = 2,
                            Start = 16,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 17L,
                            ColumnPosition = 5,
                            Company = "Unimed",
                            End = 47,
                            Field = "Nome",
                            FieldCode = "nome",
                            Size = 30,
                            Start = 18,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 18L,
                            ColumnPosition = 6,
                            Company = "Unimed",
                            End = 55,
                            Field = "CRM",
                            FieldCode = "crm",
                            Size = 8,
                            Start = 48,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 19L,
                            ColumnPosition = 7,
                            Company = "Unimed",
                            End = 67,
                            Field = "Valor da Despesa",
                            FieldCode = "valorDespesa",
                            Size = 12,
                            Start = 56,
                            Typing = "Decimal"
                        },
                        new
                        {
                            Id = 20L,
                            ColumnPosition = 8,
                            Company = "Unimed",
                            End = 75,
                            Field = "AMB",
                            FieldCode = "amb",
                            Size = 8,
                            Start = 68,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 21L,
                            ColumnPosition = 9,
                            Company = "Unimed",
                            End = 83,
                            Field = "Controle Unimed Lotação",
                            FieldCode = "controleUnimedLotacao",
                            Size = 8,
                            Start = 76,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 22L,
                            ColumnPosition = 10,
                            Company = "Unimed",
                            End = 84,
                            Field = "Controle Unimed Acomodação",
                            FieldCode = "controleUnimedAcomodacao",
                            Size = 8,
                            Start = 84,
                            Typing = "Texto"
                        },
                        new
                        {
                            Id = 23L,
                            ColumnPosition = 11,
                            Company = "Unimed",
                            End = 85,
                            Field = "Pago ou Não Pago",
                            FieldCode = "pago",
                            Size = 1,
                            Start = 85,
                            Typing = "Texto"
                        });
                });

            modelBuilder.Entity("ProcessFile.API.Domain.Entities.JobEvent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("JobEvents");
                });

            modelBuilder.Entity("ProcessFile.API.Domain.Entities.Process", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Process");
                });

            modelBuilder.Entity("ProcessFile.API.Domain.Entities.Sulamerica", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carteirinha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoAleatorio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataRegistro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nascimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeColaborador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ProcessId")
                        .HasColumnType("bigint");

                    b.Property<string>("Sequencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Valor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProcessId");

                    b.ToTable("Sulamericas");
                });

            modelBuilder.Entity("ProcessFile.API.Domain.Entities.Unimed", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Amb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoDependenteSistema")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ControleUnimedAcomodacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ControleUnimedLotacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Crm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataConsumo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ProcessId")
                        .HasColumnType("bigint");

                    b.Property<string>("TipoServico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ValorDespesa")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ne")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProcessId");

                    b.ToTable("Unimed");
                });

            modelBuilder.Entity("ProcessFile.API.Domain.Entities.Sulamerica", b =>
                {
                    b.HasOne("ProcessFile.API.Domain.Entities.Process", "Process")
                        .WithMany("Sulamericas")
                        .HasForeignKey("ProcessId");

                    b.Navigation("Process");
                });

            modelBuilder.Entity("ProcessFile.API.Domain.Entities.Unimed", b =>
                {
                    b.HasOne("ProcessFile.API.Domain.Entities.Process", "Process")
                        .WithMany("Unimed")
                        .HasForeignKey("ProcessId");

                    b.Navigation("Process");
                });

            modelBuilder.Entity("ProcessFile.API.Domain.Entities.Process", b =>
                {
                    b.Navigation("Sulamericas");

                    b.Navigation("Unimed");
                });
#pragma warning restore 612, 618
        }
    }
}
