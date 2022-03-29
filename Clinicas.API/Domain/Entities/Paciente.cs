using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Paciente : Persona
    {
        public int NroHistoriaClinica { get; set; }
        public int ClinicaId { get; set; }
        public Clinica Clinica { get; set; }
        public List<Consulta> Consultas { get; set; }
    }
}
