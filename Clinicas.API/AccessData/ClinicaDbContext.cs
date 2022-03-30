using AccessData.Configuration;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData
{
    public class ClinicaDbContext : DbContext
    {
        public ClinicaDbContext(DbContextOptions<ClinicaDbContext> options) : base(options) 
        { }

        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<ConsultaEnConsultorio> ConsultasEnConsultorio { get; set; }
        public DbSet<PracticaMedica> PracticasMedicas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Model Contraints
            ModelConfig(builder);

            // call the method that loads seed data for database testing
            // llamar a los metodos seed en orden segun las relaciones entre entidades
            builder.SeedClinica();
            builder.SeedEspecialidad();
            builder.SeedMedico();
            builder.SeedPaciente();
            builder.SeedConsultaEnConsultorio();
            builder.SeedPracticaMedica();
        }

        private void ModelConfig(ModelBuilder builder)
        {
            builder.Entity<Medico>().ToTable("Medicos");
            builder.Entity<Paciente>().ToTable("Pacientes");
            builder.Entity<ConsultaEnConsultorio>().ToTable("ConsultasEnConsultorio");
            builder.Entity<PracticaMedica>().ToTable("PracticasMedicas");

            builder.Entity<Consulta>()
                .HasOne(m => m.Medico)
                .WithMany(c => c.Consultas)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.Entity<Consulta>()
                .HasOne(p => p.Paciente)
                .WithMany(c => c.Consultas)
                .OnDelete(DeleteBehavior.ClientCascade);

            new ClinicaConfiguration(builder.Entity<Clinica>());
            new ConsultaEnConsultorioConfiguration(builder.Entity<ConsultaEnConsultorio>());
            new EspecialidadConfiguration(builder.Entity<Especialidad>());
            
            new MedicoConfiguration(builder.Entity<Medico>());
            new PacienteConfiguration(builder.Entity<Paciente>());
            new PracticaMedicaConfiguration(builder.Entity<PracticaMedica>());
           
        }
    }
}
