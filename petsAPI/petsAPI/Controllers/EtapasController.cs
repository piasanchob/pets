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
    public class EtapasController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Etapas>>> GetEtapas()
        {
            return new List<EtapasController> {
                new EtapasController
                {
                    id = "1",
                    nombre = "Adulto"

                }
            };
        }
    }
}
