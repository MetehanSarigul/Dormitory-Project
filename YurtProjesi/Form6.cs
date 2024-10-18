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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=Metehan\\SQLEXPRESS;Initial Catalog=YurtProje;Integrated Security=True;Encrypt=False");

        void bolumlistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TblYonetici", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void temizle()
        {
            txtId.Text = "";
            txtKullanıcıAdı.Text = "";
            txtŞifre.Text = "";
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            bolumlistesi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("insert into TblYonetici (YoneticiAdSoyad,YoneticiSifre) values(@p1,@p2)", con);
            com.Parameters.AddWithValue("@p1", txtKullanıcıAdı.Text);
            com.Parameters.AddWithValue("@p2", txtŞifre.Text);
            com.ExecuteNonQuery();
            con.Close();    
            MessageBox.Show("Yönetici kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            temizle();
            bolumlistesi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKullanıcıAdı.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtŞifre.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("delete From TblYonetici Where YoneticiId=@p1",con);
            com.Parameters.AddWithValue("@p1",txtId.Text);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Yönetici silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            bolumlistesi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("Update TblYonetici set YoneticiAdSoyad=@p1,YoneticiSifre=@p2 Where YoneticiId=@p3", con);
            com.Parameters.AddWithValue("@p1",txtKullanıcıAdı.Text);
            com.Parameters.AddWithValue("@p2", txtŞifre.Text);
            com.Parameters.AddWithValue("@p3", txtId.Text);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Yönetici güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            bolumlistesi();
        }
    }
}
