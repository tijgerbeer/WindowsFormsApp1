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
		}

		private void buttonHello_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "") textBox1.Text = "Hello there!"; else textBox1.Text = "";
		}

        private void buttonGoodbye_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "Good bye!"; else textBox1.Text = "";
        }

        private void buttonStay_Click(object sender, EventArgs e)
        {
			if (textBox1.Text == "") textBox1.Text = "Stay"; else textBox1.Text = ""; 
        }
    }
}
