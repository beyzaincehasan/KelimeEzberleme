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
    public partial class FormKelimeEkle : Form
    {
        public FormKelimeEkle()
        {
            InitializeComponent();
        }
        //veritabanı bağlantısı
        SqlConnection con = new SqlConnection("server=EXCALIBUR\\SQLEXPRESS;database=KelimeEzberleme;integrated security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_Eng.Text=="" || textBox_Turkish.Text == "")
                {
                    MessageBox.Show("Kelime boş bırakılamaz");
                    return;
                }

                con.Open();
                SqlCommand komut = new SqlCommand("kelimekaydet @UserID=" + ((FormLogin)Application.OpenForms["FormLogin"]).UserID.ToString()+ "" +
                    ",@EngWordName='" + textBox_Eng.Text + "' " +
                    ",@TurWordName='" + textBox_Turkish.Text + "'  " +
                    ",@PictureURL='" + textBox_Gorsel_Url.Text + " ' " +
                     ",@WordSample='" + textBox_OrnekCumle.Text + " ' " +
                    ",@SubjectID='" + comboBox_Konular.SelectedValue + "' " +
                    "", con);


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

        private void buttonGorselSec_Click(object sender, EventArgs e)
        {
            string dosya;
            OpenFileDialog ResmiAc = new OpenFileDialog();
            ResmiAc.Filter = "resim dosyaları(*.jpg)|*.jpg|bütün dosyalar|*.*";//görsel seçme



            if (ResmiAc.ShowDialog() == DialogResult.OK)//görsel seçildiyse
            {
                pictureBox1.Image = Image.FromFile(ResmiAc.FileName);//pictureBox'a görsel yolu tanımlandı
                dosya = ResmiAc.FileName;
                Convert.ToString(dosya);
                textBox_Gorsel_Url.Text = dosya;
            }

        }

        void konugetir()//veritabanındaki konular comboBox'a getirildi
        {
            


            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select SubjectID,SubjectAciklama from Subjects";
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();

            da.Fill(dt);

            comboBox_Konular.DataSource = dt;

            con.Close();

        }

        private void FormKelimeEkle_Load(object sender, EventArgs e)
        {
            konugetir();
        }

      
    }
}
