using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace számoló
{
    class Program
    {
        string kijelzoo;
        private void egy_Click(object sender, EventArgs e)
        {
            kijelzoo.Text = kijelzoo.Text + 1;
        }
        private void keto_Click(object sender, EventArgs e)
        {
            kijelzoo.Text = kijelzoo.Text + 2;
        }
        private void harom_Click(object sender, EventArgs e)
        {
            kijelzoo.Text = kijelzoo.Text + 3;
        }
        private void negy_Click(object sender, EventArgs e)
        {
            kijelzoo.Text = kijelzoo.Text + 4;
        }
        private void ot_Click(object sender, EventArgs e)
        {
            kijelzoo.Text = kijelzoo.Text + 5;
        }
        private void hat_Click(object sender, EventArgs e)
        {
            kijelzoo.Text = kijelzoo.Text + 6;
        }
        private void het_Click(object sender, EventArgs e)
        {
            kijelzoo.Text = kijelzoo.Text + 7;
        }
        private void nyoc_Click(object sender, EventArgs e)
        {
            kijelzoo.Text = kijelzoo.Text + 8;
        }
        private void kelenc_Click(object sender, EventArgs e)
        {
            kijelzoo.Text = kijelzoo.Text + 9;
        }
        private void nula_Click(object sender, EventArgs e)
        {
            kijelzoo.Text = kijelzoo.Text + 0;
        }
        private void Dell_Click(object sender, RoutedEventArgs e)
        {
            kijelzoo.Text = "";
        }
        private void cT_Click(object sender, RoutedEventArgs e)
        {
            if (kijelzoo.Text.Length > 0)
            {
                kijelzoo.Text = kijelzoo.Text.Substring(0, kijelzoo.Text.Length - 1);
            }
        }
        private void result()
        {
            String op;
            int iOp = 0;
            if (kijelzoo.Text.Contains("+"))
            {
                iOp = kijelzoo.Text.IndexOf("+");
            }
            else if (kijelzoo.Text.Contains("-"))
            {
                iOp = kijelzoo.Text.IndexOf("-");
            }
            else if (kijelzoo.Text.Contains("*"))
            {
                iOp = kijelzoo.Text.IndexOf("*");
            }
            else if (kijelzoo.Text.Contains("/"))
            {
                iOp = kijelzoo.Text.IndexOf("/");
            }
            else
            {
                //error    
            }
            op = kijelzoo.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(kijelzoo.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(kijelzoo.Text.Substring(iOp + 1, kijelzoo.Text.Length - iOp - 1));
            if (op == "+")
            {
                kijelzoo.Text += "=" + (op1 + op2);
            }
            else if (op == "-")
            {
                kijelzoo.Text += "=" + (op1 - op2);
            }
            else if (op == "*")
            {
                kijelzoo.Text += "=" + (op1 * op2);
            }
            else
            {
                kijelzoo.Text += "=" + (op1 / op2);
            }
        }
    }
}