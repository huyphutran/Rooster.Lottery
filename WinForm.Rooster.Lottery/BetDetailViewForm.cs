using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Rooster.Lottery.Model;
using WinForm.Rooster.Lottery.Model.DTOs;

namespace WinForm.Rooster.Lottery
{
    public partial class BetDetailViewForm : Form
    {
        private static Player currPlayer;

        public BetDetailViewForm()
        {
            InitializeComponent();
            GetBetPlayerResult(currPlayer.PhoneNumber);
            

        }
        internal static void SetCurrentPlayer(Player player)
        {
            if (player != null)
            {
                currPlayer = player;
            }
        }

        private async void GetBetPlayerResult(string phoneNumber)
        {
            using (var client = new HttpClient())
            {
                var res = await client.GetAsync($"https://localhost:7194/bet/player/{phoneNumber}");

                if (res.IsSuccessStatusCode)
                {
                    var responseString = await res.Content.ReadAsStringAsync();

                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseString);

                    if (apiResponse != null)
                    {
                        // Kiểm tra xem có cột nào trong DataGridView trước đó không
                        if (dtg_BetDetail.Columns.Count > 0)
                        {
                            // Xóa các cột hiện tại trong DataGridView
                            dtg_BetDetail.Columns.Clear();
                        }

                        // Thêm các cột mới vào DataGridView
                        DataGridViewTextBoxColumn phoneNumberColumn = new DataGridViewTextBoxColumn();
                        phoneNumberColumn.HeaderText = "Phone Number";
                        phoneNumberColumn.DataPropertyName = "PhoneNumber";
                        DataGridViewTextBoxColumn selectedNumberColumn = new DataGridViewTextBoxColumn();
                        selectedNumberColumn.HeaderText = "Selected Number";
                        selectedNumberColumn.DataPropertyName = "SelectedNumber"; // Set DataPropertyName

                        DataGridViewTextBoxColumn drawingTimeColumn = new DataGridViewTextBoxColumn();
                        drawingTimeColumn.HeaderText = "Drawing Time";
                        drawingTimeColumn.DataPropertyName = "DrawingTime"; // Set DataPropertyName



                        // Thêm các cột mới vào DataGridView
                        dtg_BetDetail.Columns.AddRange(new DataGridViewColumn[]
                        {
                            phoneNumberColumn,
                            selectedNumberColumn,
                            drawingTimeColumn,
                        });

                        // Gán dữ liệu cho DataGridView
                        dtg_BetDetail.DataSource = apiResponse.PlayerInfo;
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            LotteryForm lotteryForm = new LotteryForm();
            this.Hide();
            lotteryForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BetForm betForm = new BetForm();
            this.Hide();
            betForm.Show();
        }
    }
}
