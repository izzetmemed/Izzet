﻿namespace Izzet
{
    partial class Login
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
            Password = new TextBox();
            Passw = new Label();
            User = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Password.Location = new Point(535, 362);
            Password.Name = "Password";
            Password.Size = new Size(367, 36);
            Password.TabIndex = 33;
            Password.UseSystemPasswordChar = true;
            // 
            // Passw
            // 
            Passw.AutoSize = true;
            Passw.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Passw.Location = new Point(668, 325);
            Passw.Name = "Passw";
            Passw.Size = new Size(104, 25);
            Passw.TabIndex = 32;
            Passw.Text = "Password:";
            // 
            // User
            // 
            User.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            User.Location = new Point(535, 272);
            User.Name = "User";
            User.Size = new Size(367, 36);
            User.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(668, 233);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 30;
            label1.Text = "User:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(634, 421);
            button1.Name = "button1";
            button1.Size = new Size(175, 39);
            button1.TabIndex = 29;
            button1.Text = "Daxil olmaq";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(128, 255, 128);
            label4.Location = new Point(550, 138);
            label4.Name = "label4";
            label4.Size = new Size(336, 65);
            label4.TabIndex = 34;
            label4.Text = "HomeLand.az";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 620);
            Controls.Add(label4);
            Controls.Add(Password);
            Controls.Add(Passw);
            Controls.Add(User);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Password;
        private Label Passw;
        private TextBox User;
        private Label label1;
        private Button button1;
        private Label label4;
    }
}