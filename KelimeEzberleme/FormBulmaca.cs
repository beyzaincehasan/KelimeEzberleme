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
        private string currentWord = "";
        private int maxAttempts = 5;
        private int attemptsLeft;
        //private List<string> learnedWords = new List<string> { "APPLE", "PLANE", "GRAPE", "WORDS", "WORMS" }; // Örnek kelimeler
        SqlConnection con = new SqlConnection("server=EXCALIBUR\\SQLEXPRESS;database=KelimeEzberleme;integrated security=True");

        public FormBulmaca()
        {
            InitializeComponent();
        }
      
        private void FormBulmaca_Load(object sender, EventArgs e)
        {
            YeniOyunBaslat();
        }
        private void YeniOyunBaslat()
        {

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select EngWordName from Words where Tekrar=6 and UserID=" + ((FormLogin)Application.OpenForms["FormLogin"]).UserID.ToString() + " order by NEWID()";
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            da.Fill(ds);
            //label_kelime.Text = ds.Tables[0].Rows[0][0].ToString();


            Random rnd = new Random();
            currentWord = ds.Tables[0].Rows[0][0].ToString().ToUpper();
            txtTahmin.MaxLength = currentWord.Length;


           // currentWord = learnedWords[rnd.Next(learnedWords.Count)].ToUpper();
            attemptsLeft = maxAttempts;
            lblKalanHak.Text = $"Kalan Hak: {attemptsLeft}";
            panelKutu.Controls.Clear();

            // İpucu olarak ilk harfi göster (ör: "A _ _ _ _")
            string ipucu = currentWord[0] + " " + string.Join(" ", new string('_', currentWord.Length - 1).ToCharArray());
            lblIpucu.Text = ipucu;

            txtTahmin.Clear();
            txtTahmin.Enabled = true;
            btnTahminEt.Enabled = true;
        }





        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            string guess = txtTahmin.Text.ToUpper();

            if (guess.Length != currentWord.Length)
            {
                MessageBox.Show($"{currentWord.Length} harfli bir kelime giriniz.");
                return;
            }
            if (guess[0] != currentWord[0])
            {
                MessageBox.Show("İlk harf ipucu olarak verildi. Doğru giriniz.");
                return;
            }

            attemptsLeft--;
            lblKalanHak.Text = $"Kalan Hak: {attemptsLeft}";

            FlowLayoutPanel flpRow = new FlowLayoutPanel();
            flpRow.FlowDirection = FlowDirection.LeftToRight;
            flpRow.AutoSize = true;

            // Lingo mantığıyla renkler
            for (int i = 0; i < currentWord.Length; i++)
            {
                Label lbl = new Label();
                lbl.Text = guess[i].ToString();
                lbl.Width = 40;
                lbl.Height = 40;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Font = new Font("Arial", 20, FontStyle.Bold);
                lbl.Margin = new Padding(2);

                if (guess[i] == currentWord[i])
                    lbl.BackColor = Color.Green;      // Doğru harf, doğru yerde (YEŞİL)
                else if (currentWord.Contains(guess[i]))
                    lbl.BackColor = Color.Gold;       // Doğru harf, yanlış yerde (SARI)
                else
                    lbl.BackColor = Color.Gray;       // Hiç yok (GRİ)


                lbl.ForeColor = Color.White;
                flpRow.Controls.Add(lbl);
            }

            panelKutu.Controls.Add(flpRow);

            if (guess == currentWord)
            {
                MessageBox.Show("Tebrikler, buldunuz!");
                txtTahmin.Enabled = false;
                btnTahminEt.Enabled = false;
            }
            else if (attemptsLeft == 0)
            {
                MessageBox.Show($"Bilemediniz! Doğru kelime: {currentWord}");
                txtTahmin.Enabled = false;
                btnTahminEt.Enabled = false;
            }

            txtTahmin.Clear();
        }

        private void txtTahmin_TextChanged(object sender, EventArgs e)
        {
            int selStart = txtTahmin.SelectionStart;
            string upper = txtTahmin.Text.ToUpper();

            if (txtTahmin.Text != upper)
            {
                txtTahmin.Text = upper;
                txtTahmin.SelectionStart = selStart;
            }
        }
    }


    }

