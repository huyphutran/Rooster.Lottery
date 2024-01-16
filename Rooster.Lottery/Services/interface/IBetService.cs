using Rooster.Lottery.Models;

namespace Rooster.Lottery.Services.@interface
{
    public interface IBetService
    {
        void AddBet(Bet bet, DateTime drawTime);
        BetResult CheckBetResults(DateTime slotTime, string playerId);
        IEnumerable<Bet> GetBet(string playerId);
    }
}