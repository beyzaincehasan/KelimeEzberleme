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
    public partial class FormSifremiUnuttum : Form
    {
        public FormSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void button_Kaydet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Gonder_Click(object sender, EventArgs e)
        {
            textBox_Dogrulama.Enabled = true;
            textBox_Dogrulama.Focus();
        }
    }
}
