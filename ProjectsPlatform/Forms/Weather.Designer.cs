
namespace ProjectsPlatform.Forms
{
    partial class Weather
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weather));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TempDescriptionLabel = new System.Windows.Forms.Label();
            this.TempPanel = new System.Windows.Forms.Panel();
            this.TempLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.WindSpeedLabel = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.WindLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Humiditylabel = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.CityBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Countrybox = new System.Windows.Forms.ComboBox();
            this.Update = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 20);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Hold);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Drag);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_LetGo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Weather Api";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(338, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(20, 20);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 167);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.TempDescriptionLabel);
            this.panel2.Controls.Add(this.TempPanel);
            this.panel2.Controls.Add(this.TempLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 76);
            this.panel2.TabIndex = 15;
            // 
            // TempDescriptionLabel
            // 
            this.TempDescriptionLabel.AutoSize = true;
            this.TempDescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.TempDescriptionLabel.Location = new System.Drawing.Point(3, 20);
            this.TempDescriptionLabel.Name = "TempDescriptionLabel";
            this.TempDescriptionLabel.Size = new System.Drawing.Size(30, 13);
            this.TempDescriptionLabel.TabIndex = 13;
            this.TempDescriptionLabel.Text = "desc";
            // 
            // TempPanel
            // 
            this.TempPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TempPanel.Location = new System.Drawing.Point(0, 66);
            this.TempPanel.Name = "TempPanel";
            this.TempPanel.Size = new System.Drawing.Size(170, 10);
            this.TempPanel.TabIndex = 15;
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempLabel.ForeColor = System.Drawing.Color.White;
            this.TempLabel.Location = new System.Drawing.Point(110, 13);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(55, 38);
            this.TempLabel.TabIndex = 13;
            this.TempLabel.Text = "13";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Temperature";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel6.Location = new System.Drawing.Point(0, 66);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(170, 10);
            this.panel6.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.WindSpeedLabel);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.WindLabel);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(174, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 76);
            this.panel5.TabIndex = 16;
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.AutoSize = true;
            this.WindSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.WindSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.WindSpeedLabel.Location = new System.Drawing.Point(-3, 33);
            this.WindSpeedLabel.Name = "WindSpeedLabel";
            this.WindSpeedLabel.Size = new System.Drawing.Size(36, 25);
            this.WindSpeedLabel.TabIndex = 16;
            this.WindSpeedLabel.Text = "12";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel9.Location = new System.Drawing.Point(0, 66);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(170, 10);
            this.panel9.TabIndex = 15;
            // 
            // WindLabel
            // 
            this.WindLabel.AutoSize = true;
            this.WindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindLabel.ForeColor = System.Drawing.Color.White;
            this.WindLabel.Location = new System.Drawing.Point(0, 5);
            this.WindLabel.Name = "WindLabel";
            this.WindLabel.Size = new System.Drawing.Size(127, 25);
            this.WindLabel.TabIndex = 13;
            this.WindLabel.Text = "Wind speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.Humiditylabel);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(3, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 76);
            this.panel3.TabIndex = 18;
            // 
            // Humiditylabel
            // 
            this.Humiditylabel.AutoSize = true;
            this.Humiditylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Humiditylabel.ForeColor = System.Drawing.Color.White;
            this.Humiditylabel.Location = new System.Drawing.Point(59, 24);
            this.Humiditylabel.Name = "Humiditylabel";
            this.Humiditylabel.Size = new System.Drawing.Size(104, 38);
            this.Humiditylabel.TabIndex = 16;
            this.Humiditylabel.Text = "100%";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel7.Location = new System.Drawing.Point(0, 66);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(207, 10);
            this.panel7.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Humidity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.CountryLabel);
            this.panel4.Controls.Add(this.CityLabel);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(174, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 76);
            this.panel4.TabIndex = 17;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel8.Location = new System.Drawing.Point(0, 66);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(207, 10);
            this.panel8.TabIndex = 16;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryLabel.ForeColor = System.Drawing.Color.White;
            this.CountryLabel.Location = new System.Drawing.Point(3, 25);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(76, 20);
            this.CountryLabel.TabIndex = 14;
            this.CountryLabel.Text = "Country:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.ForeColor = System.Drawing.Color.White;
            this.CityLabel.Location = new System.Drawing.Point(3, 4);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(44, 20);
            this.CityLabel.TabIndex = 13;
            this.CityLabel.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.White;
            this.outputBox.Enabled = false;
            this.outputBox.Location = new System.Drawing.Point(9, 199);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(336, 74);
            this.outputBox.TabIndex = 18;
            this.outputBox.Text = "";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Black;
            this.ErrorLabel.Location = new System.Drawing.Point(7, 260);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(27, 13);
            this.ErrorLabel.TabIndex = 19;
            this.ErrorLabel.Text = "City:";
            // 
            // CityBox
            // 
            this.CityBox.BackColor = System.Drawing.Color.White;
            this.CityBox.ForeColor = System.Drawing.Color.Black;
            this.CityBox.FormattingEnabled = true;
            this.CityBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CityBox.Location = new System.Drawing.Point(9, 296);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(165, 21);
            this.CityBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(177, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Country:";
            // 
            // Countrybox
            // 
            this.Countrybox.FormattingEnabled = true;
            this.Countrybox.Location = new System.Drawing.Point(177, 296);
            this.Countrybox.Name = "Countrybox";
            this.Countrybox.Size = new System.Drawing.Size(165, 21);
            this.Countrybox.TabIndex = 22;
            this.Countrybox.SelectedIndexChanged += new System.EventHandler(this.Country_Changed);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Update.FlatAppearance.BorderSize = 0;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Update.Location = new System.Drawing.Point(9, 323);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(333, 23);
            this.Update.TabIndex = 23;
            this.Update.Text = "Update Information";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DownloadButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DownloadButton.FlatAppearance.BorderSize = 0;
            this.DownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DownloadButton.Location = new System.Drawing.Point(263, 249);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(80, 23);
            this.DownloadButton.TabIndex = 24;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = false;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.ErrorLabel);
            this.panel10.Location = new System.Drawing.Point(2, 20);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(353, 336);
            this.panel10.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(187, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Go to file";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.GoToFile_Click);
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(357, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Countrybox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
          
            this.Name = "Weather";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Weather_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TempDescriptionLabel;
        public System.Windows.Forms.Panel TempPanel;
        public System.Windows.Forms.Label TempLabel;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label WindSpeedLabel;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.Label WindLabel;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label Humiditylabel;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Label CountryLabel;
        public System.Windows.Forms.Label CityLabel;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.ComboBox CityBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Countrybox;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button1;
    }
}