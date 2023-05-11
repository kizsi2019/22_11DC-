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
        public static int nap = 0, kesz = 0, eladott = 0, ossz = 0;

        private void Hozzáad_Click(object sender, RoutedEventArgs e)
        {
            kesz = Convert.ToInt32(keszTB.Text);
            eladott = Convert.ToInt32(eladottTB.Text);
            if(kesz < 0 || eladott < 0)
            {
                Hiba.Content = "Negatív számot nem adhat meg!";
            }
            else if (eladott > kesz + ossz)
            {
                Hiba.Content = "Túl sok az eladott angyalka!";
            }
            else
            {
                nap = Convert.ToInt32(Napok.SelectedItem.ToString());
                ossz += kesz - eladott;
                kimenetTB.Text += nap + ".nap: \t+" + kesz + "\t-" + eladott + "\t= \t" + ossz + "\n";
                for (int i = 1; i <= nap; i++)
                {
                    Napok.Items.Remove(i);
                }
                keszTB.Text = "0";
                eladottTB.Text = "0";
                Hiba.Content = "";
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            if(Napok.Items.Count < 40)
            {
                Napok.Items.Clear();
                for (int i = 1; i <= 40; i++)
                {
                    Napok.Items.Add(i);
                }
            }
        }
    }
    
}
