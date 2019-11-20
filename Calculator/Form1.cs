using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calulator : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char opperation;
        double result;


        public Calulator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            this.textBox1.Text = "";
            if (String.IsNullOrEmpty(input))
            {
                input += "0.";
            }
            else
            {
                input += ".";
            }
            this.textBox1.Text = input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            this.textBox1.Text = "";
            if (input.Contains('-'))
            {
                input = input.Remove(0, 1);
            }
            else
            {
                input = $"-{input}";
            }
            this.textBox1.Text = input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text = input;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(input))
            {
                return;
            }
            else
            {
                this.textBox3.Text = "";
                this.textBox1.Text = "";
                input = input.Remove(input.Length-1);
                this.textBox1.Text = input;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            this.textBox1.Text = "0";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            this.result = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            this.textBox1.Text = "";
            result = Math.Sqrt(Convert.ToInt32(input));
            this.textBox1.Text = $"{result}";
            this.textBox3.Text = $"√{input}";
            if (result == NaN)
            {
                input = string.Empty;
            }
            else
            {
                this.input = Convert.ToString(result);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text = input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text = input;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text = input;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text = input;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text = input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text = input;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text = input;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            operand1 = input;
            opperation = '+';
            input = string.Empty;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            operand1 = input;
            opperation = '-';
            input = string.Empty;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            operand1 = input;
            opperation = '*';
            input = string.Empty;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            operand1 = input;
            opperation = '/';
            input = string.Empty;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            this.textBox1.Text = "";
            this.textBox1.Text = "0";
            input = string.Empty;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            string showing = string.Empty;

            if (opperation == '+')
            {
                result = num1 + num2;
                showing = $"{num1}+{num2}=";
            }
            else if (opperation == '-')
            {
                result = num1 - num2;
                showing = $"{num1}-{num2}=";
            }
            else if (opperation == '*')
            {
                result = num1 * num2;
                showing = $"{num1}*{num2}=";
            }
            else if (opperation == '/')
            {
                result = num1 / num2;
                showing = $"{num1}/{num2}=";
            }
            else
            {
                result = 0.0;
            }


            this.textBox1.Text = "";
            this.textBox1.Text = Convert.ToString(result);

            this.textBox3.Text = "";
            this.textBox3.Text = showing;

            this.operand1 = String.Empty;
            this.operand2 = string.Empty;
            this.input = Convert.ToString(result);
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox3.Text = "";
            this.result = Convert.ToInt32(input) * Convert.ToInt32(input);
            
            this.textBox1.Text = Convert.ToString(result);


            input = Convert.ToString(result);
        }
    }
}
