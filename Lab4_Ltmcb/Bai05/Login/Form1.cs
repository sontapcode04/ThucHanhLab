using Newtonsoft.Json.Linq;
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

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false; // Disable the login button during the request

            try
            {
                var formData = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("username", tbUsername.Text),
                    new KeyValuePair<string, string>("password", tbPassword.Text)
                });

                using (HttpResponseMessage response = await httpClient.PostAsync("auth/token", formData))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        JObject data = JObject.Parse(jsonResponse);
                        string access_token = (string)data["access_token"];
                        string token_type = (string)data["token_type"];
                        rtbStatus.Text = token_type + "\n" + access_token + "\n\n" + "Đăng nhập thành công";
                    }
                    else
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        JObject data = JObject.Parse(jsonResponse);
                        string detail = (string)data["detail"];
                        rtbStatus.Text = detail;
                    }
                }
            }
            catch (Exception ex)
            {
                rtbStatus.Text = "An error occurred: " + ex.Message;
            }
            finally
            {
                btnLogin.Enabled = true; // Re-enable the login button after the request
            }
        }

    }
}
