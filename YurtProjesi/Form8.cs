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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=Metehan\\SQLEXPRESS;Initial Catalog=YurtProje;Integrated Security=True;Encrypt=False");

        void borclarıgoster()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TblBorc",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            
           borclarıgoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Alınan parayı kaydetmek için.
            con.Open();
            SqlCommand com = new SqlCommand("insert into TblKasa (OdemeAy,OdemeMiktar) values (@p1,@p2)",con);
            com.Parameters.AddWithValue("@p1",txtTarih.Text);
            com.Parameters.AddWithValue("@p2", txtMiktar.Text);
            com.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlCommand komut = new SqlCommand("Select * From TblBorc", con);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                label4.Text = Convert.ToString(dr[2]);
            }
            con.Close();

            int borç= Convert.ToInt16(label4.Text)-Convert.ToInt16(txtMiktar.Text);
            // Alınan parayı öğrenci borcundan düşmek için.
            con.Open();
            SqlCommand com2 = new SqlCommand("Update TblBorc set OgrKalanBorc=@p2 Where OgrAdSoyad=@p1",con);
            com2.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            com2.Parameters.AddWithValue("@p2", borç);
            com2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ödeme alındı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            borclarıgoster();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAdSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
