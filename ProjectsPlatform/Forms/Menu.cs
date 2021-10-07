using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectsPlatform
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();                     

            this.CenterToScreen();                        
            Calculator.BackgroundImage = Image.FromFile(@"../../Images/CalculatorImage.png");
            WeatherButton.BackgroundImage = Image.FromFile(@"../../Images/Weather.png");
            Base64.BackgroundImage = Image.FromFile(@"../../Images/base64.png");
            PasswordGeneratorButton.BackgroundImage = Image.FromFile(@"../../Images/PasswordGenerator.png");
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            
            Calculator calc = new Calculator();
            calc.Show();
            this.Hide();
        }
        private void WeatherButton_Click(object sender, EventArgs e)
        {
            var weather = new Forms.Weather();
            weather.Show();
            this.Hide();
        }
        private void Base64_Click(object sender, EventArgs e)
        {

            var Base = new Forms.Base64Converter();
            Base.Show();
            this.Hide();
            

        }


        bool mouseDown;
        Point offset;
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        
    }
}
