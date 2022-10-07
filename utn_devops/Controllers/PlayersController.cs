using Microsoft.AspNetCore.Mvc;
using utn_devops.Entities;

namespace utn_devops.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : ControllerBase
    {
        private static readonly List<Player> players = new List<Player>
        {
           new Player("Lionel", "Messi", DateTime.Today),
           new Player("Juan", "Arango", DateTime.Today),
        };
        
        private readonly ILogger<PlayersController> _logger;

        public PlayersController(ILogger<PlayersController> logger)
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