﻿using System;
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

namespace sudokuGUI
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

        private void btnMinusz_Click(object sender, RoutedEventArgs e)
        {
            int meret = int.Parse(txtMeret.Text);
            if (meret > 4)
            {
                txtMeret.Text = (meret - 1).ToString();
            }
        }

        private void btnPlusz_Click(object sender, RoutedEventArgs e)
        {
            int meret = int.Parse(txtMeret.Text);
            if (meret < 9)
            {
                txtMeret.Text = (meret + 1).ToString();
            }
        }

        private void txtKezdoallapot_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblHossz.Content = string.Format("Hossz: {0}", txtKezdoallapot.Text.Length)
        }

        private void btnEllenorzes_Click(object sender, RoutedEventArgs e)
        {
            int meret = int.Parse(txtMeret.Text);
            int hossz = txtKezdoallapot.Text.Length;
            if (meret * meret == hossz)
            {
                MessageBox.Show("A feladvány megfelelő hosszúságú")
            }
            else if (meret * meret > hossz)
            { }
        }
    }
}
