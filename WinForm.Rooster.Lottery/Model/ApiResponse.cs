using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Rooster.Lottery.Model
{
    public class ApiResponse
    {
        public bool Sucess { get; set; }
        public string Message { get; set; }
        public List<BetPlayerInfo> PlayerInfo { get; set; }
    }
}
