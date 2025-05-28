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
                SqlCommand komut = new SqlCommand("kullanicikaydet @UserName="+ textBox_KullaniciAdi.Text + "" +
                    ",@FirstName='" + textBox_KullaniciAdi.Text + "' " +
                    ",@LastName='" + textBox_KullaniciAdi.Text + "'  "+                   
                    ",@Password='" + textBox_KullaniciAdi.Text + " ' "+
                    ",@Mail='" + textBox_KullaniciAdi.Text + "'  ", con);
      
              
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
