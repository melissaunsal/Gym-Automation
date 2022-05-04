using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Gym_Automation
{
  
    public partial class Form2 : Form
    {
     
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Pinpon.34;database=mydb");

        private void label1_Click(object sender, EventArgs e)
        {


        }
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

          


            con.Open();
            textBox1.Text = Form1.bilgi.ToString();
            MySqlCommand komut = new MySqlCommand("select*from `paket secimi` where Kisi_tc like '" +textBox1.Text + "'", con);
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textBox2.Text = read[5].ToString();
            }

                con.Close();

        }
        

    }
}
