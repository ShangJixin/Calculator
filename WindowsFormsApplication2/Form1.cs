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
        public Form1()
        {
            InitializeComponent();
        }

        public double beforeInput = 0;
        public double afterInput = 0;
        public char mode = 'i';

        public void clickFunction(int num)
        {
            if (textBox1.Text == "" || textBox1.Text == "分母不能为0")
                textBox1.Text = null;
            textBox1.Text = textBox1.Text + num.ToString();
        }

        public void switchMode(char s)
        {
            if (this.mode == 'i')
            {
                this.beforeInput = double.Parse(textBox1.Text);
                textBox1.Text = "";
                this.mode = s;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            clickFunction(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickFunction(2);
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            clickFunction(int.Parse(btn.Text));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.afterInput = double.Parse(textBox1.Text);
            switch (this.mode)
            {
                case '+' :
                    this.beforeInput = this.beforeInput + this.afterInput;
                    textBox1.Text = this.beforeInput.ToString();
                    this.mode = 'i';
                    break;
                case '-':
                    this.beforeInput = this.beforeInput - this.afterInput;
                    textBox1.Text = this.beforeInput.ToString();
                    this.mode = 'i';
                    break;
                case '*':
                    this.beforeInput = this.beforeInput * this.afterInput;
                    textBox1.Text = this.beforeInput.ToString();
                    this.mode = 'i';
                    break;
                case '/':
                    if (this.afterInput == 0)
                    {
                        textBox1.Text = "分母不能为0";
                        this.mode = 'i';
                    }
                    else
                    {
                        this.beforeInput = this.beforeInput / this.afterInput;
                        textBox1.Text = this.beforeInput.ToString();
                        this.mode = 'i';
                    }
                    break;
                default :
                    textBox1.Text = "0";
                    break;

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clickFunction(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clickFunction(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clickFunction(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clickFunction(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clickFunction(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clickFunction(9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switchMode('+');
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clickFunction(0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switchMode('-');
        }

        private void button13_Click(object sender, EventArgs e)
        {
            switchMode('*');
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switchMode('/');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickFunction(3);
        }
    }
}
