using Domain;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RetornaJurosController : Controller
    {
        /// <summary>
        /// GET: RetornaJuros diretamente de 0.01
        /// http://localhost:62372/RetornaJuros/taxaJuros
        /// </summary>
        /// <returns>(decimal) fixed 0.01</returns>
        [HttpGet]
        [Route("taxaJuros")]
        public async Task<IActionResult> GetJuros()
        {
            TaxaJurosService taxaJurosService = new TaxaJurosService();
            var txJuros = await taxaJurosService.RetornaTaxaJuros();
            return new JsonResult(txJuros);
        }
    }
}
