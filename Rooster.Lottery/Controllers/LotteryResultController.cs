using Microsoft.AspNetCore.Mvc;
using Rooster.Lottery.Models;
using Rooster.Lottery.Repository.In_memory_Repository;
using Rooster.Lottery.Services.@interface;

namespace Rooster.Lottery.Controllers
{
    public class LotteryResultController : Controller
    {
        private readonly ILotteryResultService lotteryResultService;

        public LotteryResultController(ILotteryResultService lotteryResultService)
        {
            this.lotteryResultService = lotteryResultService;
        }


        [HttpGet("/lottery/getresult/{slotTime}")]
        public IActionResult GetLotteryResult(string slotTime) {
            var res = lotteryResultService.GetLotteryResult(slotTime);
            return res != null ? Ok(new { Success = true, Message = "Get lottery Success!", res }) :
                NotFound(new { Success = false, Message = "lottery not Exsit" });
             
        }
        [HttpGet("/lottery/{slotTime}")]
        public IActionResult GetLotterybyTime(string slotTime)
        {
            var res = lotteryResultService.GenerateLotteryNumber(slotTime);
            return res != null ? Ok(new { Success = true, Message = "Get lottery Success!", LotteryInfo = res }) :
                NotFound(new { Success = false, Message = "lottery not Exsit" });
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
