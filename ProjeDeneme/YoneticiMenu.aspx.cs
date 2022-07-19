using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ProjeDeneme
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string conString = "Data Source=DESKTOP-1BO408E\\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {          
            if(RouteData.Values["YöneticiAdi"]!=null)
            {
                Response.Write(RouteData.Values["YöneticiAdi"]);
            }


            KullanicilariGetir();
        }
        Veritabani.denemeEntities ent = new Veritabani.denemeEntities();
        
        void KullanicilariGetir()
        {
            Veritabani.denemeEntities ent = new Veritabani.denemeEntities();
            GridView1.DataSource = ent.Kullanicilar.ToList();
            GridView1.DataBind();
           
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            Veritabani.Kullanicilar yeni = new Veritabani.Kullanicilar ();
            yeni.KullaniciAd = TextBox1.Text;
            yeni.KullaniciSoyad = TextBox2.Text;
            yeni.KullaniciMeslek = TextBox3.Text;
            ent.Kullanicilar.Add(yeni);
            ent.SaveChanges();
            KullanicilariGetir();
         
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(TextBox4.Text);
            Veritabani.Kullanicilar yeni = ent.Kullanicilar.First(f => f.KullaniciID == id);
            yeni.KullaniciAd = TextBox1.Text;
            yeni.KullaniciSoyad = TextBox2.Text;
            yeni.KullaniciMeslek = TextBox3.Text;         
            ent.SaveChanges();
            MessageBox.Show("Kullanıcı Güncellendi.");
            KullanicilariGetir();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(TextBox4.Text);
            
            Veritabani.Kullanicilar yeni = ent.Kullanicilar.First(f => f.KullaniciID == id);
            ent.Kullanicilar.Remove(yeni);
            ent.SaveChanges();
            MessageBox.Show("Kullanici Silindi.");
            KullanicilariGetir();
        }
    }
}