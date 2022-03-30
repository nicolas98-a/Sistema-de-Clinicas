using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Medico : Persona
    {
        public int NroMatricula { get; set; }
        public int EspecialidadId { get; set; }
        public Especialidad Especialidad { get; set; }
        public int ClinicaId { get; set; }
        public Clinica Clinica { get; set; }
        public List<Consulta> Consultas { get; set; }
    }
}
