﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cat_test
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form2 settingsForm = new Form2();

            // Show the settings form
            settingsForm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            РасписаниеАдмин settingsForm = new РасписаниеАдмин();

            // Show the settings form
            settingsForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
           Удалить_кормушку settingsForm = new Удалить_кормушку();

            // Show the settings form
            settingsForm.Show();
        }
    }
}
