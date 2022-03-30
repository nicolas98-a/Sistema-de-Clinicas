using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Configuration
{
    public class PacienteConfiguration
    {
        public PacienteConfiguration(EntityTypeBuilder<Paciente> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.NroHistoriaClinica);
            entityTypeBuilder.Property(x => x.NroHistoriaClinica).IsRequired().HasMaxLength(15);
            entityTypeBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
            entityTypeBuilder.Property(x => x.Apellido).IsRequired().HasMaxLength(50);
        }
    }
}
