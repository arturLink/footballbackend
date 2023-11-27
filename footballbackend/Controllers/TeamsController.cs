using footballbackend.Data;
using footballbackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace footballbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TeamsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Team> GetTeams()
        {
            var teams = _context.Teams.ToList();
            return teams;
        }
    }
}
