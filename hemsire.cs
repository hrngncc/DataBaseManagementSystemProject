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
    public partial class hemsire : Form
    {
        public hemsire()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hemsire_Load(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=HastaneOtomasyon; user Id=postgres; password=Selver1+");
        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from hemsire";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into hemsire(id,brans,ad,soyad) values(@p1,@p2,@p3,@p4)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(Txthemsireid.Text));
            komut1.Parameters.AddWithValue("@p2", txthemsirebrans.Text);
            komut1.Parameters.AddWithValue("@p3", txthemsiread.Text);
            komut1.Parameters.AddWithValue("@p4", txthemsiresoyad.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hemşire ekleme işlemi başarıyla gerçekleştirildi.");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from hemsire where id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(Txthemsireid.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hemşire silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
