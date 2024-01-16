using System.ComponentModel.DataAnnotations;

namespace Rooster.Lottery.Models
{
    public class Player
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
