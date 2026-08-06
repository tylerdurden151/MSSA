using System.ComponentModel;

namespace Assignments_4._1._2
{

    public partial class Form1 : Form
    {
        private readonly ICalculator _calculator = new Calculator();


        public Form1()
        {
            InitializeComponent();

        }
        //Method to get the numbers from the textboxes and validate them
        private bool TryGetNumbers(out double x, out double y)
        {
            y = 0;

            if (!double.TryParse(firstNbx.Text, out x))
            {
                resultbx.Text = "First number is not valid.";
                return false;
            }

            if (!double.TryParse(secondNbx.Text, out y))
            {
                resultbx.Text = "Second number is not valid.";
                return false;
            }

            return true;
        }

        private void addbtrn_Click(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double x, out double y))
            {
                resultbx.Text = _calculator.Add(x, y).ToString();
            }
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double x, out double y))
            {
                resultbx.Text = _calculator.Subtract(x, y).ToString();
            }
        }

        private void multibtn_Click(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double x, out double y))
            {
                resultbx.Text = _calculator.Multiply(x, y).ToString();
            }
        }

        private void divbtn_Click(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double x, out double y))
            {
                try
                {
                    resultbx.Text = _calculator.Divide(x, y).ToString();
                }
                catch (DivideByZeroException ex)
                {
                    // the throw inside Math.Divide lands here
                    resultbx.Text = ex.Message;
                }
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            firstNbx.Clear();
            secondNbx.Clear();
            resultbx.Clear();
        }

    }
}
