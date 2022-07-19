using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritabanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        void Doldur()
        {
            KUllanicilarEntity dp = new KUllanicilarEntity();
            dataGridView1.DataSource = dp.Kullanicilars.ToList();
        }
        Veritabanı.KUllanicilarEntity kUllanicilar = new Veritabanı.KUllanicilarEntity();
            
        private void button1_Click(object sender, EventArgs e)
        {
            Kullanicilar ekle = new Kullanicilar();
            ekle.KullaniciAd = textBox1.Text;
            ekle.KullaniciSoyad = textBox2.Text;
            ekle.KullaniciMeslek = textBox3.Text;
            kUllanicilar.Kullanicilars.Add(ekle);
            kUllanicilar.SaveChanges();
            MessageBox.Show("işlem başarılı");
            foreach(Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }
            Doldur();
        }
        int indexRow;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
            newDataRow.Cells[1].Value = textBox1.Text;
            newDataRow.Cells[2].Value = textBox2.Text;
            newDataRow.Cells[3].Value = textBox3.Text;
        }
        /*
       public string KayitEkleme(Veritabanı.Kullanicilar nesne)
       {
           Veritabanı.KUllanicilarEntity ekleme = new Veritabanı.KUllanicilarEntity();
           Veritabanı.Kullanicilar yeni = new Veritabanı.Kullanicilar();
           yeni = nesne;
           ekleme.Kullanicilars.Add(yeni);
           int sonuc = ekleme.SaveChanges();
           Doldur();
           if (sonuc == 1)
               return "1";
           else
               return "0";
       }
       */
    }
}
