using Microsoft.AspNetCore.Mvc;
using SalaCinema.Models;
using SalaCinema.Service;

namespace SalaCinema.Controllers
{
    public class SalaController : Controller
    {
        private readonly ISalaServiceHttpClient _salaServiceHttpClient;

        public SalaController(ISalaServiceHttpClient salaServiceHttpClient)
        {
            _salaServiceHttpClient = salaServiceHttpClient;
        }

        [HttpGet]
        public IActionResult Index(SalaDto request)
        {
            return View();
        }
        [HttpGet]
        public IActionResult ListarSala()
        {
           List<SalaDto> response = _salaServiceHttpClient.GetSalasAsync().Result;
            return View(response);
        }
   
       public int ContarSala()
        {
            List<SalaDto> response = _salaServiceHttpClient.GetSalasAsync().Result;
            //List<SalaDto> response = (List<SalaDto>)ListarSala();
            var total=response.Count();
            return total;
        }

    }
}
