using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventLite.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventLiteApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Events")]
    public class EventsController : Controller
    {
        private EventLiteContext db;

        public EventsController(EventLiteContext context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            try
            {
                List<Event> events = db.Event.Select(x => x).ToList();
                return Ok(events);
            }
            catch (Exception e)
            {
                return BadRequest($"O oh, something ({e.Message}) went wrong");
            }
        }

        [HttpGet("{id}", Name = "GetEvent")]
        public IActionResult Get(int id)
        {
            try
            {
                Event eventTOSend = db.Event.Where(x => x.Id == id).SingleOrDefault();
                if (eventTOSend == null)
                {
                    return NotFound($"No event found with id {id}...");
                }
                return Ok(eventTOSend);
            }
            catch (Exception e)
            {
                return BadRequest($"O oh, something ({e.Message}) went wrong");
            }
        }

        
    }
}