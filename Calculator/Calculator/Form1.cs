using System.Diagnostics;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        Char operation = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text[0];
            result = Double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void clearClick(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
            operation = ' ';

            MessageBox.Show("Obrisani podaci");
        }

        private void dateClick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("dd.MM.yyyy. HH:mm:ss.");

            MessageBox.Show("Prikazan datum");
        }

        private void exitClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void equalsClick(object sender, EventArgs e)
        {
            Double finalResult = result;
            switch (operation)
            {
                case '+':
                    finalResult += Double.Parse(textBox1.Text);
                    break;
                case '-':
                    finalResult -= Double.Parse(textBox1.Text);
                    break;
                case '*':
                    finalResult *= Double.Parse(textBox1.Text);
                    break;
                case '/':
                    finalResult /= Double.Parse(textBox1.Text);
                    break;
            }
            textBox1.Text = finalResult.ToString();

            MessageBox.Show("Rezultat je: " + textBox1.Text);
        }

        private void reverseClick(object sender, EventArgs e)
        {
            Double result = Double.Parse(textBox1.Text);
            result *= -1;
            textBox1.Text = result.ToString();
        }
    }
}
