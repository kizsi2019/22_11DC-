using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

namespace szamologep
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

        private void egybtn_Click(object sender, RoutedEventArgs e)
        {
            outlbl.Content += "";
            userInput += "1";
            outlbl.Content = userInput;
        }

        private void kettobtn_Click(object sender, RoutedEventArgs e)
        {
            outlbl.Content += "";
            userInput += "2";
            outlbl.Content = userInput;
        }

        private void harombtn_Click(object sender, RoutedEventArgs e)
        {
            outlbl.Content += "";
            userInput += "3";
            outlbl.Content = userInput;
        }

        private void szorzasbtn_Click(object sender, RoutedEventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void negybtn_Click(object sender, RoutedEventArgs e)
        {
            outlbl.Content += "";
            userInput += "4";
            outlbl.Content = userInput;
        }

        private void otbtn_Click(object sender, RoutedEventArgs e)
        {
            outlbl.Content += "";
            userInput += "5";
            outlbl.Content = userInput;
        }

        private void hatbtn_Click(object sender, RoutedEventArgs e)
        {
            outlbl.Content += "";
            userInput += "6";
            outlbl.Content = userInput;
        }

        private void minuszbtn_Click(object sender, RoutedEventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void hetbtn_Click(object sender, RoutedEventArgs e)
        {
            outlbl.Content += "";
            userInput += "7";
            outlbl.Content = userInput;
        }

        private void nyolcbtn_Click(object sender, RoutedEventArgs e)
        {
            outlbl.Content += "";
            userInput += "8";
            outlbl.Content = userInput;
        }

        private void kilencbtn_Click(object sender, RoutedEventArgs e)
        {
            outlbl.Content += "";
            userInput += "9";
            outlbl.Content = userInput;
        }

        private void pluszbtn_Click(object sender, RoutedEventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void nullabtn_Click(object sender, RoutedEventArgs e)
        {
            outlbl.Content += "";
            userInput += "0";
            outlbl.Content = userInput;
        }

        private void vesszobtn_Click(object sender, RoutedEventArgs e)
        {
            outlbl.Content += "";
            userInput += ",";
            outlbl.Content = userInput;
        }

        private void egyenlobtn_Click(object sender, RoutedEventArgs e)
        {
            second = userInput;
            double firstNUM, secondNUM;
            firstNUM = Convert.ToDouble(first);
            secondNUM = Convert.ToDouble(second);

            if (function == '+')
            {
                result = firstNUM + secondNUM;
                outlbl.Content = result;
            }
            else if (function == '-')
            {
                result = firstNUM - secondNUM;
                outlbl.Content = result;
            }
            else if (function == '*')
            {
                result = firstNUM * secondNUM;
                outlbl.Content = result;
            }

            else if (function == '/')
            {
                if (secondNUM == 0)
                {
                    outlbl.Content = "Nullával nem lehet osztani";
                }
                else
                {
                    result = firstNUM / secondNUM;
                    outlbl.Content = result;
                }
            }
        }

        private void osztasbtn_Click(object sender, RoutedEventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void bsbtn_Click(object sender, RoutedEventArgs e)
        {
            function = 'B';
            first = userInput;
            userInput = "";
            if (Convert.ToString(outlbl.Content).Length > 1)
            {
                outlbl.Content = Convert.ToString(outlbl.Content).Substring(0, Convert.ToString(outlbl.Content).Length - 1);
            }
            else
            {
                outlbl.Content = "0";
            }
        }

        private void clearbtn_Click(object sender, RoutedEventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            outlbl.Content = "0";
        }

        private void szazalekbtn_Click(object sender, RoutedEventArgs e)
        {
            function = '%';
            double firstNUM;
            first = userInput;
            firstNUM = Convert.ToDouble(first);
            userInput = Convert.ToString(firstNUM / 100);
            outlbl.Content = userInput;
        }

        private void outlbl_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}