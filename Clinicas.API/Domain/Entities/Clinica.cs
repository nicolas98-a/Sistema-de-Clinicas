using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Clinica
    {
        public int ClinicaId { get; set; }
        public string Nombre { get; set; }
        public List<Telefono> Telefonos { get; set; }
        public List<Mail> Mails { get; set; }
        public List<Medico> Medicos { get; set; }
        public List<Paciente> Pacientes { get; set; }

    }
}
