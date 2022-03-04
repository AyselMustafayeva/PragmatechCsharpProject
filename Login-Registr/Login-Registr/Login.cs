﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Registr
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.BackColor = Color.Yellow;
            var emailtxt = new Label();
            emailtxt.Width = 80;
            emailtxt.Text = "Email : ";
            emailtxt.Top = this.Height / 2 - 100;
            emailtxt.Left = this.Width / 2 - 200;
            emailtxt.ForeColor = Color.Blue;
            this.Controls.Add(emailtxt);
            var UEmail = new TextBox();
            UEmail.Width = 200;
            UEmail.Top = this.Height / 2 - 100;
            UEmail.Left = this.Width / 2 - 100;
            UEmail.ForeColor = Color.Blue;
            this.Controls.Add(UEmail);
            this.BackColor = Color.Yellow;
            var Passtxt = new Label();
            Passtxt.Width = 80;
            Passtxt.Text = "Password : ";
            Passtxt.Top = this.Height / 2 - 60;
            Passtxt.Left = this.Width / 2 - 200;
            Passtxt.ForeColor = Color.Blue;
            this.Controls.Add(Passtxt);
            var UPassword = new TextBox();
            UPassword.Width = 200;
            UPassword.Top = this.Height / 2 - 60;
            UPassword.Left = this.Width / 2 - 100;
            UPassword.ForeColor = Color.Blue;
            this.Controls.Add(UPassword);
            var loginbtn = new Button();
            loginbtn.Width = 80;
            loginbtn.Text = "Login";
            loginbtn.Left = this.Width / 2 - 100;
            loginbtn.BackColor = Color.Blue;
            loginbtn.ForeColor = Color.Yellow;
            loginbtn.Top = this.Height / 2;
            this.Controls.Add(loginbtn);
            var registrbtn = new Button();
            registrbtn.Width = 80;
            registrbtn.Text = "Registration";
            registrbtn.Left = this.Width / 2;
            registrbtn.BackColor = Color.Blue;
            registrbtn.ForeColor = Color.Yellow;
            registrbtn.Top = this.Height / 2;
            registrbtn.Click += new EventHandler(this.ShowRegistr);
            this.Controls.Add(registrbtn);

        }

        private void ShowRegistr(object sender, EventArgs e)
        {
            var registration = new Registr();
            registration.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}