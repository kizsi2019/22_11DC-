using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jegyrendelesGUI
{
    public partial class Jegyrendelés : Form
    {
        public Jegyrendelés()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Megnyomtad a gombot!");
            int km = 0;
            try
            {
                 km = Convert.ToInt32(txBoxKm.Text);
            }
            catch (Exception hiba)
            {
                MessageBox.Show("Egy számot kérek!");
            }
            

            double fizetendo = km * 35;
            if (cbOsztaly.SelectedIndex == 0)
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

            TxBoxFizetendo.Text = fizetendo.ToString();
        }
    }
}
