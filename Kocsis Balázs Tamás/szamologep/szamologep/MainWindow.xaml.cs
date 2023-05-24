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
            outtb.Text += "";
            userInput += "1";
            outtb.Text = userInput;
        }

        private void kettobtn_Click(object sender, RoutedEventArgs e)
        {
            outtb.Text += "";
            userInput += "2";
            outtb.Text = userInput;
        }

        private void harombtn_Click(object sender, RoutedEventArgs e)
        {
            outtb.Text += "";
            userInput += "3";
            outtb.Text = userInput;
        }

        private void szorzasbtn_Click(object sender, RoutedEventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void negybtn_Click(object sender, RoutedEventArgs e)
        {
            outtb.Text += "";
            userInput += "4";
            outtb.Text = userInput;
        }

        private void otbtn_Click(object sender, RoutedEventArgs e)
        {
            outtb.Text += "";
            userInput += "5";
            outtb.Text = userInput;
        }

        private void hatbtn_Click(object sender, RoutedEventArgs e)
        {
            outtb.Text += "";
            userInput += "6";
            outtb.Text = userInput;
        }

        private void minuszbtn_Click(object sender, RoutedEventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void hetbtn_Click(object sender, RoutedEventArgs e)
        {
            outtb.Text += "";
            userInput += "7";
            outtb.Text = userInput;
        }

        private void nyolcbtn_Click(object sender, RoutedEventArgs e)
        {
            outtb.Text += "";
            userInput += "8";
            outtb.Text = userInput;
        }

        private void kilencbtn_Click(object sender, RoutedEventArgs e)
        {
            outtb.Text += "";
            userInput += "9";
            outtb.Text = userInput;
        }

        private void pluszbtn_Click(object sender, RoutedEventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void nullabtn_Click(object sender, RoutedEventArgs e)
        {
            outtb.Text += "";
            userInput += "0";
            outtb.Text = userInput;
        }

        private void vesszobtn_Click(object sender, RoutedEventArgs e)
        {
            outtb.Text += "";
            userInput += ",";
            outtb.Text = userInput;
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
                outtb.Text = result;
            }
            else if (function == '-')
            {
                result = firstNUM - secondNUM;
                outtb.Text = result;
            }
            else if (function == '*')
            {
                result = firstNUM * secondNUM;
                outtb.Text = result;
            }

            else if (function == '/')
            {
                if (secondNUM == 0)
                {
                    outtb.Text = "Nullával nem lehet osztani";
                }
                else
                {
                    result = firstNUM / secondNUM;
                    outtb.Text = result;
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
            if (Convert.ToString(outtb.Text).Length > 1)
            {
                outtb.Text = Convert.ToString(outtb.Text).Substring(0, Convert.ToString(outtb.Text).Length - 1);
            }
            else
            {
                outtb.Text = "0";
            }
        }

        private void clearbtn_Click(object sender, RoutedEventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            outtb.Text = "0";
        }

        private void szazalekbtn_Click(object sender, RoutedEventArgs e)
        {
            function = '%';
            double firstNUM;
            first = userInput;
            firstNUM = Convert.ToDouble(first);
            userInput = Convert.ToString(firstNUM / 100);
            outtb.Text = userInput;
        }

        private void outtb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
