using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jegyrendeles
{
    public partial class Jegyrendeles : Form
    {
        public Jegyrendeles()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void szamol_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Megnyomtad a gombot!");
            int km = 0;

            try
            {
                km = Convert.ToInt32(tbtavolsag.Text);
            }
            catch (Exception hiba)
            {
                MessageBox.Show("Egy számot kérek!");
            }

            double fizetendo = km * 35;
            if (cbosztaly.SelectedIndex == 0)
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

            tbfizetendo.Text = fizetendo.ToString();
        }
    }
}
