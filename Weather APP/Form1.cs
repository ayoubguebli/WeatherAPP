using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Weather_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getWeather();
            stad.Text = "Amsterdam";
        }

        async void getWeather()
        {
            try
            {
                HttpClient client = new HttpClient();

                var latitude = 52.37;
                var longitude = 4.09;

                string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&current=temperature_2m,wind_speed_10m&hourly=temperature_2m,relative_humidity_2m,wind_speed_10m";

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                forecast forecast = JsonConvert.DeserializeObject<forecast>(json);

                // Access current weather data from the forecast object
                temperatuurLbl.Text = $"Momentele Temperatuur: {forecast.current.temperature_2m}°C\n";
                windkrachtLbl.Text = $"Momentele snelheid van de wind: {forecast.current.wind_speed_10m}km/h";
                timeLbl.Text = $"Tijd op dit moment: {forecast.current.time}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching weather data: {ex.Message}");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stadZoekbtn_Click(object sender, EventArgs e)
        {
            stad.Text = stadInvoertxt.Text;
            stadInvoertxt.Text = string.Empty;
        }
    }
}
