using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventLite.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventLiteApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Show")]
    public class ShowController : Controller
    {
        private EventLiteContext db;

        public ShowController(EventLiteContext context)
        {
            db = context;
        }

        [HttpGet("{id}", Name = "GetShows")]
        public IActionResult Get(int id)
        {
            try
            {
                List<Show> shows = db.Show.Where(x => x.EventId == id).ToList();
                if (shows == null)
                {
                    return NotFound($"No shows found with id {id}...");
                }
                return Ok(shows);
            }
            catch (Exception e)
            {
                return BadRequest($"O oh, something ({e.Message}) went wrong");
            }
        }
    }
}