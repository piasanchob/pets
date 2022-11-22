using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petsAPI
{
    public class Veterinarios
    {
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string descripcion { get; set; } = string.Empty;
        public string ubiexacta { get; set; } = string.Empty;
        public string numero { get; set; } = string.Empty;
        public string ubicacion { get; set; } = string.Empty;
        public int nota { get; set; } 
        public string horario { get; set; } = string.Empty;
        public string especialidad { get; set; } = string.Empty;

    }
}
