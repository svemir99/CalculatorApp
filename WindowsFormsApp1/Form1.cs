using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String oprationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "0") || (isOperationPerformed))
                textBox2.Clear();

            isOperationPerformed = false;
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            textBox2.Text = textBox2.Text + button.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            oprationPerformed = button.Text;
            resultValue = Double.Parse(textBox2.Text);
            isOperationPerformed = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            resultValue = 0;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (oprationPerformed)
            {
                case "+":
                    textBox2.Text = (resultValue + Double.Parse(textBox2.Text)).ToString();
                    break;
                case "-":
                    textBox2.Text = (resultValue - Double.Parse(textBox2.Text)).ToString();
                    break;
                case "*":
                    textBox2.Text = (resultValue * Double.Parse(textBox2.Text)).ToString();
                    break;
                case "/":
                    textBox2.Text = (resultValue / Double.Parse(textBox2.Text)).ToString();
                    break;
                default:
                    break;


            }
        }
    }
}
