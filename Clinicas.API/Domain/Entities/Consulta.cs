using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class Consulta
    {
        public int ConsultaId { get; set; }
        public DateTime Fecha { get; set; }
        public int Costo { get; set; }
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }
        public int? PacienteId { get; set; }
        public Paciente Paciente { get; set; }
    }
}
