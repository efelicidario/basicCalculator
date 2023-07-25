using System;
using System.Data;
using System.Windows.Forms;
namespace my_calc
{
    public partial class Form1 : Form
    {
        private string currentInput = "";
        private double currentResult = 0.0;
        private char lastOperator = ' ';
        //private bool isCalculationPending = false;
        private double pendingOperand = 0.0; // New variable to track pending operand
        private char pendingOperator = ' '; // New variable to track pending operator

        public Form1()
        {
            InitializeComponent();
            textBoxResult.Text = "0";
            // buttonEquals.Click += buttonEquals_Click;

        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            // Check if the result is zero and display a single "0" without multiple zeros.
            if (currentInput == "0")
            {
                textBoxResult.Text = currentInput;
            }
            else
            {
                Button button = (Button)sender;
                currentInput += button.Text;
                textBoxResult.Text = currentInput;
            }
            /*
            Button button = (Button)sender;
            currentInput += button.Text;
            textBoxResult.Text = currentInput;
            */
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
                        currentResult /= input;
                        break;
                    default:
                        currentResult = input;
                        break;
                }
            }
        }

        /*
        private void divisionByZero()
        {
            currentInput = "";
            lastOperator = ' ';
            isCalculationPending = false;
            textBoxResult.Text = "Error: Division by zero";
        }
        */

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            // Perform any pending calculation first
            Calculate();

            // Reset currentInput and pending values for potential new calculations
            currentInput = "";

            // Display the final result
            textBoxResult.Text = currentResult.ToString();
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            // Check if there is any input to clear
            if (!string.IsNullOrEmpty(currentInput))
            {
                // Remove the last character from the current input
                currentInput = currentInput.Remove(currentInput.Length - 1);

                // Update the output display
                textBoxResult.Text = currentInput;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            currentResult = 0.0;
            lastOperator = ' ';
            //isCalculationPending = false;
            pendingOperand = 0;
            pendingOperator = ' ';
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
    }
}