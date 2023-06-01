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

namespace caclulator
{
    public partial class MainWindow : Window
    {
        string numb1 = "";
        string numb2 = "";
        char operation;
        double result = 0.0;
        string userInput = "";
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void percent_Click(object sender, RoutedEventArgs e)
        {
            operation = '%';
            numb1 = userInput;
            userInput = "";
        }

        private void nulla_Click(object sender, RoutedEventArgs e)
        {
            lblbox.Content += "";
            userInput += "0";
            lblbox.Content = userInput;
        }

        private void num1_Click(object sender, RoutedEventArgs e)
        {
            lblbox.Content += "";
            userInput += "1";
            lblbox.Content = userInput;
        }

        private void num2_Click(object sender, RoutedEventArgs e)
        {
            lblbox.Content += "";
            userInput += "2";
            lblbox.Content = userInput;
        }

        private void num3_Click(object sender, RoutedEventArgs e)
        {
            lblbox.Content += "";
            userInput += "3";
            lblbox.Content = userInput;
        }

        private void num4_Click(object sender, RoutedEventArgs e)
        {
            lblbox.Content += "";
            userInput += "4";
            lblbox.Content = userInput;
        }

        private void num5_Click(object sender, RoutedEventArgs e)
        {
            lblbox.Content += "";
            userInput += "5";
            lblbox.Content = userInput;
        }

        private void num6_Click(object sender, RoutedEventArgs e)
        {
            lblbox.Content += "";
            userInput += "6";
            lblbox.Content = userInput;
        }

        private void num7_Click(object sender, RoutedEventArgs e)
        {
            lblbox.Content += "";
            userInput += "7";
            lblbox.Content = userInput;
        }

        private void num8_Click(object sender, RoutedEventArgs e)
        {
            lblbox.Content += "";
            userInput += "8";
            lblbox.Content = userInput;
        }

        private void num9_Click(object sender, RoutedEventArgs e)
        {
            lblbox.Content += "";
            userInput += "9";
            lblbox.Content = userInput;
        }

        private void multip_Click(object sender, RoutedEventArgs e)
        {
            operation = '*';
            numb1 = userInput;
            lblbox.Content = userInput;
            userInput = "";
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            operation = '-';
            numb1 = userInput;
            lblbox.Content = userInput;
            userInput = "";
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            operation = '+';
            numb1 = userInput;
            lblbox.Content = userInput;
            userInput = "";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            lblbox.Content = "";
            userInput = "";
            numb1 = "";
        }

        private void period_Click(object sender, RoutedEventArgs e)
        {
            lblbox.Content = "";
            userInput += ",";
            lblbox.Content = userInput;
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            operation = '/';
            numb1 = userInput;
            lblbox.Content = userInput;
            userInput = "";
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            numb2 = userInput;
            double input1 = Convert.ToDouble(numb1);
            double input2 = Convert.ToDouble(numb2);

            switch (operation)
            {
                case '-':
                    result = input1 - input2;
                    break;
                case '+':
                    result = input1 + input2;
                    break;
                case '/':
                    result = input1 / input2;
                    break;
                case '*':
                    result = input1 * input2;
                    break;
            }
            lblbox.Content = result;
            
            
        }
    }
}
