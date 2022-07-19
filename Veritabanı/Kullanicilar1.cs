using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veritabanı
{
    internal class Kullanicilar1
    {
        public List<Veritabanı.Kullanicilar> GetByAdSoyad(string KullaniciAd)
        {
            Veritabanı.KUllanicilarEntity ent = new Veritabanı.KUllanicilarEntity();
            var sonuc = ent.Kullanicilars.Where
            return sonuc.ToList();
        }
    }
}
