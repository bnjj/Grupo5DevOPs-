using Microsoft.AspNetCore.Mvc;
using utn_devops.Entities;

namespace utn_devops.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        private static readonly List<Player> players = new List<Player>
        {
           new Player("A", "B", DateTime.Today),
           new Player("C", "D", DateTime.Today),
        };
        
        private readonly ILogger<PlayerController> _logger;

        public PlayerController(ILogger<PlayerController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPlayers")]
        public IEnumerable<Player> Get()
        {
            return players;
        }
    }
}