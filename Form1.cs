using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_calculator_real
{
    public partial class Form1 : Form
    {
        double a, b, c;
        string d;
        public Form1()

        {
            InitializeComponent();
        }

        public void process(string s)
        {
            if (T.Text.Contains("-"))
                T2.Text = T.Text;
                d = s;
            if (d == "÷")
                T2.Text += "÷";
            if (d == "×")
                T2.Text += "×";
            if (d == "-")
                T2.Text += "-";
            if (d == "+")
                T2.Text += "+";
            if (d == "%")
                T2.Text += "%";

            a = Convert.ToDouble(T.Text);
            T.Clear();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            KeyEnter(0);

        }

        private void KeyEnter(int i)
        {
            if (T.Text == "0")
            {
                T.Text = i.ToString();
                T2.Text = i.ToString();
            }

            else
            {
                T.Text += i.ToString();
                T2.Text += i.ToString(); 
            }
        }

        private void T_TextChanged(object sender, EventArgs e)
        {

        }

        private void One_Click(object sender, EventArgs e)
        {
            KeyEnter(1);
        }

        private void Two_Click(object sender, EventArgs e)
        {
            KeyEnter(2);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            KeyEnter(3);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            KeyEnter(4);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            KeyEnter(5);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            KeyEnter(6);
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            KeyEnter(7);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            KeyEnter(8);
        }

        private void Devide_Click(object sender, EventArgs e)
        {
            process("÷");
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            process("×");
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            process("-");
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            process("+");
        }
        private void Percent_Click(object sender, EventArgs e)
        {
            process("%");
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            T2.Clear();
            b = Convert.ToDouble(T.Text);
            switch (d)
            {
                case "÷":
                    c = a / b;
                    break;
                case "×":
                    c = a * b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "+":
                    c = a + b;
                    break;
                case "%":
                    c = a % b;
                    break;
            }
            T.Text = c.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double h = Convert.ToDouble(T.Text);
            T2.Text = "√" + h;
            h = Convert.ToDouble(System.Math.Sqrt(h));
            T.Text = h.ToString();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            double h = Convert.ToDouble(T.Text);
            T2.Text = "sqrt(" + h + ")";
            h = h * h;
            T.Text = h.ToString();
        }

        private void oneuponex_Click_1(object sender, EventArgs e)
        {
            double h = Convert.ToDouble(T.Text);
            T2.Text = "Inv(" + h + ")";
            h = 1 / h;
            T.Text = h.ToString();
        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            if (!T.Text.Contains("-"))
                T.Text = "-" + T.Text.Trim('+');
            else
                T.Text = "+" + T.Text.Trim('-');
        }

        private void CE_Click(object sender, EventArgs e)
        {
            T.Clear();
            T.Text = "0";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            KeyEnter(9);
        }

        private void C_Click(object sender, EventArgs e)
        {
            T.Clear();
            T.Text = "0";
        }
    }
}
