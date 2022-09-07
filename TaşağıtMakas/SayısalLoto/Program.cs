using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayısalLoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random sayi = new Random();
            int[] rastgele = new int[7];

            for (int i = 0; i < 7; i++)
            {
                rastgele[i] = sayi.Next(1 , 50);
            }

            Array.Sort(rastgele);
            Console.WriteLine("0 - 49 Arasındaki Sayılar");
            Console.WriteLine("------------------------------");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(rastgele[i] + "-");
            }

            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            Console.ReadLine();
        }
    }
}
