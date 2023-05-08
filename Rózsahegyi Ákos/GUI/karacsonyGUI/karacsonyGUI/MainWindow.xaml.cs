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

        public static int nap = 0, kesz = 0, eladott = 0, ossz = 0;

        private void btnHozzaad_Click(object sender, RoutedEventArgs e)
        {
            kesz = Convert.ToInt32(kimenet1.Text);
            eladott = Convert.ToInt32(kimenet2.Text);
            if (kesz < 0 || eladott < 0)
            {
                hiba.Content = "Negatív számot nem adhat meg!";
            }
            else if (eladott > kesz + ossz)
            {
                hiba.Content = "Túl sok az eladott angyalka!";
            }
            else
            {
                nap = Convert.ToInt32(napokCB.SelectedItem.ToString());
                ossz += kesz - eladott;
                kimenet.Text += nap + ".nap: \t+" + kesz + " \t-" + eladott + " \t= \t" + ossz + "\n";
                for (int i = 1; i <= nap; i++)
                {
                    napokCB.Items.Remove(i);
                }
                kimenet1.Text = "0";
                kimenet2.Text = "0";
                hiba.Content = "";
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            if (napokCB.Items.Count < 40)
            {
                napokCB.Items.Clear();
                for (int i = 1; i <= 40; i++)
                {
                    napokCB.Items.Add(i);
                }
            }
        }
    }
}
