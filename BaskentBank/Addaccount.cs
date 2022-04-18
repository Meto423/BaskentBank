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
    public partial class Addaccount : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server=localhost;port=5432;database=postgres;user Id=postgres;password=31743174");
        public Addaccount()
        {
            InitializeComponent();
        }

        private void Addaccount_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kaydolb_Click(object sender, EventArgs e)
        {
            if (adtext.Text == "" || soyadtext.Text == "" || telefontext.Text == "" || cinsiyetcb.SelectedIndex == -1 || adrestext.Text == "" || tctext.Text == "" || gelirtext.Text == "" || sifretext.Text == "" || sifredogrulamatext.Text == "")
            {
                MessageBox.Show("Lütfen Boş Değer Bırakmayınız!");
            }
            else if (sifretext.Text  != sifredogrulamatext.Text)
            {
                MessageBox.Show("Girdiğiniz şifre değerleri eşleşmiyor!");
            }
            else
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO \"userinformation\"(tcno,ad,soyad,telefon,cinsiyet,adres,ortgelir,sifre)VALUES('@TC','@AD','@SOYAD','@TEL','@CIN','@ADR','@ORT','@SIF')", conn);       
                cmd.Parameters.AddWithValue("@TC",tctext.Text);
                cmd.Parameters.AddWithValue("@AD",adtext.Text);
                cmd.Parameters.AddWithValue("@SOYAD", soyadtext.Text);
                cmd.Parameters.AddWithValue("@TEL", telefontext.Text);
                cmd.Parameters.AddWithValue("@CIN", cinsiyetcb.GetItemText(cinsiyetcb.SelectedItem));
                cmd.Parameters.AddWithValue("@ADRES", adtext.Text);
                cmd.Parameters.AddWithValue("@ORT", adtext.Text);
                cmd.Parameters.AddWithValue("@SIF", adtext.Text);
                cmd.ExecuteNonQuery();
               


                MessageBox.Show("Başarıyla Kaydoldunuz!");


            }
             conn.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
