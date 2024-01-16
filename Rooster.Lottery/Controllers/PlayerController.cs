using Microsoft.AspNetCore.Mvc;
using Rooster.Lottery.Models;
using Rooster.Lottery.Services.@interface;

namespace Rooster.Lottery.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerService playerService;

        public PlayerController(IPlayerService playerService)
        {
            this.playerService = playerService;
        }
        [HttpPost("player/register")]
        public IActionResult RegisterPlayer([FromBody] Player player) { 
          bool res = playerService.RegisterPlayer(player);
            return res ? Ok("Regist Success!") : BadRequest("Player exist!");
        }

        [HttpGet("player/{playerId}")]
        public IActionResult GetPlayerById(string playerId) {
            var player = playerService.GetPlayer(playerId);
            return player!=null ? Ok(new { Success = true, Message = "Login!",PlayerInfo = player }) :
                NotFound(new {Success = false, Message = "Phone Number not Exsit"});  
        }
        [HttpPut("player/update/{playerId}")]
        public IActionResult UpdateUserInformation(string playerId, [FromBody] Player player) {
             playerService.UpdatePlayer(playerId, player);
            return Ok();
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
