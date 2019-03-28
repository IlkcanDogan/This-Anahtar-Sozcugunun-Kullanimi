using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisAnahtarSozcugu
{
    class Ogrenci
    {
        private string AdSoyad;
        private int No;
        private int Sinif;

        public Ogrenci(string AdSoyad, int No, int Sinif) 
        {
            this.AdSoyad = AdSoyad;
            this.No = No;
            this.Sinif = Sinif;
        }

        /*
         * This anahtar sözcüğünü kullanmak zorunda değiliz. Biz yazmasakta arkaplanda çalışırlar
         * ve kodların okunabilirliğini sağlarlar.
         * 
         * Yukarıdaki veri modelinde sınıfın üye elemanları ile yapıcı metodun parametrelerinin
         * aynı isimlere sahip olduğu görülmektedir. Peki yapıcı metot içerisindeki "AdSoyad" 
         * değişkenine erişmek istediğmizde; sınıfın üye elemanı olan "AdSoyad" değişkenine mi
         * erişiriz yoksa yapıcı metodun parametresi olan "AdSoyad" değişkenine mi? İşte bu 
         * sorunun cevabını netleştirip, kaynak kodlarımmızın okunabilirliğini arttırmaktadır.
         * 
         * this anahtar sözcüğü ile nitelendirilen sınıfın üye elemanlarıdır. Yukarıdaki veri
         * modelinde yapıcı metoda parametre olarak gönderilen değerler, sınıfın üye elemanına
         * akarılacakır.
         */
    }
}
