using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Configuration
{
    public class ClinicaConfiguration
    {
        public ClinicaConfiguration(EntityTypeBuilder<Clinica> entityTypeBuilder)
        {
            entityTypeBuilder.HasIndex(x => x.ClinicaId);
            entityTypeBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
        }
    }
}
