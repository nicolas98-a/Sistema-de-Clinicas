using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Especialidad
    {
        public int EspecialidadId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Medico Medico { get; set; }
    }
}
