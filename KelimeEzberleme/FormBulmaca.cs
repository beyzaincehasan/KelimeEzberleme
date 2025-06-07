using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeEzberleme
{
    public partial class FormBulmaca : Form
    {
        private string currentWord = "";
        private int maxAttempts = 5;
        private int attemptsLeft;
        private List<string> learnedWords = new List<string> { "APPLE", "PLANE", "GRAPE", "WORDS", "WORMS" }; // Örnek kelimeler

        public FormBulmaca()
        {
            InitializeComponent();
        }

        private void YeniOyunBaslat()
        {
            Random rnd = new Random();
            currentWord = learnedWords[rnd.Next(learnedWords.Count)].ToUpper();
            attemptsLeft = maxAttempts;
            lblKalanHak.Text = $"Kalan Hak: {attemptsLeft}";
            flowLayoutPanel1.Controls.Clear();

            // İpucu olarak ilk harfi göster (ör: "A _ _ _ _")
            string ipucu = currentWord[0] + " " + string.Join(" ", new string('_', currentWord.Length - 1).ToCharArray());
            lblIpucu.Text = ipucu;

            txtTahmin.Clear();
            txtTahmin.Enabled = true;
            btnTahminEt.Enabled = true;
        }

        private void button_TahminEt_Click(object sender, EventArgs e)
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

            flowLayoutPanel1.Controls.Add(flpRow);

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
    }
    }
}
