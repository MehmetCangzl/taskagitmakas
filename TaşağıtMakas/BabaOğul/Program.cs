using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareDikdörtgen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alanCevre = "";
            int a, b, cevre, alan;
            Console.WriteLine("1- Kare");
            Console.WriteLine("2- Dikdörtgen");
            Console.WriteLine("Seçiminiz (1-2) : ");
            var kareDikdortgen = Convert.ToInt16(Console.ReadLine());

            if (kareDikdortgen == 1)
            {
                Console.WriteLine("1- Alan");
                Console.WriteLine("2- Çevre");
                Console.WriteLine("Seçiminiz (1-2) : ");
                alanCevre = Console.ReadLine();

                if (alanCevre == "1")
                {
                    Console.Write("Kenarı Gİriniz = ");
                    a = int.Parse(Console.ReadLine());
                    alan = a * a;
                    Console.WriteLine("Alan = {0}",alanCevre);
                }
                 if (alanCevre == "2")
                 {
                    Console.Write("Kenarı giriniz =");
                    a = int.Parse(Console.ReadLine());
                    cevre = 4 * a;
                    Console.WriteLine();
                 }
                
            }
            if (kareDikdortgen == 2)
            {
                Console.WriteLine("1- Alan");
                Console.WriteLine("2- Çevre");
                Console.Write("Seçiminiz (1-2) : ");
                alanCevre = Console.ReadLine();
                if (alanCevre == "1")
                {
                    Console.Write("Uzun kenarı giriniz = ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Kısa kenarı giriniz = ");
                    b = int.Parse(Console.ReadLine());
                    alan = a * b;
                    Console.WriteLine("Alan = {0}", alan);
                }
                if (alanCevre == "2")
                {
                    Console.Write("Uzun kenarı giriniz = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Kısa kenarı giriniz = ");
                    b = int.Parse(Console.ReadLine());
                    cevre = 2 * (a + b);
                    Console.WriteLine("Çevre = {0}", cevre);
                    
                }
            }
            Console.ReadLine();
        }
    }
}
