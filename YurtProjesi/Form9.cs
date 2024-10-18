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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=Metehan\\SQLEXPRESS;Initial Catalog=YurtProje;Integrated Security=True;Encrypt=False");


        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtProjeDataSet2.TblYurtOdemeler' table. You can move, or remove it, as needed.
            this.tblYurtOdemelerTableAdapter.Fill(this.yurtProjeDataSet2.TblYurtOdemeler);

        }
        void temizle()
        {
            txtId.Text = "";
            txtElektrik.Text = "";
            txtDoğalgaz.Text = "";
            txtDiğer.Text = "";
            txtGıda.Text = "";
            txtPersonel.Text = "";
            txtSu.Text = "";
            txtİnternet.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("insert into TblYurtOdemeler (Elektirik,Su,Doğalgaz,İnternet,Gıda,Personel,Diger) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",con);
            com.Parameters.AddWithValue("@p1", txtElektrik.Text);
            com.Parameters.AddWithValue("@p2", txtSu.Text);
            com.Parameters.AddWithValue("@p3", txtDoğalgaz.Text);
            com.Parameters.AddWithValue("@p4", txtİnternet.Text);
            com.Parameters.AddWithValue("@p5", txtGıda.Text);
            com.Parameters.AddWithValue("@p6", txtPersonel.Text);
            com.Parameters.AddWithValue("@p7", txtDiğer.Text);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Giderler kaydedildi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tblYurtOdemelerTableAdapter.Fill(this.yurtProjeDataSet2.TblYurtOdemeler);
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("Update TblYurtOdemeler set Elektirik=@p1,Su=@p2,Doğalgaz=@p3,İnternet=@p4,Gıda=@p5,Personel=@p6,Diger=@p7 Where OdemeId=@p8", con);
            com.Parameters.AddWithValue("@p1", txtElektrik.Text);
            com.Parameters.AddWithValue("@p2", txtSu.Text);
            com.Parameters.AddWithValue("@p3", txtDoğalgaz.Text);
            com.Parameters.AddWithValue("@p4", txtİnternet.Text);
            com.Parameters.AddWithValue("@p5", txtGıda.Text);
            com.Parameters.AddWithValue("@p6", txtPersonel.Text);
            com.Parameters.AddWithValue("@p7", txtDiğer.Text);
            com.Parameters.AddWithValue("@p8", txtId.Text);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Giderler güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tblYurtOdemelerTableAdapter.Fill(this.yurtProjeDataSet2.TblYurtOdemeler);
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("Delete From TblYurtOdemeler Where OdemeId=@p1", con);
            com.Parameters.AddWithValue("@p1",txtId.Text);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Giderler silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tblYurtOdemelerTableAdapter.Fill(this.yurtProjeDataSet2.TblYurtOdemeler);
            temizle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; 
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtElektrik.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSu.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtDoğalgaz.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtİnternet.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtGıda.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtPersonel.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtDiğer.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            
        }
    }
}
