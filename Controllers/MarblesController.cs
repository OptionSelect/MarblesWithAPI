using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarblesWithAPI.Models;

namespace MarblesWithAPI.Controllers
{
    [Route("api/[controller]")]
    public class MarblesController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<MarbleModel> Get()
        {
            var Marble = new MarbleModel();
            IEnumerable<MarbleModel> marbles = Marble.MarbleBagGetter();
            return marbles;    
        }

        [HttpGet("/api/marbles/random")]
        public MarbleModel GetRandom()
        {   
            var Marble = new MarbleModel();
            List<MarbleModel> marbles = Marble.MarbleBagGetter();

            Random rnd = new Random();
            Marble = marbles[rnd.Next(0, marbles.Count())];
            return Marble;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public MarbleModel Get(int id)
        {   
            var Marble = new MarbleModel();
            List<MarbleModel> marbles = Marble.MarbleBagGetter();
            return marbles[id-1];
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]string marblecol)
        {
            var Marble = new MarbleModel();
            List<MarbleModel> marbles = Marble.MarbleBagGetter();
            var newMarble = new MarbleModel{
                ID = marbles.Count()+1,
                MarbleColor = marblecol
            };
            marbles.Add(newMarble);
            return Redirect("/api/marbles");
        }
        
    }
}
