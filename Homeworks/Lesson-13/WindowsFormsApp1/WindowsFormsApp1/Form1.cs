﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var btn = new Button();
            btn.Click += new EventHandler(this.ShowRegistr);
            this.Controls.Add(btn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void ShowRegistr(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }
    }
}
