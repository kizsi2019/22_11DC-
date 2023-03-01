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
    public partial class Jegyrendelés : Form
    {
        public Jegyrendelés()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Megnyomtad a gonbot! ");
            int km = 0;
            try
            {
                km = Convert.ToInt32(tavolsag.Text);
            }
            catch (Exception hiba)
            {
                MessageBox.Show("Egy számot kérek! ");
            }
            double fizetendo = km * 35;
            if (osztaly.SelectedIndex == 0)
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
            fizetes.Text = fizetendo.ToString();
        }
    }
}
