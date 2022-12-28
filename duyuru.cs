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
    public partial class duyuru : Form
    {
        public duyuru()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=HastaneOtomasyon; user Id=postgres; password=Selver1+");
        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from duyuru order by  id asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into duyuru(id,aciklama) values(@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(Txtduyuruid.Text));
            komut1.Parameters.AddWithValue("@p2", txtduyuruaciklama.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Duyuru ekleme işlemi başarıyla gerçekleştirildi. ");
           
        }
    }
}
