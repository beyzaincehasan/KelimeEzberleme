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
    public partial class FormBulmaca : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=KelimeEzberleme;integrated security=True");

        string kelime = "";
        List<Label> kutular = new List<Label>();

        public FormBulmaca()
        {
            InitializeComponent();
        }
        private string GetRandomKelime()
        {
            
                con.Open();
                SqlCommand cmd = new SqlCommand("select EngWordName from Words where Tekrar=6 and UserID=" + ((FormLogin)Application.OpenForms["FormLogin"]).UserID.ToString() + " order by NEWID()", con);
                object result = cmd.ExecuteScalar();
                return result?.ToString() ?? "kelime";
           // con.Close();
            
        }
        private void FormBulmaca_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < kelime.Length; i++)
            {
                Label lbl = new Label();
                lbl.Width = 48;
                lbl.Height = 48;
                lbl.Font = new Font("Segoe UI", 22, FontStyle.Bold);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.BackColor = Color.White;
                lbl.Margin = new Padding(3);
                lbl.BorderStyle = BorderStyle.FixedSingle;

                if (i == 0)
                {
                    lbl.Text = kelime[0].ToString();
                    lbl.BackColor = Color.LightGreen;  // İsteğe bağlı: ilk harfi vurgula
                    lbl.ForeColor = Color.Black;
                }
                else
                {
                    lbl.Text = "";
                }

                kutular.Add(lbl);
                panelKutu.Controls.Add(lbl);
            }
        }

       

       

     
        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            string tahmin = txtTahmin.Text.Trim().ToUpper();

            if (tahmin.Length != kelime.Length)
            {
                MessageBox.Show($"Kelime {kelime.Length} harfli olmalı!");
                return;
            }

            for (int i = 0; i < kelime.Length; i++)
            {
                kutular[i].Text = tahmin[i].ToString();
                if (tahmin[i] == kelime[i])
                {
                    kutular[i].BackColor = Color.SeaGreen; // Doğru yerde doğru harf: Yeşil
                    kutular[i].ForeColor = Color.White;
                }
                else if (kelime.Contains(tahmin[i]))
                {
                    kutular[i].BackColor = Color.Gold; // Yanlış yerde doğru harf: Sarı
                    kutular[i].ForeColor = Color.Black;
                }
                else
                {
                    kutular[i].BackColor = Color.LightGray; // Hiç yok: Gri
                    kutular[i].ForeColor = Color.DarkGray;
                }
            }

            // Kazanma durumu
            if (tahmin == kelime)
                MessageBox.Show("Tebrikler, bildiniz!");

        }


    }
}
