using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm.Rooster.Lottery.Model;


namespace WinForm.Rooster.Lottery.Model
{
     public class Bet
    {
        public string PhoneNumber { get; set; }
        public Player Player { get; set; }
        public int SelectedNumber { get; set; }
        public DateTime DrawingTime { get; set; }

    }
}
