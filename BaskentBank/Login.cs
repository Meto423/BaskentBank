using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaskentBank
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            kullanitext.Text = "";
            sifretext.Text = "";
            oturumturucb.SelectedIndex = -1;
            oturumturucb.Text = "Oturum Türü";
        }
        private void girisbutton_Click(object sender, EventArgs e)
        {
            if (oturumturucb.SelectedIndex == -1)
            {
                MessageBox.Show("LÜTFEN OTURUM TÜRÜNÜ SEÇİNİZ!");
            }
            else if(oturumturucb.SelectedIndex==0)
            {
                if(kullanitext.Text=="" || sifretext.Text == "")
                {
                    MessageBox.Show("KULLANICI ADI VEYA ŞİFRE EKSİK!!");
                }
                else
                {
                    Mainpage git = new Mainpage();
                    git.Show();
                    this.Hide();
                }

            }
            else if(oturumturucb.SelectedIndex==1)
            {
                if (kullanitext.Text == "" || sifretext.Text == "")
                {
                    MessageBox.Show("YÖNETİCİ NUMARASI VEYA ŞİFRE EKSİK!!");
                }
                else
                {
                    Agents git = new Agents();
                    git.Show();
                    this.Hide();
                }
            }
        }
    }
}
