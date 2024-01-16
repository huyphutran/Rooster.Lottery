using Rooster.Lottery.Models;
using System.Numerics;

namespace Rooster.Lottery.Repository.In_memory_Repository
{
    public class BetRepository : IBetRepository
    {
        private List<Bet> bets = new List<Bet>();
        private readonly ILotteryResultRepository _lotteryResultRepository;
        private readonly IPlayerRepository playerRepository;
        private BetResult res = new BetResult();


        public BetRepository(ILotteryResultRepository lotteryResultRepository,IPlayerRepository playerRepository)
        {
            this._lotteryResultRepository = lotteryResultRepository;
            this.playerRepository = playerRepository;
        }

        public BetResult AddBet(Bet bet,DateTime dateTime)
        {
            if (!bets.Any(x => x.DrawingTime == dateTime)) {
                bets.Add(bet);
                res.IsSuccesfull = false;
                res.Message = $"Bet is placed at {dateTime}";
                return res;
            } 
            else
            {
                res.IsSuccesfull = false;
                res.Message = $"Already placed Bet at {dateTime}";
                return res;
            }
            return res;



        }

        public IEnumerable<Bet> GetBetByPlayerId(string playerId)
        {
            var player = playerRepository.GetPlayer(playerId);
            var res = (
                from bet in bets
                where bet.PhoneNumber == playerId
                select new Bet
                {
                    PhoneNumber = bet.PhoneNumber,
                    Player = player,
                    SelectedNumber = bet.SelectedNumber,
                    DrawingTime = bet.DrawingTime
                }).ToList();
            return res;
        }

        public BetResult CheckBetResults(DateTime slotTime, string playerId)
        {

            var bets = GetBetByPlayerId(playerId).Where(b => b.DrawingTime == slotTime);

            if (!bets.Any() == null)
            {
                res.IsSuccesfull = false;
                res.Message = "Bet not Found";
                return res;
            }

            var lotteryResult = _lotteryResultRepository.GetLotteryResult(slotTime.ToString());
            {
                if (lotteryResult == null)
                {
                    res.IsSuccesfull = false;
                    res.Message = "Lottery result not found";
                    return res;
                }
                foreach (var bet in bets)
                {
                    if (lotteryResult.WinningNumber == bet.SelectedNumber)
                    {
                        res.IsSuccesfull = true;
                        res.Message = "Winner Lottery!";
                        return res;
                    }
                }
            }
            res.IsSuccesfull = false;
            res.Message = "Unlucky Day ):, No price for today maybe luck tomorrow";
            return res;
        }
    }
}
