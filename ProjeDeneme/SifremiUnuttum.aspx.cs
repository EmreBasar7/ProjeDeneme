using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeDeneme
{
    public partial class SifremiUnuttum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Veritabani.denemeEntities ent = new Veritabani.denemeEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            string ad = (TextBox1.Text);
            string soyad = (TextBox2.Text);
            string meslek = (TextBox3.Text);
            string kullaniciID = (TextBox5.Text);
            int id = Convert.ToInt16(TextBox5.Text);
            Veritabani.Kullanicilar yeni = ent.Kullanicilar.First(f => f.KullaniciID == id);
            yeni.KullaniciSifre = TextBox4.Text;
            ent.SaveChanges();
        }
    }
}