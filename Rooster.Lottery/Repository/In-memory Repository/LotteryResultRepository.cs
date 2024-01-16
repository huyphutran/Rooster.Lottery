using Rooster.Lottery.Models;

namespace Rooster.Lottery.Repository.In_memory_Repository
{
    public class LotteryResultRepository : ILotteryResultRepository
    {
        private List<LotteryResult> _lotteryresults = new List<LotteryResult>();
        private Random _random = new Random();



        public void AddLotteryResult(LotteryResult result)
        {
            _lotteryresults.Add(result);
        }
        public LotteryResult GetLotteryResult(string slotTime)
        {
            return _lotteryresults.FirstOrDefault(res => res.DrawTime == slotTime);
        }


        public int GernerateRandomLotteryNumber()
        {
            return _random.Next(0, 10);
        }
    }
}
