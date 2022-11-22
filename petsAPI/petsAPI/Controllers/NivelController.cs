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
    public class NivelController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Nivel>>> GetNivel()
        {
            return new List<Nivel> {
                new Nivel
                {
                    nombre = "Copito"

                }
            };
        }
    }
}
