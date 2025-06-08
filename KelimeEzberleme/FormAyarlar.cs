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
    public partial class FormAyarlar : Form
    {
        public FormAyarlar()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=EXCALIBUR\\SQLEXPRESS;database=KelimeEzberleme;integrated security=True");
        private DataSet ds = new DataSet();
        private void button_Kaydet_Click(object sender, EventArgs e)
        {
          
            con.Open();
            SqlCommand komut = new SqlCommand("update Parametre set ParametreDegeri='"+numericUpDown_KelimeSayisi.Value+"' where ParametreID=1 ", con);


            komut.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Kayıt Yapıldı");
            
        }

        private void FormAyarlar_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT  [ParametreID],[ParametreAdi],[ParametreDegeri] FROM[KelimeEzberleme].[dbo].[Parametre] ";
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            da.Fill(ds);

            numericUpDown_KelimeSayisi.Value =Convert.ToInt32( ds.Tables[0].Rows[0][2]);
        }

        private void labelBaslik_Click(object sender, EventArgs e)
        {

        }
    }
}
