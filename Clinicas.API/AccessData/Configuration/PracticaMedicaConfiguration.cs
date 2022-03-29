using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Configuration
{
    public class PracticaMedicaConfiguration
    {
        public PracticaMedicaConfiguration(EntityTypeBuilder<PracticaMedica> entityTypeBuilder)
        {
            entityTypeBuilder.HasIndex(x => x.ConsultaId);
            entityTypeBuilder.Property(x => x.Costo).IsRequired();
            entityTypeBuilder.Property(x => x.Fecha).IsRequired();
            entityTypeBuilder.Property(x => x.MedicoId).IsRequired();
            entityTypeBuilder.Property(x => x.Descripcion).IsRequired();
            entityTypeBuilder.Property(x => x.PacienteId).IsRequired();
            entityTypeBuilder.Property(x => x.CostoMaterialies).IsRequired();

        }
    }
}
