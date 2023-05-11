using System;
using System.IO;
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

namespace karacsonyGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int keszlet = 0;
        public static int nap = 0, kesz = 0, eladott = 0, ossz = 0;

        private void kimenet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnHozzaad_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(kesztext.Text) < 0 || int.Parse(eladotttext.Text) < 0)
            {
                hiba.Content = "Negatív számot enm adhat meg!";
                return;
            }
            if (keszlet + int.Parse(kesztext.Text) < int.Parse(eladotttext.Text))
            {

            }
            keszlet += int.Parse(kesztext.Text);
            keszlet -= int.Parse(eladotttext.Text);
            string sor = string.Format("{0}.nap\t+{1}\t=\t{3}", cbnap.SelectedItem.ToString(), kesztext.Text, eladotttext.Text, keszlet);

            listbox.Items.Add(sor);
            eladotttext.Text = "0";
            kesztext.Text = "0";
            cbnap.SelectedIndex = -1;
        }

        public MainWindow()
        {
            InitializeComponent();
            for (int i = 1; i <= 40; i++)
            {
                cbnap.Items.Add(i);
            }
        }
    }
}
