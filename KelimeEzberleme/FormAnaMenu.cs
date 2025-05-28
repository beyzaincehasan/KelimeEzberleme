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
    public partial class FormAnaMenu : Form
    {
        public FormAnaMenu()
        {
            InitializeComponent();
        }

        private void button_KelimeEkle_Click(object sender, EventArgs e)
        {
            FormKelimeEkle ekle = new FormKelimeEkle();
            ekle.ShowDialog();
        }

        private void button_Ayarlar_Click(object sender, EventArgs e)
        {
            FormAyarlar ayar = new FormAyarlar();
            ayar.ShowDialog();
        }
    }
}
