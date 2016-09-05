using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using trails.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace trails.Controllers
{
    [Route("api/[controller]")]
    public class RunnerController : Controller
    {
        // GET api/runner
        [HttpGet]
        public Runner[] Get()
        {
            var runners = new List<Runner>();

            runners.Add(new Runner() { Id = 1, First = "Anmol", Last = "Nandha", Age = 33, FavouriteBeer = "Bud" });
            runners.Add(new Runner() { Id = 2, First = "Wassif", Last = "Aziz", Age = 26, FavouriteBeer = "Gin and Tonic" });
            runners.Add(new Runner() { Id = 3, First = "Andre", Last = "Domingos", Age = 26, FavouriteBeer = "Estrella" });

            return runners.ToArray();
        }

        // GET api/runner/5
        [HttpGet("{id}")]
        public Runner Get(int id)
        {
            return Get().Where(r => r.Id == id).FirstOrDefault();
        }
    }
}
