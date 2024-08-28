using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BasicCalculatorFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        bool firstInput = false;
        bool secondInput = false;
        bool startInput = false;
        double num1; // Changed from int to double
        double num2; // Changed from int to double
        string operation = "";
        double result; // Changed from int to double

        private void clearInput()
        {
            textDisplay.Text = "";
        }

        private void textDisplay_TextChanged(object sender, EventArgs e) { }

        private void numberEight_Click(object sender, EventArgs e)
        {
            if (startInput)
            {
                clearInput();
                startInput = !startInput;
            }
            textDisplay.Text += numberEight.Text;
        }

        private void numberSeven_Click(object sender, EventArgs e)
        {
            if (startInput)
            {
                clearInput();
                startInput = !startInput;
            }
            textDisplay.Text += numberSeven.Text;
        }

        private void numberNine_Click(object sender, EventArgs e)
        {
            if (startInput)
            {
                clearInput();
                startInput = !startInput;
            }
            textDisplay.Text += numberNine.Text;
        }

        private void numberFour_Click(object sender, EventArgs e)
        {
            if (startInput)
            {
                clearInput();
                startInput = !startInput;
            }
            textDisplay.Text += numberFour.Text;
        }

        private void numberFive_Click(object sender, EventArgs e)
        {
            if (startInput)
            {
                clearInput();
                startInput = !startInput;
            }
            textDisplay.Text += numberFive.Text;
        }

        private void numberSix_Click(object sender, EventArgs e)
        {
            if (startInput)
            {
                clearInput();
                startInput = !startInput;
            }
            textDisplay.Text += numberSix.Text;
        }

        private void numberOne_Click(object sender, EventArgs e)
        {
            if (startInput)
            {
                clearInput();
                startInput = !startInput;
            }
            textDisplay.Text += numberOne.Text;
        }

        private void numberTwo_Click(object sender, EventArgs e)
        {
            if (startInput)
            {
                clearInput();
                startInput = !startInput;
            }
            textDisplay.Text += numberTwo.Text;
        }

        private void numberThree_Click(object sender, EventArgs e)
        {
            if (startInput)
            {
                clearInput();
                startInput = !startInput;
            }
            textDisplay.Text += numberThree.Text;
        }

        private void numberZero_Click(object sender, EventArgs e)
        {
            if (startInput)
            {
                clearInput();
                startInput = !startInput;
            }
            textDisplay.Text += numberZero.Text;
        }

        private void decimalPoint_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textDisplay.Text) && textDisplay.Text.IndexOf(".") == -1)
            {
                textDisplay.Text += decimalPoint.Text;
            }
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                secondInput = double.TryParse(textDisplay.Text, out num2);
                if (secondInput)
                {
                    switch (operation)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            if (num2 != 0) // Check for division by zero
                            {
                                result = num1 / num2;
                            }
                            else
                            {
                                textDisplay.Text = "Error";
                                return; // Exit early on division by zero
                            }
                            break;
                    }

                    // Display result dynamically with precision up to 10 decimal places
                    textDisplay.Text = $"{result:0.##########}";
                }

                num1 = 0;
                num2 = 0;
                firstInput = false;
                secondInput = false;
                operation = "";
                startInput = true;
            }
        }


        private void plusButton_Click(object sender, EventArgs e)
        {
            firstInput = double.TryParse(textDisplay.Text, out num1); // Changed from int to double
            if (firstInput)
            {
                operation = plusButton.Text;
                textDisplay.Text = "";
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            firstInput = double.TryParse(textDisplay.Text, out num1); // Changed from int to double
            if (firstInput)
            {
                operation = minusButton.Text;
                textDisplay.Text = "";
            }
        }

        private void timesButton_Click(object sender, EventArgs e)
        {
            firstInput = double.TryParse(textDisplay.Text, out num1); // Changed from int to double
            if (firstInput)
            {
                operation = timesButton.Text;
                textDisplay.Text = "";
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            firstInput = double.TryParse(textDisplay.Text, out num1); // Changed from int to double
            if (firstInput)
            {
                operation = divideButton.Text;
                textDisplay.Text = "";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "";
            firstInput = false;
            secondInput = false;
            startInput = false;
            num1 = 0;
            num2 = 0;
            operation = "";
        }
    }
}
