// <auto-generated />
using System;
using AccessData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccessData.Migrations
{
    [DbContext(typeof(ClinicaDbContext))]
    [Migration("20220330032210_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Clinica", b =>
                {
                    b.Property<int>("ClinicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("ClinicaId");

                    b.HasIndex("ClinicaId");

                    b.ToTable("Clinicas");

                    b.HasData(
                        new
                        {
                            ClinicaId = 1,
                            Mail = "clinicaInformatica@mail.com",
                            Nombre = "Clinica Informatica",
                            Telefono = 42557896
                        });
                });

            modelBuilder.Entity("Domain.Entities.Consulta", b =>
                {
                    b.Property<int>("ConsultaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Costo")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.Property<int?>("PacienteId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ConsultaId");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("Domain.Entities.Especialidad", b =>
                {
                    b.Property<int>("EspecialidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EspecialidadId");

                    b.HasIndex("EspecialidadId");

                    b.ToTable("Especialidades");

                    b.HasData(
                        new
                        {
                            EspecialidadId = 1,
                            Descripcion = "Descripcion de especialidad 1",
                            Nombre = "Especialidad 1"
                        },
                        new
                        {
                            EspecialidadId = 2,
                            Descripcion = "Descripcion de especialidad 2",
                            Nombre = "Especialidad 2"
                        },
                        new
                        {
                            EspecialidadId = 3,
                            Descripcion = "Descripcion de especialidad 3",
                            Nombre = "Especialidad 3"
                        },
                        new
                        {
                            EspecialidadId = 4,
                            Descripcion = "Descripcion de especialidad 4",
                            Nombre = "Especialidad 4"
                        },
                        new
                        {
                            EspecialidadId = 5,
                            Descripcion = "Descripcion de especialidad 5",
                            Nombre = "Especialidad 5"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Medico", b =>
                {
                    b.Property<int>("NroMatricula")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ClinicaId")
                        .HasColumnType("int");

                    b.Property<int>("EspecialidadId")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("NroMatricula");

                    b.HasIndex("ClinicaId");

                    b.HasIndex("EspecialidadId")
                        .IsUnique();

                    b.ToTable("Medicos");

                    b.HasData(
                        new
                        {
                            NroMatricula = 1,
                            Apellido = "Apellido del medico1",
                            ClinicaId = 1,
                            EspecialidadId = 1,
                            Mail = "medico1@mail.com",
                            Nombre = "Medico1",
                            Telefono = 4256000
                        },
                        new
                        {
                            NroMatricula = 2,
                            Apellido = "Apellido del medico2",
                            ClinicaId = 1,
                            EspecialidadId = 2,
                            Mail = "medico2@mail.com",
                            Nombre = "Medico2",
                            Telefono = 4256001
                        },
                        new
                        {
                            NroMatricula = 3,
                            Apellido = "Apellido del medico3",
                            ClinicaId = 1,
                            EspecialidadId = 3,
                            Mail = "medico3@mail.com",
                            Nombre = "Medico3",
                            Telefono = 4256002
                        },
                        new
                        {
                            NroMatricula = 4,
                            Apellido = "Apellido del medico4",
                            ClinicaId = 1,
                            EspecialidadId = 4,
                            Mail = "medico4@mail.com",
                            Nombre = "Medico4",
                            Telefono = 4256003
                        },
                        new
                        {
                            NroMatricula = 5,
                            Apellido = "Apellido del medico5",
                            ClinicaId = 1,
                            EspecialidadId = 5,
                            Mail = "medico5@mail.com",
                            Nombre = "Medico5",
                            Telefono = 4256004
                        });
                });

            modelBuilder.Entity("Domain.Entities.Paciente", b =>
                {
                    b.Property<int>("NroHistoriaClinica")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ClinicaId")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("NroHistoriaClinica");

                    b.HasIndex("ClinicaId");

                    b.ToTable("Pacientes");

                    b.HasData(
                        new
                        {
                            NroHistoriaClinica = 1,
                            Apellido = "Apellido del paciente1",
                            ClinicaId = 1,
                            Mail = "paciente1@mail.com",
                            Nombre = "Paciente1",
                            Telefono = 4255778
                        },
                        new
                        {
                            NroHistoriaClinica = 2,
                            Apellido = "Apellido del paciente2",
                            ClinicaId = 1,
                            Mail = "paciente2@mail.com",
                            Nombre = "Paciente2",
                            Telefono = 4255779
                        },
                        new
                        {
                            NroHistoriaClinica = 3,
                            Apellido = "Apellido del paciente3",
                            ClinicaId = 1,
                            Mail = "paciente3@mail.com",
                            Nombre = "Paciente3",
                            Telefono = 4255780
                        },
                        new
                        {
                            NroHistoriaClinica = 4,
                            Apellido = "Apellido del paciente4",
                            ClinicaId = 1,
                            Mail = "paciente4@mail.com",
                            Nombre = "Paciente4",
                            Telefono = 4255781
                        },
                        new
                        {
                            NroHistoriaClinica = 5,
                            Apellido = "Apellido del paciente5",
                            ClinicaId = 1,
                            Mail = "paciente5@mail.com",
                            Nombre = "Paciente5",
                            Telefono = 4255782
                        });
                });

            modelBuilder.Entity("Domain.Entities.ConsultaEnConsultorio", b =>
                {
                    b.HasBaseType("Domain.Entities.Consulta");

                    b.Property<int>("NroConsultorio")
                        .HasColumnType("int");

                    b.HasIndex("ConsultaId")
                        .IsUnique();

                    b.ToTable("ConsultasEnConsultorio");

                    b.HasData(
                        new
                        {
                            ConsultaId = 1,
                            Costo = 500,
                            Fecha = new DateTime(2022, 3, 30, 0, 22, 9, 304, DateTimeKind.Local).AddTicks(8933),
                            MedicoId = 1,
                            PacienteId = 1,
                            NroConsultorio = 1
                        },
                        new
                        {
                            ConsultaId = 2,
                            Costo = 500,
                            Fecha = new DateTime(2022, 3, 30, 0, 22, 9, 308, DateTimeKind.Local).AddTicks(3642),
                            MedicoId = 2,
                            PacienteId = 2,
                            NroConsultorio = 2
                        },
                        new
                        {
                            ConsultaId = 3,
                            Costo = 500,
                            Fecha = new DateTime(2022, 3, 30, 0, 22, 9, 308, DateTimeKind.Local).AddTicks(3781),
                            MedicoId = 3,
                            PacienteId = 3,
                            NroConsultorio = 3
                        },
                        new
                        {
                            ConsultaId = 4,
                            Costo = 500,
                            Fecha = new DateTime(2022, 3, 30, 0, 22, 9, 308, DateTimeKind.Local).AddTicks(3823),
                            MedicoId = 4,
                            PacienteId = 4,
                            NroConsultorio = 4
                        },
                        new
                        {
                            ConsultaId = 5,
                            Costo = 500,
                            Fecha = new DateTime(2022, 3, 30, 0, 22, 9, 308, DateTimeKind.Local).AddTicks(3858),
                            MedicoId = 5,
                            PacienteId = 5,
                            NroConsultorio = 5
                        });
                });

            modelBuilder.Entity("Domain.Entities.PracticaMedica", b =>
                {
                    b.HasBaseType("Domain.Entities.Consulta");

                    b.Property<int>("CostoMaterialies")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("ConsultaId")
                        .IsUnique();

                    b.ToTable("PracticasMedicas");

                    b.HasData(
                        new
                        {
                            ConsultaId = 6,
                            Costo = 500,
                            Fecha = new DateTime(2022, 3, 30, 0, 22, 9, 309, DateTimeKind.Local).AddTicks(3537),
                            MedicoId = 1,
                            PacienteId = 1,
                            CostoMaterialies = 600,
                            Descripcion = "Descripcion de practica medica 6"
                        },
                        new
                        {
                            ConsultaId = 7,
                            Costo = 500,
                            Fecha = new DateTime(2022, 3, 30, 0, 22, 9, 309, DateTimeKind.Local).AddTicks(7811),
                            MedicoId = 2,
                            PacienteId = 2,
                            CostoMaterialies = 700,
                            Descripcion = "Descripcion de practica medica 7"
                        },
                        new
                        {
                            ConsultaId = 8,
                            Costo = 500,
                            Fecha = new DateTime(2022, 3, 30, 0, 22, 9, 309, DateTimeKind.Local).AddTicks(7929),
                            MedicoId = 3,
                            PacienteId = 3,
                            CostoMaterialies = 800,
                            Descripcion = "Descripcion de practica medica 8"
                        },
                        new
                        {
                            ConsultaId = 9,
                            Costo = 500,
                            Fecha = new DateTime(2022, 3, 30, 0, 22, 9, 309, DateTimeKind.Local).AddTicks(7969),
                            MedicoId = 4,
                            PacienteId = 4,
                            CostoMaterialies = 900,
                            Descripcion = "Descripcion de practica medica 9"
                        },
                        new
                        {
                            ConsultaId = 10,
                            Costo = 500,
                            Fecha = new DateTime(2022, 3, 30, 0, 22, 9, 309, DateTimeKind.Local).AddTicks(8005),
                            MedicoId = 5,
                            PacienteId = 5,
                            CostoMaterialies = 1000,
                            Descripcion = "Descripcion de practica medica 10"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Consulta", b =>
                {
                    b.HasOne("Domain.Entities.Medico", "Medico")
                        .WithMany("Consultas")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Paciente", "Paciente")
                        .WithMany("Consultas")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Domain.Entities.Medico", b =>
                {
                    b.HasOne("Domain.Entities.Clinica", "Clinica")
                        .WithMany("Medicos")
                        .HasForeignKey("ClinicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Especialidad", "Especialidad")
                        .WithOne("Medico")
                        .HasForeignKey("Domain.Entities.Medico", "EspecialidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinica");

                    b.Navigation("Especialidad");
                });

            modelBuilder.Entity("Domain.Entities.Paciente", b =>
                {
                    b.HasOne("Domain.Entities.Clinica", "Clinica")
                        .WithMany("Pacientes")
                        .HasForeignKey("ClinicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinica");
                });

            modelBuilder.Entity("Domain.Entities.ConsultaEnConsultorio", b =>
                {
                    b.HasOne("Domain.Entities.Consulta", null)
                        .WithOne()
                        .HasForeignKey("Domain.Entities.ConsultaEnConsultorio", "ConsultaId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.PracticaMedica", b =>
                {
                    b.HasOne("Domain.Entities.Consulta", null)
                        .WithOne()
                        .HasForeignKey("Domain.Entities.PracticaMedica", "ConsultaId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Clinica", b =>
                {
                    b.Navigation("Medicos");

                    b.Navigation("Pacientes");
                });

            modelBuilder.Entity("Domain.Entities.Especialidad", b =>
                {
                    b.Navigation("Medico");
                });

            modelBuilder.Entity("Domain.Entities.Medico", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("Domain.Entities.Paciente", b =>
                {
                    b.Navigation("Consultas");
                });
#pragma warning restore 612, 618
        }
    }
}
