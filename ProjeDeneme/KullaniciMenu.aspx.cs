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
    public partial class WebForm2 : System.Web.UI.Page
    {
        public string conString = "Data Source=DESKTOP-1BO408E\\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            HayvanlarıGetir();
        }

        Veritabani.denemeEntities ent = new Veritabani.denemeEntities();

        void HayvanlarıGetir()
        {
            Veritabani.denemeEntities ent = new Veritabani.denemeEntities();
            GridView1.DataSource = ent.Hayvanlar.ToList();
            GridView1.DataBind();

        }
    }
}