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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void main_num_label1_Click(object sender, EventArgs e)
        {
            this.main_num_label1.ResetText();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            this.main_num_label1.ResetText();
        }
        private void button0_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "9";
        }
        private void button_decimal_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + ".";
        }        

        private void division_button_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "÷";
            if (this.main_num_label1.Text != "")
            {
                this.first_nub_label.Text = this.main_num_label1.Text;
            }
            this.main_num_label1.Text = "";
        }

        private void multiply_button_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "*";
            if (this.main_num_label1.Text != "")
            {
                this.first_nub_label.Text = this.main_num_label1.Text;
            }
            this.main_num_label1.Text = "";
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "-";
            if (this.main_num_label1.Text != "")
            {
                this.first_nub_label.Text = this.main_num_label1.Text;
            }
            this.main_num_label1.Text = "";
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "+";
            if (this.main_num_label1.Text != "")
            {
                this.first_nub_label.Text = this.main_num_label1.Text;
            }
            this.main_num_label1.Text = "";
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            double firstNum;
            double secondNum;
            double result;

            double.TryParse(this.first_nub_label.Text, out firstNum);
            double.TryParse(this.main_num_label1.Text, out secondNum);
            result = 0;

            if (this.operator_label.Text == "+")
            {
                result = firstNum + secondNum;
            }

            if(this.operator_label.Text == "-")
            {
                result = firstNum - secondNum;
            }

            if (this.operator_label.Text == "÷")
            {
                result = firstNum/secondNum;
            }

            if (this.operator_label.Text == "*")
            {
                result = firstNum*secondNum;
            }

            this.main_num_label1.Text = result.ToString();
            this.operator_label.Text = "";
            this.first_nub_label.ResetText();

        }

        
    }    
}
