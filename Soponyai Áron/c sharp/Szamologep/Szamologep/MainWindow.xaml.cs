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
        private void Kijelzo(object sender, TextChangedEventArgs e)
        {

        }
        private void zero_Click(object sender, RoutedEventArgs e)
        {
            kijelzo.Text += "";
            userInput += "0";
            kijelzo.Text = userInput;
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            kijelzo.Text += "";
            userInput += "1";
            kijelzo.Text = userInput;
        }

        private void Two_Click_1(object sender, RoutedEventArgs e)
        {
            kijelzo.Text += "";
            userInput += "2";
            kijelzo.Text = userInput;
        }

        private void Three_Click_1(object sender, RoutedEventArgs e)
        {
            kijelzo.Text += "";
            userInput += "3";
            kijelzo.Text = userInput;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            kijelzo.Text += "";
            userInput += "4";
            kijelzo.Text = userInput;
        }

        private void Five_Click_1(object sender, RoutedEventArgs e)
        {
            kijelzo.Text += "";
            userInput += "5";
            kijelzo.Text = userInput;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            kijelzo.Text += "";
            userInput += "6";
            kijelzo.Text = userInput;
        }

        private void Seven_Click_1(object sender, RoutedEventArgs e)
        {
            kijelzo.Text += "";
            userInput += "7";
            kijelzo.Text = userInput;
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            kijelzo.Text += "";
            userInput += "8";
            kijelzo.Text = userInput;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            kijelzo.Text += "";
            userInput += "9";
            kijelzo.Text = userInput;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void Fraction_Click(object sender, RoutedEventArgs e)
        {
            kijelzo.Text += "";
            userInput += ",";
            kijelzo.Text = userInput;
        }

        // Nincs kész VVVVVVVVV //
        private void Plusminus_Click(object sender, RoutedEventArgs e)
        {
            kijelzo.Text += "";
            userInput += ",";
            kijelzo.Text = userInput;
        }

        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            function = '%';
            first = userInput;
            userInput = "";
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            first = null;
            second = null;
            userInput = null;
            kijelzo.Text = "0";
        }

        // Nincs kész VVVVVVVVV // 
        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (kijelzo.Text.Length > 1)
            {
                kijelzo.Text = kijelzo.Text.Length - 1;
            }
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            first = userInput;
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            if (function == '+')
            {
                result = firstNum + secondNum;
                kijelzo.Text = Convert.ToString(result);
            }
            else if (function == '-')
            {
                result = firstNum - secondNum;
                kijelzo.Text = Convert.ToString(result);
            }
            else if (function == '*')
            {
                result = firstNum * secondNum;
                kijelzo.Text = Convert.ToString(result);
            }
            else if (function == '/')
            {
                if (secondNum == 0)
                {
                    kijelzo.Text = "Nullával nem lehet osztani";
                }
                else
                {
                    result = firstNum / secondNum;
                    kijelzo.Text = Convert.ToString(result);
                }
            }
        }
    }
}
