using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Configuration
{
    public class MedicoConfiguration
    {
        public MedicoConfiguration(EntityTypeBuilder<Medico> entityTypeBuilder)
        {
            entityTypeBuilder.HasIndex(x => x.Id);
            entityTypeBuilder.Property(x => x.NroMatricula).IsRequired().HasMaxLength(15);
            entityTypeBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
            entityTypeBuilder.Property(x => x.Apellido).IsRequired().HasMaxLength(50);
        }
    }
}
