using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjectsPlatform.Forms
{
    public partial class Base64Converter : Form
    {
        public Base64Converter()
        {
            InitializeComponent();
            this.CenterToScreen();
            Errorlabel.Text = "";
            InputBox.DragDrop += new DragEventHandler(InputBox_DragDrop);
            InputBox.AllowDrop = true;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Show();
        }
        private void InputBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData("FileDrop") is string[] Txt)
            {
                foreach (var list in from string name in Txt
                                     let list = Txt as string[]
                                     where list != null && !string.IsNullOrWhiteSpace(list[0])
                                     select list)
                {
                    InputBox.Clear();
                    InputBox.LoadFile(list[0], RichTextBoxStreamType.PlainText);
                }
            }
        }
        private void Decode_click(object sender, EventArgs e)
        {

            string Base64BinaryStr = InputBox.Text;


            if (NameBox.Text == "")
            {
                FileNameLabel.ForeColor = Color.Red;
                FileNameLabel.Text = "Please enter a name";
            }
            else {
                FileNameLabel.ForeColor = Color.Black;
                FileNameLabel.Text = "File name:";
            string FileName = NameBox.Text;

            string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // finder den nuværendes brugers desktop mappe
            string type = "Type";
           

            if (string.IsNullOrEmpty(InputBox.Text)) //Checker om base64 input feltet er tomt, og lær dig ikke komme vidre vis det er.
            {
                Errorlabel.Text = "Please input base64 to continue.";
                Errorlabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
            }


            else if (string.IsNullOrEmpty(InputBox.Text)) //Checker om navnefeltet er tomt. og lær dig ikke komme vidre vis det er.
            {
                Errorlabel.Text = "Invalid Name:";
                Errorlabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
            }


            else //Ellers forsætter den med at checke om bruger inputet har har en specefik signatur i den.
            {

                switch (Base64BinaryStr)
                {
                    //-----------------------------------------------------------------------//

                    case string Pdf when Pdf.Contains("JVBERi0"): //Den checker om texten har JVBERi0 i den. Vis den har, er det et pdf document.
                        type = ".pdf"; //laver en ny value under string type.
                        FileTypeLabel.Text = "Type: Pdf"; //Skriver i label4 at den har decoded en pdf fil.
                        break;

                    //----------------------------------------------------------------// 

                    case string Png when Png.Contains("iVBORw0KGgo"):
                        type = ".png";
                        FileTypeLabel.Text = "Type: png";
                        break;

                    //------------------------------------------------------------------//

                    case string Gif when Gif.Contains("R0lGODdh") || Gif.Contains("R0lGODlh"):
                        type = ".gif";
                        FileTypeLabel.Text = "Type: gif";
                        break;

                    //----------------------------------------------------------------//

                    case string Mp3 when Mp3.Contains("SUQzBAAAAAAAI1"):
                        type = ".mp3";
                        FileTypeLabel.Text = "Type: mp3";
                        break;

                    //--------------------------------------------------------------//

                    case string Jpg when Jpg.Contains("/9j/"):
                        type = ".jpg";
                        FileTypeLabel.Text = "Type: jpg";
                        break;

                    //-------------------------------------------------------------//

                    case string Mkv when Mkv.Contains("GkXfo6NChoEB"):
                        type = ".mkv";
                        FileTypeLabel.Text = "Type: mkv";
                        break;

                    //----------------------------------------------------------//

                    case string Mp4 when Mp4.Contains("AAAAGGZ0"):
                        type = ".mp4";
                        FileTypeLabel.Text = "Type: mp4";
                        break;

                    //---------------------------------------------------------//                    

                    case string Docx when Docx.Contains("UEsDBBQA"):
                        type = ".docx";
                        FileTypeLabel.Text = "Type: Docx";
                        break;
                }

                string FileLocation = FilePath + @"\" + FileName + type; // string der får sat sammen hele file stigen. For at kunne checke den og bruge den længere nede.

                if (File.Exists(FileLocation)) // Cheker om filen excistere.  
                {
                    FileNameLabel.Text = "Filename Exists:"; // Hvis den ikke excistere ændre den label 2 til "Filename Exists". 
                    FileNameLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                }
                else if (type.Contains("Type"))
                {
                    Errorlabel.Text = "Base64 invalid or not supported.";
                    Errorlabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                }
                else
                {

                    byte[] Bytes = Convert.FromBase64String(Base64BinaryStr); // tær Base64BinaryStr og convertere den fra base64.


                    System.IO.FileStream Stream =
                    new FileStream(FileLocation, FileMode.CreateNew); //Udskriver den som den type den fandt ud af tidligere.
                    System.IO.BinaryWriter Writer =
                        new BinaryWriter(Stream);
                    Writer.Write(Bytes, 0, Bytes.Length);
                    Writer.Close();                  
                   
                    //Og skifter farven tilbage til sort.
                    FileNameLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");

                    //Vis man er kommet igennem decoding skriver den Succesful i bunden. 
                    Errorlabel.Text = "Your decoding was succesful.";
                    Errorlabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");

                }
            }
        }
    }

        private void DeleteText_Click(object sender, EventArgs e)
        {
            InputBox.Text = ""; //vis du clicker delete text i bunden. Sletter den alt text inden i text feltet.
            Errorlabel.Text = "";

        }

        private void GoToFile_Click(object sender, EventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //finder din skrivebordsfolder.

            System.Diagnostics.Process.Start("explorer.exe", filePath); //sender dig ud til din desktop folder.
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

        private void Base64Converter_Load(object sender, EventArgs e)
        {

        }
    }
}
