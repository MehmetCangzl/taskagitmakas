using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıBasamkları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Sayı Gir : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            while(sayi > 0)
            {
                sayi /= 10;
                s++;
            }
            Console.Write( "Sayı " + s + " basamaklıdır. ");
            Console.ReadLine();
        }
    }
}
