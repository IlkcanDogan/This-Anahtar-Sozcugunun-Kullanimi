using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisAnahtarSozcugu
{
    class Silindir
    {
        private double r;
        private double h;
        private double PI;

        public Silindir(double yaricap, double yukseklik, double piSayisi)
        {
            r = yaricap;
            h = yukseklik;
            PI = piSayisi;
        }

        public Silindir(double yaricap, double yukseklik) : this(yaricap, yukseklik, 3.1415) { }
        /*
         * this anahtar sözcüğü ile; girilen 2 parametreyle beraber, PI girilmediği taktirde
         * varsayılan olarak kabul edilmesini istediğimiz değerini, double tipinden 3 parametre 
         * alan yapıcı metoda gönderdik. Böylece 2 parametre alan yapıcı metodu, 3 parametre
         * alan yapıcı metottan faydalanarak kullandık.
         */


        public double Hacim()
        {
            return (PI * r * r * h);
        }

        public double YuzeyAlani()
        {
            return (2 * PI * r * h);

        }

        /*
         *this anahtar sözcüğü ilgili nesnenin referansını belirtmektedir.
         *
         * Silindir sınıfının 2 adet yapıcı metodu bulunmaktadır. Silindir sınıfından
         * nesne oluşturulurken 3 adet parametre girildiğinde; 1.parametre silindirin yarıçapı,
         * 2.parametre yuksekliğini ve 3.parametre PI sayısının kaç alacağını belirtecektir.
         * 
         * Eğer silindir sınıfından nesne oluşturulurken 2 adet parametre girilirse; 1.parametre 
         * silindirin yarıçapı, 2.parametre yüksekliğini belirtecektir ve PI sayısı "3.1415"
         * olarak alınacaktır.
         * 
         */
        
    }
}
