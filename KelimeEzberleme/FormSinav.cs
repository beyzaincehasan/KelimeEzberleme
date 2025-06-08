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
    
    public partial class FormSinav : Form
    {
        public FormSinav()
        {
            InitializeComponent();
        }
        //değişkenler
        string SoruWordID;
        string SoruEngWordName;
        string SoruTurkWordName;


        string CevapWordID;
        string CevapEngWordName;
        string CevapTurkWordName;
        string OrnekCumle;
        //veritabanı bağlantısı
        SqlConnection con = new SqlConnection("server=EXCALIBUR\\SQLEXPRESS;database=KelimeEzberleme;integrated security=True");
        private DataSet ds = new DataSet();
        private void FormSinav_Load(object sender, EventArgs e)
        {
            kelimegetir();
            kelimesayisigetir();
         
                     
        }
        void kelimesayisigetir()// kullanıcı parametresine bağlı günlük sorulacak kelime sayısı getirildi
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "kelimesayisigetir @ParametreID = 1, @UserID =" + ((FormLogin)Application.OpenForms["FormLogin"]).UserID.ToString() + "";
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            da.Fill(ds);

            label_GunlukKelimeSayisi.Text=     ds.Tables[0].Rows[0][0].ToString();
            label_CalisilanKelimeSayisi.Text = ds.Tables[1].Rows[0][0].ToString();
            label_KalanKelimeSayisi.Text =     ds.Tables[2].Rows[0][0].ToString();

            if (label_KalanKelimeSayisi.Text=="0")
            {
                panelSecenekler.Enabled = false;
                button_ileri.Enabled = false;
                button_Control.Enabled = false;

                MessageBox.Show("Günlük Kelime Sayısına Ulaşıldı");
                this.Close();
            }

        }

        void kelimegetir()// kullanıcı bazlı rastgele 4 kelime getirildi

           {

            try
            {
                foreach (Control item in panelSecenekler.Controls)
                {
                    if (item.GetType().ToString() == "System.Windows.Forms.RadioButton") item.BackColor = Color.White;

                }



                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = con.CreateCommand();
                
                cmd.CommandText = "kelimegetir @UserID=" + ((FormLogin)Application.OpenForms["FormLogin"]).UserID.ToString() + "";//kullanıcı bazlı rastgele kelime
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                
                da.Fill(ds);
                label_kelime.Text = ds.Tables[0].Rows[0][0].ToString();//sorulacak ingilizce kelime
                SoruWordID =        ds.Tables[0].Rows[0][2].ToString();
                SoruTurkWordName =  ds.Tables[0].Rows[0][1].ToString();
                OrnekCumle=         ds.Tables[0].Rows[0][4].ToString();

                radioButton_Sec1.Text = ds.Tables[1].Rows[0][1].ToString();//veritabanından rastgele gelen şıklar radioButton'a atanıyor
                radioButton_Sec2.Text = ds.Tables[1].Rows[1][1].ToString();
                radioButton_Sec3.Text = ds.Tables[1].Rows[2][1].ToString();
                radioButton_Sec4.Text = ds.Tables[1].Rows[3][1].ToString();






                con.Close();
                da.Dispose();
            }
            catch (SqlException a )
            {

                MessageBox.Show(a.Message);
            }
            
        }

        private void button_Control_Click(object sender, EventArgs e)
        {
            try
            {
                if (CevapTurkWordName is null)
                {
                    MessageBox.Show("Lütfen Bir Cevap Seçiniz");
                    return;
                }
                if (SoruTurkWordName != CevapTurkWordName)
                {
                    button_Control.Enabled = false;
                    panelSecenekler.Enabled = false;

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "kelimedogrula @UserID=" + ((FormLogin)Application.OpenForms["FormLogin"]).UserID.ToString() + "" +
                        ",@WordID=" + SoruWordID + ",@CevapDurum='F'";//seçilen şıkkın veritabanında doğruluğu kontrol edilip raddioButtonlar renklendirildi
                    cmd.ExecuteNonQuery();
                    con.Close();
                    foreach (Control item in panelSecenekler.Controls)
                    {
                        if (item.GetType().ToString() == "System.Windows.Forms.RadioButton")

                            if (item.Text == SoruTurkWordName)
                            {
                                item.BackColor = Color.Green;
                               
                            }


                        if (item.Text == CevapTurkWordName) 
                        {
                            item.BackColor = Color.Red;
                        }

                    }
                    
                }
                else
                {
                    button_Control.Enabled = false;
                    panelSecenekler.Enabled = false;
                   con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "kelimedogrula @UserID=" + ((FormLogin)Application.OpenForms["FormLogin"]).UserID.ToString() + "" +
                        ",@WordID=" + SoruWordID + ",@CevapDurum='T'";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    foreach (Control item in panelSecenekler.Controls)
                    {
                        if (item.GetType().ToString() == "System.Windows.Forms.RadioButton")

                            if (item.Text == SoruTurkWordName)
                            {
                                item.BackColor = Color.Green;
                            }

                    }

                    label_OrnekCumle.Text = OrnekCumle;
                    label_OrnekCumle.Visible = true;
                }


                kelimesayisigetir();
                button_ileri.Visible = true;


            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void radioButton_Sec1_CheckedChanged(object sender, EventArgs e)
        {
            CevapTurkWordName = radioButton_Sec1.Text;
           
        }

        private void radioButton_Sec2_CheckedChanged(object sender, EventArgs e)
        {
            CevapTurkWordName = radioButton_Sec2.Text;
        }

        private void radioButton_Sec3_CheckedChanged(object sender, EventArgs e)
        {
            CevapTurkWordName = radioButton_Sec3.Text;
        }

        private void radioButton_Sec4_CheckedChanged(object sender, EventArgs e)
        {
            CevapTurkWordName = radioButton_Sec4.Text;
        }

        private void button_geri_Click(object sender, EventArgs e)
        {

        }

        private void button_ileri_Click(object sender, EventArgs e)
        {
            kelimegetir();
            kelimesayisigetir();
            radioButton_Sec1.Checked = false;
            radioButton_Sec2.Checked = false;
            radioButton_Sec3.Checked = false;
            radioButton_Sec4.Checked = false;
            button_Control.Enabled = true;
            panelSecenekler.Enabled = true;
            label_OrnekCumle.Visible = false;
        }

     
    }
}
