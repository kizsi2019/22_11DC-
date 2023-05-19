using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace susu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("nevekGUI.txt",Encoding.UTF8);
            string sor = "";
            while (!sr.EndOfStream) 
            {
                sor=sr.ReadLine();
                listBox1.Items.Add(sor);
            }
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Nem jelőlt ki tanulót!");
            }
            else
            {
                int hanyadik = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(hanyadik);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("nevekNEW.txt");
            foreach (var elem in listBox1.Items)
            {
                sw.WriteLine(elem);
            }
            sw.Close();
            MessageBox.Show("sikeres mentés!");
        }
    }
}
