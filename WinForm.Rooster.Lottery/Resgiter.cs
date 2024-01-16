using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Runtime.Caching;
using WinForm.Rooster.Lottery.Model;

namespace WinForm.Rooster.Lottery
{
    public partial class Resgiter: UserControl
    {
        private bool isUserRegistered = false;
        public Resgiter()
        {
            InitializeComponent();
        }

        private void CheckUserRegistration()
        {
            if (!isUserRegistered)
            {
                MessageBox.Show("Welcome to Rooster Lottery!");

                var result = MessageBox.Show("Already have account?", "Yes", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    LoginForm login = new LoginForm();
                    login.Show();
                }
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            var player = new Player
            {
                UserName = txt_username.Text,
                PhoneNumber = txt_phone.Text,
                DateOfBirth = dtp_dob.Value,
            };

            Registerplayer(player);
        }
        private async void Registerplayer(Player player)
        {
            using(var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(player), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7194/player/register", content);
                if(response.IsSuccessStatusCode)
                {
                    isUserRegistered = true;
                    MessageBox.Show("Resgister Complete!");
                    this.Hide();
                    LoginForm login = new LoginForm();
                    login.Show();
                }
                if(!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Phone Number already Exit!");
                }
            }

        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            CheckUserRegistration();
        }
    }
}
