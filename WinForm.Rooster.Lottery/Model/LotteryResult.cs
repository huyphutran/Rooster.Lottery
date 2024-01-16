using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Rooster.Lottery.Model
{
    public class LotteryResult
    {
        [JsonProperty("drawTime")]
        public string DrawTime { get; set; }
        [JsonProperty("winningNumber")]
        public int WinningNumber { get; set; }
    }
}
