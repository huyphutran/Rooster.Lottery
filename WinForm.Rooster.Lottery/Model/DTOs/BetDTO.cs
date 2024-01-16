using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Rooster.Lottery.Model.DTOs
{
    public class BetDTO : ApiResponse
    {
        public Bet betInfo { get; set; }
    }
}
