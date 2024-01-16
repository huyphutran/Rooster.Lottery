using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using WinForm.Rooster.Lottery.Model;
using WinForm.Rooster.Lottery.Model.DTOs;
using Timer = System.Timers.Timer;

namespace WinForm.Rooster.Lottery
{
    public partial class LotteryForm : Form
    {
        private Timer myTimer = new Timer();

        public LotteryForm()
        {
            InitializeComponent();
            string dateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            GetLotteryResult(dateTime);
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            lb_time.Text = currentTime.ToString("HH:mm:ss");
        }




        private async Task GetLotteryResult(string slotTime)
        {

            using (var client = new HttpClient())
            {
                var res = await client.GetAsync($"https://localhost:7194/lottery/{slotTime}");
                if (res.IsSuccessStatusCode)
                {
                    var responseString = await res.Content.ReadAsStringAsync();

                    var apiResponse = JsonConvert.DeserializeObject<LotteryApiResponseDTO>(responseString);

                    if (apiResponse.LotteryInfo != null)
                    {
                        dtg_LotteryView.DataSource = new List<LotteryResult> { apiResponse.LotteryInfo };

                    }
                    else
                    {
                        MessageBox.Show("No lottery information available.");
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            GetLotteryResult(dateTime);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BetDetailViewForm betDetailViewForm = new BetDetailViewForm();
            this.Hide();
            betDetailViewForm.Show();
        }
    }
}
