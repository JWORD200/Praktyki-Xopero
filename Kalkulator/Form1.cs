using System.Drawing.Text;
using System.Globalization;
using System.IO.Pipes;
using System.Numerics;
using System.Security.Cryptography;
using System.Transactions;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number, answer, memoryAnswer, memory, numberPrecent;
        int operation, clickOn = 0, clickMemory = 0;
        Boolean isOn = false;

        private void add(string a)
        {
            if (isOn)
            {
                if (numberInput.Text == "0" && numberInput.Text != null)
                {
                    numberInput.Text = a;
                }
                else
                {
                    numberInput.Text = numberInput.Text + a;
                }
            }
        }

        private void addDot()
        {
            if (isOn)
            {
                int c = numberInput.TextLength;
                int b = 0;
                string text = numberInput.Text;
                for (int i = 0; i < c; i++)
                {
                    if (text[i].ToString() == ",")
                    {
                        b = 1; 
                        break;
                    }
                    else
                    {
                        b = 0;
                    }
                }
                if (b == 0)
                {
                    
                    numberInput.Text = numberInput.Text + ",";
                }
            }
        }

        private void clear()
        {
            if (isOn)
            {
                numberInput.Clear();
                numberInput.Text = "0";
                operation = 0;
            }
        }

        private void On()
        {
            if (clickOn == 0 || isOn == false)
            {
                numberInput.Enabled = true;
                numberInput.ReadOnly = true;
                errorHandler(false);
                clickOn++;
            }
            else if (clickOn > 0)
            {
                clear();
            }
        }

        private void operations(string arg)
        {
            if (isOn)
            {
                switch (arg)
                {
                    case "+":
                        number = double.Parse(numberInput.Text);
                        numberInput.Clear();
                        numberInput.Focus();
                        numberInput.Text = "0";
                        operation = 1;
                        break;
                    case "-":
                        if (numberInput.Text != "")
                        {
                            number = double.Parse(numberInput.Text);
                            numberInput.Clear();
                            numberInput.Focus();
                            numberInput.Text = "0";
                            operation = 2;
                        }
                        break;
                    case "*":
                        number = double.Parse(numberInput.Text);
                        numberInput.Clear();
                        numberInput.Focus();
                        numberInput.Text = "0";
                        operation = 4;
                        break;
                    case "/":
                        number = double.Parse(numberInput.Text);
                        numberPrecent = double.Parse(numberInput.Text);
                        numberInput.Clear();
                        numberInput.Focus();
                        numberInput.Text = "0";
                        operation = 3;
                        break;
                    case "%":
                        if (operation == 3)
                        { 
                            operation = 6;
                            finish(operation);
                        }
                        else
                        {
                            numberInput.Text = "0";
                        }
                        break;
                    case "sqrt":
                        number = double.Parse(numberInput.Text);
                        answer = Math.Sqrt(number);
                        numberInput.Clear();
                        numberInput.Focus();
                        if (double.IsNaN(answer))
                        {
                            errorHandler(true);
                        }
                        else
                        {
                            numberInput.Text = answer.ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void finish(int operation)
        {
            switch (operation)
            {
                case 2:
                    answer = number - double.Parse(numberInput.Text);
                    numberInput.Text = answer.ToString();
                    break;
                case 1:
                    answer = number + double.Parse(numberInput.Text);
                    numberInput.Text = answer.ToString();
                    break;
                case 3:
                    answer = number / double.Parse(numberInput.Text);
                    numberInput.Text = answer.ToString();
                    break;
                case 4:
                    answer = number * double.Parse(numberInput.Text);
                    numberInput.Text = answer.ToString();
                    break;
                case 6:
                    if (numberPrecent == 0) 
                    {
                        numberInput.Text = "0";
                    }
                    else
                    {
                        answer = numberPrecent / double.Parse(numberInput.Text);
                        answer = answer * 100;
                        numberInput.Text = answer.ToString();
                    }
                    break;
                default:
                    break;
            }
        }

        private void errorHandler(Boolean error) {
            if (error)
            {
                numberInput.Text = "0";
                isOn = false;
                labelError.Visible = true;
            }
            else if (!error)
            {
                numberInput.Text = "0";
                isOn = true;
                labelError.Visible = false;
            }

        }

        private void setType()
        {
            if (numberInput.Text != "0")
            {
                number = double.Parse(numberInput.Text);
                number = number * -1;
                string a = number.ToString();
                numberInput.Text = a;
            }
        }

        private void putInMemory()
        {
            if (isOn)
            {
                if (clickMemory == 0)
                {
                    memory = double.Parse(numberInput.Text);
                    numberInput.Text = "0";
                    clickMemory++;
                }
                else
                {
                    memory = 0;
                    clickMemory--;
                }
            }
        }

        private void memorySum()
        {
            if (isOn)
            {
                memoryAnswer = memory + double.Parse(numberInput.Text);
                numberInput.Text = memoryAnswer.ToString();
            }
        }

        private void memoryMinus()
        {
            if (isOn)
            {
                memoryAnswer = double.Parse(numberInput.Text) - memory;
                numberInput.Text = memoryAnswer.ToString();
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {

            add("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add("3");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            add("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            add("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            add("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            add("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            add("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            add("9");
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            addDot();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            operations("+");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operations("-");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operations("/");
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            operations("*");
        }

        private void buttonEl_Click(object sender, EventArgs e)
        {
            operations("sqrt");
        }

        private void buttonPrecent_Click(object sender, EventArgs e)
        {
            operations("%");
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            finish(operation);
        }

        private void buttonChangeType_Click(object sender, EventArgs e)
        {
            setType();
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            On();
        }

        private void buttonMemory_Click(object sender, EventArgs e)
        {
            putInMemory();
        }

        private void buttonMemorySum_Click(object sender, EventArgs e)
        {
            memorySum();
        }

        private void buttonMemoryMinus_Click(object sender, EventArgs e)
        {
            memoryMinus();
        }
    }
}