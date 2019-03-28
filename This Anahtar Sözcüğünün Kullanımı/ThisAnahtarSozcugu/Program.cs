using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisAnahtarSozcugu
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Parametre girilmediği için Pi değeri 3.1415 olacaktır.
            Silindir s1 = new Silindir(4,6);
            Console.WriteLine("Hacim: {0}\nYüzey Alanı: {1}\n",s1.Hacim(),s1.YuzeyAlani());

            //3.Parametreye girilen değer PI'ye aktarılacaktır.
            Silindir s2 = new Silindir(4,6,3);
            Console.WriteLine("Hacim: {0}\nYüzey Alanı: {1}",s2.Hacim(), s2.YuzeyAlani());


            Console.ReadLine();
        }
    }
}
