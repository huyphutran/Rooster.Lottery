using Rooster.Lottery.Models;
using Rooster.Lottery.Repository.In_memory_Repository;
using Rooster.Lottery.Services.@interface;
using System.Net;

namespace Rooster.Lottery.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            this._playerRepository = playerRepository;
        }

        public bool RegisterPlayer(Player player)
        {
            var res = _playerRepository.RegisterPlayer(player);
            return res;

        }

        public Player GetPlayer(string playerId)
        {
            return _playerRepository.GetPlayer(playerId);
        }
        public void UpdatePlayer(string playerId, Player updatePlayer)
        {
            _playerRepository.UpdatePlayer(playerId, updatePlayer);
        }
    }
}
