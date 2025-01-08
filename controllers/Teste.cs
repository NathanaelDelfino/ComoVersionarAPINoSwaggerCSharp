using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TesteApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class TesteController : ControllerBase
    {
        [HttpGet("Teste")]
        [MapToApiVersion("1.0")]
        public string Get()
        {
            return "Teste";
        }

        [HttpGet("Teste2")]
        [MapToApiVersion("2.0")]
        public string Teste2()
        {
            return "Teste 2";
        }
    }
}