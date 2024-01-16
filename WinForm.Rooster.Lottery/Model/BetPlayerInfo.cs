using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm.Rooster.Lottery.Model;

namespace WinForm.Rooster.Lottery.Model
{
    public class BetPlayerInfo 
    {
        public string PhoneNumber { get; set; }
        public int SelectedNumber { get; set; }
        public DateTime DrawingTime { get; set; }
        public Player Player;

        public string PlayerUserName
        {
            get { return Player?.UserName; } 
        }

        public DateTime? PlayerDateOfBirth
        {
            get { return Player?.DateOfBirth; }
        }
        public BetPlayerInfo(Player player)
        {
            Player = player;
        }
    }
}
