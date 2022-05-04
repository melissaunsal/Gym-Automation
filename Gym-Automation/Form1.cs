using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;




namespace Gym_Automation
{
    public partial class Form1 : Form
    {

        public static string bilgi = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {






        }

        private void button1_Click(object sender, EventArgs e)
        {
            bilgi = txt_ad.Text.Trim();
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Pinpon.34;database=mydb");
            string querry = "select*from kisiler where Kisi_tc= '" + txt_ad.Text.Trim() + "'and Parola='" + textBox2.Text.Trim()+"'";
     
            MySqlDataAdapter sda = new MySqlDataAdapter(querry , con);
            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);
            bilgi = txt_ad.Text.Trim();
       
            string cmbItemValue = comboBox1.SelectedItem.ToString();
            if (dtbl.Rows.Count >0)
            {
                for(int i=0; i<dtbl.Rows.Count; i++) {
                if (dtbl.Rows[i]["Kisi_turu_id"].ToString() == cmbItemValue)

                    {
                  
                        MessageBox.Show("GİRİŞ BAŞARILI  " );
                        if (comboBox1.SelectedIndex == 0)
                        {
                            Form2 f = new Form2();
                            f.textBox1.Text = txt_ad.Text.Trim();
                            f.Show();
                            this.Hide();
                        }
                        else 
                        {
                            Form3 ff = new Form3();
                            ff.Show();
                            this.Hide();
                        }
                    }
                        }
              

            }
            else
            {
                if (txt_ad.Text == "" || textBox2.Text == "" || txt_ad.Text == "" )
                {
                    MessageBox.Show("hatalı giriş");
                }
           
                else   if  (comboBox1.SelectedIndex == -1){
                    {
                        MessageBox.Show("hatalı giriş");
                    }
      
                        MessageBox.Show("hatalı giriş");
                    


                }

            }
      


        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}


