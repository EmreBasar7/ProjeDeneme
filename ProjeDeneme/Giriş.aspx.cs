using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeDeneme
{
    public partial class Giriş : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Veritabani.denemeEntities ent = new Veritabani.denemeEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in ent.Yöneticiler
                        where x.YöneticiAd == TextBox1.Text && x.YöneticiSoyad == TextBox2.Text && x.YöneticiSifre == TextBox3.Text
                        select x;

            if (sorgu.Any())
            {
                Response.Redirect("YoneticiMenu.aspx");
            }
            else
            {
                Response.Write("Hatalı Giriş Yaptınız.");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var sorgu = from x in ent.Kullanicilar
                        where x.KullaniciAd == TextBox4.Text && x.KullaniciSoyad == TextBox5.Text && x.KullaniciSifre == TextBox6.Text
                        select x;
            if (sorgu.Any())
            {
                Response.Redirect("KullaniciMenu.aspx");
            }
            else
            {
                Response.Write("Hatalı Giriş Yaptınız.");
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Kayit.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("SifremiUnuttum.aspx");
        }
    }
}