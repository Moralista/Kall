using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        string oldValue;
        char act = '0';
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            act = '+';
            oldValue = textBox1.Text;
            textBox1.Text = "";

        }

       

        private void button12_Click(object sender, EventArgs e)
        {
            act = '-';
            oldValue = textBox1.Text;
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            act = '*';
            oldValue = textBox1.Text;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            act = '/';
            oldValue = textBox1.Text;
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            act = '0';
            oldValue = "";
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            act = 's';
        }

        private void button19_Click(object sender, EventArgs e)
        {
            act = '^';
            oldValue = textBox1.Text;
            textBox1.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            act = '1';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (act)
            {
                case '+':
                    textBox1.Text = Convert.ToString(Convert.ToDouble(oldValue) + Convert.ToDouble(textBox1.Text));
                    act = '0';
                    break;
                case '-':
                    textBox1.Text = Convert.ToString(Convert.ToInt32(oldValue) - Convert.ToInt32(textBox1.Text));
                    act = '0';
                    break;
                case '*':
                    textBox1.Text = Convert.ToString(Convert.ToDouble(oldValue) * Convert.ToDouble(textBox1.Text));
                    act = '0';
                    break;
                case '/':
                    textBox1.Text = Convert.ToString(Convert.ToDouble(oldValue) / Convert.ToDouble(textBox1.Text));
                    act = '0';
                    break;
                case 's':
                    textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
                    act = '0';
                    break;
                case '^':
                    textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(oldValue), Convert.ToDouble(textBox1.Text)));
                    act = '0';
                    break;
                case '1':
                    textBox1.Text = Convert.ToString(1 / Convert.ToDouble(textBox1.Text));
                    act = '0';
                    break;
            }
            }
        }
    }

    
