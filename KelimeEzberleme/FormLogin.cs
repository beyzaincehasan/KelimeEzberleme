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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_Giris_Click(object sender, EventArgs e)
        {
            FormSifremiUnuttum sifre = new FormSifremiUnuttum();
            sifre.ShowDialog();
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
    }
}
