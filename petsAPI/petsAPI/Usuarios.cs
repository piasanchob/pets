using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petsAPI
{
    public class Usuarios
    {
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string cedula { get; set; } = string.Empty;
        public string correo { get; set; } = string.Empty;
        public string fechanac { get; set; } = string.Empty;
        public string usuario { get; set; } = string.Empty;
        public string contraseña { get; set; } = string.Empty;
        
    }
}
