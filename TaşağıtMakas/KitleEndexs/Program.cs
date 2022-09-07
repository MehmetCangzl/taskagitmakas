using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitleEndexs
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double boy, kilo, indeks = 0;
            Console.Write("Boyunuzu m cinsinden Giriniz (Ör:1,65)  : ");
            boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kilonuzu Giriniz : ");
            kilo = Convert.ToDouble(Console.ReadLine());
            indeks = kilo / (boy * boy);
            Console.WriteLine("================================================");
            Console.WriteLine("Vücut Kitle İndexiniz : {0}", indeks);
            if (indeks < 18)
            {
                Console.WriteLine("Zayıf");
            }
            else if (indeks >= 18 && indeks < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (indeks >= 25 && indeks < 30)
            {
                Console.WriteLine("Kilolu");
            }
            else if (indeks >= 30 && indeks < 35)
            {
                Console.WriteLine("Obez");
            }
            else
            {
                Console.WriteLine("Ciddi Obez");
            }
            Console.ReadLine();
        }

    }
}

