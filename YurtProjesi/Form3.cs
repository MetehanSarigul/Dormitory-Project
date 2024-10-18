using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtProjesi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Metehan Sarıgül tarafından yapılmıştır.\n Mail:metesarigul44@gmail.com", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bölümİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.ShowDialog();
        }

       

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtProjeDataSet3.TblOgrenci' table. You can move, or remove it, as needed.
            this.tblOgrenciTableAdapter.Fill(this.yurtProjeDataSet3.TblOgrenci);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void öğrenciKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.ShowDialog();
        }

        private void öğrenciDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fm = new Form4();
            fm.ShowDialog();
        }

        private void yöneticiDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void personelDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void ödemeAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 fm = new Form8(); 
            fm.ShowDialog();
        }

        private void giderDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 fm = new Form9();
            fm.ShowDialog();
        }

        private void gelirİstatistiğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.ShowDialog();
        }
    }
}
