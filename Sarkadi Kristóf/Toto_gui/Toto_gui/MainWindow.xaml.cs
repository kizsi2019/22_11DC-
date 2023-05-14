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

namespace Toto_gui
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

        private void Ellenorzes(object send,TextChangedEventArgs e)
        {
            int hossz = txbInput.Text.Length;
            if (hossz != 14)
            {
                cbxHossz.IsChecked = true;
                cbxHossz.Content = $"Nem megfelelő a karakterek száma ({hossz})";
            }
            else
            {
                cbxHossz.IsChecked = false;
                cbxHossz.Content = $"Nem megfelelő a karakterek száma ({hossz})";
            }
            List<char> invalids = new List<char>();
            string text = txbInput.Text;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '1' && text[i] != '2' && text[i] != 'X' && text[i] != 'x')
                {
                    invalids.Add(text[i]);
                }
            }
            if (invalids.Count != 0)
            {
                cbxKarakter.IsChecked = true;
                string output = "Helytelen karakter az eredményben(";
                for (int i = 0; i < invalids.Count -1; i++)
                {
                    output += invalids[i] + ";";
                }
                output += invalids[invalids.Count - 1] +")";
                cbxKarakter.Content = output;
            }
            else
            {
                cbxKarakter.IsChecked = false;
                cbxKarakter.Content = "Helytelen karakter az eredményben()";
            }
            if (cbxKarakter.IsChecked == true || cbxKarakter.Checked == true)
            {
                btnMentes.IsEnabled = false;
            }
            else
            {
                btnMentes.IsEnabled = true;
            }
        }
    }
}
