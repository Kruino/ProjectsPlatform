
namespace ProjectsPlatform
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Calculator = new System.Windows.Forms.Button();
            this.WeatherButton = new System.Windows.Forms.Button();
            this.Base64 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.Calculator);
            this.flowLayoutPanel1.Controls.Add(this.WeatherButton);
            this.flowLayoutPanel1.Controls.Add(this.Base64);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(337, 395);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Calculator
            // 
            this.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Calculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Calculator.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Calculator.FlatAppearance.BorderSize = 0;
            this.Calculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculator.Location = new System.Drawing.Point(3, 3);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(162, 118);
            this.Calculator.TabIndex = 0;
            this.Calculator.UseVisualStyleBackColor = false;
            this.Calculator.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // WeatherButton
            // 
            this.WeatherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.WeatherButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WeatherButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.WeatherButton.FlatAppearance.BorderSize = 0;
            this.WeatherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeatherButton.Location = new System.Drawing.Point(171, 3);
            this.WeatherButton.Name = "WeatherButton";
            this.WeatherButton.Size = new System.Drawing.Size(162, 118);
            this.WeatherButton.TabIndex = 1;
            this.WeatherButton.UseVisualStyleBackColor = false;
            this.WeatherButton.Click += new System.EventHandler(this.WeatherButton_Click);
            // 
            // Base64
            // 
            this.Base64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Base64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Base64.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Base64.FlatAppearance.BorderSize = 0;
            this.Base64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Base64.Location = new System.Drawing.Point(3, 127);
            this.Base64.Name = "Base64";
            this.Base64.Size = new System.Drawing.Size(162, 118);
            this.Base64.TabIndex = 2;
            this.Base64.UseVisualStyleBackColor = false;
            this.Base64.Click += new System.EventHandler(this.Base64_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 20);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menu";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(343, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(20, 20);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(2, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 442);
            this.panel2.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Calculator;
        private System.Windows.Forms.Button WeatherButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button Base64;
        private System.Windows.Forms.Panel panel2;
    }
}

