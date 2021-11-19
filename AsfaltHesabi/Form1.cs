using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsfaltHesabi
{
    public partial class Form1 : Form
    {
        public class Degerler
        {
            public double yolUzunlugu { get; set; }
            public double yolGenislik { get; set; }
            public double yolKalinlik { get; set; }
            public double ozcutle { get; set; }
            public double butumOranı { get; set; }
        }
        public class Sonuclar
        {
            public double Agirlik { get; set; }
            public double ButumMiktari { get; set; }
            public double ButumsuzAgirlik { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Degerler degerler = new Degerler();
            Sonuclar sonuclar = new Sonuclar();
            degerler.yolUzunlugu = Convert.ToDouble(textBox1.Text);
            degerler.yolGenislik = Convert.ToDouble(textBox2.Text);
            degerler.yolKalinlik = Convert.ToDouble(textBox3.Text);
            degerler.ozcutle = Convert.ToDouble(textBox4.Text);
            degerler.butumOranı = Convert.ToDouble(textBox5.Text);
            sonuclar.Agirlik = degerler.yolUzunlugu * degerler.yolGenislik * degerler.yolKalinlik * degerler.ozcutle;
            label8.Text = sonuclar.Agirlik.ToString();
            sonuclar.ButumMiktari = sonuclar.Agirlik * degerler.butumOranı / 100;
            label10.Text = sonuclar.ButumMiktari.ToString();
            label12.Text = (sonuclar.Agirlik - sonuclar.ButumMiktari).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
