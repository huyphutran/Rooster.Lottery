using Microsoft.AspNetCore.Mvc;
using Rooster.Lottery.Models;
using Rooster.Lottery.Services.@interface;
using System.Numerics;

namespace Rooster.Lottery.Controllers
{
    public class BetController : Controller
    {
        private readonly IBetService betService;

        public BetController(IBetService betService)
        {
            this.betService = betService;
        }


        [HttpPost("/bet/place")]
        public IActionResult Bet( [FromBody] Bet bet, DateTime drawTime) {

            betService.AddBet(bet, drawTime);
            return Ok();
        }


        [HttpGet("bet/player/{playerId}")]

        public IActionResult GetBetsByPlayer(string playerId) {
        
            var bet = betService.GetBet(playerId);
            return bet!=null ? Ok(new { Success = true, Message = "Bet Found!", PlayerInfo = bet }):
                NotFound(new { Success = false, Message = "Bet not Exsit" }); ;
        }


        [HttpGet("bet/player/{playerId}&{slotTime}/results")]
        public IActionResult CheckBetResult(DateTime slotTime, string playerId) {
            var res = betService.CheckBetResults(slotTime, playerId);
            return Ok(res);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
