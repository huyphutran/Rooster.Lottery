using Rooster.Lottery.Models;

namespace Rooster.Lottery.Services.@interface
{
    public interface ILotteryResultService
    {
        void AddLotteryResult(LotteryResult result);
        LotteryResult GetLotteryResult(string slotTime);
        LotteryResult GenerateLotteryNumber(string slotTime);
    }
}