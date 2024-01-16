using Rooster.Lottery.Models;

namespace Rooster.Lottery.Repository.In_memory_Repository
{
    public interface IPlayerRepository
    {
        Player GetPlayer(string playerId);
        bool RegisterPlayer(Player player);
        void UpdatePlayer(string playerId, Player updatePlayer);
    }
}