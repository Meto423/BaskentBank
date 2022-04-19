using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;

namespace BaskentBank
{
    public partial class Transactions : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server=localhost;port=5432;database=postgres;user Id=postgres;password=31743174");
        public Transactions()
        {
            InitializeComponent();
        }

        void CheckBalance() 
        {
            conn.Open();
            string Query = "select +* from accinfo where miktar" + bakiyetext.Text + "";
            NpgsqlCommand cmd = new NpgsqlCommand(Query, conn);
            DataTable dt = new DataTable();
            NpgsqlCommand sda = new NpgsqlCommand();
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkBalance()
        {

        }
        private void bakiyebutton_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bakiyetext_TextChanged(object sender, EventArgs e)
        {
            if (bakiyetext.Text == "")
            {
                MessageBox.Show("TC Numranızı Giriniz!");
            }
            else if (bakiyetext.Text)
            {

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
