using Newtonsoft.Json;
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
using WinForm.Rooster.Lottery.Model.DTOs;

namespace WinForm.Rooster.Lottery
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string phoneNumber = txt_phone.Text;
            Login(phoneNumber);
        }
        private async void Login(string phoneNumber)
        {
            using(var client = new HttpClient())
            {
                
                var res = await client.GetAsync($"https://localhost:7194/player/{phoneNumber}");
                var responseString = await res.Content.ReadAsStringAsync();

                if (res.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<PlayerDTO>(responseString);
                    MessageBox.Show("Login Success");
                    var currUser = result.PlayerInfo;
                    MemoryCache.Default["CurrentUser"] = currUser;
                    BetForm betForm = new BetForm();
                    BetForm.SetCurrentPlayer(currUser);
                    this.Hide();
                    betForm.Show();

                }
                else
                {
                    MessageBox.Show("Error Login");
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
