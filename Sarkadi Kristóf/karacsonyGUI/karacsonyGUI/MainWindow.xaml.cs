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

namespace karacsonyGUI
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
        public static int nap = 0, kesz = 0, eladott = 0, ossz = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            kesz = Convert.ToInt32(keszTB);
            eladott = Convert.ToInt32(elaTB);
            if (kesz < 0 || eladott > 0)
            {
                hiba.Content = "Negatív számot nem adhat meg!";
            }
            else if (eladott > kesz + ossz)
            {
                hiba.Content = "Túl sok az eladott angyalka";
            }
            else
            {
                nap = Convert.ToInt32(napok);
            }
        }
    }
}
