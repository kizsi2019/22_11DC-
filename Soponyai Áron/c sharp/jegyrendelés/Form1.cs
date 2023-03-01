using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jegyrendelés
{
    public partial class Jegyrendelés : Form
    {
        public Jegyrendelés()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Megnyomtad a gombot!");
            int km = 0;
            try
            {
                km = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception hiba)
            {
                MessageBox.Show("Egy számot kérek");
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
            textBox2.Text = fizetendo.ToString();
        }
    }
}
