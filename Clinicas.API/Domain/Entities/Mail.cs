using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Mail
    {
        public int MailId { get; set; }
        public string Email { get; set; }
        public int? PersonaId { get; set; }
        public Persona Persona { get; set; }

        public int? ClinicaId { get; set; }
        public Clinica Clinica { get; set; }
    }
}
