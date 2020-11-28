using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace Network_lab3
{
    public partial class Form1 : Form
    {
        HttpClient httpClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            httpClient = new HttpClient();
            httpClient.MaxResponseContentBufferSize = 256000;
            httpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");
        }

        private async void Get_button_Click(object sender, EventArgs e)
        {
            try
            {
                string responseBodyAsText;
                OutputView.Text = "";
                Status_label.Text = "Waiting for response ...";

                HttpResponseMessage response = await httpClient.GetAsync(InputAddress.Text);
                response.EnsureSuccessStatusCode();

                Status_label.Text = response.StatusCode + " " + response.ReasonPhrase + Environment.NewLine;
                responseBodyAsText = await response.Content.ReadAsStringAsync();
                responseBodyAsText = responseBodyAsText.Replace("<br>", Environment.NewLine); // Insert new lines
                OutputView.Text = responseBodyAsText;
            }
            catch (HttpRequestException hre)
            {
                Status_label.Text = hre.ToString();
            }
            catch (Exception ex)
            {
                // For debugging
                Status_label.Text = ex.ToString();
            }
        }
    }
}
