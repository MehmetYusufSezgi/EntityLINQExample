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

namespace EntityLINQExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            //buttonOgrenciListele
            dgwList.DataSource = db.TBLOgrenci.ToList();
            dgwList.Columns[3].Visible = false;
            dgwList.Columns[4].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //buttonEkle
            TBLOgrenci tBLOgrenci = new TBLOgrenci();
            tBLOgrenci.OgrenciAdi = txbOgrenciAd.Text;
            tBLOgrenci.OgrenciSoyadi = txbOgrenciSoyad.Text;
            db.TBLOgrenci.Add(tBLOgrenci);
            db.SaveChanges();
            MessageBox.Show("Öğrenci listeye eklenmiştir");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDersListe_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbSinavOgrenci;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("Select * from TBLDersler", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgwList.DataSource = dataTable;
        }

        private void buttonNotListele_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLNotlar select new { item.NotId, item.Ogr, item.Ders, 
                item.Sinav1, item.Sinav2, item.Sinav3, item.Ortalama, item.Durum };

            dgwList.DataSource = query.ToList();
            //dgwList.DataSource=db.TBLNotlar.ToList();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbOgrenciId.Text);
            var deleting = db.TBLOgrenci.Find(id);
            db.TBLOgrenci.Remove(deleting);
            db.SaveChanges();
            MessageBox.Show("Öğrenci sistemden silindi");
        }
    }
}
