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

        string SoruWordID;
        string SoruEngWordName;
        string SoruTurkWordName;


        string CevapWordID;
        string CevapEngWordName;
        string CevapTurkWordName;

        SqlConnection con = new SqlConnection("server=localhost;database=KelimeEzberleme;integrated security=True");
        private DataSet ds = new DataSet();
        private void FormSinav_Load(object sender, EventArgs e)
        {
            kelimegetir();
            kelimesayisigetir();
                     
        }
        void kelimesayisigetir()
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
                panel1.Enabled = false;
                button_ileri.Enabled = false;
                button_Control.Enabled = false;

                MessageBox.Show("Günlük Kelime Sayısına Ulaşıldı");
            }

        }

        void kelimegetir()

           {
            foreach (Control item in panel1.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.RadioButton") item.BackColor = Color.White  ;
               
            }

          

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "kelimegetir @UserID=" + ((FormLogin)Application.OpenForms["FormLogin"]).UserID.ToString() + "";
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
           
            da.Fill(ds);     
            label_kelime.Text = ds.Tables[0].Rows[0][0].ToString();
            SoruWordID =        ds.Tables[0].Rows[0][2].ToString();
            SoruTurkWordName=   ds.Tables[0].Rows[0][1].ToString();

            radioButton_Sec1.Text = ds.Tables[1].Rows[0][1].ToString();
            radioButton_Sec2.Text = ds.Tables[1].Rows[1][1].ToString();
            radioButton_Sec3.Text = ds.Tables[1].Rows[2][1].ToString();
            radioButton_Sec4.Text = ds.Tables[1].Rows[3][1].ToString();

           




            con.Close();
            da.Dispose();
        }

        private void button_Control_Click(object sender, EventArgs e)
        {
            try
            { 
                if (SoruTurkWordName != CevapTurkWordName)
                {
                    button_Control.Enabled = false;
                    panel1.Enabled = false;

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "kelimedogrula @UserID=" + ((FormLogin)Application.OpenForms["FormLogin"]).UserID.ToString() + "" +
                        ",@WordID=" + SoruWordID + ",@CevapDurum='F'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    foreach (Control item in panel1.Controls)
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
                    panel1.Enabled = false;
                   con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "kelimedogrula @UserID=" + ((FormLogin)Application.OpenForms["FormLogin"]).UserID.ToString() + "" +
                        ",@WordID=" + SoruWordID + ",@CevapDurum='T'";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    foreach (Control item in panel1.Controls)
                    {
                        if (item.GetType().ToString() == "System.Windows.Forms.RadioButton")

                            if (item.Text == SoruTurkWordName)
                            {
                                item.BackColor = Color.Green;
                            }

                    }

                   
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
            panel1.Enabled = true;
        }
    }
}
