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


namespace KelimeEzberleme
{
    public partial class FormKullaniciKayit : Form
    {
        public FormKullaniciKayit()
        {
            InitializeComponent();
        }

        private void button_Kayit_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_Sifre.Text != textBox_Sifre_Tekrar.Text)
                {
                    MessageBox.Show("Şifreler Aynı Değil");
                    return;
                }

                SqlConnection con = new SqlConnection("server=localhost;database=KelimeEzberleme;integrated security=True");
                con.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Users (UserName, FirstName,LastName,Password,Mail)" +
                    " VALUES (@UserName, @FirstName,@LastName,@Password,@Mail)", con);
                komut.Parameters.AddWithValue("@UserName", textBox_KullaniciAdi.Text);
                komut.Parameters.AddWithValue("@FirstName", textBox_Ad.Text);
                komut.Parameters.AddWithValue("@LastName", textBox_Soyad.Text);
                komut.Parameters.AddWithValue("@Password", textBox_Sifre.Text);
                komut.Parameters.AddWithValue("@Mail", textBox_Mail.Text);
                komut.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Kayıt Yapıldı");
                this.Close();
            }
            catch (SqlException a)
            {

                MessageBox.Show(a.Message);

            }
          
        }
    }
}
