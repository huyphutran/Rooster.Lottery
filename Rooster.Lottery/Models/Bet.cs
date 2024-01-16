namespace Rooster.Lottery.Models
{
    public class Bet
    {
        public string PhoneNumber { get; set; }
        public Player Player { get; set; }
        public int SelectedNumber { get; set; }
        public DateTime DrawingTime { get; set; }

    }
}
