using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petsAPI
{
    public class HistorialMascota
    {
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string peso { get; set; } = string.Empty;
        public string raza { get; set; } = string.Empty;
        public string edad { get; set; } = string.Empty;
        public string vacunas { get; set; } = string.Empty;
        public int observaciones { get; set; }
        public string proxima_cita { get; set; } = string.Empty;
        public string usuario_id { get; set; } = string.Empty;

    }
}
