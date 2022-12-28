using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritabaniproje
{
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=HastaneOtomasyon; user Id=postgres; password=Selver1+");
        

        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from hasta ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Hasta_Load(object sender, EventArgs e)
        {
           

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from hasta where tc=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", BigInteger.Parse(Txttc.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hasta silme işlemi başarılı bir şekilde gerçekleşti","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into hasta(tc,ad,soyad,ilçe_id) values(@p1,@p2,@p3,@p4)", baglanti);
            komut1.Parameters.AddWithValue("@p1", BigInteger.Parse(Txttc.Text));
            komut1.Parameters.AddWithValue("@p2", txtad.Text);
            komut1.Parameters.AddWithValue("@p3", txtsoyad.Text);
            komut1.Parameters.AddWithValue("@p4", int.Parse(txtilceid.Text));
            string sorgu = "select *from hasta_sayisi()";
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hasta ekleme işlemi başarıyla gerçekleştirildi. ");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update hasta set ad=@p1,soyad=@p2,ilçe_id=@p3 where tc=@p4", baglanti);
            komut3.Parameters.AddWithValue("@p1", txtad.Text);
            komut3.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut3.Parameters.AddWithValue("@p3", int.Parse(txtilceid.Text));
            komut3.Parameters.AddWithValue("@p4", BigInteger.Parse(Txttc.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hasta güncelleme işlemi başarıyla gerçekleştirildi");
        } 

        private void BtnArama_Click(object sender, EventArgs e)
        {
            
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from hasta where ad like'" + txtara.Text+ "%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu2 = "select * from hasta_sayisi()";
            NpgsqlCommand komut4 = new NpgsqlCommand(sorgu2, baglanti);
            NpgsqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
               txthastasayisi.Text = dr.GetValue(0).ToString();
            }
            baglanti.Close();
        }
    }
}
