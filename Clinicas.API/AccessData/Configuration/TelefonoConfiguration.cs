using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Configuration
{
    public class TelefonoConfiguration
    {
        public TelefonoConfiguration(EntityTypeBuilder<Telefono> entityTypeBuilder)
        {
            entityTypeBuilder.HasIndex(x => x.TelefonoId);
            entityTypeBuilder.Property(x => x.Numero).IsRequired();
        }
    }
}
