using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace YurtProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=Metehan\\SQLEXPRESS;Initial Catalog=YurtProje;Integrated Security=True;Encrypt=False");

      
        private void Form1_Load(object sender, EventArgs e)
        {
            // Bölümleri Sql'den comboBox'a çekmek için.
            con.Open();
            SqlCommand com = new SqlCommand("Select * From TblBolum",con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                cmbBolum.Items.Add(dr[1]);
            }
            con.Close();

            // Oda numaralarını Sql'den comboBox'a çekmek için.
            con.Open ();
            SqlCommand com2 = new SqlCommand("Select * From TblOda Where OdaDurum = 1 ", con);
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                cmbOdaNo.Items.Add(dr2[1]);
            }
            con.Close ();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            // Girilen Öğrenciyi Sql veri tabanında öğrenci bölümüne kaydetme.
            con.Open();
            SqlCommand com = new SqlCommand("insert into TblOgrenci (OgrAdSoyad,OgrTc,OgrTel,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", con);
            com.Parameters.AddWithValue("@p1",txtAdSoyad.Text);
            com.Parameters.AddWithValue("@p2", mskTc.Text);
            com.Parameters.AddWithValue("@p3", mskTel.Text);
            com.Parameters.AddWithValue("@p4", mskDogum.Text);
            com.Parameters.AddWithValue("@p5", cmbBolum.Text);
            com.Parameters.AddWithValue("@p6", txtMail.Text);
            com.Parameters.AddWithValue("@p7", cmbOdaNo.Text);
            com.Parameters.AddWithValue("@p8", txtVeliAdsoyad.Text);
            com.Parameters.AddWithValue("@p9", mskVeliTelefon.Text);
            com.ExecuteNonQuery();
            con.Close();

            // Girilen öğrenciyi borclar bölümüne kaydetme.
            con.Open();
            SqlCommand com2 = new SqlCommand("insert into  TblBorc (OgrAdSoyad,OgrKalanBorc) values (@p1,@p2)", con);
            com2.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            com2.Parameters.AddWithValue("@p2", 10000);
            com2.ExecuteNonQuery();
            con.Close();

            // Girilen öğrenci için oda kontenjanını düzenleme.
            con.Open();
            SqlCommand com3 = new SqlCommand("Update TblOda set OdaAktif=OdaAktif+1 Where OdaNo=@p1", con);
            com3.Parameters.AddWithValue("@p1",cmbOdaNo.Text);
            com3.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Öğrenci kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
