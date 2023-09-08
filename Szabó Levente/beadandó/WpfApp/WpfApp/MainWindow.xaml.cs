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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Ferfi_Checked(object sender, RoutedEventArgs e)
        {
            if (Ferfi.IsChecked == true)
            {
                MessageBox.Show("Férfi nem.");
            }
            else if (No.IsChecked == true)
            {
                MessageBox.Show("Nő nem.");
            }
        }
        private void No_Checked(object sender, RoutedEventArgs e)
        {
            if (No.IsChecked == true)
            {
                MessageBox.Show("Nő nem.");
            }
            else if (Ferfi.IsChecked == true)
            {
                MessageBox.Show("Férfi nem.");
            }
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (tizen.IsChecked == true)
            {
                MessageBox.Show("Iskolás időszak");
            }
            else if (kozott.IsChecked == true)
            {
                MessageBox.Show("Dolgozás.");
            }
            else if (nagyobb.IsChecked == true)
            {
                MessageBox.Show("Nyugdíj");
            }
        }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (tizen.IsChecked == true)
            {
                MessageBox.Show("Iskolás időszak");
            }
            else if (kozott.IsChecked == true)
            {
                MessageBox.Show("Dolgozás.");
            }
            else if (nagyobb.IsChecked == true)
            {
                MessageBox.Show("Nyugdíj");
            }
        }
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            if (tizen.IsChecked == true)
            {
                MessageBox.Show("Iskolás időszak");
            }
            else if (kozott.IsChecked == true)
            {
                MessageBox.Show("Dolgozás.");
            }
            else if (nagyobb.IsChecked == true)
            {
                MessageBox.Show("Nyugdíj");
            }
        }
        private void A_Click(object sender, RoutedEventArgs e)
        {
            ide.Text = ide.Text + 1;
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            ide.Text = ide.Text + 2;
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            ide.Text = ide.Text + 3;
        }

        private void space_Click(object sender, RoutedEventArgs e)
        {
            ide.Text = ide.Text + " ";
        }
    }
}