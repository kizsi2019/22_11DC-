using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace xamp_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = @"datasource=127.0.0.1; port=3306; username=root; database=formula1";
            SqlConnection kapcsolat = new SqlConnection(conn);
            kapcsolat.Open();
            string sql = "SELECT * FROM nagydijak";
            SqlCommand parancs = new SqlCommand(sql, kapcsolat);
            SqlDataReader lekerdez = parancs.ExecuteReader();

            while (lekerdez.Read())
            {
                dataGridView1.Rows.Add(lekerdez[0], lekerdez[1], lekerdez[2], lekerdez[3]);
            }
            kapcsolat.Close();

        }
    }
}
