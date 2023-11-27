using footballbackend.Data;
using footballbackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace footballbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PlayersController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Player> GetPlayers()
        {
            var players = _context.Players.ToList();
            return players;
        }

        [HttpPost]
        public List<Player> PostPerson([FromBody] Player person)
        {
            _context.Players.Add(person);
            _context.SaveChanges();
            return _context.Players.ToList();
        }

        [HttpPut("{id}")]
        public ActionResult<List<Player>> PutPerson(int id, [FromBody] Player updatedPerson)
        {
            var persons = _context.Players.Find(id);

            if (persons == null)
            {
                return NotFound();
            }

            persons.Name = updatedPerson.Name;
            persons.SecondName = updatedPerson.SecondName;
            persons.Sex = updatedPerson.Sex;
            persons.DateOfBirth = updatedPerson.DateOfBirth;
            persons.TeamId = updatedPerson.TeamId;
            persons.Country = updatedPerson.Country;

            _context.Players.Update(persons);
            _context.SaveChanges();

            return Ok(_context.Players);
        }

    }
}
