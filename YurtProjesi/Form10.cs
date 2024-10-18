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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=Metehan\\SQLEXPRESS;Initial Catalog=YurtProje;Integrated Security=True;Encrypt=False");

       
        private void Form10_Load(object sender, EventArgs e)
        {
            // distinct kodu kullanımı.
            con.Open();
            SqlCommand com = new SqlCommand("Select distinct OdemeAy From TblKasa ",con);
            SqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader[0]);
            }
            con.Close();
             
            // Sum kodu kullanımı.
            con.Open();
            SqlCommand com2 = new SqlCommand("Select sum(OdemeMiktar) From TblKasa", con);
            SqlDataReader dr = com2.ExecuteReader();
            while(dr.Read())
            {
                label5.Text= dr[0].ToString();
            }
            con.Close();

            // İstatistikleri grafiğie çekme.
            con.Open();
            SqlCommand com3 = new SqlCommand("Select OdemeAy, sum(OdemeMiktar) From TblKasa group by OdemeAy", con);
            SqlDataReader dr2 = com3.ExecuteReader();
            while( dr2.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(dr2[0], dr2[1]);
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("Select sum(OdemeMiktar) From TblKasa Where OdemeAy = '" + comboBox1.Text + "'", con); 
            SqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                label4.Text= dataReader[0].ToString();
            }
            con.Close();
        }
    }
}
