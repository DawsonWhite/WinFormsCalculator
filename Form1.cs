using System.Linq.Expressions;
namespace WinFormsDemo
{
    public partial class Calculator2 : Form
    {
        double num1;
        double num2;
        string option;
        double total=0;

        public Calculator2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null)
            {
                richTextBox1.Text += button1.Text;
            }
            else
            {
                richTextBox1.Text = button1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null)
            {
                richTextBox1.Text += button2.Text;
            }
            else
            {
                richTextBox1.Text = button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null)
            {
                richTextBox1.Text += button3.Text;
            }
            else
            {
                richTextBox1.Text = button2.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null)
            {
                richTextBox1.Text += button4.Text;
            }
            else
            {
                richTextBox1.Text = button4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null)
            {
                richTextBox1.Text += button5.Text;
            }
            else
            {
                richTextBox1.Text = button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null)
            {
                richTextBox1.Text += button6.Text;
            }
            else
            {
                richTextBox1.Text = button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null)
            {
                richTextBox1.Text += button7.Text;
            }
            else
            {
                richTextBox1.Text = button7.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null)
            {
                richTextBox1.Text += button8.Text;
            }
            else
            {
                richTextBox1.Text = button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null)
            {
                richTextBox1.Text += button9.Text;
            }
            else
            {
                richTextBox1.Text = button9.Text;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null)
            {
                richTextBox1.Text += button0.Text;
            }
            else
            {
                richTextBox1.Text = button0.Text;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            total = 0;
            num1 = 0;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(richTextBox1.Text);
            richTextBox1.Clear();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(richTextBox1.Text);
            richTextBox1.Clear();
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(richTextBox1.Text);
            richTextBox1.Clear();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(richTextBox1.Text);
            richTextBox1.Clear();
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(richTextBox1.Text);
            if (option.Equals("+"))
            {
                total = num1 + num2;
            }
            else if (option.Equals("-"))
            {
                total = (num1 - num2);
            }
            else if (option.Equals("*"))
            {
                total = (num1 * num2);
            }
            else if (option.Equals("/"))
            {
                total = (num1 / num2);
            }
            richTextBox1.Text = total.ToString();
        }
    }
}
