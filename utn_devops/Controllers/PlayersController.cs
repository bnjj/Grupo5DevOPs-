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
           new Player("Lionel", "Messi", DateTime.Parse("1987-06-24").Ticks),
           new Player("Juan", "Arango", DateTime.Parse("1980-04-16").Ticks),
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