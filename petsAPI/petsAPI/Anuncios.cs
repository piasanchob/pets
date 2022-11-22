using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petsAPI
{
    public class Anuncios
    {
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string tamaño_id { get; set; } = string.Empty;
        public string tipo_id { get; set; } = string.Empty;
        public string provincia_id { get; set; } = string.Empty;
        public string nivel_id { get; set; } = string.Empty;
        public string etapa_id { get; set; } = string.Empty;
        public int usuario_id { get; set; } 
        public string descripcion { get; set; } = string.Empty;
        public string correo { get; set; } = string.Empty;
        public string tel { get; set; } = string.Empty;

    }
}
