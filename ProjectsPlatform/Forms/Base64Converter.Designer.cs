
namespace ProjectsPlatform.Forms
{
    partial class Base64Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base64Converter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Errorlabel = new System.Windows.Forms.Label();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.GoToFileButton = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileTypeLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 20);
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
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Base64 Converter";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(377, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(20, 20);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Errorlabel
            // 
            this.Errorlabel.AutoSize = true;
            this.Errorlabel.ForeColor = System.Drawing.Color.Red;
            this.Errorlabel.Location = new System.Drawing.Point(12, 158);
            this.Errorlabel.Name = "Errorlabel";
            this.Errorlabel.Size = new System.Drawing.Size(0, 13);
            this.Errorlabel.TabIndex = 16;
            // 
            // DecodeButton
            // 
            this.DecodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DecodeButton.FlatAppearance.BorderSize = 0;
            this.DecodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecodeButton.Location = new System.Drawing.Point(12, 174);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(271, 23);
            this.DecodeButton.TabIndex = 10;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = false;
            this.DecodeButton.Click += new System.EventHandler(this.Decode_click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(289, 145);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(96, 23);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Delete text";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteText_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(12, 26);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(271, 129);
            this.InputBox.TabIndex = 12;
            this.InputBox.Text = "";
            // 
            // GoToFileButton
            // 
            this.GoToFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GoToFileButton.FlatAppearance.BorderSize = 0;
            this.GoToFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToFileButton.Location = new System.Drawing.Point(289, 174);
            this.GoToFileButton.Name = "GoToFileButton";
            this.GoToFileButton.Size = new System.Drawing.Size(96, 23);
            this.GoToFileButton.TabIndex = 13;
            this.GoToFileButton.Text = "Go to file";
            this.GoToFileButton.UseVisualStyleBackColor = false;
            this.GoToFileButton.Click += new System.EventHandler(this.GoToFile_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.BackColor = System.Drawing.Color.White;
            this.FileNameLabel.Location = new System.Drawing.Point(286, 27);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FileNameLabel.TabIndex = 14;
            this.FileNameLabel.Text = "File Name:";
            // 
            // FileTypeLabel
            // 
            this.FileTypeLabel.AutoSize = true;
            this.FileTypeLabel.BackColor = System.Drawing.Color.White;
            this.FileTypeLabel.Location = new System.Drawing.Point(286, 129);
            this.FileTypeLabel.Name = "FileTypeLabel";
            this.FileTypeLabel.Size = new System.Drawing.Size(34, 13);
            this.FileTypeLabel.TabIndex = 15;
            this.FileTypeLabel.Text = "Type:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(289, 43);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(92, 20);
            this.NameBox.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(2, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 200);
            this.panel2.TabIndex = 17;
            // 
            // Base64Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(397, 209);
            this.Controls.Add(this.Errorlabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.FileTypeLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.GoToFileButton);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
            this.Name = "Base64Converter";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Base64Converter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.Button GoToFileButton;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label FileTypeLabel;
        private System.Windows.Forms.Label Errorlabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Panel panel2;
    }
}