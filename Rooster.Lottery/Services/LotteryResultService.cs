using Rooster.Lottery.Models;
using Rooster.Lottery.Repository.In_memory_Repository;
using Rooster.Lottery.Services.@interface;

namespace Rooster.Lottery.Services
{
    public class LotteryResultService : ILotteryResultService
    {
        private readonly ILotteryResultRepository _lotteryResultRepository;

        public LotteryResultService(ILotteryResultRepository lotteryResultRepository)
        {
            this._lotteryResultRepository = lotteryResultRepository;
        }


        public void AddLotteryResult(LotteryResult result)
        {
            _lotteryResultRepository.AddLotteryResult(result);
        }


        public LotteryResult GetLotteryResult(string slotTime)
        {
            return _lotteryResultRepository.GetLotteryResult(slotTime);

        }


        public LotteryResult GenerateLotteryNumber(string slotTime)
        {
            int winningNumber = _lotteryResultRepository.GernerateRandomLotteryNumber();

            var lotteryRes = new LotteryResult()
            {
                DrawTime = slotTime,
                WinningNumber = winningNumber
            };
            _lotteryResultRepository.AddLotteryResult(lotteryRes);
            return lotteryRes;
        }
    }
}
