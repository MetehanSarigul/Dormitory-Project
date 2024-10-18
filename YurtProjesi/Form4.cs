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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=Metehan\\SQLEXPRESS;Initial Catalog=YurtProje;Integrated Security=True;Encrypt=False");

        // Sqlden çekilen değerleri dataGridView'e yazdırmak için.
        void ogrencilistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tblogrenci",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        // dataGridView'den çekilip metinleri dolduran değerleri temizlemek için.
        void temizle()
        {
            txtId.Text = "";
            textBox1.Text="";
            mskTc.Text="";
            mskTel.Text = "";
            mskDogum.Text = "";
            cmbBolum.Text = "";
            txtMail.Text = "";
            cmbOdaNo.Text = "";
            txtVeliAdsoyad.Text = "";
            mskVeliTelefon.Text = "";
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            ogrencilistesi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen= dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskDogum.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmbBolum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            cmbOdaNo.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtVeliAdsoyad.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            mskVeliTelefon.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        // Öğrenciyi yurttan silme.
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Öğrenciyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 

             // Öğrenci tablosundan silmek için.
             con.Open();
             SqlCommand com = new SqlCommand("Delete From TblOgrenci Where OgrId=@p1", con);
             com.Parameters.AddWithValue("@p1", txtId.Text);
             com.ExecuteNonQuery();
             con.Close();
 
             // Borçlar tablosundan silmek için.
             con.Open();
             SqlCommand com2 = new SqlCommand("Delete From TblBorc Where OgrId=@p1", con);
             com2.Parameters.AddWithValue("@p1", txtId.Text);
             com2.ExecuteNonQuery();
             con.Close();

             // Silinen öğrenci için oda kontenjanını düzeltme.
             con.Open();
             SqlCommand com3 = new SqlCommand("Update TblOda set OdaAktif=OdaAktif-1 Where OdaNo=@p1", con);
             com3.Parameters.AddWithValue("@p1", cmbOdaNo.Text);
             com3.ExecuteNonQuery();
             con.Close();
            
             ogrencilistesi();
             temizle();
             MessageBox.Show("Öğrenci silindi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Öğrenci bilgilerini güncellemek için.
        private void button2_Click(object sender, EventArgs e)
        {
            // Öğrenci tablosunu güncellemek için.
            con.Open();
            SqlCommand com = new SqlCommand("Update TblOgrenci set OgrAdSoyad=@p1,OgrTc=@p2,OgrTel=@p3,OgrDogum=@p4,OgrBolum=@p5,OgrMail=@p6,OgrOdaNo=@p7,OgrVeliAdSoyad=@p8,OgrVeliTelefon=@p9 where OgrId=@p10", con);
            com.Parameters.AddWithValue("@p10",txtId.Text);
            com.Parameters.AddWithValue("@p1", textBox1.Text);
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
            MessageBox.Show("Öğrenci güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ogrencilistesi();
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TblOgrenci Where OgrAdSoyad = '" + txtgöster.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
