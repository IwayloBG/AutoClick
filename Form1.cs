using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClick
{
    public partial class Form1 : Form
    {
        ClickOptions option = new ClickOptions();
        int Counter = 0;

        public Form1()
        {
            InitializeComponent();

            option.ClickOption = "";
            timer1.Interval = (int)numericUpDown1.Value;
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = int.MaxValue;
            numericUpDown1.Value = 2000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (option.ClickOption == "")
            {
                textBox1.Text = "Select Click Option";
            }
            else
            {
                timer1.Start();
                textBox1.Text = "Currently Clicking " + option.ClickOption;
            }
        }

        private void ClickIt(string ClickChoice)
        {
            System.Windows.Forms.SendKeys.SendWait(ClickChoice);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ClickIt(option.ClickOption);
            Counter++;
            textBox2.Text = Counter.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1000)
            {
                textBox1.Text = "Cannot have less than 1000 as Clicking Interval";
                numericUpDown1.Value = 1000;
            }
            else
            {
                timer1.Interval = (int)numericUpDown1.Value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            option.ClickOption = "";
            textBox1.Text = "Clicking Stopped";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            option.ClickOption = "(6)";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            option.ClickOption = "(G)";
        }
    }
}
