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


namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        SqlConnection bağlanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }

       
        void StokuGetir()
        {
            bağlanti=new SqlConnection("Server=DESKTOP-IUSJUU5\\SQLEXPRESS;Database=stoktakip;Integrated Security=True;");
            bağlanti.Open();
            da = new SqlDataAdapter("SELECT * FROM ÜrünÖzellikleri", bağlanti);
            DataTable tablo  =new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bağlanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StokuGetir();
        }




        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {

            txtÜrünAdı.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtÜrünRengi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtÜrünDepolamaKpasitesi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtÜrünİşlemcisi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtÜrünFiyatı.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtÜrünAdedi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE ÜrünÖzellikleri SET ÜrünFiyatı=@ÜrünFiyatı, ÜrünRengi=@ÜrünRengi,Ürünİşlemcisi=@Ürünİşlemcisi,ÜrünDepolamaKapasitesi=@ÜrünDepolamaKapasitesi WHERE ÜrünAdı=@ÜrünAdı";
            komut = new SqlCommand(sorgu, bağlanti);
            komut.Parameters.AddWithValue("@ÜrünAdı", txtÜrünAdı.Text);
            komut.Parameters.AddWithValue("@ÜrünRengi", txtÜrünRengi.Text);
            komut.Parameters.AddWithValue("@Ürünİşlemcisi", Convert.ToInt32(txtÜrünİşlemcisi.Text));
            komut.Parameters.AddWithValue("@ÜrünDepolamaKapasitesi", Convert.ToInt32(txtÜrünDepolamaKpasitesi.Text));
            komut.Parameters.AddWithValue("@ÜrünFiyatı", Convert.ToInt32(txtÜrünFiyatı.Text));
            komut.Parameters.AddWithValue("@ÜrünAdedi", Convert.ToInt32(txtÜrünAdedi.Text));
            bağlanti.Open();
            komut.ExecuteNonQuery();
            bağlanti.Close();
            StokuGetir();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM ÜrünÖzellikleri WHERE ÜrünFiyatı=@ÜrünFiyatı";
            komut = new SqlCommand(sorgu, bağlanti);
            komut.Parameters.AddWithValue("@ÜrünFiyatı", Convert.ToInt32(txtÜrünFiyatı.Text));
            bağlanti.Open();
            komut.ExecuteNonQuery();
            bağlanti.Close();
            StokuGetir();
        }


       
        private void kayıtekle_Click(object sender, EventArgs e)
        {

            string sorgu = "INSERT INTO ÜrünÖzellikleri(ÜrünAdı,ÜrünRengi,ÜrünDepolamaKapasitesi,Ürünİşlemcisi,ÜrünFiyatı) VALUES(@ÜrünAdı,@ÜrünRengi,@ÜrünDepolamaKapasitesi,@Ürünİşlemcisi,@ÜrünFiyatı)";
            komut = new SqlCommand(sorgu, bağlanti);
            komut.Parameters.AddWithValue("@ÜrünAdı", txtÜrünAdı.Text);
            komut.Parameters.AddWithValue("@ÜrünRengi", txtÜrünRengi.Text);
            komut.Parameters.AddWithValue("@Ürünİşlemcisi", txtÜrünİşlemcisi.Text);
            komut.Parameters.AddWithValue("@ÜrünDepolamaKapasitesi", txtÜrünDepolamaKpasitesi.Text);
            komut.Parameters.AddWithValue("@ÜrünFiyatı", txtÜrünFiyatı.Text);
            komut.Parameters.AddWithValue("txtÜrünAdedi", txtÜrünAdedi.Text);
            bağlanti.Open();
            komut.ExecuteNonQuery();
            bağlanti.Close();
            StokuGetir();
        }

        
    }
}

