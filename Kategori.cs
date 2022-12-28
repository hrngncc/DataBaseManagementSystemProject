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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doktor doktor = new doktor();
            doktor.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gorevli gorevli = new Gorevli();
            gorevli.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hemsire hemsire = new hemsire();
            hemsire.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            brans brans = new brans();
            brans.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            il il = new il();
            il.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ilce ilce = new ilce();
            ilce.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ilac ilac = new ilac();
            ilac.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            recete recete = new recete();
            recete.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ilacrecete ilacrecete = new ilacrecete();
            ilacrecete.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            muayene muayene = new muayene();
            muayene.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            duyuru duyuru = new duyuru();
            duyuru.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sikayetistek sikayetistek = new sikayetistek();
            sikayetistek.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            randevu randevu = new randevu();
            randevu.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            yatacaklarlistesi yatacaklarlistesi = new yatacaklarlistesi();
            yatacaklarlistesi.ShowDialog();
        }
    }
}
