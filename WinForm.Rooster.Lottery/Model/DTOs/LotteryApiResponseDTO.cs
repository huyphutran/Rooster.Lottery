using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Rooster.Lottery.Model.DTOs
{
    public class LotteryApiResponseDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public LotteryResult LotteryInfo { get; set; }

    }
}
