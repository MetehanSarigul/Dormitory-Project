using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace YurtProjesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=Metehan\\SQLEXPRESS;Initial Catalog=YurtProje;Integrated Security=True;Encrypt=False");

        // Bölümleri dataGridViewde göstermek için.
        void bolumlisteleme()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TblBolum", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bolumlisteleme();
        }

        // dataGridViewde tıklanıldığında seçilen değeri yukarı çekebilmek için.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBolum.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        // Girilen bölümü Sql'e kaydetme.
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("insert into TblBolum (BolumAd) values (@p1)",con);
            com.Parameters.AddWithValue("@p1",txtBolum.Text);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bölüm kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bolumlisteleme();
        }

        // Girilen bölümü Sql'den silme.
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("Delete From TblBolum Where BolumId=@p1", con);
            com.Parameters.AddWithValue("@p1",txtId.Text);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bölüm silindi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            bolumlisteleme();
        }

        // Girilen Bölümü Güncelleme.       
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("Update TblBolum set BolumAd=@p1 Where BolumId=@p2",con);
            com.Parameters.AddWithValue("@p1", txtBolum.Text);
            com.Parameters.AddWithValue("@p2", txtId.Text);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bölüm güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            bolumlisteleme();
        }
    }
}
