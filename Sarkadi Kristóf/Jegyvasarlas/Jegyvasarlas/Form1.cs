using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jegyvasarlas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int km = 0;
            try
            {
                km = Convert.ToInt32(tbTávolság.Text);
            }
            catch (Exception hiba)
            {

                MessageBox.Show("Egy számot kérek!");
            }

            double fizetendo = km * 35;
            if (cbOsztály.SelectedIndex == 0)
            {
                fizetendo *= 1.5;
            }
            if (radioButton2.Checked == true)
            {
                fizetendo *= 0.5;
            }
            if (radioButton3.Checked == true)
            {
                fizetendo *= 0.1;
            }

            tbFizetendő.Text = fizetendo.ToString();
        }
    }
}
