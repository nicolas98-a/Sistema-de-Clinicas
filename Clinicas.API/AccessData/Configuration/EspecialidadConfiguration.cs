using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Configuration
{
    public class EspecialidadConfiguration
    {
        public EspecialidadConfiguration(EntityTypeBuilder<Especialidad> entityTypeBuilder)
        {
            entityTypeBuilder.HasIndex(x => x.EspecialidadId);
            entityTypeBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
            entityTypeBuilder.Property(x => x.Descripcion).IsRequired();

        }
    }
}
