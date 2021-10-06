using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectsPlatform
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            this.CenterToScreen();
            input2.Visible = false;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu men = new Menu();
            men.Show();
        }

        string selectedbutton = "";      
        string FullNumber = "";       
        string FullNumber2 = "";       
        int result = 0;
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            
            input1.Visible = true;
            input2.Visible = false;
            input1.Text = "";
            input2.Text = "";
            result = 0;
        }
        private void DivideButton_Click(object sender, EventArgs e)
        {
            ResetButtons();
            DivideButton.BackColor = Color.FromArgb(255, 128, 255);
            selectedbutton = "/";
            FullNumber = input1.Text;
            SwitchInput();


        }
        private void TimesButton_Click(object sender, EventArgs e)
        {
            ResetButtons();
            TimesButton.BackColor = Color.FromArgb(255, 128, 255);
            selectedbutton = "*";
            FullNumber = input1.Text;
            SwitchInput();


        }
        private void MinusButton_Click(object sender, EventArgs e)
        {
            ResetButtons();
            MinusButton.BackColor = Color.FromArgb(255, 128, 255); ;
            selectedbutton = "-";
            FullNumber = input1.Text;
            SwitchInput();


        }
        private void PlusButton_Click(object sender, EventArgs e)
        {
            ResetButtons();
            PlusButton.BackColor = Color.FromArgb(255, 128, 255);
            selectedbutton = "+";
            FullNumber = input1.Text;
            SwitchInput();

        }
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            ResetButtons();
            input1.Visible = true;
            input2.Visible = false;

            if (selectedbutton == "")
            {

            }
            else
            {         
                FullNumber2 = input2.Text;                
                if (FullNumber == "")
                {
                    FullNumber = "0";
                }
                if (FullNumber2 == "")
                {
                    FullNumber2 = "0";
                }
                
                int FullNumberInt = Int32.Parse(FullNumber);
                int FullNumber2Int = Int32.Parse(FullNumber2);
                

                switch (selectedbutton)
                {
                    case "/":
                        result = FullNumberInt / FullNumber2Int;
                        break;                  
                    case "*":
                        result = FullNumberInt * FullNumber2Int;
                        break;
                    case "+":
                        result = FullNumberInt + FullNumber2Int;
                        break;
                    case "-":
                        result = FullNumberInt - FullNumber2Int;
                        break;
                    case "":
                        break; 
                }

                input1.Text = result.ToString();
                input2.Text = "";
                ResetButtons();
            }          
        }     
        public void ResetButtons()
        {
            DivideButton.BackColor = Color.FromArgb(128, 128, 255);           
            TimesButton.BackColor = Color.FromArgb(128, 128, 255);
            MinusButton.BackColor = Color.FromArgb(128, 128, 255);
            PlusButton.BackColor = Color.FromArgb(128, 128, 255);         
        }       
        public void SwitchInput()
        {
            input1.Visible = false;
            input2.Visible = true;
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

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
