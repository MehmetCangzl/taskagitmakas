using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenSayınınKaresi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, kare;
            Console.Write("Sayıy Gir : ");

            sayi = Convert.ToInt32(Console.ReadLine());

            kare = sayi * sayi;

            Console.Write("Sayının Karesi= " + kare);
            Console.Read();
        }
    }
}
