using Rooster.Lottery.Models;

namespace Rooster.Lottery.Repository.In_memory_Repository
{
    public interface IBetRepository
    {
        BetResult AddBet(Bet bet, DateTime drawTime);
        BetResult CheckBetResults(DateTime slotTime, string playerId);
        IEnumerable<Bet> GetBetByPlayerId(string playerId);
    }
}