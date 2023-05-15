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

namespace Szamologep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnPercent_Click(object sender, RoutedEventArgs e)
        {
            function = '%';
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            TBox.Text += "";
            userInput += "0";
            TBox.Text = userInput;
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            TBox.Text += "";
            userInput += "1";
            TBox.Text = userInput;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            TBox.Text += "";
            userInput += "2";
            TBox.Text = userInput;
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            TBox.Text += "";
            userInput += "3";
            TBox.Text = userInput;
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            TBox.Text += "";
            userInput += "4";
            TBox.Text = userInput;
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            TBox.Text += "";
            userInput += "5";
            TBox.Text = userInput;
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            TBox.Text += "";
            userInput += "6";
            TBox.Text = userInput;
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            TBox.Text += "";
            userInput += "7";
            TBox.Text = userInput;
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            TBox.Text += "";
            userInput += "8";
            TBox.Text = userInput;
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            TBox.Text += "";
            userInput += "9";
            TBox.Text = userInput;
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void BtnX_Click(object sender, RoutedEventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void BtnSlash_Click(object sender, RoutedEventArgs e)
        {
            TBox.Text += "";
            userInput += ",";
            TBox.Text = userInput;
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            if (function == '+')
            {
                result = firstNum + secondNum;
                TBox.Text = result;
            }
            else if (function == '-')
            {
                result = firstNum - secondNum;
                TBox.Text = result;
            }
            else if (function == '*')
            {
                result = firstNum * secondNum;
                TBox.Text = result;
            }
            else if (function == '/')
            {
                if (secondNum == 0)
                {
                    TBox.Text = "Nullával nem lehet osztani";
                }
                else
                {
                    result = firstNum / secondNum;
                    TBox.Text = result;
                }
            }
        }
    }
}
