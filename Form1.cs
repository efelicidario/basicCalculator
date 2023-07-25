using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace my_calc
{
    public partial class Form1 : Form
    {
        private string currentInput = "";
        private double currentResult = 0.0;
        private char lastOperator = ' ';

        public Form1()
        {
            InitializeComponent();
            textBoxResult.Text = "0";
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            if (currentInput == "0") { textBoxResult.Text = currentInput; }
            else
            {
                Button button = (Button)sender;
                currentInput += button.Text;
                textBoxResult.Text = currentInput;
            }
        }

        private void buttonOp_Click(object sender, EventArgs e)
        {
            if (currentInput != "")
            {
                Calculate();
                Button opButton = (Button)sender;
                lastOperator = opButton.Text[0];
                currentInput = "";
            }
        }

        private void Calculate()
        {
            if (currentInput != "")
            {
                double input = double.Parse(currentInput);
                switch (lastOperator)
                {
                    case '+':
                        currentResult += input;
                        break;
                    case '-':
                        currentResult -= input;
                        break;
                    case '×':
                        currentResult *= input;
                        break;
                    case '÷':
                        if (input == 0)
                        {
                            MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            currentResult = 0.0;
                            textBoxResult.Text = "0";
                            break;
                        }
                        else
                        {
                            currentResult /= input;
                            break;
                        }
                    case '%':
                        currentResult %= input;
                        break;
                    default:
                        currentResult = input;
                        break;
                }
            }
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                currentInput += ".";
                textBoxResult.Text = currentInput;
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            Calculate();
            currentInput = "";
            textBoxResult.Text = currentResult.ToString();
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            if (currentInput != "")
            {
                currentInput = currentInput.Remove(currentInput.Length - 1);
                textBoxResult.Text = currentInput;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            currentResult = 0.0;
            lastOperator = ' ';
            textBoxResult.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}