using Rooster.Lottery.Models;
using Rooster.Lottery.Repository.In_memory_Repository;
using Rooster.Lottery.Services.@interface;
using System.Collections.Generic;

namespace Rooster.Lottery.Services
{
    public class BetService : IBetService
    {
        private readonly IBetRepository betRepository;

        public BetService(IBetRepository betRepository)
        {
            this.betRepository = betRepository;
        }


        public void AddBet( Bet bet, DateTime drawtime)
        {
            betRepository.AddBet(bet,drawtime);
        }

        public IEnumerable<Bet> GetBet(string playerId)
        {
            return betRepository.GetBetByPlayerId(playerId);
        }

        public BetResult CheckBetResults(DateTime slotTime, string playerId)
        {
            return betRepository.CheckBetResults(slotTime, playerId);
        }
    }
}
