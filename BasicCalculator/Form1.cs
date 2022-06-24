using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrivitiveDataBase;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        ICalculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddText_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case nameof(buttonMin): outputTextBox.Text += "Min("; break;
                case nameof(buttonMax): outputTextBox.Text += "Max("; break;
                case nameof(buttonAdd): outputTextBox.Text += "+"; break;
                case nameof(buttonSubstr): outputTextBox.Text += "-"; break;
                case nameof(buttonMulty): outputTextBox.Text += "*"; break;
                case nameof(buttonDiv): outputTextBox.Text += "/"; break;
                case nameof(buttonPow): outputTextBox.Text += "^"; break;
                case nameof(buttonCos): outputTextBox.Text += "Cos("; break;
                case nameof(buttonSin): outputTextBox.Text += "Sin("; break;
                case nameof(buttonFactorial): outputTextBox.Text += "Sin("; break;
                case nameof(buttonComma): outputTextBox.Text += ","; break;

                case nameof(buttonZero):    outputTextBox.Text += "0"; break;
                case nameof(buttonOne):     outputTextBox.Text += "1"; break;
                case nameof(buttonTwo):     outputTextBox.Text += "2"; break;
                case nameof(buttonThree):   outputTextBox.Text += "3"; break;
                case nameof(buttonFour):    outputTextBox.Text += "4"; break;
                case nameof(buttonFive):    outputTextBox.Text += "5"; break;
                case nameof(buttonSix):     outputTextBox.Text += "6"; break;
                case nameof(buttonSeven):   outputTextBox.Text += "7"; break;
                case nameof(buttonEight):   outputTextBox.Text += "8"; break;
                case nameof(buttonNine):    outputTextBox.Text += "9"; break;
                case nameof(buttonPoint):   outputTextBox.Text += "."; break;

                case nameof(buttonOpenSquareBracket): outputTextBox.Text += "["; break;
                case nameof(buttonCloseSquareBracket): outputTextBox.Text += "]"; break;

                case nameof(buttonOpenBracket): outputTextBox.Text += "("; break;
                case nameof(buttonCloseBracket): outputTextBox.Text += ")"; break;

                case nameof(buttonBackspace): outputTextBox.Text = outputTextBox.Text.Remove(outputTextBox.Text.Length - 1); break;
                case nameof(buttonC): outputTextBox.Text = ""; break;
                default: MessageBox.Show("Unexpected button. This button currently doesn't work"); break;
            }
            
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string expresion = outputTextBox.Text.ToString();

            outputTextBox.Text = calculator.Calculate(outputTextBox.Text);

            DBHelper.WriteExpression(expresion, outputTextBox.Text);
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            string[] history = DBHelper.ReadExpressions();

            string res = "";
            int i = 0;
            while (history.Length > i)
            {
                res += history[i] + " = " + history[i+1] + "\n";
                i += 2;
            }

            MessageBox.Show(res);
        }
    }
}
