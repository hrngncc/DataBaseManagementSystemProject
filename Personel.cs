using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritabaniproje
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=HastaneOtomasyon; user Id=postgres; password=Selver1+");
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into personel(id,ad,soyad) values(@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtpid.Text));
            komut1.Parameters.AddWithValue("@p2", txtpad.Text);
            komut1.Parameters.AddWithValue("@p3", txtpsoyad.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel ekleme işlemi başarıyla gerçekleştirildi.");
        }

        private void Personel_Load(object sender, EventArgs e)
        {

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from personel order by  id asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from personel where id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1",int.Parse(txtpid.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnArama_Click(object sender, EventArgs e)
        {

        }

        private void txtarap_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from personel where soyad like'" + (txtarap.Text) + "%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update personel set soyad=@p1,ad=@p2 where id=@p3", baglanti);
            komut3.Parameters.AddWithValue("@p1", txtpsoyad.Text);
            komut3.Parameters.AddWithValue("@p2", txtpad.Text);
            komut3.Parameters.AddWithValue("@p3", int.Parse(txtpid.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel güncelleme işlemi başarıyla gerçekleştirildi");
        }
    }
}
