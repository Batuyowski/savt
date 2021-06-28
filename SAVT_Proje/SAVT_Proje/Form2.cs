using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SAVT_Proje
{
    public partial class Form2 : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\1\source\repos\SAVT_Proje\SAVT_Proje\Database11.accdb;Persist Security Info=True");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        public Form2()
        {

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)           
        {
           
        }

        bool show1;
        bool show2;
        private void button1_Click(object sender, EventArgs e)
        {
            if (show1)
            {
                button4.Visible = false;
                panel2.Visible = false;
                show1 =  false;
            }
            else
            {
                button4.Visible = true;
                panel2.Visible = true;
                show1 = true;
            }
            {
                if (textBox1.Text != "" && textBox2.Text != "" && numericUpDown1.Value.ToString()!="" && textBox4.Text != "" && textBox5.Text != "" && comboBox2.SelectedItem !="" && textBox7.Text != "" && comboBox1.SelectedItem != "")
                {
                    komut.Connection = baglanti;
                    komut.CommandText = "Insert Into turnuva_uyeleri(ad,soyad,yas,mail,telefon,cinsiyet,takimadi,oyun) Values ('" + textBox1.Text + "','" + textBox2.Text + "', '" + numericUpDown1.Value.ToString() + "','" + textBox4.Text + "','" + textBox5.Text + "','" +comboBox2.SelectedItem+ "', '" + textBox7.Text + "','" + comboBox1.SelectedItem + "')";
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Turnuva Kaydınız Başarıyla Oluşturuldu.");
                    ds.Clear();

                }
            }

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
