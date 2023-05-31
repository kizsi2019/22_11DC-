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
            first = userInput;
            userInput = "";
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            LblBox.Content += "";
            userInput += "0";
            LblBox.Content = userInput;
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            LblBox.Content += "";
            userInput += "1";
            LblBox.Content = userInput;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            LblBox.Content += "";
            userInput += "2";
            LblBox.Content = userInput;
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            LblBox.Content += "";
            userInput += "3";
            LblBox.Content = userInput;
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            LblBox.Content += "";
            userInput += "4";
            LblBox.Content = userInput;
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            LblBox.Content += "";
            userInput += "5";
            LblBox.Content = userInput;
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            LblBox.Content += "";
            userInput += "6";
            LblBox.Content = userInput;
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            LblBox.Content += "";
            userInput += "7";
            LblBox.Content = userInput;
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            LblBox.Content += "";
            userInput += "8";
            LblBox.Content = userInput;
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            LblBox.Content += "";
            userInput += "9";
            LblBox.Content = userInput;
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
            LblBox.Content += "";
            userInput += ",";
            LblBox.Content = userInput;
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
                LblBox.Content = result;
            }
            else if (function == '-')
            {
                result = firstNum - secondNum;
                LblBox.Content = result;
            }
            else if (function == '*')
            {
                result = firstNum * secondNum;
                LblBox.Content = result;
            }
            else if (function == '/')
            {
                if (secondNum == 0)
                {
                    LblBox.Content = "Nullával nem lehet osztani";
                }
                else
                {
                    result = firstNum / secondNum;
                    LblBox.Content = result;
                }
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            function = 'B';
            first = userInput;
            userInput = "";
            if (Convert.ToString(LblBox.Content).Length > 1)
            {
                LblBox.Content = Convert.ToString(LblBox.Content).Substring(0, Convert.ToString(LblBox.Content).Length - 1);
            }
        }

        private void BtnPm_Click(object sender, RoutedEventArgs e)
        {
            first = userInput;
            double firstNum;
            firstNum = Convert.ToDouble(first);

            result = firstNum * (-1);

            LblBox.Content = result;
            first = Convert.ToString(result);
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            LblBox.Content = "0";
        }
    }
}
