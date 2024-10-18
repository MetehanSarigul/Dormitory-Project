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
using System.Data.Sql;

namespace YurtProjesi
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=Metehan\\SQLEXPRESS;Initial Catalog=YurtProje;Integrated Security=True;Encrypt=False");

        // Log-in girişi.
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("Select * From TblYonetici Where YoneticiAdSoyad = '" + txtKullanıcıAdı.Text + "' and YoneticiSifre = '" + txtŞifre.Text + "'" ,con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                Form3 fm = new Form3();
                fm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
