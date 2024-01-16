using Rooster.Lottery.Models;
using System.Net;

namespace Rooster.Lottery.Repository.In_memory_Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        public List<Player> _players = new List<Player>();
        public bool RegisterPlayer(Player player)
        {
            if (!_players.Any(p => p.UserName == player.UserName && p.PhoneNumber == player.PhoneNumber))
            {
                _players.Add(player);

                return true;
            }
            else
            {
                return false;
            }
        }


        public Player GetPlayer(string playerId)
        {
            return _players.FirstOrDefault(x => x.PhoneNumber == playerId);
        }

        public void UpdatePlayer(string playerId, Player updatePlayer)
        {
            var player = GetPlayer(playerId);
            if (player != null)
            {
                player.UserName = updatePlayer.UserName;
                player.DateOfBirth = updatePlayer.DateOfBirth;
                player.PhoneNumber = updatePlayer.PhoneNumber;
            }


        }
    }
}
