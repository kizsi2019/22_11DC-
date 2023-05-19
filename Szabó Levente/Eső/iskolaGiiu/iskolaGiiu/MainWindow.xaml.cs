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
using System.IO;

namespace iskolaGiiu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void AdatokBetöltése()
        {
            foreach (var i in File.ReadAllLines("nevekGUI.txt"))
            {
                mylistbox.Items.Add(i);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            AdatokBetöltése();
        }
        private void btn_Törlés_Click(object sender, RoutedEventArgs e)
        {
            if (mylistbox.SelectedIndex == -1)
            {
                MessageBox.Show("Newm jelölt ki rekordot!");
            }
            else
            {
                mylistbox.Items.RemoveAt(mylistbox.SelectedIndex);
            }
        }
        private void btn_Mentes_Click(object sender, RoutedEventArgs e)
        {
            List<string> ki = new List<string>();
            foreach (var i in mylistbox.Items)
            {
                ki.Add((string)i);
            }
            try
            {
                File.WriteAllLines("nevekNEW.txt", ki);
                MessageBox.Show("Sikeres mentés!");
            }
            catch (Exception hiba)
            {
                MessageBox.Show(hiba.Message);
            }
        }
    }
}