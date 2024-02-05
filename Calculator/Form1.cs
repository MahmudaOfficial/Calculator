using System.Security;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float number1;
        float number2;
        float total;
        string opt;

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            opt = "+";
            number1 = float.Parse(textBox.Text);
            textBox.Clear();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            opt = "-";
            number1 = float.Parse(textBox.Text);
            textBox.Clear();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            opt = "*";
            number1 = float.Parse(textBox.Text);
            textBox.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            opt = "/";
            number1 = float.Parse(textBox.Text);
            textBox.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            number2 = float.Parse(textBox.Text);
            if (opt == "+")
            {
                total = number1 + number2;
            }
            if (opt == "-")
            {
                total = number1 - number2;
            }
            if (opt == "*")
            {
                total = number1 * number2;
            }
            if (opt == "/")
            {
                total = number1 / number2;
            }
            textBox.Text = total.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {

            textBox.Clear();

        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ".";
        }
    }
}
