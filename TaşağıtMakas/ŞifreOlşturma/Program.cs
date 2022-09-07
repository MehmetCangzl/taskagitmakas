using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŞifreOlşturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            for (int j = 1; j <= 20; j++)
            {
                //İki büyük harf üretme
                for (int i = 1; i <= 2; i++)
                {
                    int sayi1 = rastgele.Next(65, 91);
                    Console.Write((char)sayi1);
                }
                //İki küçük harf üretme
                for (int i = 1; i <= 2; i++)
                {
                    int sayi1 = rastgele.Next(97, 123);
                    Console.Write((char)sayi1);
                }
                //İki sayı üretme
                for (int i = 1; i <= 2; i++)
                {
                    int sayi1 = rastgele.Next(48, 58);
                    Console.Write((char)sayi1);
                }
                //iki sembol üretme
                for (int i = 1; i <= 2; i++)
                {
                    int sayi1 = rastgele.Next(35, 39);
                    Console.Write((char)sayi1);
                }

                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
