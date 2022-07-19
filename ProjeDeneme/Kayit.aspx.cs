using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeDeneme
{
    public partial class Kayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Veritabani.denemeEntities ent = new Veritabani.denemeEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            Veritabani.Kullanicilar yeni = new Veritabani.Kullanicilar();
            yeni.KullaniciAd = TextBox1.Text;
            yeni.KullaniciSoyad = TextBox2.Text;
            yeni.KullaniciMeslek = TextBox3.Text;
            yeni.KullaniciSifre = TextBox4.Text;
            ent.Kullanicilar.Add(yeni);
            ent.SaveChanges();
            
        }
    }
}