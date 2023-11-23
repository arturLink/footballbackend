using footballbackend.Data;
using footballbackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
