using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace KelimeEzberleme
{
    public partial class FormSifremiUnuttum : Form
    {
        public FormSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void button_Kaydet_Click(object sender, EventArgs e)
        {
            if (DogrulamaKodu!=textBox_Dogrulama.Text)
            {
                MessageBox.Show("Doğrulama Kodu Hatalı");
                return;
            }

            if (textBox_sifre1.Text!=textBox_sifre2.Text)
            {
                MessageBox.Show("Şifreler Aynı Değil");
                return;
            }

            try
            {

                if (textBox_sifre1.Text != textBox_sifre2.Text)
                {
                    MessageBox.Show("Şifreler Aynı Değil");
                    return;
                }

                con.Close();
                con.Open();
                SqlCommand komut = new SqlCommand("update Users set Password='"+textBox_sifre2.Text+"'where Mail='"+textBox_Eposta.Text+"' ", con);


                komut.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Şifre Değiştirildi");
                this.Close();
            }
            catch (SqlException a)
            {

                MessageBox.Show(a.Message);

            }



        }

        private void button_Gonder_Click(object sender, EventArgs e)
        {
            mailkontrol();
        }

        private void FormSifremiUnuttum_Load(object sender, EventArgs e)
        {
           

        }

        SqlConnection con = new SqlConnection("server=localhost;database=KelimeEzberleme;integrated security=True");
        void mailkontrol()
        {
            if ( textBox_Eposta.Text == "")
            {
                MessageBox.Show("Mail Adresi Boş Olamaz");
                return;
            }
            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select Mail from Users where Mail = '" + textBox_Eposta.Text + "'";
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Kayıtlı Eposta Adresi Bulunamadı");
                return;
            }
            if (dt.Rows.Count == 1)
            {
                textBox_Dogrulama.Enabled = true;
                textBox_Dogrulama.Focus();
                panel_SifreSifirlama.Visible = true;
                mailgonder();
                textBox_Eposta.Enabled = false;
                button_Gonder.Enabled = false;
            }


        }
        string DogrulamaKodu;
    

     
        void mailgonder()
        {
            try
            {
                Random rand = new Random();
              
                int stringlen = rand.Next(4, 10);
                int randValue;
                string str = "";
                char letter;
                for (int i = 0; i < stringlen; i++)
                {

                   
                    randValue = rand.Next(0, 26);

                   
                    letter = Convert.ToChar(randValue + 65);

                 
                    str = str + letter;
                }
               




                DogrulamaKodu = str.ToString();


                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;

                sc.Credentials = new NetworkCredential("kelimeezberlemeuygulamasi@gmail.com", "mudz nudp dwux yevb");

                MailMessage mail = new MailMessage();

                mail.From = new MailAddress("kelimeezberlemeuygulamasi@gmail.com", "Kelime Ezberleme Uygulaması");

                mail.To.Add(textBox_Eposta.Text);


                mail.Subject = "Şifre Yenileme Kodu"; mail.IsBodyHtml = true; mail.Body ="Şifre yenilemek için doğrulama kodunuz :"+ DogrulamaKodu;


                sc.Send(mail);
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
           
        }

        Random rand = new Random();

        public const string Alphabet =
        "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

       
    }
}
