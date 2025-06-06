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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public string UserName;
        public string UserID;
        public string FirstName;
        public string LastName;

     SqlConnection con = new SqlConnection("server=localhost;database=KelimeEzberleme;integrated security=True");
        private void button_Giris_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_Sifre.Text =="" || textBox_KullaniciAdi.Text=="")
                {
                    MessageBox.Show("Kullanıcı adı yada şifre boş olamaz");
                    return;
                }
                con.Close();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select UserID,UserName,FirstName,LastName from Users where UserName = '"+textBox_KullaniciAdi.Text+"' and Password = '"+textBox_Sifre.Text+"'";
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Kullanıcı Adı yada Şifre Hatalı");
                    return;
                }

                if (dt.Rows.Count==1)
                {
                    // 
                    UserID   = dt.Rows[0][0].ToString();
                    UserName = dt.Rows[0][1].ToString();
                    FirstName =dt.Rows[0][2].ToString();
                    LastName = dt.Rows[0][3].ToString();

                    FormAnaMenu menu = new FormAnaMenu();
                    menu.Text ="Kelime Ezberleme ("+ FirstName + "  " + LastName+")";

                    menu.Show();
                    this.Hide();

                }         
                             
            
                con.Close();

             
              
            }
            catch (SqlException a)
            {

                MessageBox.Show(a.Message);

            }
        }

        private void label_SifremiUnuttum_Click(object sender, EventArgs e)
        {
             FormSifremiUnuttum sifre = new FormSifremiUnuttum();
            sifre.ShowDialog();
            
        }

        private void label_KayitOl_Click(object sender, EventArgs e)
        {
            FormKullaniciKayit kayit = new FormKullaniciKayit();
            kayit.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
