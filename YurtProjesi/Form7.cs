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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=Metehan\\SQLEXPRESS;Initial Catalog=YurtProje;Integrated Security=True;Encrypt=False");

        void personellistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TblPersonel", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void temizle()
        {
            txtId.Text = "";
            txtAdSoyad.Text = "";
            txtDepartman.Text = "";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            personellistesi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("insert into TblPersonel (PersonelAdSoyad,PersonelDepartman) values(@p1,@p2)", con);
            com.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            com.Parameters.AddWithValue("@p2", txtDepartman.Text);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Personel kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            personellistesi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAdSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtDepartman.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("delete From TblPersonel Where PersonelId=@p1", con);
            com.Parameters.AddWithValue("@p1", txtId.Text);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Personel silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            personellistesi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("Update TblPersonel set PersonelAdSoyad=@p1,PersonelDepartman=@p2 Where PersonelId=@p3", con);
            com.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            com.Parameters.AddWithValue("@p2", txtDepartman.Text);
            com.Parameters.AddWithValue("@p3", txtId.Text);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Yönetici güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            personellistesi();
        }
    }
}
