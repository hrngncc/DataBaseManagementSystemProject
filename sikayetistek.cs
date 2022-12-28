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
    public partial class sikayetistek : Form
    {
        public sikayetistek()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into sikayetistek(id,ad,soyad,aciklama) values(@p1,@p2,@p3,@p4)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtsiid.Text));
            komut1.Parameters.AddWithValue("@p2", txtsiad.Text);
            komut1.Parameters.AddWithValue("@p3", txtsisoyad.Text);
            komut1.Parameters.AddWithValue("@p4", txtsiaciklama.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şikayet,istek ekleme işlemi başarıyla gerçekleştirildi. ");
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=HastaneOtomasyon; user Id=postgres; password=Selver1+");
        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from sikayetistek ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
