using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PracticaMedica : Consulta
    {
        public string Descripcion { get; set; }
        public int CostoMaterialies { get; set; }
    }
}
