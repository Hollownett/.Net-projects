using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        StringBuilder rezult = new StringBuilder();
        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            rezult.Append("/");
            textBox1.Text = rezult.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            rezult.Append(0);
            textBox1.Text = rezult.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rezult.Clear();
            textBox1.Text = rezult.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            rezult.Append("(");
            textBox1.Text = rezult.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            rezult.Append(")");
            textBox1.Text = rezult.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int lenght = rezult.Length - 1;
                string text = rezult.ToString();
                rezult.Clear();
                for (int i = 0; i < lenght; i++)
                {
                    rezult.Append(text[i]);
                }
                textBox1.Text = rezult.ToString();
            }
            catch (ArgumentOutOfRangeException e2)
            {
                Console.WriteLine(e2.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            rezult.Append(1);
            textBox1.Text = rezult.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rezult.Append(2);
            textBox1.Text = rezult.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rezult.Append(3);
            textBox1.Text = rezult.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rezult.Append("*");
            textBox1.Text = rezult.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            rezult.Append(4);
            textBox1.Text = rezult.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            rezult.Append(5);
            textBox1.Text = rezult.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            rezult.Append(6);
            textBox1.Text = rezult.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rezult.Append("-");
            textBox1.Text = rezult.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            rezult.Append(7);
            textBox1.Text = rezult.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            rezult.Append(8);
            textBox1.Text = rezult.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            rezult.Append(9);
            textBox1.Text = rezult.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            rezult.Append("+");
            textBox1.Text = rezult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rezult.Append(",");
            textBox1.Text = rezult.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string n = rezult.ToString();
            PostfixNotationExpression p = new PostfixNotationExpression();


            
            textBox1.Text = p.result(n).ToString();
            

            }

        private void button27_Click(object sender, EventArgs e)
        {
            rezult.Append("sqr");
            textBox1.Text = rezult.ToString();

        }

        private void Button25_Click(object sender, EventArgs e)
        {
            rezult.Append("sqrt");
            textBox1.Text = rezult.ToString();
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            rezult.Append("sin");
            textBox1.Text = rezult.ToString();
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            rezult.Append("pow10");
            textBox1.Text = rezult.ToString();
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            rezult.Append("cos");
            textBox1.Text = rezult.ToString();
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            rezult.Append("Exp");
            textBox1.Text = rezult.ToString();
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            rezult.Append("%");
            textBox1.Text = rezult.ToString();
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            rezult.Append("tan");
            textBox1.Text = rezult.ToString();
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            rezult.Append("fact");
            textBox1.Text = rezult.ToString();
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            rezult.Append("log");
            textBox1.Text = rezult.ToString();
        }
    }
    }

