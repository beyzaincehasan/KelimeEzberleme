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
    public partial class FormRapor : Form
    {
        public FormRapor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=localhost;database=KelimeEzberleme;integrated security=True");
        private void FormRapor_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select distinct  b.SubjectAciklama,(CorrectAnswer + WrongAnswer) ToplamCevap,(CorrectAnswer)DogruSayisi,(WrongAnswer)YanlisSayisi from Words a left join Subjects b on a.SubjectID = b.SubjectID where UserID = " + ((FormLogin)Application.OpenForms["FormLogin"]).UserID.ToString() + " and CorrectAnswer+WrongAnswer > 0 group by  SubjectAciklama,CorrectAnswer,WrongAnswer";
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView_Rapor.DataSource = dt;

            con.Close();
        }
    }
}
