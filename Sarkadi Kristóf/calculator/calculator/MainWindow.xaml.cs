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

namespace calculator
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

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            lblkijelzo.Content += "";
            userInput += "7";
            lblkijelzo.Content = userInput;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            lblkijelzo.Content += "";
            userInput += "8";
            lblkijelzo.Content = userInput;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            lblkijelzo.Content += "";
            userInput += "9";
            lblkijelzo.Content = userInput;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            lblkijelzo.Content += "";
            userInput += "6";
            lblkijelzo.Content = userInput;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            lblkijelzo.Content += "";
            userInput += "5";
            lblkijelzo.Content = userInput;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            lblkijelzo.Content += "";
            userInput += "4";
            lblkijelzo.Content = userInput;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            lblkijelzo.Content += "";
            userInput += "1";
            lblkijelzo.Content = userInput;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            lblkijelzo.Content += "";
            userInput += "2";
            lblkijelzo.Content = userInput;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            lblkijelzo.Content += "";
            userInput += "3";
            lblkijelzo.Content = userInput;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            lblkijelzo.Content += "";
            userInput += "0";
            lblkijelzo.Content = userInput;
        }

        private void btnDivided_Click(object sender, RoutedEventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void btnPlusz_Click(object sender, RoutedEventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void btnMultiplied_Click(object sender, RoutedEventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void btnPoint_Click(object sender, RoutedEventArgs e)
        {
            lblkijelzo.Content += "";
            userInput += ".";
            lblkijelzo.Content += userInput;
        }

        private void btnequal_Click(object sender, RoutedEventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);
            if (function == '+')
            {
                result = firstNum + secondNum;
                lblkijelzo.Content = result;
            }
            else if (function == '-')
            {
                result = firstNum - secondNum;
                lblkijelzo.Content = result;
            }
            else if (function == '*')
            {
                result = firstNum * secondNum;
                lblkijelzo.Content = result;
            }
            else if (function == '/')
            {
                if (secondNum == 0)
                {
                    lblkijelzo.Content = "Nullával nem lehet osztani";
                }
                else
                {

                }
            }
        }

        private void btnPersent_Click(object sender, RoutedEventArgs e)
        {
            function = '%';
            double firstNum;
            first = userInput;
            firstNum = Convert.ToDouble(first);
            userInput = Convert.ToString(firstNum / 100);
            lblkijelzo.Content = userInput;
        }

        private void btndel_Click(object sender, RoutedEventArgs e)
        {
            function = '0';
            first = userInput;
            userInput = "";
            if (Convert.ToString(lblkijelzo.Content).Length > 1)
            {
                lblkijelzo.Content = Convert.ToString(lblkijelzo.Content).Substring(0, Convert.ToString(lblkijelzo.Content).Length - 1);
            }
        }

        private void btnAC_Click(object sender, RoutedEventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            lblkijelzo.Content = "0";
        }

        private void btnElojel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
