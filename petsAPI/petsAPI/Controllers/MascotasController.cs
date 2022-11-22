using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MascotasController : ControllerBase
    {
        [HttpGet]
        public async Task <ActionResult<List<Mascotas>>> GetMascotas()
        {
            return new List<Mascotas> { 
                new Mascotas 
                {
                    nombre = "Copito",
                    tamaño = "1",
                    tipo_id = "1",
                    edad = "13",
                    descripción = "Perro Pequeño",
                    raza = "Maltes",
                    peso = "55",
                    usuario_id = 1


                } 
            };
        }
    }
}
