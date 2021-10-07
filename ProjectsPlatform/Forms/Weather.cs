using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;

using System.Windows.Forms;

namespace ProjectsPlatform.Forms
{
    public partial class Weather : Form
    {
        public static string Data = "";

        public static string city = "Odense";
        public static string Country = "DK";
        public static string SpeedType = "M/s";
        public static string CurrentTemp = "10";
        public static string jsonData = "";
        public string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Weather() 
        {
           
            InitializeComponent();
            
            this.CenterToScreen();

            this.CityBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Countrybox.DropDownStyle = ComboBoxStyle.DropDownList;

            Countrybox.Items.AddRange(new object[] { "Danmark", "United Kingdoms", "United States" });
            CityBox.Items.AddRange(new object[] { "Odense", "Årslev", "Nyborg", "Svendborg", "Kerteminde", "København", "Ålborg", "Randers", "Skagen" });

            Countrybox.SelectedIndex = 0;
            CityBox.SelectedIndex = 0;

            city = CityBox.SelectedItem.ToString();
            Country = Countrybox.SelectedItem.ToString();

            Api();
        }
        private void Weather_Load(object sender, EventArgs e)
        {

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Show();
        }
        public async void Api()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://weather-by-api-ninjas.p.rapidapi.com/v1/weather?city=" + city),
                Headers =
            {
            { "x-rapidapi-host", "weather-by-api-ninjas.p.rapidapi.com" },
            { "x-rapidapi-key", "33e7e23e6cmshc9258f82ac27d1bp15c44ajsn68058433470f" },
            },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                jsonData = body;

                setLoadingbar();
                SetData();

                Data = body;
                outputBox.Text = body;

            }

        }  
        private void Update_Click(object sender, EventArgs e)
        {

            Country = Countrybox.SelectedItem.ToString();
            city = CityBox.SelectedItem.ToString();
            Api();


        }
        public void setLoadingbar()
        {

            var json = (JObject)JsonConvert.DeserializeObject(jsonData);

            var Currenttemperature = json["temp"].ToString();

            int temp = Int32.Parse(Currenttemperature);

            if (temp <= 15)
            {
                TempPanel.BackColor = Color.Blue;
            }
            if (temp > 15 && temp < 25)
            {
                TempPanel.BackColor = Color.Yellow;
            }
            if (temp > 25)
            {
                TempPanel.BackColor = Color.Red;
            }
            int size = temp * 4;

            if (size >= 170)
            {
                size = 170;
            }

            TempPanel.Size = new Size(size, 10);
            TempPanel.AutoSize = true;




        }
        public void SetData()
        {
            var json = (JObject)JsonConvert.DeserializeObject(jsonData);


            TempLabel.Text = json["temp"].ToString();
            TempDescriptionLabel.Text = "Feels like: " + json["feels_like"] + "\nMax temp: " + json["max_temp"] + "\nMin temp:  " + json["min_temp"];


            WindSpeedLabel.Text = json["wind_speed"] + " M/s";

            CityLabel.Text = "City: " + CityBox.SelectedItem.ToString();
            CountryLabel.Text = "Country: \n" + Countrybox.SelectedItem.ToString();

            Humiditylabel.Text = json["humidity"] + "%";
        }
        private void Country_Changed(object sender, EventArgs e)
        {

            if (Countrybox.SelectedItem.ToString() == "Danmark")
            {
                CityBox.Items.Clear();
                CityBox.Items.AddRange(new object[] { "Odense", "Årslev", "Nyborg", "Svendborg", "Kerteminde", "København", "Ålborg", "Randers", "Skagen" });
                CityBox.SelectedIndex = 0;

            }
            else if (Countrybox.SelectedItem.ToString() == "United States")
            {
                CityBox.Items.Clear();
                CityBox.Items.AddRange(new object[] { "Las Vegas", "New York", "San Francisco", "Los Angeles", "Chicago", "Washington D.C.", "Miami" });
                CityBox.SelectedIndex = 0;

            }
            else if (Countrybox.SelectedItem.ToString() == "United Kingdoms")
            {
                CityBox.Items.Clear();
                CityBox.Items.AddRange(new object[] { "London", "Edinburgh", "Manchester", "Belfast", "Glasgow", "Bath", "Bristol" });
               

                CityBox.SelectedIndex = 0;
            }


        }
        private void DownloadButton_Click(object sender, EventArgs e)
        {
            
            string file = FilePath + @"\Weather.txt";
            
            if (File.Exists(file))
            {
                

                DialogResult dialogResult = MessageBox.Show("File exists. Want to replace it?", "Error!!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    File.Delete(file);

                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(file)))
                    {
                        outputFile.WriteLine(Data);
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                   
                }
            }
            else
            {
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(file)))
                {
                    outputFile.WriteLine(Data);
                }
            }          
        }
        private void GoToFile_Click(object sender, EventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); 

            System.Diagnostics.Process.Start("explorer.exe", filePath); 
        }

        bool mouseDown;
        Point offset;

        private void MouseDown_Hold(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void MouseMove_Drag(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void MouseUp_LetGo(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}

