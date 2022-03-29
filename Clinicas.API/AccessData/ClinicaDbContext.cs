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
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<Mail> Mails { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<ConsultaEnConsultorio> ConsultasEnConsultorio { get; set; }
        public DbSet<PracticaMedica> PracticasMedicas { get; set; }
    }
}
