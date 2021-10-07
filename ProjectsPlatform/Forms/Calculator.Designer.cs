
namespace ProjectsPlatform
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.TimesButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(245, 20);
            this.panel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Calculator";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(222, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(20, 20);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteButton.Location = new System.Drawing.Point(12, 90);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(162, 59);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "C";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DivideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DivideButton.Location = new System.Drawing.Point(180, 90);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(50, 59);
            this.DivideButton.TabIndex = 4;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = false;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // TimesButton
            // 
            this.TimesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TimesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimesButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TimesButton.Location = new System.Drawing.Point(12, 155);
            this.TimesButton.Name = "TimesButton";
            this.TimesButton.Size = new System.Drawing.Size(50, 59);
            this.TimesButton.TabIndex = 5;
            this.TimesButton.Text = "X";
            this.TimesButton.UseVisualStyleBackColor = false;
            this.TimesButton.Click += new System.EventHandler(this.TimesButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MinusButton.Location = new System.Drawing.Point(68, 155);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(50, 59);
            this.MinusButton.TabIndex = 6;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlusButton.Location = new System.Drawing.Point(124, 155);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(50, 59);
            this.PlusButton.TabIndex = 7;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EqualsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EqualsButton.Location = new System.Drawing.Point(180, 155);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(50, 59);
            this.EqualsButton.TabIndex = 8;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = false;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.input1.Location = new System.Drawing.Point(12, 36);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(218, 38);
            this.input1.TabIndex = 9;
            // 
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.input2.Location = new System.Drawing.Point(12, 36);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(218, 38);
            this.input2.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(2, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 222);
            this.panel2.TabIndex = 11;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(242, 230);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.TimesButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculator";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button TimesButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Panel panel2;
    }
}