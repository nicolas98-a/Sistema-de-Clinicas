using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData
{
    public static class ModelBuilderExtension
    {
        public static void SeedEspecialidad(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 6; i++)
            {
                modelBuilder.Entity<Especialidad>().HasData(
                    new Especialidad
                    {
                        EspecialidadId = i,
                        Nombre = "Especialidad " + i,
                        Descripcion = "Descripcion de especialidad " + i
                    });
            }
        }

        public static void SeedMedico(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 6; i++)
            {
                modelBuilder.Entity<Medico>().HasData(
                    new Medico 
                    {
                        NroMatricula = i,
                        EspecialidadId = i,
                        ClinicaId = 1,
                        Nombre = "Medico" + i,
                        Apellido = "Apellido del medico" + i,
                        Telefono = 4255999 + i,
                        Mail = "medico" + i + "@mail.com"
                    });
            }
        }

        public static void SeedPaciente(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 6; i++)
            {
                modelBuilder.Entity<Paciente>().HasData(
                    new Paciente
                    {
                        NroHistoriaClinica = i,
                        ClinicaId = 1,
                        Nombre = "Paciente" + i,
                        Apellido = "Apellido del paciente" + i,
                        Telefono = 4255777 + i,
                        Mail = "paciente" + i + "@mail.com"
                    });
            }
        }

        public static void SeedConsultaEnConsultorio(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 6; i++)
            {
                modelBuilder.Entity<ConsultaEnConsultorio>().HasData(
                    new ConsultaEnConsultorio
                    {
                        ConsultaId = i,
                        Fecha = DateTime.Now,
                        Costo = 500,
                        MedicoId = i,
                        PacienteId = i,
                        NroConsultorio = i
                    });
            }
        }

        public static void SeedPracticaMedica(this ModelBuilder modelBuilder)
        {
            for (int i = 6; i < 11; i++)
            {
                modelBuilder.Entity<PracticaMedica>().HasData(
                    new PracticaMedica
                    {
                        ConsultaId = i,
                        Fecha = DateTime.Now,
                        Costo = 500,
                        MedicoId = i - 5,
                        PacienteId = i - 5,
                        Descripcion = "Descripcion de practica medica " + i,
                        CostoMaterialies = 100 * i
                    });
            }
        }

        public static void SeedClinica(this ModelBuilder modelBuilder)
        {
            Clinica clinica = new Clinica
            {
                ClinicaId = 1,
                Nombre = "Clinica Informatica",
                Telefono = 42557896,
                Mail = "clinicaInformatica@mail.com"
            };

            modelBuilder.Entity<Clinica>().HasData(clinica);
        }
    }
}
