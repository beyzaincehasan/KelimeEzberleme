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
        
           

          
        }
        void kelimegetir()


           {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "kelimegetir @UserID=" + ((FormAnaMenu)Application.OpenForms["FormAnaMenu"]).userID.ToString() + "";
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

        }
    }
}
