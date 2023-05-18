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

        private void szazalekBtn_Click(object sender, RoutedEventArgs e)
        {
            function = '%';
            first = userInput;
            userInput = "";
        }

        private void CBtn_Click(object sender, RoutedEventArgs e)
        {
            
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            kijelzoLbl.Content = "0";

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            function = 'B';
            first = userInput;
            userInput = "";
        }

        private void osztasBtn_Click(object sender, RoutedEventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void hetBtn_Click(object sender, RoutedEventArgs e)
        {
            kijelzoLbl.Content += "";
            userInput += "7";
            kijelzoLbl.Content = userInput;
        }

        private void nyolcBtn_Click(object sender, RoutedEventArgs e)
        {
            kijelzoLbl.Content += "";
            userInput += "8";
            kijelzoLbl.Content = userInput;
        }

        private void kilencBtn_Click(object sender, RoutedEventArgs e)
        {
            kijelzoLbl.Content += "";
            userInput += "9";
            kijelzoLbl.Content = userInput;
        }

        private void szorzasBtn_Click(object sender, RoutedEventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void negyBtn_Click(object sender, RoutedEventArgs e)
        {
            kijelzoLbl.Content += "";
            userInput += "4";
            kijelzoLbl.Content = userInput;
        }

        private void otBtn_Click(object sender, RoutedEventArgs e)
        {
            kijelzoLbl.Content += "";
            userInput += "5";
            kijelzoLbl.Content = userInput;
        }

        private void hatBtn_Click(object sender, RoutedEventArgs e)
        {
            kijelzoLbl.Content += "";
            userInput += "6";
            kijelzoLbl.Content = userInput;
        }

        private void kivonasBtn_Click(object sender, RoutedEventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void egyBtn_Click(object sender, RoutedEventArgs e)
        {
            kijelzoLbl.Content += "";
            userInput += "1";
            kijelzoLbl.Content = userInput;
        }

        private void kettoBtn_Click(object sender, RoutedEventArgs e)
        {
            kijelzoLbl.Content += "";
            userInput += "2";
            kijelzoLbl.Content = userInput;
        }

        private void haromBtn_Click(object sender, RoutedEventArgs e)
        {
            kijelzoLbl.Content += "";
            userInput += "3";
            kijelzoLbl.Content = userInput;
        }

        private void pluszBtn_Click(object sender, RoutedEventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void elojelBtn_Click(object sender, RoutedEventArgs e)
        {

            first = userInput;
            double firstNum;
            firstNum = Convert.ToDouble(first);

            result = firstNum * (-1);
            
            kijelzoLbl.Content = result;
            first = Convert.ToString(first);
        }

        private void nullaBtn_Click(object sender, RoutedEventArgs e)
        {
            kijelzoLbl.Content += "";
            userInput += "0";
            kijelzoLbl.Content = userInput;
        }

        private void tizedesBtn_Click(object sender, RoutedEventArgs e)
        {
            kijelzoLbl.Content += "";
            userInput += ".";
            kijelzoLbl.Content += userInput;
        }

        private void egyenloBtn_Click(object sender, RoutedEventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            if (function == '+')
            {
                result = firstNum + secondNum;
                kijelzoLbl.Content = result;
            }
            else if (function == '-')
            {
                result = firstNum - secondNum;
                kijelzoLbl.Content = result;
            }
            else if (function == '*')
            {
                result = firstNum * secondNum;
                kijelzoLbl.Content = result;
            }
            else if (function == '/')
            {
                if (secondNum == 0)
                {
                    kijelzoLbl.Content = "Nullával nem lehet osztani";
                }
                else
                {
                    result = firstNum / secondNum;
                    kijelzoLbl.Content = result;
                }
                
            }
        }
    }
}
