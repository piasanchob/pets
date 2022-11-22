using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petsAPI
{
    public class Mascotas
    {
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string tamaño { get; set; } = string.Empty;
        public string tipo_id { get; set; } = string.Empty;
        public string edad { get; set; } = string.Empty;
        public string descripción { get; set; } = string.Empty;
        public string raza { get; set; } = string.Empty;
        public string peso { get; set; } = string.Empty;
        public int usuario_id { get; set; }


    }
}
