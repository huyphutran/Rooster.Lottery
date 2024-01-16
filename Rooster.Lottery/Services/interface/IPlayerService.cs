using Rooster.Lottery.Models;

namespace Rooster.Lottery.Services.@interface
{
    public interface IPlayerService
    {
        Player GetPlayer(string playerId);
        bool RegisterPlayer(Player player);
        void UpdatePlayer(string playerId, Player updatePlayer);
    }
}