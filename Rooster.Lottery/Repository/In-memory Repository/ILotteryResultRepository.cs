using Rooster.Lottery.Models;

namespace Rooster.Lottery.Repository.In_memory_Repository
{
    public interface ILotteryResultRepository
    {
        void AddLotteryResult(LotteryResult result);
        int GernerateRandomLotteryNumber();
        LotteryResult GetLotteryResult(string slotTime);
    }
}