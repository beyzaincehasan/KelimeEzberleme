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
                if(textBox_KullaniciAdi.Text=="" || textBox_Mail.Text=="")//mail ve kullanıcı adı kontrolü
                {
                    MessageBox.Show("Kullanıcı adı ya da mail adresi boş olamaz");
                    return;
                }
                if (textBox_Sifre.Text != textBox_Sifre_Tekrar.Text)//şifre kontrolü
                {
                    MessageBox.Show("Şifreler Aynı Değil");
                    return;
                }

                SqlConnection con = new SqlConnection("server=EXCALIBUR\\SQLEXPRESS;database=KelimeEzberleme;integrated security=True");
                con.Open();
                SqlCommand komut = new SqlCommand("kullanicikaydet @UserName="+ textBox_KullaniciAdi.Text + "" +
                    ",@FirstName='" + textBox_Ad.Text + "' " +
                    ",@LastName='" + textBox_Soyad.Text + "'  "+                   
                    ",@Password='" + textBox_Sifre.Text + " ' "+
                    ",@Mail='" + textBox_Mail.Text + "'  ", con);
      
              
                komut.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (SqlException a)
            {

                MessageBox.Show(a.Message);

            }
          
        }

        private void FormKullaniciKayit_Load(object sender, EventArgs e)
        {
            button_Kayit.MouseEnter += (s, ea) => button_Kayit.BackColor = Color.DarkGreen;
            button_Kayit.MouseLeave += (s, ea) => button_Kayit.BackColor = Color.SeaGreen;
        }

        private void panelKayit_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
