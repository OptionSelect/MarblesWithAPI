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
        // GET api/values
        [HttpGet]
        public IEnumerable<MarbleModel> Get()
        {
            var Marble = new MarbleModel();
            IEnumerable<MarbleModel> marbles = Marble.MarbleBagGetter();
            return marbles;    
        }

         [HttpGet("/api/random")]
        public MarbleModel GetRandom()
        {
            Console.WriteLine("not that");
            
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
        public void Post([FromBody]int id, string color)
        {
            var Marble = new MarbleModel();
            List<MarbleModel> marbles = Marble.MarbleBagGetter();
            var newMarble = new MarbleModel{
                ID = id,
                MarbleColor = color
            };
            marbles.Add(newMarble);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
