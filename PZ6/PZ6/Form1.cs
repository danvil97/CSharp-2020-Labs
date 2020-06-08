using System;
using System.Windows.Forms;

namespace PZ6
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string perfOperation = "";
        private bool isPerfOperation = false;

        public Form1()
        {
            InitializeComponent(); KeyPreview = true;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if (labelDisplay.Text == "0" ||  (isPerfOperation))
                labelDisplay.Text = "";

            isPerfOperation = false;
            Button B = (Button)sender;
            if (B.Text == ".")
            {
                if (!labelDisplay.Text.Contains(","))
                        labelDisplay.Text += ",";
            }
            else
            labelDisplay.Text += B.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = "0";
            result = 0;
            string perfOperation = "";
            bool isPerfOperation = false;
    }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (perfOperation)
            {
                case "+":
                    labelDisplay.Text = (result + Double.Parse(labelDisplay.Text)).ToString();
                    break;
                case "-":
                    labelDisplay.Text = (result - Double.Parse(labelDisplay.Text)).ToString();
                    break;
                case "/":
                    labelDisplay.Text = (result / Double.Parse(labelDisplay.Text)).ToString(); 
                    break;
                case "*":
                    labelDisplay.Text = (result * Double.Parse(labelDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(labelDisplay.Text);
            Clipboard.SetText(labelDisplay.Text);
        }

        private void buttonOperation(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (result != 0)
            {
                buttonEqual.PerformClick();
                perfOperation = B.Text;
                isPerfOperation = true;
            }
            else { 
            perfOperation = B.Text;
            result = Double.Parse(labelDisplay.Text);
            isPerfOperation = true;
            }
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            switch (e.KeyChar)
            {
                case '1':
                    buttonOne.PerformClick();
                    break;
                case '2':
                    buttonTwo.PerformClick();
                    break;
                case '3':
                    buttonThree.PerformClick();
                    break;
                case '4':
                    buttonFour.PerformClick();
                    break;
                case '5':
                    buttonFive.PerformClick();
                    break;
                case '6':
                    buttonSix.PerformClick();
                    break;
                case '7':
                    buttonSeven.PerformClick();
                    break;
                case '8':
                    buttonEight.PerformClick();
                    break;
                case '9':
                    buttonNine.PerformClick();
                    break;
                case '0':
                    buttonZero.PerformClick();
                    break;
                case '.':
                    buttonDot.PerformClick();
                    break;
                case '+':
                    buttonPlus.PerformClick();
                    break;
                case '-':
                    buttonMinus.PerformClick();
                    break;
                case '*':
                    buttonMultiply.PerformClick();
                    break;
                case '/':
                    buttonDivide.PerformClick();
                    break;                               
                case '=':
                    buttonEqual.PerformClick();
                    break;
                case (char)Keys.Enter:
                    buttonEqual.PerformClick();
                    break;
                case (char)Keys.Back:
                    buttonClear.PerformClick();
                    break;               
                default:
                    break;
            }
        }
    }
}