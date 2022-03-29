using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Configuration
{
    public class MailConfiguration
    {
        public MailConfiguration(EntityTypeBuilder<Mail> entityTypeBuilder)
        {
            entityTypeBuilder.HasIndex(x => x.MailId);
            entityTypeBuilder.Property(x => x.Email).IsRequired();
        }
    }
}
