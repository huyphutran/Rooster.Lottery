using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Rooster.Lottery.Model;

namespace WinForm.Rooster.Lottery
{

    public partial class BetForm : Form
    {
        private static Player currPlayer;
        public BetForm()
        {
            InitializeComponent();
            dtpBettingTime.Format = DateTimePickerFormat.Custom;
            dtpBettingTime.CustomFormat = "dd/MM/yyyy HH:00";
            dtpBettingTime.MinDate = DateTime.Now;
            SetNextEvenHour();
        }
        private void SetNextEvenHour()
        {
            var now = DateTime.Now;
            var nextEvenHour = now.Hour % 2 == 0 ? now.AddHours(1) : now.AddHours(2);
            nextEvenHour = new DateTime(nextEvenHour.Year, nextEvenHour.Month, nextEvenHour.Day, nextEvenHour.Hour, 0, 0);

            dtpBettingTime.MinDate = DateTime.Now; 
            dtpBettingTime.Value = nextEvenHour;
        }


        internal static void SetCurrentPlayer(Player player) {
            if(player != null)
            {
                currPlayer = player;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectNumber = cbSelectedNumber.SelectedItem.ToString();
            int.TryParse(selectNumber, out int selectedNumber);
            var betTime = dtpBettingTime.Value;
            if(!IsBettingTimeValid(betTime))
            {
                MessageBox.Show("Invalid Time Bet Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            Bet bet = new Bet
            {
                PhoneNumber = currPlayer.PhoneNumber,
                SelectedNumber = selectedNumber,
                DrawingTime = betTime
            };
            PlaceBet(bet);



        }
        private bool IsBettingTimeValid(DateTime betTime)
        {
            return betTime > DateTime.Now.AddMinutes(1);
        }

        private void BetForm_Load(object sender, EventArgs e)
        {

        }
        private async void PlaceBet(Bet bet)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(bet), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7194/bet/place", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("bet Complete!");
                    this.Hide();
                    BetForm betForm = new BetForm();
                    betForm.Show();
                    
                }
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error bet");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BetDetailViewForm.SetCurrentPlayer(currPlayer);
            this.Hide();
            BetDetailViewForm betDetailViewForm = new BetDetailViewForm();
            betDetailViewForm.Show();
        }
    }
}
