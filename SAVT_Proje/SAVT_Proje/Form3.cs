using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.OleDb;
namespace SAVT_Proje
{
    public partial class Form3 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database11.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public Form3()
        {
      
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {
                    komut.Connection = baglanti;
                    komut.CommandText = "Insert Into kullanicilar(kullaniciadi,sifre,mail,telefon,ad,soyad) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "', '"+ textBox5.Text + "', '" + textBox6.Text + "')";
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Kullanıcı kaydınız başarıyla oluşturuldu!");
                    ds.Clear();
                   
                }
         
            }
        }
    }
}
