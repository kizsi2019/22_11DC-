using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace szamolo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string? currentOperator;
        private double firstOperand;
        private bool isOperatorSelected;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string digit = (sender as Button).Content.ToString();

            if (isOperatorSelected)
            {
                resultBox.Text = digit;
                isOperatorSelected = false;
            }
            else
            {
                if (resultBox.Text == "0")
                {
                    resultBox.Text = digit;
                }
                else
                {
                    resultBox.Text += digit;
                }
            }
        }



        private void operatorButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(currentOperator))
            {
                return;
            }

            currentOperator = (sender as Button).Content.ToString();
            firstOperand = double.Parse(resultBox.Text);
            isOperatorSelected = true;
        }



        private void egyenlo_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(currentOperator))
            {
                return;
            }

            double secondOperand = double.Parse(resultBox.Text);

            switch (currentOperator)
            {
                case "+":
                    resultBox.Text = (firstOperand + secondOperand).ToString();
                    break;
                case "-":
                    resultBox.Text = (firstOperand - secondOperand).ToString();
                    break;
                case "*":
                    resultBox.Text = (firstOperand * secondOperand).ToString();
                    break;
                case "/":
                    resultBox.Text = (firstOperand / secondOperand).ToString();
                    break;
                case "%":
                    resultBox.Text = (firstOperand % secondOperand).ToString();
                    break;
            }

            currentOperator = null;
        }

        private void torles_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = "0";
            currentOperator = null;
            isOperatorSelected = false;
        }

        private void vissza_Click(object sender, RoutedEventArgs e)
        {
            if (resultBox.Text.Length > 1)
            {
                resultBox.Text = resultBox.Text.Substring(0, resultBox.Text.Length - 1);
            }
            else
            {
                resultBox.Text = "0";
            }
        }

        private void szazalekxd(object sender, RoutedEventArgs e)
        {
 
        }
    }
}

