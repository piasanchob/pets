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
    public class AnunciosController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Anuncios>>> GetAnuncios()
        {
            return new List<Anuncios> {
                new Anuncios
                {
                    nombre = "Copito",
                    tamaño_id = "1",
                    tipo_id = "1",
                    provincia_id = "2",
                    nivel_id = "1",
                    etapa_id = "3",
                    usuario_id = 1,
                    descripcion = "Copito en Adopción",
                    correo = "piasancho1@hotmail.com",
                    tel = "83712456"


                }
            };
        }
    }
}
